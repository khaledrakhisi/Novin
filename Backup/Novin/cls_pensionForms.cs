using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Novin
{
    class cls_pensionForms
    {
        public static int getNextPensionFormID()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            int n_pensionID = 0;
            try
            {
                n_pensionID = (int)_mydal.doCommandScalar("select max(pension_id) from tbl_pensionForms");
            }
            catch
            {
            }
            _mydal.disconnect();

            return ++n_pensionID;
        }

        public static int getNextPensionDetractID()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            int n_penDetID = 0;
            try
            {
                n_penDetID = (int)_mydal.doCommandScalar("select max(penDet_id) from tbl_pensionsDetracts");
            }
            catch
            {
            }
            _mydal.disconnect();

            return ++n_penDetID;
        }

        //public static DataTable viewAPensionForm()
        //{

        //}
    }
}
