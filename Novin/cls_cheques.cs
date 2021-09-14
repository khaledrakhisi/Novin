using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Novin
{
    class cls_cheques
    {
        public static DataTable viewCheques(string s_whereExp)
        {
            string s_tableName = "";
            string s_sqlCommand = "";

            s_sqlCommand = "SELECT        dbo.tbl_cheques.chq_id, dbo.tbl_persons.person_familyAndName, dbo.tbl_cheques.chq_price, dbo.tbl_accounts.account_number, dbo.tbl_cheques.chq_number, dbo.tbl_chqStates.chqState_title, dbo.tbl_banks.bank_name, dbo.tbl_cheques.chq_comment,CASE WHEN dbo.tbl_cheques.chq_isItMine = 1 THEN 'پرداختی' ELSE 'دریافتی' END AS chequeType, dbo.tbl_cheques.accDoc_id " +
                            "FROM            dbo.tbl_cheques INNER JOIN dbo.tbl_chqStates ON dbo.tbl_cheques.chqState_id = dbo.tbl_chqStates.chqState_id INNER JOIN dbo.tbl_persons ON dbo.tbl_cheques.person_id = dbo.tbl_persons.person_id INNER JOIN dbo.tbl_banks ON dbo.tbl_cheques.bank_id = dbo.tbl_banks.bank_id INNER JOIN dbo.tbl_accounts ON dbo.tbl_cheques.bank_id = dbo.tbl_accounts.bank_id "
                            + s_whereExp;

            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            DataTable dt_ = _mydal.select(s_sqlCommand, s_tableName);
            _mydal.disconnect();

            return dt_;
        }

        public static bool moveChequesToTrash(int n_accDoc_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_cheques set chq_deleted = 1 where chq_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, n_accDoc_id);
                _mydal.docommand(s_sqlCommand);

                _mydal.disconnect();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool recycleCheques(int n_accDoc_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "";

            try
            {
                _mydal.connect();

                //disable invoice table
                s_sqlCommand = "update tbl_cheques set chq_deleted = NULL where chq_id = {0}";
                s_sqlCommand = string.Format(s_sqlCommand, n_accDoc_id);
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
