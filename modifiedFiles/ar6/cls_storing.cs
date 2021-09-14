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

        public enum invoiceType { buyInvoic = 1, sellInvoic, unBuyInvoice, unSellInvoice, wastedInvoic};

        public cls_storing()
        {
            _mydal = new cls_myDataAccessLayer();
        }

        public bool setTheEntity(invoiceType _invoiceType, int n_invoiceID)
        {
            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@invoiceType", _invoiceType);
            _mydal.com.Parameters.AddWithValue("@n_invoiceID", n_invoiceID);
            _mydal.executeAProcedure("sp_setTheEntity");
            return false;
        }
    }
}
