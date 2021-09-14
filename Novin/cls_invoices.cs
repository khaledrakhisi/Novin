using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Novin
{
    class cls_invoices
    {
        cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
        public enum invoiceType { buyInvoice = 1, sellInvoice, wastedInvoice, unSellInvoice, unBuyInvoice };

        public int getAvailableWastedInvoiceID()
        {
            _mydal.connect();
            int n_availableID = 0;
            try
            {
                n_availableID = (int)_mydal.doCommandScalar("select max(invoiceWasted_id) from tbl_invoicesWasted;");
            }
            catch
            {
            }
            n_availableID++;
            _mydal.disconnect();
            return n_availableID;
        }

        public int getAvailableBuyInvoiceID()
        {
            _mydal.connect();
            int n_availableID = 0;
            try
            {
                n_availableID = (int)_mydal.doCommandScalar("select max(invoiceBuy_id) from tbl_invoicesBuy where invoiceBuy_kind = 1;");
            }
            catch
            {
            }
            n_availableID++;
            _mydal.disconnect();
            return n_availableID;
        }
        public int getAvailableSellInvoiceID()
        {
            _mydal.connect();
            int n_availableID = 0;
            try
            {
                n_availableID = (int)_mydal.doCommandScalar("select max(invoiceSell_id) from tbl_invoicesSell where invoiceSell_kind = 1;");
            }
            catch
            {
            }
            n_availableID++;
            _mydal.disconnect();
            return n_availableID;
        }

        public int getAvailableUnBuyInvoiceID()
        {
            _mydal.connect();
            int n_availableID = 0;
            try
            {
                n_availableID = (int)_mydal.doCommandScalar("select max(invoiceSell_id) from tbl_invoicesSell where invoiceSell_kind = 0;");
            }
            catch
            {
            }
            n_availableID++;
            _mydal.disconnect();
            return n_availableID;
        }
        public int getAvailableUnSellInvoiceID()
        {
            _mydal.connect();
            int n_availableID = 0;
            try
            {
                n_availableID = (int)_mydal.doCommandScalar("select max(invoiceBuy_id) from tbl_invoicesBuy where invoiceBuy_kind = 0;");
            }
            catch
            {
            }
            n_availableID++;
            _mydal.disconnect();
            return n_availableID;
        }
        public int getTheInvoiceID(int n_accDoc_id, invoiceType _invoiceType)
        {
            string s_sqlCommand = "";
            int n_invoiceID = -1;

            if (_invoiceType == invoiceType.buyInvoice)
            {
                s_sqlCommand = "select invoiceBuy_id from tbl_invoicesBuy where accDoc_id = " + n_accDoc_id.ToString() + " AND invoiceBuy_kind = 1"; 
            }
            else if (_invoiceType == invoiceType.sellInvoice)
            {
                s_sqlCommand = "select invoiceSell_id from tbl_invoicesSell where accDoc_id = " + n_accDoc_id.ToString() + " AND invoiceSell_kind = 1";
            }
            else if (_invoiceType == invoiceType.unBuyInvoice)
            {
                s_sqlCommand = "select invoiceSell_id from tbl_invoicesSell where accDoc_id = " + n_accDoc_id.ToString() + " AND invoiceSell_kind = 0";
            }
            else if (_invoiceType == invoiceType.unSellInvoice)
            {
                s_sqlCommand = "select invoiceBuy_id from tbl_invoicesBuy where accDoc_id = " + n_accDoc_id.ToString() + " AND invoiceBuy_kind = 0";
            }            
            else if (_invoiceType == invoiceType.wastedInvoice)
            {
                s_sqlCommand = "select invoiceWasted_id from tbl_invoicesWasted where accDoc_id = " + n_accDoc_id.ToString();
            }

            _mydal.connect();            
            try
            {
                n_invoiceID = (int)_mydal.doCommandScalar(s_sqlCommand);
            }
            catch
            {
            }
            _mydal.disconnect();

            return n_invoiceID;
        }
        public bool isThisInvoiceExists(invoiceType _invoiceType, int n_invoice_id)
        {
            string s_sqlCommand = "";
            if (_invoiceType == invoiceType.buyInvoice)
            {
                s_sqlCommand = "select count(*) from tbl_invoicesBuy where invoiceBuy_id = " + n_invoice_id.ToString() + " AND invoiceBuy_kind = 1";
            }
            else if (_invoiceType == invoiceType.sellInvoice)
            {
                s_sqlCommand = "select count(*) from tbl_invoicesSell where invoiceSell_id = " + n_invoice_id.ToString() + " AND invoiceSell_kind = 1";
            }
            else if (_invoiceType == invoiceType.unBuyInvoice)
            {
                s_sqlCommand = "select count(*) from tbl_invoicesSell where invoiceSell_id = " + n_invoice_id.ToString() + " AND invoiceSell_kind = 0";
            }
            else if (_invoiceType == invoiceType.unSellInvoice)
            {
                s_sqlCommand = "select count(*) from tbl_invoicesBuy where invoiceBuy_id = " + n_invoice_id.ToString() + " AND invoiceBuy_kind = 0";
            }
            else if (_invoiceType == invoiceType.wastedInvoice)
            {
                s_sqlCommand = "select count(*) from tbl_invoicesWasted where invoiceWasted_id = " + n_invoice_id.ToString();
            }

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

        public static DataTable viewAnInvoice(invoiceType _invoiceType, string s_whereExp)
        {
            string s_invoiceType = "";
            string s_sqlCommand = "SELECT        dbo.tbl_invoices{0}.invoice{0}_id, dbo.tbl_invoices{0}.invoice{0}_Kind, dbo.tbl_invoices{0}.invoice{0}_date, dbo.tbl_invoices{0}.invoice{0}_totalPrice, " +
                                    "dbo.tbl_invoices{0}.invoice{0}_cashPrice, dbo.tbl_invoices{0}.invoice{0}_discountPrice, dbo.tbl_invoices{0}.invoice{0}_transportPrice, " +
                                    "dbo.tbl_invoices{0}.invoice{0}_comment, dbo.tbl_persons.person_id, dbo.tbl_persons.person_familyAndName, dbo.tbl_persons.person_phone, " +
                                    "dbo.tbl_persons.person_address1, dbo.viw_items{0}.objectTitle, dbo.viw_items{0}.objectUnit_title, dbo.viw_items{0}.item{0}_unitCount, " +
                                    "dbo.viw_items{0}.item{0}_retailCount, dbo.viw_items{0}.objectTotalCount, dbo.viw_items{0}.object_retailInUnit, dbo.viw_items{0}.item{0}_retailPrice, " +
                                    "dbo.viw_items{0}.item{0}_discountPercent, dbo.viw_items{0}.objectTotalPrice, dbo.viw_items{0}.item{0}_comment, dbo.viw_items{0}.item{0}_taxPercent, " +
                                    "dbo.tbl_persons.person_beforeType, dbo.tbl_persons.person_remainMoney, dbo.tbl_persons.person_nowRemainMoney, dbo.tbl_persons.person_mobile, dbo.tbl_persons.person_phone2,dbo.tbl_persons.person_aliasName " +
                                    "FROM            dbo.tbl_persons INNER JOIN dbo.tbl_invoices{0} ON dbo.tbl_persons.person_id = dbo.tbl_invoices{0}.person_id INNER JOIN " +
                                    "dbo.viw_items{0} ON dbo.tbl_invoices{0}.invoice{0}_id = dbo.viw_items{0}.invoice{0}_id AND dbo.tbl_invoices{0}.invoice{0}_Kind = dbo.viw_items{0}.invoice{0}_kind "
                                    + s_whereExp;

            if(_invoiceType == invoiceType.buyInvoice)
            {
                s_invoiceType = "Buy";
            }
            else if(_invoiceType == invoiceType.sellInvoice)
            {
                s_invoiceType = "Sell";
            }

            s_sqlCommand = string.Format(s_sqlCommand, s_invoiceType);
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            DataTable dt_ = _mydal.select(s_sqlCommand, "viw_invoiceBuy");
            //ds_.Tables.Add(dt_);
            _mydal.disconnect();

            return dt_;
        }

        public static DataTable searchInvoicesByCondition(invoiceType _invoiceType, string s_whereExp)
        {
            string s_tableName = "";
            string s_sqlCommand = "";
            
            if (_invoiceType == invoiceType.buyInvoice)
            {
                s_tableName = "viw_invoiceBuy";
                s_sqlCommand = "SELECT        dbo.tbl_invoicesBuy.invoiceBuy_id, dbo.tbl_invoicesBuy.invoiceBuy_Kind, dbo.tbl_invoicesBuy.invoiceBuy_date, dbo.tbl_invoicesBuy.invoiceBuy_totalPrice, " +
                                        "dbo.tbl_invoicesBuy.invoiceBuy_cashPrice, dbo.tbl_invoicesBuy.invoiceBuy_discountPrice, dbo.tbl_invoicesBuy.invoiceBuy_transportPrice, " +
                                        "dbo.tbl_invoicesBuy.invoiceBuy_comment, dbo.tbl_persons.person_id, dbo.tbl_persons.person_familyAndName, dbo.tbl_persons.person_phone, " +
                                        "dbo.tbl_persons.person_address1 " +
                                        "FROM            dbo.tbl_persons INNER JOIN " +
                                        "dbo.tbl_invoicesBuy ON dbo.tbl_persons.person_id = dbo.tbl_invoicesBuy.person_id "
                                        + s_whereExp;
            }
            else if (_invoiceType == invoiceType.sellInvoice)
            {
                s_sqlCommand = "SELECT        dbo.tbl_invoicesSell.invoiceSell_id, dbo.tbl_invoicesSell.invoiceSell_Kind, dbo.tbl_invoicesSell.invoiceSell_date, dbo.tbl_invoicesSell.invoiceSell_totalPrice, " +
                                        "dbo.tbl_invoicesSell.invoiceSell_cashPrice, dbo.tbl_invoicesSell.invoiceSell_discountPrice, dbo.tbl_invoicesSell.invoiceSell_transportPrice, " +
                                        "dbo.tbl_invoicesSell.invoiceSell_comment, dbo.tbl_persons.person_id, dbo.tbl_persons.person_familyAndName, dbo.tbl_persons.person_phone, " +
                                        "dbo.tbl_persons.person_address1 " +
                                        "FROM            dbo.tbl_persons INNER JOIN " +
                                        "dbo.tbl_invoicesSell ON dbo.tbl_persons.person_id = dbo.tbl_invoicesSell.person_id "
                                        + s_whereExp;
            }
            else if (_invoiceType == invoiceType.wastedInvoice)
            {
                s_sqlCommand = "SELECT        tbl_invoicesWasted.invoiceWasted_id, tbl_invoicesWasted.invoiceWasted_date, tbl_invoicesWasted.invoiceWasted_totalPrice, " +
                                "tbl_invoicesWasted.invoiceWasted_comment, viw_itemsWasted.objectTitle, viw_itemsWasted.objectUnit_title, viw_itemsWasted.itemWasted_unitCount, " +
                                "viw_itemsWasted.itemWasted_retailCount, viw_itemsWasted.objectTotalCount, viw_itemsWasted.object_retailInUnit, viw_itemsWasted.itemWasted_retailPrice, " +
                                "viw_itemsWasted.objectTotalPrice, viw_itemsWasted.itemWasted_comment " +
                                "FROM            tbl_invoicesWasted INNER JOIN " +
                                "viw_itemsWasted ON tbl_invoicesWasted.invoiceWasted_id = viw_itemsWasted.invoiceWasted_id "
                                 + s_whereExp;
            }
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            DataTable dt_ = _mydal.select(s_sqlCommand, s_tableName);
            _mydal.disconnect();

            return dt_;
        }


        public static int UpdateObjectPrice(int n_invoiceID)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@n_invoiceID", n_invoiceID);
            int result = (int)_mydal.executeAProcedure("UpdatePrice");
            _mydal.disconnect();
            return result;
        }

        public static DataTable searchObject(string s_whereExp)
        {
             string s_sqlCommand = "";
             s_sqlCommand = "SELECT        tbl_invoicesSell.invoiceSell_id, tbl_invoicesSell.invoiceSell_date, tbl_invoicesSell.invoiceSell_comment, tbl_invoicesSell.invoiceSell_totalPrice, " +
                            "tbl_slaveGroups.slaveGroup_title + '  ' + tbl_objects.object_title AS objectTitle, tbl_persons.person_familyAndName, tbl_slaveGroups.slaveGroup_title, tbl_objects.object_title " +
                            "FROM            tbl_invoicesSell INNER JOIN tbl_itemsSell ON tbl_invoicesSell.invoiceSell_id = tbl_itemsSell.invoiceSell_id INNER JOIN tbl_objects ON tbl_itemsSell.object_id = tbl_objects.object_id INNER JOIN " +
                            "tbl_persons ON tbl_invoicesSell.person_id = tbl_persons.person_id INNER JOIN tbl_slaveGroups ON tbl_objects.slaveGroup_id = tbl_slaveGroups.slaveGroup_id " +
                            s_whereExp;

             cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
             _mydal.connect();
             DataTable dt_ = _mydal.select(s_sqlCommand, "viw_object");
             _mydal.disconnect();

             return dt_;
        }

        public static bool moveAnInvoiceToTrash(invoiceType _invoiceType, string s_invoiceXXX_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                if (_invoiceType == invoiceType.buyInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = 1 where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Buy", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = 1 where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Buy", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    _mydal.disconnect();
                }
                else if (_invoiceType == invoiceType.sellInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = 1 where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Sell", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = 1 where invoice{0}_id = {1}";                    
                    s_sqlCommand = string.Format(s_sqlCommand, "Sell", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);
                                                                              
                    _mydal.disconnect();
                }
                else if (_invoiceType == invoiceType.wastedInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = 1 where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Wasted", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = 1 where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Wasted", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    _mydal.disconnect();
                }
            }
            catch
            {                
                return false;
            }
            return true;
        }

        public static bool recycleAnInvoice(invoiceType _invoiceType, string s_invoiceXXX_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                if (_invoiceType == invoiceType.buyInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Buy", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Buy", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    _mydal.disconnect();
                }
                else if (_invoiceType == invoiceType.sellInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Sell", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Sell", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    _mydal.disconnect();
                }
                else if (_invoiceType == invoiceType.wastedInvoice)
                {
                    _mydal.connect();

                    //disable invoice table
                    s_sqlCommand = "update tbl_invoices{0} set invoice{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Wasted", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    //disable items table
                    s_sqlCommand = "update tbl_items{0} set item{0}_deleted = NULL where invoice{0}_id = {1}";
                    s_sqlCommand = string.Format(s_sqlCommand, "Wasted", s_invoiceXXX_id);
                    _mydal.docommand(s_sqlCommand);

                    _mydal.disconnect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
