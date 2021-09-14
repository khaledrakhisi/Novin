using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_bank : Novin.frm_FATHER
    {
        public frm_bank()
        {
            InitializeComponent();
        }

        private void frm_bank_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ds_accounts.tbl_banks' table. You can move, or remove it, as needed.
                this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }

        }

        private void updateTheDatabase()
        {

            this.Validate();
            bs_banks.EndEdit();
            tbl_banksTableAdapter.Update(ds_accounts.tbl_banks);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string s_bankName = cls_inputBox.show("نام بانک جدید را وارد نمایید. ");
            if (s_bankName != "")
            {
                DataRow drw_newBank;

            
                drw_newBank = ds_accounts.tbl_banks.NewRow();

                drw_newBank["bank_name"] = s_bankName;
                drw_newBank["bank_comment"] = "";
              
                ds_accounts.tbl_banks.Rows.Add(drw_newBank);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cls_msgBox.show("آیا از حذف کردن بانک مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes) 
            {
                bs_banks.RemoveCurrent();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updateTheDatabase();            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bs_banks_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frm_bank_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTheDatabase();     
            
        }
    }
}
