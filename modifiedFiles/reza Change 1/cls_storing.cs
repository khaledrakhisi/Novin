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

        public DataSet viewObjectsEntity(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " where " + s_where;
            }

            string s_sqlCommand = "SELECT        dbo.tbl_objects.object_id, dbo.tbl_slaveGroups.slaveGroup_title + ' ' + dbo.tbl_objects.object_title AS objectTitle, dbo.tbl_objects.object_entity, " +
                         "dbo.tbl_objects.object_retailBuyPrice, dbo.tbl_objects.object_retailInUnit * dbo.tbl_objects.object_retailBuyPrice AS buyPrice, " +
                         "dbo.tbl_objects.object_entity * dbo.tbl_objects.object_retailBuyPrice AS buyPriceTotall " +
                         "FROM            dbo.tbl_objects INNER JOIN " +
                         "dbo.tbl_slaveGroups ON dbo.tbl_objects.slaveGroup_id = dbo.tbl_slaveGroups.slaveGroup_id "
                                     + s_where;
                                     //+ " ORDER BY accDoc_date, accDoc_id";
            DataSet ds_ = _mydal.select(s_sqlCommand, "viw_objectEntity");

            _mydal.disconnect();

            return ds_;
        }
    }
}
