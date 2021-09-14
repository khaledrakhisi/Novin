using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Novin
{
    class cls_myDataAccessLayer
    {
        public string database = "novinDB.mdf";
        public static string s_pathRun = @"D:\develop\csharp\Novin\Novin";
        //public static string s_pathRun = Environment.CurrentDirectory;

        private static string s_connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + s_pathRun + @"\novinDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public static  string ConnectionString
        {
            get { return s_connectionString; }
        }

        private SqlConnection con;
        public SqlCommand com;
        public SqlDataAdapter da;        

        public cls_myDataAccessLayer()
        {
            //s_connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\develop\csharp\Novin\Novin\novinDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //s_connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Environment.CurrentDirectory + @"\school1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";

            con = new SqlConnection(s_connectionString);
            da = new SqlDataAdapter();
            com = new SqlCommand();
            com.Connection = con;
            da.SelectCommand = com;
        }
        public void connect()
        {                        
            s_connectionString = string.Format(s_connectionString, this.database);
            con.ConnectionString = s_connectionString;
            con.Open();
        }

        public void disconnect()
        {
            con.Close();
        }

        public DataTable select(string sSqlCommand, string sTableName)
        {
            DataTable dt = new DataTable(sTableName);
            try
            {
                com.CommandText = sSqlCommand;
                da = new SqlDataAdapter(com);
                //da.SelectCommand = new SqlCommand(s);
                //SqlDataReader dr = com.ExecuteReader();
                //da.Fill(dt, sTableName);
                da.Fill(dt);                
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
            return dt;
        }

        public object doCommandScalar(string s_sqlCommand)
        {
            com.CommandText = s_sqlCommand;
            return com.ExecuteScalar();
        }

        public void docommand(string s)
        {
            com.CommandText = s;
            com.ExecuteNonQuery();
        }

        public object executeAProcedure(string s_storedProcedureName)
        {
            com.CommandText = s_storedProcedureName;
            com.CommandType = CommandType.StoredProcedure;
            return com.ExecuteNonQuery();
        }

        public object executeAFunction(string s_functionName)
        {
            com.CommandText = s_functionName;
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter p = com.Parameters.Add("@result", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.ReturnValue;
            com.ExecuteNonQuery();

            return com.Parameters["@result"].Value;
        }

       
    }
}
