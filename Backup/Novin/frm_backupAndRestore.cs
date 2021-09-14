using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Novin
{
    public partial class frm_backupAndRestore : Novin.frm_FATHER
    {
        public frm_backupAndRestore()
        {
            InitializeComponent();
        }

        private void btn_provideBackup_Click(object sender, EventArgs e)
        {
            //SqlConnection sq = new SqlConnection("Data Source=.;Integrated Security=True");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.bak|*.bak";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
                _mydal.connect();
                _mydal.docommand(@"backup database novinDB to disk = '" + sfd.FileName + "'");
                _mydal.disconnect();
                //SqlCommand com = new SqlCommand("backup database " + txtDBName + " to disk='"
                //+ sfd.FileName + "'", sq);
                //sq.Open();
                //com.ExecuteNonQuery();
                //sq.Close();
            }//if
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            //ConnectionStringSettings settings =
            //ConfigurationManager.ConnectionStrings["connectionString"];
            //string connectString = settings.ConnectionString;
            //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            //builder.DataSource = ServerName;
            //builder.InitialCatalog = DataBaseName;
            //string conString = builder.ConnectionString;
        }
    }
}
