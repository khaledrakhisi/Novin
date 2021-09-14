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

            da_accDocRows.SelectCommand = new SqlCommand("select * from tbl_accDocRows where accDoc_id = -1", new SqlConnection(cls_myDataAccessLayer.ConnectionString));
            da_accDocRows.Fill(ds_accDocs, "tbl_accDocRows");

            _cmdBldr = new SqlCommandBuilder(da_accDocs);
            _cmdBldr = new SqlCommandBuilder(da_accDocRows);

            bs_accDocs = new BindingSource(ds_accDocs, "tbl_accDocs");
            bs_accDocRows = new BindingSource(ds_accDocs, "tbl_accDocRows");

            ds_accDocs.Relations.Add(ds_accDocs.Tables["tbl_accDocs"].Columns["accDoc_id"], ds_accDocs.Tables["tbl_accDocRows"].Columns["accDoc_id"]);

            bs_accDocs.PositionChanged += new EventHandler(bs_accDocs_PositionChanged);
        }

        public static bool saveTheAccDoc()
        {
            try
            {
                try
                {

                    ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_date"] = accDoc_date;
                    ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_comment"] = accDoc_comment;
                }
                catch
                {
                }

                bs_accDocs.EndEdit();
                da_accDocs.Update(ds_accDocs.Tables["tbl_accDocs"]);

                bs_accDocRows.EndEdit();
                da_accDocRows.Update(ds_accDocs.Tables["tbl_accDocRows"]);
            }
            catch (ArgumentNullException ex)
            {
                cls_msgBox.show(ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                cls_msgBox.show(ex.Message);
                return false;
            }
            catch (SystemException ex)
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

                    bs_accDocs_PositionChanged(null, null);
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
        public static void createAccDoc(bool b_isItPermenantAccDoc)
        {
            getNextAvailableAccDocID();

            try
            {
                DataRow row_newAccDoc;
                row_newAccDoc = ds_accDocs.Tables["tbl_accDocs"].NewRow();
                row_newAccDoc["accDoc_id"] = accDoc_id;
                row_newAccDoc["accDoc_price"] = 0;
                row_newAccDoc["accDoc_date"] = cls_numberConvertor.nowDateInAppropriateFormat();
                row_newAccDoc["accDoc_isItPerm"] = b_isItPermenantAccDoc;
                ds_accDocs.Tables["tbl_accDocs"].Rows.Add(row_newAccDoc);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private static void bs_accDocs_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                accDoc_id = (int)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_id"];
                accDoc_price = (long)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_price"];
                accDoc_date = (string)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_date"];
                accDoc_isItPermenantly = (bool)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_isItPerm"];
                accDoc_comment = (string)ds_accDocs.Tables["tbl_accDocs"].Rows[bs_accDocs.Position]["accDoc_comment"];
            }
            catch
            {
            }
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
        }
        public static void updateAnAccDoc(int n_accDoc_id)
        {
            //bs_accDocs_PositionChanged(null, null);

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
                //clearAccDocRows();
                ds_accDocs.Tables["tbl_accDocRows"].Clear();
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
        public static void clearAccDocRows()
        {
            da_accDocRows.DeleteCommand = new SqlCommand("delete from tbl_accDocRows where accDoc_id = " + accDoc_id.ToString(), new SqlConnection(cls_myDataAccessLayer.ConnectionString));
            da_accDocRows.DeleteCommand.Connection.Open();
            da_accDocRows.DeleteCommand.ExecuteNonQuery();
            da_accDocRows.DeleteCommand.Connection.Close();
        }

        public static DataTable viewTheJurnal(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " where " + s_where;
            }

            string s_sqlCommand = "SELECT        dbo.tbl_accDocRows.moeen_id, dbo.tbl_KOLs.kol_id, dbo.tbl_MOEENs.moeen_title + '   ' + dbo.tbl_accDocRows.accDocRow_comment as accDocRow_comment, dbo.tbl_accDocs.accDoc_comment, " +
                                    "dbo.tbl_accDocRows.accDocRow_retail, dbo.tbl_accDocRows.accDocRow_indebted, dbo.tbl_accDocRows.accDocRow_creditor, " +
                                    "dbo.tbl_accDocRows.accDocRow_remain, dbo.tbl_accDocRows.accDocRow_detect, dbo.tbl_accDocs.accDoc_id, dbo.tbl_accDocs.accDoc_date " +                                    
                                    "FROM            dbo.tbl_accDocs INNER JOIN dbo.tbl_accDocRows ON dbo.tbl_accDocs.accDoc_id = dbo.tbl_accDocRows.accDoc_id INNER JOIN " +
                                    "dbo.tbl_MOEENs ON dbo.tbl_accDocRows.moeen_id = dbo.tbl_MOEENs.moeen_id INNER JOIN " +
                                    "dbo.tbl_KOLs ON dbo.tbl_MOEENs.kol_id = dbo.tbl_KOLs.kol_id "
                                     + s_where 
                                     + " ORDER BY accDoc_date, accDoc_id";
            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_jurnal");
            
            _mydal.disconnect();

            return dt_;
        }
        public static DataTable getTheJurnalTotals(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            if (s_where != "")
            {
                s_where = " where " + s_where;
            }

            string s_sqlCommand = "SELECT        SUM(tbl_accDocRows.accDocRow_indebted) AS indebtedTotal, SUM(tbl_accDocRows.accDocRow_creditor) AS creditorTotal " +
                                    "FROM            tbl_accDocs AS tbl_accDocs INNER JOIN tbl_accDocRows AS tbl_accDocRows ON tbl_accDocs.accDoc_id = tbl_accDocRows.accDoc_id  INNER JOIN tbl_MOEENs ON tbl_accDocRows.moeen_id = tbl_MOEENs.moeen_id "
                                    + s_where;

            _mydal.connect();
            DataTable dt_totals = _mydal.select(s_sqlCommand, "viw_jurnalTotals");
            _mydal.disconnect();

            return dt_totals;
        }

        public static DataTable viewTheBigLedger(string @s_kol_id, string sWhere)
        {
            cls_myDataAccessLayer _mydal1 = new cls_myDataAccessLayer();
            cls_myDataAccessLayer _mydal2 = new cls_myDataAccessLayer();

            _mydal1.connect();
            _mydal1.com.Parameters.AddWithValue("@s_id", @s_kol_id);
            _mydal1.com.Parameters.AddWithValue("@n_ledgerKind", 1);//1 means KOL ledger
            _mydal1.executeAProcedure("sp_ledger");
            _mydal1.disconnect();

            if (sWhere != "")
            {
                sWhere = " AND " + sWhere;
            }

            string s_sqlCommand = "SELECT        tbl_accDocs.accDoc_id, tbl_accDocs.accDoc_date, tbl_accDocRows.accDocRow_comment, tbl_accDocRows.accDocRow_indebted, tbl_accDocRows.accDocRow_creditor, tbl_accDocRows.accDocRow_remain, CASE WHEN tbl_accDocRows.accDocRow_detect = 1 THEN 'بد' WHEN tbl_accDocRows.accDocRow_detect = 2 THEN 'بس' ELSE '---' END AS detect , tbl_KOLs.kol_title , '' as moeen_title , tbl_MOEENs.kol_id, '' as moeen_id " +
                                    "FROM            dbo.tbl_accDocs AS tbl_accDocs INNER JOIN dbo.tbl_accDocRows AS tbl_accDocRows ON tbl_accDocs.accDoc_id = tbl_accDocRows.accDoc_id INNER JOIN dbo.tbl_MOEENs AS tbl_MOEENs ON tbl_accDocRows.moeen_id = tbl_MOEENs.moeen_id INNER JOIN dbo.tbl_KOLs AS tbl_KOLs ON tbl_MOEENs.kol_id = tbl_KOLs.kol_id " +
                                    "WHERE (tbl_MOEENs.kol_id = '" + @s_kol_id + "') "
                                    + sWhere +
                                    " ORDER BY accDoc_date, accDoc_id";    
            _mydal2.connect();
            DataTable dt_ = _mydal2.select(s_sqlCommand, "viw_ledgers");
            _mydal2.disconnect();
            
            return dt_;
        }

        public static DataTable getTheTotalsOfLedger(string @s_kol_id, string sWhere)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            if (sWhere != "")
            {
                sWhere = " AND " + sWhere;
            }
            string s_sqlCommand = "SELECT        SUM(tbl_accDocRows.accDocRow_indebted) AS indebtedTotal, SUM(tbl_accDocRows.accDocRow_creditor) AS creditorTotal, SUM(tbl_accDocRows.accDocRow_remain) AS remainTotal " +
                                    "FROM            tbl_accDocs AS tbl_accDocs INNER JOIN tbl_accDocRows AS tbl_accDocRows ON tbl_accDocs.accDoc_id = tbl_accDocRows.accDoc_id  INNER JOIN tbl_MOEENs ON tbl_accDocRows.moeen_id = tbl_MOEENs.moeen_id " +
                                    "WHERE tbl_MOEENs.kol_id = " + @s_kol_id + " "
                                    + sWhere;
            _mydal.connect();
            DataTable dt_totals = _mydal.select(s_sqlCommand, "viw_ledgerTotals");
            _mydal.disconnect();

            return dt_totals;
        }

        public static DataTable viewTheSmallLedger(string @s_moeen_id, string sWhere)
        {
            cls_myDataAccessLayer _mydal1 = new cls_myDataAccessLayer();
            cls_myDataAccessLayer _mydal2 = new cls_myDataAccessLayer();

            _mydal1.connect();
            _mydal1.com.Parameters.AddWithValue("@s_id", @s_moeen_id);
            _mydal1.com.Parameters.AddWithValue("@n_ledgerKind", 2);//2 means moeen ledger
            _mydal1.executeAProcedure("sp_ledger");
            _mydal1.disconnect();

            if (sWhere != "")
            {
                sWhere = " AND " + sWhere;
            }

            string s_sqlCommand = "SELECT        tbl_accDocs.accDoc_id, tbl_accDocs.accDoc_date, tbl_accDocRows.accDocRow_comment, tbl_accDocRows.accDocRow_indebted, tbl_accDocRows.accDocRow_creditor, tbl_accDocRows.accDocRow_remain, CASE WHEN tbl_accDocRows.accDocRow_detect = 1 THEN 'بد' WHEN tbl_accDocRows.accDocRow_detect = 2 THEN 'بس' ELSE '---' END AS detect, tbl_MOEENs.moeen_title , '' as kol_title , '' as kol_id, tbl_accDocRows.moeen_id " +
                                    "FROM            dbo.tbl_accDocs AS tbl_accDocs INNER JOIN dbo.tbl_accDocRows AS tbl_accDocRows ON tbl_accDocs.accDoc_id = tbl_accDocRows.accDoc_id INNER JOIN dbo.tbl_MOEENs AS tbl_MOEENs ON tbl_accDocRows.moeen_id = tbl_MOEENs.moeen_id INNER JOIN dbo.tbl_KOLs AS tbl_KOLs ON tbl_MOEENs.kol_id = tbl_KOLs.kol_id " +
                                    "WHERE (tbl_accDocRows.moeen_id = '" + @s_moeen_id + "') "
                                    + sWhere +
                                    " ORDER BY accDoc_date, accDoc_id";
            _mydal2.connect();
            DataTable dt_ = _mydal2.select(s_sqlCommand, "viw_ledgers");
            _mydal2.disconnect();

            return dt_;
        }

        public static DataTable getTheSmallLedgerTotals(string @s_moeen_id, string sWhere)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            if (sWhere != "")
            {
                sWhere = " AND " + sWhere;
            }
            string s_sqlCommand = "SELECT        SUM(tbl_accDocRows.accDocRow_indebted) AS indebtedTotal, SUM(tbl_accDocRows.accDocRow_creditor) AS creditorTotal " +
                                    "FROM            tbl_accDocs AS tbl_accDocs INNER JOIN tbl_accDocRows AS tbl_accDocRows ON tbl_accDocs.accDoc_id = tbl_accDocRows.accDoc_id  INNER JOIN tbl_MOEENs ON tbl_accDocRows.moeen_id = tbl_MOEENs.moeen_id " +
                                    "WHERE (tbl_accDocRows.moeen_id = '" + @s_moeen_id + "') "
                                    + sWhere;
            _mydal.connect();
            DataTable dt_totals = _mydal.select(s_sqlCommand, "viw_ledgerTotals");
            _mydal.disconnect();

            return dt_totals;
        }

        public static DataTable viewTheExperBalance(bool showMoeens, bool b_fourCols, string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            _mydal.connect();
            if (s_where != "")
            {
                s_where = " where " + s_where + " AND ";
            }
            s_where += "(accDoc_deleted is null)";

            if (showMoeens)
            {
                s_sqlCommand = "SELECT        dbo.tbl_MOEENs.moeen_id, dbo.tbl_MOEENs.moeen_title ,'' as kol_id, '' as kol_title ";
                if (b_fourCols)
                {
                    s_sqlCommand += ",SUM(dbo.tbl_accDocRows.accDocRow_indebted) AS indTotal, SUM(dbo.tbl_accDocRows.accDocRow_creditor) AS creTotal ";
                }
                s_sqlCommand += ",CASE WHEN (SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) < 0) THEN 0 ELSE SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) END AS indRemain, CASE WHEN (SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) < 0) THEN abs(SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor)) ELSE 0 END AS creRemain ";
                s_sqlCommand += "FROM            dbo.tbl_accDocs INNER JOIN dbo.tbl_accDocRows ON dbo.tbl_accDocs.accDoc_id = dbo.tbl_accDocRows.accDoc_id INNER JOIN dbo.tbl_MOEENs ON dbo.tbl_accDocRows.moeen_id = dbo.tbl_MOEENs.moeen_id INNER JOIN dbo.tbl_KOLs ON dbo.tbl_MOEENs.kol_id = dbo.tbl_KOLs.kol_id "
                                + s_where +
                                " GROUP BY dbo.tbl_KOLs.kol_title, dbo.tbl_MOEENs.moeen_title ,dbo.tbl_MOEENs.moeen_id ";                                        
            }
            else
            {
                s_sqlCommand = "SELECT        dbo.tbl_MOEENs.kol_id, dbo.tbl_KOLs.kol_title ,'' as moeen_id,'' as moeen_title ";
                if (b_fourCols)
                {
                    s_sqlCommand += ",SUM(dbo.tbl_accDocRows.accDocRow_indebted) AS indTotal, SUM(dbo.tbl_accDocRows.accDocRow_creditor) AS creTotal ";
                }
                s_sqlCommand += ",CASE WHEN (SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) < 0) THEN 0 ELSE SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) END AS indRemain, CASE WHEN (SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor) < 0) THEN abs(SUM(dbo.tbl_accDocRows.accDocRow_indebted) - SUM(dbo.tbl_accDocRows.accDocRow_creditor)) ELSE 0 END AS creRemain ";
                s_sqlCommand += "FROM            dbo.tbl_accDocs INNER JOIN dbo.tbl_accDocRows ON dbo.tbl_accDocs.accDoc_id = dbo.tbl_accDocRows.accDoc_id INNER JOIN dbo.tbl_MOEENs ON dbo.tbl_accDocRows.moeen_id = dbo.tbl_MOEENs.moeen_id INNER JOIN dbo.tbl_KOLs ON dbo.tbl_MOEENs.kol_id = dbo.tbl_KOLs.kol_id "
                                + s_where +
                                " GROUP BY dbo.tbl_MOEENs.kol_id, dbo.tbl_KOLs.kol_title ";                                        
            }

            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_experBalance");

            _mydal.disconnect();

            return dt_;
        }

        public static DataTable SearchAccDoc(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " HAVING " + s_where;
            }

            string s_sqlCommand = "SELECT        dbo.tbl_accDocs.accDoc_id, dbo.tbl_accDocs.accDoc_date, dbo.tbl_accDocs.accDoc_comment, SUM(dbo.tbl_accDocRows.accDocRow_indebted) AS accDocPrice " +
                                    "FROM            dbo.tbl_accDocRows INNER JOIN " +
                                    "dbo.tbl_accDocs ON dbo.tbl_accDocRows.accDoc_id = dbo.tbl_accDocs.accDoc_id " +

                                    "GROUP BY dbo.tbl_accDocs.accDoc_id, dbo.tbl_accDocs.accDoc_date, dbo.tbl_accDocs.accDoc_comment "
                                    + s_where;

            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_accDoc");

            _mydal.disconnect();

            return dt_;
        }

        public static bool isThisFinActExist(int n_finAct_id)
        {
            string s_sqlCommand = "";

            s_sqlCommand = "select count(*) from tbl_finActs where finAct_id = " + n_finAct_id.ToString();

            _mydal.connect();
            int n_count = 0;
            try
            {
                n_count = (int)_mydal.doCommandScalar(s_sqlCommand);
            }
            catch
            {
            }
            _mydal.disconnect();
            if (n_count > 0)
            {
                return true;
            }
            return false;
        }

        public static bool moveThisAccDocToTrash()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_accDocs set accDoc_deleted = 1 where accDoc_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, accDoc_id);
                _mydal.docommand(s_sqlCommand);

                //disable invoice table
                s_sqlCommand = "update tbl_accDocRows set accDocRow_deleted = 1 where accDoc_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, accDoc_id);
                _mydal.docommand(s_sqlCommand);

                _mydal.disconnect();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool recycleThisAccDoc()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_accDocs set accDoc_deleted = NULL where accDoc_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, accDoc_id);
                _mydal.docommand(s_sqlCommand);

                //disable invoice table
                s_sqlCommand = "update tbl_accDocRows set accDocRow_deleted = NULL where accDoc_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, accDoc_id);
                _mydal.docommand(s_sqlCommand);

                _mydal.disconnect();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool moveAnFinActToTrash(int n_finAct_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_finActs set finAct_deleted = 1 where finAct_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, n_finAct_id);
                _mydal.docommand(s_sqlCommand);
 
                _mydal.disconnect();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool recycleAnFinAct(int n_finAct_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_finActs set finAct_deleted = NULL where finAct_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, n_finAct_id);
                _mydal.docommand(s_sqlCommand);

                _mydal.disconnect();
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
