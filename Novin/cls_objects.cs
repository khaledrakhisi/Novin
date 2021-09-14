using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novin
{
    class cls_objects
    {
        cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

        public string getObjectTitle(int n_object_id)
        {

            _mydal.connect();
            string s_objectTitle = "";
            try
            {
                s_objectTitle = (string)_mydal.doCommandScalar("select object_title from tbl_objects where object_id = " + n_object_id + ";");
            }
            catch
            {
            }            
            _mydal.disconnect();
            return s_objectTitle;
        }
    }
}
