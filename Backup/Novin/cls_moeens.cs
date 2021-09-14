using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novin
{
    class cls_moeens
    {
        cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

        public string moeen_id;
        public string kol_id;
        public string moeen_title;

        private void setTheNextMoeenID()
        {
            _mydal.connect();
            int o_availableMoeenID =(int) _mydal.doCommandScalar("select count(*) from tbl_moeens where KOL_id = " + kol_id.ToString());
            o_availableMoeenID++;
            string s_nextMoeenID = o_availableMoeenID.ToString();
            while (s_nextMoeenID.Length < 4) s_nextMoeenID = s_nextMoeenID.Insert(0, "0");

            moeen_id = kol_id + s_nextMoeenID;
            _mydal.disconnect();
        }

        public void insertRelatedMoeen()
        {
            //ابتدا باید شماره آخرین معین تعریف شده بدست آید
            setTheNextMoeenID();

            string s_sqlCommand = "insert into tbl_moeens(moeen_id, kol_id, moeen_title) values('{0}', '{1}', '{2}');";
            s_sqlCommand = string.Format(s_sqlCommand,moeen_id, kol_id, moeen_title);

            _mydal.connect();
            _mydal.docommand(s_sqlCommand);
            _mydal.disconnect();
        }

        public void updateRelatedMoeen()
        {
            string s_sqlCommand = "update tbl_moeens set moeen_title = '{0}' where moeen_id = {1};";
            s_sqlCommand = string.Format(s_sqlCommand, moeen_title, moeen_id);

            _mydal.connect();
            _mydal.docommand(s_sqlCommand);
            _mydal.disconnect();
        }

        public void deleteRelatedMoeen()
        {
            string s_sqlCommand = "delete from tbl_moeens where moeen_id = '{0}'";
            s_sqlCommand = string.Format(s_sqlCommand, moeen_id);

            _mydal.connect();
            _mydal.docommand(s_sqlCommand);
            _mydal.disconnect();
        }
    }
}
