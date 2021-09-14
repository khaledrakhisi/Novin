using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_primaryCycleEnd : Novin.frm_FATHER
    {
        public frm_primaryCycleEnd()
        {
            InitializeComponent();
        }
        long n_sumOfMineCheques=0;
        long n_sumOfNotMineCheques=0;
        long n_sumOfIndebtedPrices=0;
        long n_sumOfCreditorPrices=0;
        long n_sumOfCashPrices=0;
        long n_sumOfAccuontPrices=0;
        long n_entireObjectCost=0;

        public void issuseFirstAndSecondAccdoc()
        {
            //ویرایش سند با شماره 1
            //cls_accDoc _accDoc = new cls_accDoc();
            if (!cls_accDoc.isThisAccDocExist(1))//if accDoc 1 is exist then locate it
            {
                cls_accDoc.createAccDoc(false);
            }            
            cls_accDoc.accDoc_price = 0;
            if (cls_accDoc.isItPrimaryCycle)
            {
                cls_accDoc.accDoc_comment = "سند افتتاحیه";
                cls_accDoc.accDoc_date = cls_numberConvertor.nowDateInAppropriateFormat();
            }
            else
            {
                cls_accDoc.accDoc_comment = "سند افتتاحیه اصلاح شده";
            }
            cls_accDoc.accDoc_isItPermenantly = true;//
            cls_accDoc.updateAnAccDoc(1);
            //_accDoc.createAccDoc();
            {
                cls_accDoc.clearAccDocRows();
                //ساختن سطرهای حساب های بانکی و صندوق                    
                foreach (DataRow row_account in ds_viewAccounts.viw_accounts.Rows)
                {
                    long n_accountPrice = 0;
                    try
                    {
                        n_accountPrice = (long)row_account["account_totalPrice"];
                    }
                    catch
                    {
                    }
                    //adding the row
                    cls_accDoc.addRow(row_account["moeen_id"].ToString(), "", 0, n_accountPrice, 0, 0, 0);
                }

                //ساختن سطر اسناد دریافتی - چک های طرف حساب ها                      
                cls_accDoc.addRow("1040001", "", 0, n_sumOfNotMineCheques, 0, 0, 0);//این کد متعلق به سرفصل معین اسناد دریافتنی یا چک های طرف های حساب است

                //ساختن سطرهای حسابهای دریافتنی 
                foreach (DataRow row_person in ds_viewIndebtedCreditor.viw_indebtedCreditor.Rows)
                {
                    if (row_person["person_beforeType"].ToString() == "1")
                    {
                        //adding the row
                        cls_accDoc.addRow(row_person["moeen_id"].ToString(), "", 0, (long)row_person["person_remainMoney"], 0, 0, 0);
                    }
                }

                //ساختن سطر موجودی اول دوره انبار                    
                cls_accDoc.addRow("1060001", "", 0, n_entireObjectCost, 0, 0, 0);//این کد متعلق به "موجودی اول دوره انبار                    

                //ساختن سطر تراز افتتاحیه                    
                cls_accDoc.addRow("0050001", "", 0, 0,
                    n_entireObjectCost + n_sumOfAccuontPrices + n_sumOfCashPrices + n_sumOfIndebtedPrices
                    + n_sumOfNotMineCheques, 0, 0);//این کد متعلق به سرفصل معین تراز افتتاحیه می باشد                    

                cls_accDoc.saveTheAccDoc();
            }

            //ویرایش سند با شماره 2
            //cls_accDoc _accDoc2 = new cls_accDoc();
            if (!cls_accDoc.isThisAccDocExist(2))//if accDoc 2 is exist then locate it
            {
                cls_accDoc.createAccDoc(false);
            }
            
            cls_accDoc.accDoc_price = 0;
            if (cls_accDoc.isItPrimaryCycle)
            {
                cls_accDoc.accDoc_comment = "سند افتتاحیه";
                cls_accDoc.accDoc_date = cls_numberConvertor.nowDateInAppropriateFormat();
            }
            else
            {
                cls_accDoc.accDoc_comment = "سند افتتاحیه اصلاح شده";
            }
            cls_accDoc.accDoc_isItPermenantly = true;//
            cls_accDoc.updateAnAccDoc(2);
            {
                cls_accDoc.clearAccDocRows();

                //ساختن سطر اسناد پرداختی - چک های خودمان                      
                cls_accDoc.addRow("4020001", "", 0, 0, n_sumOfMineCheques, 0, 0);//این کد متعلق به سرفصل معین اسناد دریافتنی یا چک های طرف های حساب است

                //ساختن سطرهای حسابهای پرداختنی 
                foreach (DataRow row_person in ds_viewIndebtedCreditor.viw_indebtedCreditor.Rows)
                {
                    if (row_person["person_beforeType"].ToString() == "2")
                    {
                        long n_personRemainMoney = 0;
                        try
                        {
                            n_personRemainMoney = (long)row_person["person_remainMoney"];
                        }
                        catch
                        {
                        }
                        //adding the row
                        cls_accDoc.addRow(row_person["moeen_id"].ToString(), "", 0, 0, n_personRemainMoney, 0, 0);
                    }
                }

                //ساختن سطر تراز افتتاحیه                    
                cls_accDoc.addRow("0050001", "", 0,
                    n_entireObjectCost + n_sumOfAccuontPrices + n_sumOfCashPrices + n_sumOfIndebtedPrices
                    + n_sumOfNotMineCheques, 0, 0, 0);//این کد متعلق به سرفصل معین تراز افتتاحیه می باشد                    

                //ساختن سطر سرمایه اول دوره
                cls_accDoc.addRow("5060001", "", 0, 0, (n_entireObjectCost + n_sumOfAccuontPrices + n_sumOfCashPrices + n_sumOfIndebtedPrices + n_sumOfNotMineCheques) - (n_sumOfMineCheques + n_sumOfCreditorPrices), 0, 0);//این کد متعلق به سرفصل معین سرمایه اول دوره

                cls_accDoc.saveTheAccDoc();
            }
            if (!cls_accDoc.isItPrimaryCycle)
            {
                cls_msgBox.show("سند افتتاحیه اصلاح شد");
            }
        }

        private void upDateMineChequesPositionLabel()
        {
           lbl_currentMineChequePosition.Text = "چک " + (bs_Cheques.Position + 1).ToString() + " از " + bs_Cheques.Count.ToString();
        }

        private void bs_mineCheques_CurrentChanged(object sender, EventArgs e)
        {
            upDateMineChequesPositionLabel();

            if ((bool)ds_viewCheques.viw_cheques.Rows[bs_Cheques.Position]["chq_isItMine"])
            {
                lbl_chequeKind.Text = "پرداختی";
                lbl_owner.Text = "در وجه :";
            }
            else
            {
                lbl_chequeKind.Text = "دریافتی";
                lbl_owner.Text = "صاحب چک :";
            }
        }

        private void btn_nextCheque_Click(object sender, EventArgs e)
        {
            bs_Cheques.MoveNext();
        }

        private void btn_priorCheque_Click(object sender, EventArgs e)
        {
            bs_Cheques.MovePrevious();
        }

        public void frm_primaryCycleEnd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_viewAccounts.viw_accounts' table. You can move, or remove it, as needed.
            this.viw_accountsTableAdapter.FillBy(this.ds_viewAccounts.viw_accounts);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);
            // TODO: This line of code loads data into the 'ds_viewIndebtedCreditor.viw_indebtedCreditor' table. You can move, or remove it, as needed.
            this.viw_indebtedCreditorTableAdapter.Fill(this.ds_viewIndebtedCreditor.viw_indebtedCreditor);            
            // TODO: This line of code loads data into the 'ds_viewCheques.viw_cheques' table. You can move, or remove it, as needed.
            this.viw_chequesTableAdapter.Fill(this.ds_viewCheques.viw_cheques);

            bs_viwIndebtedCreditor.Filter = "person_beforeType > 0";//only show the indebted and creditors

            bs_viewAccounts.Sort = "account_id";

            cbx_whichCheq.SelectedIndex = 0;

            try
            {
                //get the sum of cheques
                n_sumOfMineCheques = (long)viw_chequesTableAdapter.getMineChequesTotalPrice();
            }
            catch
            {
            }
            try
            {
                n_sumOfNotMineCheques = (long)viw_chequesTableAdapter.getNotMineChequesTotalPrice();
            }
            catch
            {
            }
            try
            {
                tbx_sumOfMineCheques.Text = cls_numberConvertor.splitNumber(n_sumOfMineCheques.ToString(), false);
            }
            catch
            {
            }
            try
            {
                tbx_sumOfNotMineCheques.Text = cls_numberConvertor.splitNumber(n_sumOfNotMineCheques.ToString(), false);
            }
            catch
            {
            }

            //get the sum of indebted and creditors money
            try
            {
                n_sumOfIndebtedPrices = (long)viw_indebtedCreditorTableAdapter.getSumOfIndebteds();
            }
            catch
            {
            }
            try
            {
                n_sumOfCreditorPrices = (long)viw_indebtedCreditorTableAdapter.getSumOfCreditos();
            }
            catch
            {
            }
            try
            {
                tbx_sumOfIndebteds.Text = cls_numberConvertor.splitNumber(n_sumOfIndebtedPrices.ToString(), false);
            }
            catch
            {
            }
            try
            {
                tbx_sumOfCreditors.Text = cls_numberConvertor.splitNumber(n_sumOfCreditorPrices.ToString(), false);
            }
            catch
            {
            }
            try
            {
                //
                n_entireObjectCost = (long)tbl_objectsTableAdapter.getTheEntireWorthOfObjects();
            }
            catch
            {
            }
            tbx_entireObjectsCost.Text = cls_numberConvertor.splitNumber(n_entireObjectCost.ToString(), false);
            try
            {
                n_sumOfAccuontPrices = (long)viw_accountsTableAdapter.getSumOfAccounts();
            }
            catch
            {
            }
            try
            {
                n_sumOfCashPrices = (long)viw_accountsTableAdapter.getSumOfCach();
            }
            catch
            {
            }
            tbx_sumOfAccounts.Text = cls_numberConvertor.splitNumber(n_sumOfAccuontPrices.ToString(), false);
            tbx_sumOfCashes.Text = cls_numberConvertor.splitNumber(n_sumOfCashPrices.ToString(), false);
            tbx_sumOfAcountAndCashes.Text = cls_numberConvertor.splitNumber((n_sumOfAccuontPrices + n_sumOfCashPrices).ToString(), false);

            mTbx_accDocDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
        }

        private void tbx_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string s_money = tbx_price.Text.Replace(",", "");
                lbl_chequePriceInChars.Text = cls_numberConvertor.convertToChars(s_money) + " ریال ";
            }
            catch
            {
            }
        }

        private void cbx_whichCheq_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filtering by cheque type
            if (cbx_whichCheq.SelectedIndex == 0)
            {
                bs_Cheques.Filter = "";
            }
            else if (cbx_whichCheq.SelectedIndex == 1)
            {
                bs_Cheques.Filter = "chq_isItMine = true";
            }
            else if (cbx_whichCheq.SelectedIndex == 2)
            {
                bs_Cheques.Filter = "chq_isItMine = false";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string s_prompt = "کاربر گرامی قبل از انجام این عملیات ابتدا از اطلاعات خود کپی پشتیبان تهیه نمایید آیا عملیات را تائید می کنید؟ ";
            if (cls_msgBox.show(s_prompt, "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {
                issuseFirstAndSecondAccdoc();
                
                cls_msgBox.show("سندهای افتتاحیه با شماره های 1 و 2 صادر شدند");

                cls_msgBox.show("لطفا بعد از بسته شدن برنامه برنامه را دوباره اجرا کنید");

                Application.Exit();

            }
        }
    }
}
