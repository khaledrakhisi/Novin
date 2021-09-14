using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Novin
{
    class cls_visitors
    {
        public static DataTable viewPersons(string s_where)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            if (s_where != "")
            {
                s_where = " WHERE " + s_where;
            }

            string s_sqlCommand = "SELECT        dbo.tbl_persons.moeen_id, dbo.tbl_persons.person_id, dbo.tbl_persons.person_familyAndName, dbo.tbl_persons.person_phone, dbo.tbl_persons.person_address1,  CASE WHEN dbo.tbl_persons.person_nowRemainMoney > 0 THEN dbo.tbl_persons.person_nowRemainMoney WHEN dbo.tbl_persons.person_nowRemainMoney < 0 THEN abs(dbo.tbl_persons.person_nowRemainMoney) ELSE 0 END AS nowRemainMoney, CASE WHEN dbo.tbl_persons.person_nowRemainMoney > 0 THEN 'بد' WHEN dbo.tbl_persons.person_nowRemainMoney < 0 THEN 'بس' ELSE '---' END AS detect " +
                                    "FROM            dbo.tbl_persons INNER JOIN dbo.tbl_zones ON dbo.tbl_persons.zone_id = dbo.tbl_zones.zone_id INNER JOIN dbo.tbl_visitors ON dbo.tbl_zones.visitor_id = dbo.tbl_visitors.visitor_id "
                                    + s_where;
           
            DataTable dt_ = _mydal.select(s_sqlCommand, "tbl_persons");
            _mydal.disconnect();

            return dt_;
        }

        public static long getPersonIndebtedOrCreditorMoney(string @s_moeen_id, string sWhere)
        {
            cls_myDataAccessLayer _mydal1 = new cls_myDataAccessLayer();
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            long n_total1 = 0, n_total2 = 0;

            _mydal1.connect();
            _mydal1.com.Parameters.AddWithValue("@s_id", @s_moeen_id);
            _mydal1.com.Parameters.AddWithValue("@n_ledgerKind", 2);//2 means moeen ledger
            _mydal1.executeAProcedure("sp_ledger");
            _mydal1.disconnect();

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

            try
            {
                n_total1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                n_total2 = (long)dt_totals.Rows[0]["creditorTotal"];
            }
            catch
            {
            }

            return (n_total1 - n_total2);
        }
        public static void setPersonNowRemainMoney(string @s_moeen_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            _mydal.com.Parameters.AddWithValue("@s_id", @s_moeen_id);
            _mydal.com.Parameters.AddWithValue("@n_ledgerKind", 2);//2 means moeen ledger
            _mydal.executeAProcedure("sp_ledger");
            _mydal.disconnect();
        }

        public static int getNextPersonID()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            int n_personID = (int) _mydal.doCommandScalar("Select max(person_id) from tbl_persons");
            _mydal.disconnect();
            
            return ++n_personID;
        }               
    }
}
