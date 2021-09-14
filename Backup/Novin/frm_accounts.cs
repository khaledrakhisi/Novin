using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Novin
{
    public partial class frm_accounts : Novin.frm_FATHER
    {
        public frm_accounts()
        {
            InitializeComponent();
        }

        private void upDateTheDatabase()
        {
            this.Validate();
            bs_accounts.EndEdit();
            tbl_accountsTableAdapter.Update(ds_accounts.tbl_accounts);
        }

        private void btn_newBank_Click(object sender, EventArgs e)
        {
            try
            {
                frm_bank _frm_bank = new frm_bank();
                _frm_bank.ShowDialog();

                //this.Validate();
                //bs_banks.EndEdit();
                //tbl_banksTableAdapter.Update(ds_accounts.tbl_banks);
                this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);
            }
            catch (SqlException  ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_accounts_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ds_accounts.tbl_accountTypes' table. You can move, or remove it, as needed.
                this.tbl_accountTypesTableAdapter.Fill(this.ds_accounts.tbl_accountTypes);
                // TODO: This line of code loads data into the 'ds_accounts.tbl_banks' table. You can move, or remove it, as needed.
                this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);
                // TODO: This line of code loads data into the 'ds_accounts.tbl_accounts' table. You can move, or remove it, as needed.
                this.tbl_accountsTableAdapter.FillWithoutCash(this.ds_accounts.tbl_accounts);
            }
            catch (SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }

            tbx_totalPrice.ReadOnly = !cls_accDoc.isItPrimaryCycle;
            //bs_accounts.Filter = "account_chapterName <> '-120' or account_chapterName is null";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string s_accountNumber = cls_inputBox.show("شماره حساب را وارد نمایید");
            if (s_accountNumber != "")
            {
                cls_moeens _moeens = new cls_moeens();
                //در اینجا سرفصل معین مربوط به حساب تعریف شده ایجاد میشود                
                
                _moeens.kol_id = "102";
                _moeens.moeen_title = "";
                _moeens.insertRelatedMoeen();

                //
                DataRow drw_newAccount;

                drw_newAccount = ds_accounts.tbl_accounts.NewRow();
                drw_newAccount["bank_id"] = (int)ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_id"];
                drw_newAccount["moeen_id"] = _moeens.moeen_id;
                drw_newAccount["account_number"] = s_accountNumber;
                drw_newAccount["accountType_id"] = 1;
                drw_newAccount["account_totalPrice"] = 0;
                drw_newAccount["account_remain"] = 0;

                try
                {
                    ds_accounts.tbl_accounts.Rows.Add(drw_newAccount);

                    bs_accounts.Position = bs_accounts.Find("account_number", s_accountNumber);

                    //
                    string s_bankName = (string)ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_name"];
                    string s_accountType = (string)ds_accounts.tbl_accountTypes.Rows[bs_accountsTypes.Position]["accountType_title"];
                    _moeens.moeen_title = s_bankName + " " + s_accountType + " " + s_accountNumber;
                    _moeens.updateRelatedMoeen();

                    upDateTheDatabase();
                }
                catch (Exception ex)
                {
                    cls_msgBox.show(ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cls_msgBox.show("آیا از حذف کردن شماره حساب مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {  
                {
                    try
                    {
                        cls_moeens _moeens = new cls_moeens();
                        _moeens.moeen_id = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["moeen_id"];
                        _moeens.deleteRelatedMoeen();

                        bs_accounts.RemoveCurrent();
                    }
                    catch (Exception ex)
                    {
                        cls_msgBox.show(ex.Message);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string s_originalAccountNumber = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_number"];
                string s_newAccountNumber = cls_inputBox.show("شماره حساب را اصـــلاح نمایید", s_originalAccountNumber);
                if (s_newAccountNumber != "")
                {
                    ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_number"] = s_newAccountNumber;

                    //
                    cls_moeens _moeens = new cls_moeens();
                    _moeens.moeen_id = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["moeen_id"];
                    string s_bankName = (string)ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_name"];
                    string s_accountType = (string)ds_accounts.tbl_accountTypes.Rows[bs_accountsTypes.Position]["accountType_title"];
                    string s_accountNumber = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_number"];
                    _moeens.moeen_title = s_bankName + " " + s_accountType + " " + s_accountNumber;
                    _moeens.updateRelatedMoeen();

                    upDateTheDatabase();
                }
            }
            catch (SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //
            try
            {
                cls_moeens _moeens = new cls_moeens();
                _moeens.moeen_id = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["moeen_id"];
                string s_bankName = (string)ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_name"];
                string s_accountType = (string)ds_accounts.tbl_accountTypes.Rows[bs_accountsTypes.Position]["accountType_title"];
                string s_accountNumber = (string)ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_number"];
                _moeens.moeen_title = s_bankName + " " + s_accountType + " " + s_accountNumber;
                _moeens.updateRelatedMoeen();

                upDateTheDatabase();
                cls_msgBox.show("ثبت رکوردها با موفقیت انجام شد", "تایید ثبت", cls_msgBox.buttons.OKOnly);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void bs_accounts_CurrentChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //if it is SANDOGH
            //    if (ds_accounts.tbl_accounts.Rows[bs_accounts.Position]["account_chapterName"].ToString() == "-120")
            //    {
            //        cbx_accountType.Visible = false;
            //        cmb_bankName.Visible = false;
            //    }
            //}
            //catch(Exception ex)
            //{
            //    cls_msgBox.show(ex.Message);
            //}
        }

        private void frm_accounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_add.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_edit.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_close.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_delete.PerformClick();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            upDateTheDatabase();
        }

        
    }
}
