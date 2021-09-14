using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Novin
{
    public partial class frm_logOn : frm_FATHER
    {
        public frm_logOn()
        {
            InitializeComponent();
        }
        //DataTable dt_users = new DataTable();
        public int n_userID;

        private void loadUsers()
        {
            try
            {
                listView_users.Clear();

                int i = 0;
                foreach (DataRow row_user in ds_users.tbl_users.Rows)
                {
                    if (row_user["user_accountType"].ToString() != "0")
                    {
                        listView_users.Items.Add(row_user["user_name"].ToString(), (int)row_user["user_PicIndex"]);

                        if (row_user["user_PicPath"] != DBNull.Value)
                        {
                            string s_picPath = row_user["user_PicPath"].ToString();

                            try
                            {
                                imageList1.Images.Add(Image.FromFile(s_picPath));
                            }
                            catch
                            {
                            }
                            listView_users.Items[i].ImageIndex = imageList1.Images.Count - 1;
                        }
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_logOn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_users.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.ds_users.tbl_users);

            loadUsers();
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count == 0)
                {
                    tbx_userName.Text = "";
                }
                else
                {
                    tbx_userName.Text = ds_users.tbl_users.Rows[listView_users.SelectedIndices[0] + 1]["user_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Thread.Sleep(2000);
            }
            catch
            {
            }
        }

        private void tbx_userName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = bs_users.Find("user_name", tbx_userName.Text);
                if (pos > -1)
                {
                    btn_ok.Enabled = true;
                    if (ds_users.tbl_users.Rows[pos]["user_password"] != DBNull.Value)
                    {
                        pnl_Password.Visible = true;
                    }
                    else
                    {
                        pnl_Password.Visible = false;
                    }
                }
                else
                {
                    btn_ok.Enabled = false;
                    pnl_Password.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_logOn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.DialogResult == DialogResult.OK)
                {
                    int pos = bs_users.Find("user_name", tbx_userName.Text);
                    if (pos > -1)
                    {
                        bs_users.Position = pos;
                        if (ds_users.tbl_users.Rows[bs_users.Position]["user_password"] != DBNull.Value)
                        {
                            if (tbx_password.Text != ds_users.tbl_users.Rows[bs_users.Position]["user_password"].ToString())
                            {
                                e.Cancel = true;
                                tbx_password.Text = "";
                            }
                            else
                            {
                                n_userID = (int)ds_users.tbl_users.Rows[bs_users.Position]["user_id"];
                                cls_users.user_id = n_userID;
                            }
                        }
                        else
                        {
                            n_userID = (int)ds_users.tbl_users.Rows[bs_users.Position]["user_id"];
                            cls_users.user_id = n_userID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
