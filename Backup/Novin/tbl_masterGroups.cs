using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;                                                         


namespace Novin
{
    class tbl_masterGroups
    {
        private string s_tableName = "tbl_masterGroups";
        public int masterGroup_id;
        public string masterGroup_title;        

        public tbl_masterGroups()
        {

        }

        cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

        //public DataSet selectWhere(string sRequiredFields, string sWhere)
        //{
        //    string sql = "select " + sRequiredFields + " from tbl_prof Where= " + sWhere + " ;";
        //    _mydal.connect();
        //    DataSet dt = _mydal.select(sql, "tbl_prof");
        //    _mydal.disconnect();
        //    return dt;
        //}

        //public DataTable selectAll()
        //{
        //    string sql = "select * from " + s_tableName + ";";
        //    _mydal.connect();
        //    DataTable dt = _mydal.select(sql, s_tableName);
        //    _mydal.disconnect();
        //    return dt;
        //}

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
