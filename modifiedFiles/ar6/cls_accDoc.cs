using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Novin
{
    class cls_accDoc
    {
        private static cls_myDataAccessLayer _mydal;
        public static DataSet ds_accDocs;
        private static SqlDataAdapter da_accDocs;
        private static SqlDataAdapter da_accDocRows;
        private static BindingSource bs_accDocs;
        private static BindingSource bs_accDocRows;
        private static SqlCommandBuilder _cmdBldr;

        public static long accDoc_price;
        public static string accDoc_date;
        public static string accDoc_comment;
        public static bool accDoc_isItPermenantly;

        public static int accDoc_id;
        public static string moeen_id;
        public static long accDocRow_retail;
        public static long accDocRow_indebted;
        public static long accDocRow_creditor;
        public static long accDocRow_remain;
        public static string accDocRow_detect;

        private static bool b_isItPrimaryCycle;
        public static bool isItPrimaryCycle
        {
            get { return b_isItPrimaryCycle; }
        }

        public cls_accDoc()
        {
            accDoc_id = 0;

            _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            int n_recordCount = (int)_mydal.doCommandScalar("select count(*) from tbl_accDocRows");
            if (n_recordCount == 0)
            {
                b_isItPrimaryCycle = true;
            }
            else
            {
                b_isItPrimaryCycle = false;
            }
            _mydal.disconnect();

            ds_accDocs = new DataSet();            
            da_accDocs = new SqlDataAdapter();
            da_accDocRows = new SqlDataAdapter();            

            da_accDocs.SelectCommand = new SqlCommand("select * from tbl_accDocs", new SqlConnection(cls_myDataAccessLayer.ConnectionString));
            da_accDocs.Fill(ds_accDocs, "tbl_accDocs");

            da_accDocRows.SelectCommand = new SqlCommand("select * from tbl_accDocRows", new SqlConnection(cls_myDataAccessLayer.ConnectionString));
            da_accDocRows.Fill(ds_accDocs, "tbl_accDocRows");

            _cmdBldr = new SqlCommandBuilder(da_accDocs);
            _cmdBldr = new SqlCommandBuilder(da_accDocRows);

            bs_accDocs = new BindingSource(ds_accDocs, "tbl_accDocs");
            bs_accDocRows = new BindingSource(ds_accDocs, "tbl_accDocs");

            ds_accDocs.Relations.Add(ds_accDocs.Tables["tbl_accDocs"].Columns["accDoc_id"], ds_accDocs.Tables["tbl_accDocRows"].Columns["accDoc_id"]);

            bs_accDocs.PositionChanged += new EventHandler(bs_accDocs_PositionChanged);
        }

        public static bool saveTheAccDoc()
        {
            try
            {
                bs_accDocs.EndEdit();
                da_accDocs.Update(ds_accDocs.Tables["tbl_accDocs"]);

                bs_accDocRows.EndEdit();
                da_accDocRows.Update(ds_accDocs.Tables["tbl_accDocRows"]);
            }
            catch(ArgumentNullException ex)
            {
                cls_msgBox.show(ex.Message);
                return false;
            }
            catch(InvalidOperationException ex)
            {
                cls_msgBox.show(ex.Message);
                return false;
            }
            catch(SystemException ex)
            {
                cls_msgBox.show(ex.Message);
                return false;
            }            
            return true;
        }

        public static bool isThisAccDocExist(int n_accDoc_id)
        {
            //bs_accDocs.PositionChanged += new EventHandler(bs_accDocs_PositionChanged);

            bool b_isExist = false;
            try
            {
                int n_pos = bs_accDocs.Find("accDoc_id", n_accDoc_id);
                if (n_pos != -1)
                {
                    bs_accDocs.Position = n_pos;
                    b_isExist = true;
                }
            }
            catch
            {
            }

            return b_isExist;
        }

        public static int getNextAvailableAccDocID()
        {
            //obtaining the just added accDoc id            
            string s_sqlCommand = "select MAX(accDoc_id) from tbl_accDocs;";
            _mydal.connect();

            try
            {
                accDoc_id = (int)_mydal.doCommandScalar(s_sqlCommand);
            }
            catch
            {
            }

            _mydal.disconnect();
            return ++accDoc_id;
        }

        /// <summary>
        /// this method create the Accounting Document.
        /// </summary>
        public static void createAccDoc()
        {
            getNextAvailableAccDocID();

            //prevent issuse the primary cycle accounting doc
            //if (b_isItPrimaryCycle && accDoc_id == 3) return;

            //string s_sqlCommand = "insert into tbl_accDocs(accDoc_id, accDoc_price, accDoc_date, accDoc_comment, accDoc_isItPerm) values({0}, {1}, '{2}', '{3}', {4});";
            //s_sqlCommand = string.Format(s_sqlCommand,accDoc_id,  accDoc_price, accDoc_date, accDoc_comment, accDoc_isItPermenantly);

            //_mydal.connect();
            //_mydal.docommand(s_sqlCommand);
            //_mydal.disconnect();

            DataRow row_newAccDoc;
            row_newAccDoc = ds_accDocs.Tables["tbl_accDocs"].NewRow();
            row_newAccDoc["accDoc_id"] = accDoc_id;
            row_newAccDoc["accDoc_price"] = 0;
            row_newAccDoc["accDoc_date"] = "";
            row_newAccDoc["accDoc_isItPerm"] = false;
            ds_accDocs.Tables["tbl_accDocs"].Rows.Add(row_newAccDoc);            
        }

        private static void bs_accDocs_PositionChanged(object sender, EventArgs e)
        {
            accDoc_id =(int) ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_id"];
            accDoc_price = (long)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_price"];
            accDoc_date = (string)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_date"];
            accDoc_isItPermenantly = (bool)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_isItPerm"];
        }

        /// <summary>
        /// use this function to add the required rows to the Accounting Document.
        /// </summary>
        /// <param name="n_moeen_id"></param>
        /// <param name="n_accDocRow_retail"></param>
        /// <param name="n_accDocRow_indebted"></param>
        /// <param name="n_accDocRow_creditor"></param>
        /// <param name="n_accDocRow_remain"></param>
        /// <param name="n_accDocRow_detect"></param>
        public static void addRow(string n_moeen_id,string s_accDocRow_comment, long n_accDocRow_retail, long n_accDocRow_indebted, long n_accDocRow_creditor, long n_accDocRow_remain, short n_accDocRow_detect)
        {
            bs_accDocs_PositionChanged(null, null);

            DataRow row_newAccDocRow;
            row_newAccDocRow = ds_accDocs.Tables["tbl_accDocRows"].NewRow();
            row_newAccDocRow["accDoc_id"] = accDoc_id;
            row_newAccDocRow["moeen_id"] = n_moeen_id;
            row_newAccDocRow["accDocRow_comment"] = s_accDocRow_comment;
            row_newAccDocRow["accDocRow_retail"] = n_accDocRow_retail;
            row_newAccDocRow["accDocRow_indebted"] = n_accDocRow_indebted;
            row_newAccDocRow["accDocRow_creditor"] = n_accDocRow_creditor;
            row_newAccDocRow["accDocRow_remain"] = n_accDocRow_remain;
            row_newAccDocRow["accDocRow_detect"] = n_accDocRow_detect;
            ds_accDocs.Tables["tbl_accDocRows"].Rows.Add(row_newAccDocRow);
            //moeen_id = n_moeen_id;
            //accDocRow_retail = n_accDocRow_retail;
            //accDocRow_indebted = n_accDocRow_indebted;
            //accDocRow_creditor = n_accDocRow_creditor;
            //accDocRow_remain = n_accDocRow_remain;
            //accDocRow_detect = n_accDocRow_detect;

            //string s_sqlCommand = "insert into tbl_accDocRows(accDoc_id, moeen_id, accDocRow_retail, accDocRow_indebted, accDocRow_creditor, accDocRow_remain, accDocRow_detect) values({0}, '{1}', {2}, {3}, {4}, {5} ,'{6}');";
            //s_sqlCommand = string.Format(s_sqlCommand, accDoc_id, moeen_id, accDocRow_retail, accDocRow_indebted, accDocRow_creditor, accDocRow_remain, accDocRow_detect);

            //_mydal.connect();
            //_mydal.docommand(s_sqlCommand);
            //_mydal.disconnect();
        }
        public static void updateAnAccDoc(int n_accDoc_id)
        {
            bs_accDocs_PositionChanged(null, null);

            ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_id"] = accDoc_id;
            ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_price"] = accDoc_price;
            ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_date"] = accDoc_date;
            ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_comment"] = accDoc_comment;
            ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_isItPerm"] = accDoc_isItPermenantly;
        }
        public static void removeAnAccDoc()
        {
            int n_pos = bs_accDocs.Find("accDoc_id", accDoc_id);
            if (n_pos != -1)
            {
                bs_accDocs.Position = n_pos;
                bs_accDocs.RemoveCurrent();
                saveTheAccDoc();
            }
        }
        public static void discardTheAccDoc()
        {
            int n_pos = bs_accDocs.Find("accDoc_id", accDoc_id);
            if (n_pos != -1)
            {
                bs_accDocs.Position = n_pos;
                bs_accDocs.RemoveCurrent();
            }
        }        
    }
}
