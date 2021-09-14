using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Novin
{
    class mydataaccesslayer
    {
        public string database = "Novin.mdf";
        private string s_connectionString;
        public string ConnectionString
        {
            get { return s_connectionString; }
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataAdapter da;

        public mydataaccesslayer()
        {
            s_connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\develop\csharp\Novin\Novin\novinDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //s_connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Environment.CurrentDirectory + @"\school1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";

            con = new SqlConnection();
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

        public SqlDataReader select(string sSqlCommand, string sTableName)
        {
            com.CommandText = sSqlCommand;
            //da = new SqlDataAdapter(com);
            //da.SelectCommand = new SqlCommand(s);
            //DataSet dt = new DataSet();
            SqlDataReader dr = com.ExecuteReader();
            //da.Fill(dt, sTableName);
            //da.Fill(dt);
            return dr;
        }
        public void docommand(string s)
        {
            com.CommandText = s;
            com.ExecuteNonQuery();
        }
    }
}
