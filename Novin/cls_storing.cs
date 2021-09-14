using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Novin
{
    class cls_storing
    {
        private cls_myDataAccessLayer _mydal;

        public enum invoiceType {buyInvoic = 1, sellInvoic, unBuyInvoice, unSellInvoice, wastedInvoic};

        public cls_storing()
        {
            _mydal = new cls_myDataAccessLayer();
        }

        public int getAnObjectEntity(int n_object_id)
        {
            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@object_id", n_object_id);
            int result = (int)_mydal.executeAFunction("sp_getAnObjectEntity");
            _mydal.disconnect();
            return result;
        }

        public int setTheEntity(invoiceType _invoiceType, int n_invoiceID)
        {
            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@invoiceType", _invoiceType);
            _mydal.com.Parameters.AddWithValue("@n_invoiceID", n_invoiceID);            
            int result = (int)_mydal.executeAProcedure("sp_setTheEntity");
            _mydal.disconnect();
            return result;
        }
        public string checkTheEntity(invoiceType _invoiceType, int n_invoiceID)
        {
            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@invoiceType", _invoiceType);
            _mydal.com.Parameters.AddWithValue("@n_invoiceID", n_invoiceID);  
            string s_result = (string)_mydal.executeAFunction("fn_checkTheEntity");
            _mydal.disconnect();
            return s_result;

        }

        public DataTable viewObjectsEntity(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " where " + s_where;
            }

            string s_sqlCommand = "SELECT        dbo.tbl_objects.object_id, dbo.tbl_slaveGroups.slaveGroup_title + ' ' + dbo.tbl_objects.object_title AS objectTitle, dbo.tbl_objects.object_entity, " +
                         "dbo.tbl_objects.object_retailBuyPrice, dbo.tbl_objects.object_retailInUnit * dbo.tbl_objects.object_retailBuyPrice AS buyPrice, " +
                         "dbo.tbl_objects.object_entity * dbo.tbl_objects.object_retailBuyPrice AS buyPriceTotall , dbo.tbl_objects.object_retailSellPrice, dbo.tbl_objects.object_sellPrice2, dbo.tbl_objects.object_sellPrice3 " +
                         "FROM            dbo.tbl_objects INNER JOIN " +
                         "dbo.tbl_slaveGroups ON dbo.tbl_objects.slaveGroup_id = dbo.tbl_slaveGroups.slaveGroup_id "
                                     + s_where;
                                     //+ " ORDER BY accDoc_date, accDoc_id";
            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_objectEntity");

            _mydal.disconnect();

            return dt_;
        }

        public DataTable viewObjectsWasted(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " where " + s_where + " AND ";
            }
            else
            {
                s_where = " where ";
            }
            s_where += " (invoiceWasted_deleted is null)";

            string s_sqlCommand = "SELECT        dbo.tbl_itemsWasted.object_id,  dbo.tbl_slaveGroups.slaveGroup_title + ' ' + dbo.tbl_objects.object_title AS objectTitle, dbo.tbl_itemsWasted.itemWasted_unitCount AS unitCount, " +
                                  "dbo.tbl_itemsWasted.itemWasted_retailCount AS retailCount, dbo.tbl_itemsWasted.itemWasted_unitCount * dbo.tbl_objects.object_retailInUnit + dbo.tbl_itemsWasted.itemWasted_retailCount AS totalCount, " +
                                  "(dbo.tbl_itemsWasted.itemWasted_unitCount * dbo.tbl_objects.object_retailInUnit + dbo.tbl_itemsWasted.itemWasted_retailCount) * dbo.tbl_itemsWasted.itemWasted_retailPrice AS totalPrice,dbo.tbl_invoicesWasted.accDoc_id " +
                                  "FROM            dbo.tbl_invoicesWasted INNER JOIN dbo.tbl_itemsWasted ON dbo.tbl_invoicesWasted.invoiceWasted_id = dbo.tbl_itemsWasted.invoiceWasted_id INNER JOIN dbo.tbl_objects ON dbo.tbl_itemsWasted.object_id = dbo.tbl_objects.object_id INNER JOIN " +
                                  "dbo.tbl_slaveGroups ON dbo.tbl_objects.slaveGroup_id = dbo.tbl_slaveGroups.slaveGroup_id "
                                  + s_where;
            //+ " ORDER BY accDoc_date, accDoc_id";
            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_objectWasted");

            _mydal.disconnect();

            return dt_;
        }

        public static DataTable viewProfitLoss()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            int result = (int)_mydal.executeAProcedure("sp_profitAndLoss");
            _mydal.disconnect();

            cls_myDataAccessLayer _mydal1 = new cls_myDataAccessLayer();
            _mydal1.connect();

            string s_sqlCommand = "SELECT * FROM tbl_profitLoss;";
            DataTable dt_ = _mydal1.select(s_sqlCommand, "tbl_profitLoss");

            _mydal1.disconnect();

            return dt_;
        }
    }
}
