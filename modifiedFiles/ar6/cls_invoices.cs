using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novin
{
    class cls_invoices
    {
        cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

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


    }
}
