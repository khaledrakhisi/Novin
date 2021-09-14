using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_setPassword : Novin.frm_FATHER
    {
        public frm_setPassword()
        {
            InitializeComponent();
            s_oldPassword = "";
        }
        public string s_oldPassword;

        private void tbx_oldPass_TextChanged(object sender, EventArgs e)
        {
            if (tbx_oldPass.Text == s_oldPassword)
            {
                tbx_newPass.Enabled = true;
                tbx_confirmNewPass.Enabled = true;
                btn_ok.Enabled = true;
            }
            else
            {
                tbx_newPass.Enabled = false;
                tbx_confirmNewPass.Enabled = false;
                btn_ok.Enabled = false;
            }
        }

        private void tbx_newPass_TextChanged(object sender, EventArgs e)
        {
            if (tbx_newPass.Text == tbx_confirmNewPass.Text)
            {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void tbx_confirmNewPass_TextChanged(object sender, EventArgs e)
        {
            if (tbx_newPass.Text == tbx_confirmNewPass.Text)
            {
                btn_ok.Enabled = true;
            }
            else
            {
                btn_ok.Enabled = false;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
    }
}
