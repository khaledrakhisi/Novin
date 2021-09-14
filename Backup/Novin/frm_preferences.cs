using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Novin
{
    public partial class frm_preferences : Novin.frm_FATHER
    {
        public frm_preferences()
        {
            InitializeComponent();
        }

        private void saveBGSettings()
        {
            //Save The BG settings INTo The Rigestry
            int nState = 0, min = 0;
            if (!chk_showMainMenu.Checked)
            {
                nState = 1;
            }
            if (!chk_showSamePathPic.Checked)
            {
                min = 1;
            }
            else
            {
                min = (int)num_seconds.Value;
            }
            // Open the key
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\jaavid\\Preferences\\" + cls_users.user_id.ToString(), true);
            key.SetValue("BGImagePath", tbx_path.Text, RegistryValueKind.String);
            key.SetValue("BGImagePosition", cmb_picPosition.SelectedIndex, RegistryValueKind.DWord);
            key.SetValue("noMainMenu", nState, RegistryValueKind.DWord);
            key.SetValue("delaySeconds", min, RegistryValueKind.DWord);
            key.Close();
        }

        private void updateTheUsersDataset()
        {
            this.Validate();
            bs_users.EndEdit();
            tbl_usersTableAdapter.Update(ds_users.tbl_users);
        }

        private void applayTheLimitString()
        {
            try
            {
                string limitString = cls_users.user_limitString;
                string[] limits = limitString.Split(';');
                for (int i = 0; i < limits.Length; i++)
                {
                    bool bValue = false;
                    if (limits[i] == "1")
                    {
                        bValue = true;
                    }
                    chkLst_Allocations.SetItemChecked(i, bValue);

                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadSettings()
        {
            //LOAD APPREANCE SETTING
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\jaavid\\Preferences\\" + cls_users.user_id.ToString());

            if (key.GetValue("BGImagePath") != null)
            {
                // The value exists; load the data that stored in the registry.
                tbx_path.Text = (string)key.GetValue("BGImagePath");
            }

            try
            {
                pic_sampleScreen.Image = Image.FromFile(tbx_path.Text);
            }
            catch
            {
            }

            if (key.GetValue("BGImagePosition") != null)
            {
                // The value exists; load the data that stored in the registry.
                cmb_picPosition.SelectedIndex = (int)key.GetValue("BGImagePosition");
            }

            //load the main menu settings
            if (key.GetValue("noMainMenu") != null)
            {
                // The value exists; load the data that stored in the registry.
                int nState = 0;

                nState = (int)key.GetValue("noMainMenu");
                if (nState == 1)
                {
                    chk_showMainMenu.Checked = false;
                }
            }

            //load the Backup settings
            if (key.GetValue("backupPath") != null)
            {
                tbx_backupPath.Text = (string)key.GetValue("backupPath");
            }

            //load the 'showPicsInTheSameDirectoryDelaySeconds' settings
            if (key.GetValue("delaySeconds") != null)
            {
                int seconds = (int)key.GetValue("delaySeconds");
                if (seconds == 1)
                {
                    num_seconds.Value = 10;
                    chk_showSamePathPic.Checked = false;
                }
                else if (seconds > 1)
                {
                    num_seconds.Value = seconds;
                    chk_showSamePathPic.Checked = true;
                }
            }
            key.Close();

            key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\jaavid\\Preferences");

            //load reminder settings
            if (key.GetValue("reminderSoundPath") != null && (string)key.GetValue("reminderSoundPath") != "")
            {
                tbx_reminderSoundPath.Text = (string)key.GetValue("reminderSoundPath");
            }
            else
            {
                chk_playSoundOnTime.Checked = false;
            }
        }

        private void loadUsers()
        {
            try
            {
                listView_users.Clear();

                int i = 0;
                foreach(DataRow row_user in ds_users.tbl_users.Rows)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string s_connectionString;
        public string connectionString
        {
            get { return s_connectionString; }
            set { s_connectionString = value; }
        }


        private void frm_preferences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_users.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.ds_users.tbl_users);

            cmb_picPosition.SelectedIndex = 1;
           
            cmb_imagesNames.SelectedIndex = 0;

            loadSettings();

            loadUsers();
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count == 0)
                {
                    pnl_userProp.Enabled = false;
                    pnl_userManagment.Enabled = false;
                }
                else
                {
                    //select user properties
                    pnl_userProp.Enabled = true;
                    pnl_userManagment.Enabled = true;

                    //if the 'programmer user' has been selected
                    if (ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_accountType"].ToString() == "0")// && limitString[13] == '0')
                    {
                        pnl_userProp.Enabled = false;
                        pnl_userManagment.Enabled = false;
                    }

                    //if the 'current active user' selected
                    if (cls_users.user_id == (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_id"])
                    {
                        cmb_accountType.Enabled = false;
                        chkLst_Allocations.Enabled = false;
                    }
                    else
                    {
                        int nSelectedUserLimitType = (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_accountType"];
                        int nCurrentActiveUserLimitType = (int)ds_users.tbl_users.Rows[bs_users.Find("user_id", cls_users.user_id)]["user_accountType"];

                        if (nSelectedUserLimitType >= nCurrentActiveUserLimitType || nSelectedUserLimitType == 3 || nCurrentActiveUserLimitType == 3)
                        {
                            cmb_accountType.Enabled = true;
                            chkLst_Allocations.Enabled = true;
                        }
                    }

                    if (ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picPath"] != DBNull.Value && (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] == cmb_imagesNames.Items.Count - 1)
                    {
                        cmb_imagesNames.SelectedIndex = cmb_imagesNames.Items.Count - 1;
                    }
                    else
                    {
                        cmb_imagesNames.SelectedIndex = (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picIndex"];
                    }

                    applayTheLimitString();

                    cmb_accountType.SelectedIndex = (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_accountType"];

                    if (ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_password"] != DBNull.Value)
                    {
                        lnk_managePassword.Text = "تغییر یا حذف گذرواژه";
                    }
                    else
                    {
                        lnk_managePassword.Text = "ایجاد گذرواژه";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_imagesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_imagesNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (listView_users.SelectedIndices.Count > 0)
                {
                    listView_users.Items[listView_users.SelectedIndices[0]].ImageIndex = cmb_imagesNames.SelectedIndex;
                    ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] = cmb_imagesNames.SelectedIndex;
                    if (cmb_imagesNames.SelectedIndex < cmb_imagesNames.Items.Count - 1)
                    {
                        ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picPath"] = DBNull.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_createUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s_userName = "";
            try
            {
                if (cls_users.user_limitString[0] == '0')//limitString[0] == allow enter data
                {
                    cls_msgBox.show("دسترسی محدود است");
                    return;
                }

                s_userName = cls_inputBox.show("نام کاربری را وارد نمایید");
                if (s_userName != "")
                {
                    DataRow row_newUser;
                    row_newUser = ds_users.tbl_users.NewRow();
                    int n_user_id = cls_users.getNextUserID();
                    row_newUser["user_id"] = n_user_id;
                    row_newUser["user_name"] = s_userName;
                    row_newUser["user_picIndex"] = 0;
                    row_newUser["user_accountType"] = 2;//کاربر عادی
                    row_newUser["user_limitString"] = "1;0;0;1;1;1;1;1;1;1;1;0;1;0";
                    ds_users.tbl_users.Rows.Add(row_newUser);

                    updateTheUsersDataset();

                    loadUsers();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_selectPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls_users.user_limitString[12] == '0')//limitString[12] == allow change bg
                {
                    MessageBox.Show("دسترسی محدود است", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ofd_pic.InitialDirectory = Application.StartupPath + "\\pix";
                ofd_pic.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                ofd_pic.FileName = "";
                if (ofd_pic.ShowDialog() == DialogResult.OK)
                {
                    pic_sampleScreen.Image = Image.FromFile(ofd_pic.FileName);
                    tbx_path.Text = ofd_pic.FileName;
                    cmb_picPosition.SelectedIndex = 1;//stretch
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_renameUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cls_users.user_limitString[1] == '0')//limitString[1] == allow edit data
                {
                    cls_msgBox.show("دسترسی محدود است");
                    return;
                }

                if (listView_users.SelectedIndices.Count > 0)
                {
                    string s_user_id = ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_id"].ToString();
                    string s_oldUserName = ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_name"].ToString();
                    string s_newUserName = cls_inputBox.show("اصلاحات لازم را انجام دهید", s_oldUserName);
                    if (s_newUserName != "")
                    {
                        ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_name"] = s_newUserName;
                        updateTheUsersDataset();
                        loadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_managePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cls_users.user_limitString[1] == '0')//limitString[1] == allow edit data
            {
                cls_msgBox.show("دسترسی محدود است");
                return;
            }

            frm_setPassword frmSetPass = new frm_setPassword();

            if (ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_password"] != DBNull.Value)
            {
                frmSetPass.s_oldPassword = ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_password"].ToString();
            }

            if (frmSetPass.ShowDialog() == DialogResult.OK)
            {
                if (frmSetPass.tbx_confirmNewPass.Text == "")
                {
                    ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_password"] = DBNull.Value;
                    MessageBox.Show("گذرواژه حذف شد", "تنظیم گذرواژه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_password"] = frmSetPass.tbx_confirmNewPass.Text;
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            updateTheUsersDataset();
            saveBGSettings();
        }

        private void lnk_deleteUserAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cls_users.user_limitString[2] == '0')//limitString[2] == allow delete data
                {
                    cls_msgBox.show("دسترسی محدود است");
                    return;
                }

                if (cls_users.user_id == (int)ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_id"])
                {
                    cls_msgBox.show("شما نمی توانید یک حساب کاربری را از خودش حذف کنید");
                    return;
                }

                if (listView_users.SelectedIndices.Count > 0)
                {
                    if (MessageBox.Show("آیا از حذف کردن حساب کاربری موردنظر مطمئنید ؟", "حذف کردن حساب کاربری", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string sUserID = ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_id"].ToString();
                        bs_users.Position = bs_users.Find("user_id", sUserID);

                        bs_users.RemoveCurrent();

                        updateTheUsersDataset();
                        
                        loadUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnk_browseForPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ofd_pic.InitialDirectory = Application.StartupPath + "\\pix";
                ofd_pic.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
                ofd_pic.FileName = "";
                if (ofd_pic.ShowDialog() == DialogResult.OK)
                {
                    imageList1.Images.Add(Image.FromFile(ofd_pic.FileName));

                    cmb_imagesNames.SelectedIndex = cmb_imagesNames.Items.Count - 1;
                    listView_users.SelectedItems[0].ImageIndex = imageList1.Images.Count - 1;

                    ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picPath"] = ofd_pic.FileName;
                    ds_users.tbl_users.Rows[listView_users.SelectedIndices[0]]["user_picIndex"] = cmb_imagesNames.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_picPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_picPosition.SelectedIndex == 0)
            {
                pictureBox2.Image = pic_sampleScreen.Image;
                pictureBox3.Image = pic_sampleScreen.Image;
                pictureBox4.Image = pic_sampleScreen.Image;
                pictureBox5.Image = pic_sampleScreen.Image;

                pnl_tile.Visible = true;

            }
            else if (cmb_picPosition.SelectedIndex == 1)
            {
                pnl_tile.Visible = false;
                pic_sampleScreen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (cmb_picPosition.SelectedIndex == 2)
            {
                pnl_tile.Visible = false;
                pic_sampleScreen.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void chk_showSamePathPic_CheckedChanged(object sender, EventArgs e)
        {
            if (cls_users.user_limitString[12] == '0')//limitString[12] == allow change bg
            {
                cls_msgBox.show("دسترسی محدود است");
                return;
            }

            num_seconds.Enabled = chk_showSamePathPic.Checked;
            pnl_delayGroup.Enabled = chk_showSamePathPic.Checked;
        }
    }
}
