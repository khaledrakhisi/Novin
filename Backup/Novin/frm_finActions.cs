using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_finActions : Novin.frm_FATHER
    {
        public frm_finActions()
        {
            InitializeComponent();
        }
        private bool b_theInvoiceHasBeenSaved = true;
        public bool openForModify = false;

        public int n_finAct_id_forModify = 0;

        private enum actionType {bankToBank, cashToBank, PersonTransfer, receiveFromPerson, sendToPerson, invisitory, cost, salary, export, bankToCash, bankPrice, sendTransform };
        private actionType _actionType;

        private long n_originalTotalMoney = 0;
        private long n_totalMoney = 0;
        private long n_cashMoney = 0;
        private long n_chequesMoney = 0;
        private long n_usedChequesMoney = 0;
        private long n_discountMoney = 0;
        private long n_indebtedMoney = 0;
        private long n_remainMoney = 0;
        private long n_transportPrice = 0;
        private string s_comment = "";

        private void handleThePerson()
        {
            //محاسبه مانده فعلی و ذخیره در فیلد مربوطه
            string s_person_moeen_id = "";
            s_person_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
            cls_visitors.setPersonNowRemainMoney(s_person_moeen_id);
        }

        private void interpretByActionType()
        {            
            _actionType = (actionType)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["finAct_type"];
            cbx_typeFinAction.SelectedIndex =(int) _actionType;

            if (_actionType == actionType.bankToBank)
            {
                int n_from_account_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountFrom_id"];
                int n_to_account_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountTo_id"];

                bs_viwAccounts_from.Position = bs_viwAccounts_from.Find("account_id", n_from_account_id);
                bs_viwAccounts_to.Position = bs_viwAccounts_to.Find("account_id", n_to_account_id);
            }
            else if (_actionType == actionType.bankToCash)
            {
                int n_from_account_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountFrom_id"];

                bs_viwAccounts_from.Position = bs_viwAccounts_from.Find("account_id", n_from_account_id);                
            }
            else if (_actionType == actionType.cashToBank)
            {
                int n_to_account_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountTo_id"];
             
                bs_viwAccounts_to.Position = bs_viwAccounts_to.Find("account_id", n_to_account_id);
            }
            else if (_actionType == actionType.cost)
            {
                string s_moeen_id = (string)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["moeen_id"];

                bs_MOEENS.Position = bs_MOEENS.Find("moeen_id", s_moeen_id);
            }
            else if (_actionType == actionType.export)
            {

            }
            else if (_actionType == actionType.invisitory)
            {
            }
            else if (_actionType == actionType.PersonTransfer)
            {
            }
            else if (_actionType == actionType.receiveFromPerson)
            {
                int n_person_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["person_id"];
                bs_persons.Position = bs_persons.Find("person_id", n_person_id);
            }
            else if (_actionType == actionType.salary)
            {
            }
            else if (_actionType == actionType.sendToPerson)
            {
                int n_person_id = (int)ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["person_id"];
                bs_persons.Position = bs_persons.Find("person_id", n_person_id);
            }
            else if (_actionType == actionType.sendTransform)
            {
            }
            else if (_actionType == actionType.bankPrice)
            {
            }
        }

        private void reCalculateThePureMoney()
        {
            try
            {
                n_totalMoney = n_originalTotalMoney + n_transportPrice;

                n_remainMoney = n_totalMoney - (n_cashMoney + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney);

                tbx_uesedChequesMoney.Text = n_usedChequesMoney.ToString();
                tbx_totalPaidMoney.Text = (n_cashMoney + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney).ToString();
                tbx_remainMoney.Text = n_remainMoney.ToString();
                //tbx_totalMoney.Text = n_totalMoney.ToString();

                if (n_remainMoney > 0 || n_remainMoney < 0)
                {
                    btn_ok.Enabled = false;
                }
                else
                {
                    btn_ok.Enabled = true;
                }
            }
            catch
            {
            }
        }

        private void updateTheDatabase()
        {
            this.Validate();
            bs_finActs.EndEdit();
            tbl_finActsTableAdapter.Update(ds_finActs.tbl_finActs);
        }  

        private void createNewFinAct()
        {
            //ساختن سند به صورت موقت در حافظه
            cls_accDoc.createAccDoc(false);

            try
            {
                DataRow row_accDoc;
                row_accDoc = ds_finActs.tbl_accDocs.NewRow();
                if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
                {
                    row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                    row_accDoc["accDoc_price"] = 0;
                    row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                    row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                    row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
                }
                ds_finActs.tbl_accDocs.Rows.Add(row_accDoc);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }

            try
            {
                DataRow row_newFinAct;
                row_newFinAct = ds_finActs.tbl_finActs.NewRow();
                row_newFinAct["finAct_id"] = cls_accDoc.accDoc_id; //                
                row_newFinAct["accDoc_id"] = cls_accDoc.accDoc_id;//
                row_newFinAct["finAct_type"] = _actionType;//
                row_newFinAct["finAct_money"] = 0;//
                row_newFinAct["finAct_cashMoney"] = 0;//
                row_newFinAct["finAct_chequesMoney"] = 0;//
                row_newFinAct["finAct_useChequesMoney"] = 0;//
                row_newFinAct["finAct_indebtedMoney"] = 0;//
                ds_finActs.tbl_finActs.Rows.Add(row_newFinAct);

                bs_finActs.MoveLast();

                b_theInvoiceHasBeenSaved = false;
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void frm_finActions_Load(object sender, EventArgs e)
        {
            try
            {                
                // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);
                // TODO: This line of code loads data into the 'ds_viewAccounts.viw_accounts' table. You can move, or remove it, as needed.
                this.viw_accountsTableAdapter.Fill(this.ds_viewAccounts.viw_accounts);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }


            try
            {
                if (!openForModify)
                {
                    // TODO: This line of code loads data into the 'ds_finActs.tbl_finActs' table. You can move, or remove it, as needed.
                    this.tbl_finActsTableAdapter.Fill(this.ds_finActs.tbl_finActs, -1);

                    cbx_typeFinAction.SelectedIndex = 0;

                    createNewFinAct();

                    btn_delete.Enabled = false;
                }
                else
                {
                    // TODO: This line of code loads data into the 'ds_finActs.tbl_finActs' table. You can move, or remove it, as needed.
                    this.tbl_finActsTableAdapter.Fill(this.ds_finActs.tbl_finActs, n_finAct_id_forModify);

                    if (cls_accDoc.isThisAccDocExist(n_finAct_id_forModify))//this line make the just added accDoc active
                    {
                    }

                    interpretByActionType();

                    b_theInvoiceHasBeenSaved = true;
                }

                mTbx_accDocDate.Text = cls_accDoc.accDoc_date;
                tbx_comment.Text = cls_accDoc.accDoc_comment;
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void cbx_typeFinAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_typeFinAction.SelectedIndex == 0)//بانک به بانک
            {
                lbl_from.Text = "از بانک";
                lbl_to.Text = "به بانک";
                lbl_actionPrompt.Text = "مبلغ واریزی :";

                cbx_from.DataSource = bs_viwAccounts_from;
                cbx_from.DisplayMember = "accountTitle";
                cbx_from.ValueMember = "account_id";

                cbx_to.DataSource = bs_viwAccounts_to;
                cbx_to.DisplayMember = "accountTitle";
                cbx_to.ValueMember = "account_id";

                pnl_fromSet.Visible = true;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 1)//صندوق به بانک
            {
                lbl_from.Text = "صندوق";
                lbl_to.Text = "به بانک";
                lbl_actionPrompt.Text = "مبلغ واریزی :";

                cbx_to.DataSource = bs_viwAccounts_to;
                cbx_to.DisplayMember = "accountTitle";
                cbx_to.ValueMember = "account_id";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = false;
                btn_useCheque.Enabled = false;
            }
            else if (cbx_typeFinAction.SelectedIndex == 2)//حواله طرف حساب
            {
                lbl_from.Text = "طرف حساب";
                lbl_to.Text = "به بانک";
                lbl_actionPrompt.Text = "مبلغ واریزی :";

                cbx_from.DataSource = bs_persons;
                cbx_from.DisplayMember = "person_familyAndName";
                cbx_from.ValueMember = "person_id";

                cbx_to.DataSource = bs_viwAccounts_to;
                cbx_to.DisplayMember = "accountTitle";
                cbx_to.ValueMember = "account_id";

                pnl_fromSet.Visible = true;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = false;
                btn_useCheque.Enabled = false;
            }
            else if (cbx_typeFinAction.SelectedIndex == 3)//دریافت از طرف حساب
            {
                lbl_from.Text = "طرف حساب";
                lbl_to.Text = "به صندوق";
                lbl_actionPrompt.Text = "مبلغ دریافتی :";

                cbx_from.DataSource = bs_persons;
                cbx_from.DisplayMember = "person_familyAndName";
                cbx_from.ValueMember = "person_id";

                cbx_to.DataSource = bs_viwAccounts_to;
                cbx_to.DisplayMember = "accountTitle";
                cbx_to.ValueMember = "account_id";

                pnl_fromSet.Visible = true;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;

                tbx_discountMoney.ReadOnly = false;
            }
            else if (cbx_typeFinAction.SelectedIndex == 4)//پرداخت به طرف حساب
            {
                lbl_from.Text = "صندوق";
                lbl_to.Text = "به طرف حساب";
                lbl_actionPrompt.Text = "مبلغ پرداختی :";

                cbx_from.DataSource = bs_persons;
                cbx_from.DisplayMember = "person_familyAndName";
                cbx_from.ValueMember = "person_id";

                cbx_to.DataSource = bs_persons;
                cbx_to.DisplayMember = "person_familyAndName";
                cbx_to.ValueMember = "person_id";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 5)//سرمایه گذاری
            {
                lbl_from.Text = "بانک";
                lbl_to.Text = "به جاری شرکا";
                lbl_actionPrompt.Text = "مبلغ پرداختی :";

                cbx_from.DataSource = bs_viwAccounts_from;
                cbx_from.DisplayMember = "accountTitle";
                cbx_from.ValueMember = "account_id";

                cbx_to.DataSource = bs_MOEENS;
                cbx_to.DisplayMember = "MOEEN_title";
                cbx_to.ValueMember = "moeen_id";

                pnl_fromSet.Visible = true;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 6)//هزینــه
            {
                // TODO: This line of code loads data into the 'ds_accounting.tbl_MOEENs' table. You can move, or remove it, as needed.
                this.tbl_MOEENsTableAdapter.FillByFilter(this.ds_finActs.tbl_MOEENs, "601");

                lbl_from.Text = "صندوق";
                lbl_to.Text = "به هزینــه";
                lbl_actionPrompt.Text = "مبلغ هزینه :";

                cbx_from.DataSource = bs_viwAccounts_from;
                cbx_from.DisplayMember = "accountTitle";
                cbx_from.ValueMember = "account_id";

                cbx_to.DataSource = bs_MOEENS;
                cbx_to.DisplayMember = "MOEEN_title";
                cbx_to.ValueMember = "moeen_id";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = true;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 7)//درآمـــد
            {
                // TODO: This line of code loads data into the 'ds_accounting.tbl_MOEENs' table. You can move, or remove it, as needed.
                this.tbl_MOEENsTableAdapter.FillByFilter(this.ds_finActs.tbl_MOEENs, "702");

                lbl_actionPrompt.Text = "مبلغ درآمـــد :";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 8)//برداشت
            {
                lbl_actionPrompt.Text = "مبلغ برداشتی :";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 9)//بانک به صندوق
            {
                lbl_from.Text = "بانک";
                lbl_to.Text = "به صندوق";
                lbl_actionPrompt.Text = "مبلغ واریزی :";

                cbx_from.DataSource = bs_viwAccounts_from;
                cbx_from.DisplayMember = "accountTitle";
                cbx_from.ValueMember = "account_id";

                pnl_fromSet.Visible = true;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = true;
                btn_useCheque.Enabled = true;
            }
            else if (cbx_typeFinAction.SelectedIndex == 10)//کارمزد بانک
            {
                lbl_actionPrompt.Text = "مبلغ هزینه :";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = false;
                btn_useCheque.Enabled = false;
            }
            else if (cbx_typeFinAction.SelectedIndex == 11)//ارسال حواله
            {
                lbl_actionPrompt.Text = "مبلغ واریزی :";

                pnl_fromSet.Visible = false;
                pnl_toSet.Visible = false;

                btn_newCheque.Enabled = false;
                btn_useCheque.Enabled = false;
            }
            _actionType =(actionType) cbx_typeFinAction.SelectedIndex;
        }

        private void tbx_money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_priceInChars.Text = cls_numberConvertor.convertToChars(tbx_totalMoney.Text) + " ريال ";
                if (Convert.ToInt64(tbx_totalMoney.Text) > 0)
                {
                    grp_paySet.Enabled = true;
                }
                else
                {
                    grp_paySet.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int n_accountFrom_id = 0;
            int n_accountTo_id = 0;
            string s_costMoeen_id = "";
            int n_person_id = 0;

            cls_accDoc.accDoc_date = mTbx_accDocDate.Text;
            cls_accDoc.accDoc_comment = tbx_comment.Text;
            cls_accDoc.saveTheAccDoc();

            if (openForModify)
            {
                cls_accDoc.clearAccDocRows();
            }

            try
            {
                if (_actionType == actionType.bankToBank)
                {
                    n_accountFrom_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["account_id"];
                    n_accountTo_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["account_id"];

                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountFrom_id"] = n_accountFrom_id;
                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountTo_id"] = n_accountTo_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //واریزی به بانک
                        s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["moeen_id"];
                        n_money = n_cashMoney;
                        s_comment = "واریزی به " + cbx_to.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        //واریزی از بانک
                        s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["moeen_id"];
                        n_money = n_cashMoney;
                        s_comment = "واریزی از " + cbx_to.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                        if (n_chequesMoney > 0)
                        {
                            //واریزی به بانک
                            s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["moeen_id"];
                            n_money = n_chequesMoney;
                            s_comment = "واریزی به " + cbx_to.Text + " " + "پرداخت چک";
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                            //واریزی از بانک
                            s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["moeen_id"];
                            n_money = n_chequesMoney;
                            s_comment = "واریزی از " + cbx_to.Text + " " + "پرداخت چک";
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                        }
                    }
                }
                else if (_actionType == actionType.bankToCash)
                {
                    n_accountFrom_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["account_id"];
                    //n_accountTo_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["account_id"];

                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountFrom_id"] = n_accountFrom_id;
                    //ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountTo_id"] = n_accountTo_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //دریافت از بانک
                        s_moeen_id = "1010001";//صندوق
                        n_money = n_cashMoney;
                        s_comment = "دریافت از " + cbx_from.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        //پرداخت به صندوق
                        s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["moeen_id"];
                        n_money = n_cashMoney;
                        s_comment = "پرداخت به صندوق";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);

                        if (n_chequesMoney > 0)
                        {
                            //دریافت از بانک
                            s_moeen_id = "1010001";//صندوق
                            n_money = n_chequesMoney;
                            s_comment = "دریافت از " + cbx_from.Text + " " + "پرداخت چک";
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                            //پرداخت به صندوق
                            s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["moeen_id"];
                            n_money = n_chequesMoney;
                            s_comment = "پرداخت چک به صندوق";
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                        }
                    }
                }
                else if (_actionType == actionType.cashToBank)
                {
                    //n_accountFrom_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_from.Position]["account_id"];
                    n_accountTo_id = (int)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["account_id"];

                    //ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountFrom_id"] = n_accountFrom_id;
                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["accountTo_id"] = n_accountTo_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //واریزی از صندوق
                        s_moeen_id = (string)ds_viewAccounts.viw_accounts.Rows[bs_viwAccounts_to.Position]["moeen_id"];
                        n_money = n_cashMoney;
                        s_comment = "واریزی از صندوق";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        //واریزی از بانک
                        s_moeen_id = "1010001";//صندوق
                        n_money = n_cashMoney;
                        s_comment = "واریزی به " + cbx_to.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                    }
                }
                else if (_actionType == actionType.cost)
                {
                    s_costMoeen_id = (string)ds_finActs.tbl_MOEENs.Rows[bs_MOEENS.Position]["moeen_id"];

                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["moeen_id"] = s_costMoeen_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //پرداخت بصورت نقد
                        s_moeen_id = (string)ds_finActs.tbl_MOEENs.Rows[bs_MOEENS.Position]["moeen_id"];
                        n_money = n_cashMoney;
                        s_comment = "پرداخت بصورت نقد";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        //واریزی از بانک
                        s_moeen_id = "1010001";//صندوق
                        n_money = n_cashMoney;
                        s_comment = "پرداخت حقوق پرسنل";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);

                        if (n_chequesMoney > 0)
                        {
                            //اسناد پرداختی
                            s_moeen_id = "4020001";//اسناد پرداختی
                            n_money = n_chequesMoney;
                            s_comment = "پرداخت چک جهت " + cbx_to.Text;
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                        }
                    }
                }
                else if (_actionType == actionType.export)
                {

                }
                else if (_actionType == actionType.invisitory)
                {
                }
                else if (_actionType == actionType.PersonTransfer)
                {
                }
                else if (_actionType == actionType.receiveFromPerson)
                {
                    n_person_id = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];

                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["person_id"] = n_person_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //دریافت از طرف حساب
                        s_moeen_id = "1010001";//صندوق
                        n_money = n_cashMoney;
                        s_comment = "دریافت از " + cbx_from.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        if (n_chequesMoney > 0)
                        {
                            //واریزی از بانک
                            s_moeen_id = "1040001";//اسناد دریافتی
                            n_money = n_chequesMoney;
                            s_comment = "واریزی از " + cbx_to.Text + " " + "پرداخت چک";
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);
                        }

                        //دریافت بصورت نقد
                        s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                        n_money = n_cashMoney + n_chequesMoney;
                        s_comment = "دریافت بصورت نقد ";
                        if (n_chequesMoney > 0) s_comment += " چک ";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                    }
                }
                else if (_actionType == actionType.salary)
                {
                }
                else if (_actionType == actionType.sendToPerson)
                {
                    n_person_id = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];

                    ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["person_id"] = n_person_id;

                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        //دریافت بصورت نقد
                        s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                        n_money = n_cashMoney + n_chequesMoney;
                        s_comment = "پرداخت بصورت نقد ";
                        if (n_chequesMoney > 0) s_comment += " چک ";
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        //دریافت از طرف حساب
                        s_moeen_id = "1010001";//صندوق
                        n_money = n_cashMoney;
                        s_comment = "پرداخت به " + cbx_to.Text;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);

                        if (n_chequesMoney > 0)
                        {
                            //واریزی از بانک
                            s_moeen_id = "1040001";//اسناد دریافتی
                            n_money = n_chequesMoney;
                            s_comment = "پرداخت چک به " + cbx_to.Text;
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                        }
                    }
                }
                else if (_actionType == actionType.sendTransform)
                {
                }
                else if (_actionType == actionType.bankPrice)
                {
                }

                ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["finAct_type"] = _actionType;

                updateTheDatabase();

                b_theInvoiceHasBeenSaved = true;

                //ثبت سند حسابداری
                cls_accDoc.saveTheAccDoc();

                handleThePerson();

                //نمایش تائید
                cls_msgBox.show("سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید ");

                frm_finActions_Load(null, null);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void tbx_cashMoney_TextChanged(object sender, EventArgs e)
        {
            if (tbx_cashMoney.Text.Trim() == "")
            {
                tbx_cashMoney.Text = "0";
            }
            n_cashMoney = Convert.ToInt64(tbx_cashMoney.Text);
            reCalculateThePureMoney();
        }

        private void tbx_chequesMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_chequesMoney.Text.Trim() == "")
                {
                    tbx_chequesMoney.Text = "0";
                }
                n_chequesMoney = Convert.ToInt64(tbx_chequesMoney.Text);
                reCalculateThePureMoney();
            }
            catch
            {
            }
        }

        private void tbx_uesedChequesMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_uesedChequesMoney.Text.Trim() == "")
                {
                    tbx_uesedChequesMoney.Text = "0";
                }
                reCalculateThePureMoney();
            }
            catch
            { }
        }

        private void tbx_discountMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_discountMoney.Text.Trim() == "")
                {
                    tbx_discountMoney.Text = "0";
                }
                n_discountMoney = Convert.ToInt64(tbx_discountMoney.Text);
                reCalculateThePureMoney();
            }
            catch
            {
            }
        }

        private void tbx_indebtedMoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_indebtedMoney.Text.Trim() == "")
                {
                    tbx_indebtedMoney.Text = "0";
                }
                n_indebtedMoney = Convert.ToInt64(tbx_indebtedMoney.Text);
                reCalculateThePureMoney();
            }
            catch { }
        }

        private void tbx_cashMoney_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbx_cashMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_cashMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_discountMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_discountMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_indebtedMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_indebtedMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_totalMoney_Leave(object sender, EventArgs e)
        {
            try
            {
                n_originalTotalMoney = Convert.ToInt32(tbx_totalMoney.Text);
            }
            catch 
            {
            }
        }

        private void btn_newCheque_Click(object sender, EventArgs e)
        {
            try
            {
                int n_person_id = 0;
                frm_cheques _cheques = new frm_cheques();
                if (_actionType == actionType.bankToBank || _actionType == actionType.sendToPerson || _actionType == actionType.cost || _actionType == actionType.export || _actionType == actionType.bankToCash)
                {
                    _cheques.theChequeIsMine = true;
                    n_person_id = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                }
                else if (_actionType == actionType.receiveFromPerson || _actionType == actionType.invisitory || _actionType == actionType.salary)
                {
                    _cheques.theChequeIsMine = false;
                    n_person_id = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                }

                cls_accDoc.saveTheAccDoc();

                _cheques.isItPrimaryCycleCheques = false;
                _cheques.person_id = n_person_id;
                _cheques.accDoc_id = cls_accDoc.accDoc_id;
                //_cheques._accDoc = _accDoc;
                if (_cheques.ShowDialog() == DialogResult.OK)
                {
                    //ابتدا سند حسابداری ثبت میشود 
                    cls_accDoc.saveTheAccDoc();
                    //سپس چکهای تعریف شده
                    _cheques.updateTheDatabase();
                    tbx_chequesMoney.Text = _cheques.totalPrice.ToString();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void frm_finActions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!b_theInvoiceHasBeenSaved && !openForModify)
            {
                if (cls_msgBox.show("آیا از خروج مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    //اگر کاربر عملیات صدور فاکتور را لغو کند سند موقت ایجاد شده در دیتاست حذف میشود
                    //چون در فرم صدور سند حسابداری کاربر ممکن است چک هم تعریف کند و از آنجایی که
                    //هنگام تعریف چک سند باید در بانک اطلاعاتی فیزیکی ثبت شود ممکن است که کاربر بعد ازتعریف
                    //چک و تنظیم تمامی مقادیر نخواهد فاکتور را صادر کند پس باید سند ذخیره شده در بانک اطلاعاتی فیزیکی حذف شود
                    cls_accDoc.removeAnAccDoc();
                    //بعد از حذف سند ،فاکتور و اقلام و تمامی چکهای تعریف شده خود به خود حذف خواهند شد
                }
            }
            else
            {
                //اگر کاربر عملیات صدور فاکتور را لغو کند سند موقت ایجاد شده در دیتاست حذف میشود
                //چون در فرم صدور سند حسابداری کاربر ممکن است چک هم تعریف کند و از آنجایی که
                //هنگام تعریف چک سند باید در بانک اطلاعاتی فیزیکی ثبت شود ممکن است که کاربر بعد ازتعریف
                //چک و تنظیم تمامی مقادیر نخواهد فاکتور را صادر کند پس باید سند ذخیره شده در بانک اطلاعاتی فیزیکی حذف شود
                if (!openForModify)
                {
                    cls_accDoc.discardTheAccDoc();
                    //بعد از حذف سند ،فاکتور و اقلام و تمامی چکهای تعریف شده خود به خود حذف خواهند شد
                }
            }
        }

        private void tbx_totalMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            long isNumber = 0;
            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_cashMoney_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            long isNumber = 0;
            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_discountMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            long isNumber = 0;
            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_indebtedMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;

            long isNumber = 0;
            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //حذف فاکتور
            if (ds_finActs.tbl_finActs.Rows[bs_finActs.Position]["finAct_deleted"] == DBNull.Value)
            {
                if (cls_msgBox.show("آیا از انداختن سند به سطل بازیافت مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    if (cls_accDoc.moveAnFinActToTrash(cls_accDoc.accDoc_id))
                    {

                        if (cls_accDoc.moveThisAccDocToTrash())
                        {
                            if (cls_cheques.moveChequesToTrash(cls_accDoc.accDoc_id))
                            {
                                handleThePerson();

                                cls_msgBox.show("تمامی اسناد به سطل بازیافت انتقال یافتند");
                                Close();
                            }
                        }
                    }
                }
            }
            //بازیابی فاکتور
            else
            {
                if (cls_msgBox.show("آیا از بازیافت این سند مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {

                    if (cls_accDoc.recycleAnFinAct(cls_accDoc.accDoc_id))
                    {
                        if (cls_accDoc.recycleThisAccDoc())
                        {
                            if (cls_cheques.recycleCheques(cls_accDoc.accDoc_id))
                            {
                                handleThePerson();

                                cls_msgBox.show("تمامی اسناد بازیافت شدند");
                                Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
