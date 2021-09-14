using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_accountsPrimaryMoney : Novin.frm_FATHER
    {
        public frm_accountsPrimaryMoney()
        {
            InitializeComponent();
        }

        private void upDateTheDatabase()
        {
            try
            {
                this.Validate();
                this.bs_accounts.EndEdit();
                this.tableAdapterManager.UpdateAll(this.ds_accounts);
            }
            catch (System.Data.SqlClient.SqlException  ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void frm_accountsPrimaryMoney_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ds_accounts.tbl_accounts' table. You can move, or remove it, as needed.
                this.tbl_accountsTableAdapter.FillBy(this.ds_accounts.tbl_accounts);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            upDateTheDatabase();

            if (!cls_accDoc.isItPrimaryCycle)
            {
                //در اینجا باید سطرهای سندهای افتتاحیه از اول ساخته بشوند
                frm_primaryCycleEnd _primaryCycleEnd = new frm_primaryCycleEnd();
                _primaryCycleEnd.frm_primaryCycleEnd_Load(null, null);
                _primaryCycleEnd.issuseFirstAndSecondAccdoc();
            }
        }

        private void bs_accounts_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_moneyInChars.Text = cls_numberConvertor.convertToChars(ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_totalPrice"].ToString()) + " ریال ";
            }
            catch
            {
            }
        }
    }
}
