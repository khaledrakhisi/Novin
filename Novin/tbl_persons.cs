using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;                                                         


namespace Novin
{
    class tbl_persons
    {
        private string s_tableName = "tbl_persons";

        public int person_id;
        public int zone_id;
        public string person_familyAndName;
        public string person_aliasName;
        public string person_nationalNum;
        public string person_ccode;
        public string person_phone;
        public int person_beforeType;
        public long person_remainMoney;
        public bool person_isCustomer;
        public bool person_isSeller;
        public bool person_isInter;
        public int person_discountPercent;
        public string person_comment;

        public tbl_persons()
        {

        }

        mydataaccesslayer _mydal = new mydataaccesslayer();

        //public DataSet selectWhere(string sRequiredFields, string sWhere)
        //{
        //    string sql = "select " + sRequiredFields + " from tbl_prof Where= " + sWhere + " ;";
        //    _mydal.connect();
        //    DataSet dt = _mydal.select(sql, "tbl_prof");
        //    _mydal.disconnect();
        //    return dt;
        //}
        //ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/wd_adonet/html/e380edac-da67-4276-80a5-b64decae4947.htm

        public SqlDataReader selectAll()
        {
            string sql = "select * from " + s_tableName + ";";
            _mydal.connect();
            SqlDataReader dr = _mydal.select(sql, s_tableName);
            _mydal.disconnect();
            return dr;
            //SqlDataReader 
        }

        //public void upDateData()
        //{
        //    string sql = "update  tbl_prof set  prof_id= '{0}' ,prof_familyAndName='{1}' where prof_id={0} ";
        //    sql = string.Format(sql, prof_id, prof_familyAndName);
        //    _mydal.connect();
        //    _mydal.docommand(sql);
        //    _mydal.disconnect();

        //}

        //public void insertData()
        //{
        //    string sql = "insert into tbl_prof(prof_id, prof_familyAndName, prof_) values('{0}', '{1}', '{2}')";
        //    sql = string.Format(sql, prof_id, prof_familyAndName, prof_);

        //    _mydal.connect();
        //    _mydal.docommand(sql);
        //    _mydal.disconnect();

        //}
        //public void deleteData()
        //{
        //    string sql = "delete from tbl_prof where prof_id={0}";
        //    sql = string.Format(sql, prof_id);
        //    _mydal.connect();
        //    _mydal.docommand(sql);
        //    _mydal.disconnect();
        //}

    }
}
