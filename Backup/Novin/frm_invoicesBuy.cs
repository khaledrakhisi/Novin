using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_invoicesBuy : Novin.frm_FATHER
    {
        public frm_invoicesBuy()
        {
            InitializeComponent();
        }
        public bool openForReturnSellInvoice = false;
        public bool openForModify = false;
        public int n_invoiceIDForModify;

        private bool b_theInvoiceHasBeenSaved = true;
        private int n_invoiceID = 0;

        private void updateThePersonsTable()
        {
            this.Validate();
            bs_persons.EndEdit();
            tbl_personsTableAdapter.Update(ds_persons.tbl_persons);
        }

        private void updateTheDatabase()
        {
            this.Validate();
            bs_invoicesBuy.EndEdit();
            tbl_invoicesBuyTableAdapter.Update(ds_buyInvoices.tbl_invoicesBuy);
        }

        private void handleTheStoring()
        {
            cls_storing _storing = new cls_storing();
            //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی                    
            _storing = new cls_storing();
            if (openForReturnSellInvoice)
            {
                _storing.setTheEntity(cls_storing.invoiceType.unSellInvoice, n_invoiceID);
            }
            else
            {
                _storing.setTheEntity(cls_storing.invoiceType.buyInvoic, n_invoiceID);
            }
        }

        private void handleThePerson()
        {
            //محاسبه مانده فعلی طرف حساب
            string s_person_moeen_id = "";
            s_person_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
            cls_visitors.setPersonNowRemainMoney(s_person_moeen_id);
        }

        private void newInvoice()
        {
            try
            {
                //ساختن سند به صورت موقت در حافظه
                cls_accDoc.createAccDoc(false);

                DataRow row_accDoc;
                row_accDoc = ds_buyInvoices.tbl_accDocs.NewRow();
                if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
                {
                    row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                    row_accDoc["accDoc_price"] = 0;
                    row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                    row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                    row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
                }
                ds_buyInvoices.tbl_accDocs.Rows.Add(row_accDoc);

                int n_personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];

                DataRow row_newInvoiceBuy;
                row_newInvoiceBuy = ds_buyInvoices.tbl_invoicesBuy.NewRow();
                row_newInvoiceBuy["invoiceBuy_id"] = n_invoiceID; //                
                row_newInvoiceBuy["person_id"] = n_personID;//
                row_newInvoiceBuy["accDoc_id"] = cls_accDoc.accDoc_id;//
                row_newInvoiceBuy["invoiceBuy_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newInvoiceBuy["invoiceBuy_totalPrice"] = 0;//
                row_newInvoiceBuy["invoiceBuy_discountPrice"] = 0;//
                row_newInvoiceBuy["invoiceBuy_transportPrice"] = 0;//
                row_newInvoiceBuy["invoiceBuy_cashPrice"] = 0;//
                row_newInvoiceBuy["invoiceBuy_Kind"] = !openForReturnSellInvoice;//
                row_newInvoiceBuy["invoiceBuy_comment"] = "";//
                ds_buyInvoices.tbl_invoicesBuy.Rows.Add(row_newInvoiceBuy);

                bs_invoicesBuy.MoveLast();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }            
        }

        private void frm_invoicesBuy_Load(object sender, EventArgs e)
        {
            //// Declare and set the alternating rows style...   | رنگ سطر هاي زوج تغيير مي کند
            //DataGridViewCellStyle objAlternatingCellStyle = new
            //DataGridViewCellStyle();
            //objAlternatingCellStyle.BackColor = Color.AliceBlue;
            //dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle; 

            if (!openForModify)
            {
                // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_itemsBuy' table. You can move, or remove it, as needed.
                this.tbl_itemsBuyTableAdapter.FillBy(this.ds_buyInvoices.tbl_itemsBuy,-1, false);
                // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_invoicesBuy' table. You can move, or remove it, as needed.
                this.tbl_invoicesBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_invoicesBuy, -1, false);
                // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);
                // TODO: This line of code loads data into the 'ds_buyInvoices.viw_itemsBuy' table. You can move, or remove it, as needed.
                this.viw_itemsBuyTableAdapter1.Fill(this.ds_buyInvoices.viw_itemsBuy, -1, false);

                if (openForReturnSellInvoice)
                {
                    this.Text = "فـــاکتور برگشت از فروش";
                    grp_header.Text = "مشخصات خریدار :";
                }
                else
                {
                    this.Text = "فــــاکتور خریــــد";
                }

                //bs_persons.Filter = "person_id > 1";


                //generating the available buy invoice id
                cls_invoices _invoice = new cls_invoices();
                if (openForReturnSellInvoice)
                {
                    n_invoiceID = _invoice.getAvailableUnSellInvoiceID();
                }
                else
                {
                    n_invoiceID = _invoice.getAvailableBuyInvoiceID();
                }
                tbx_invoiceID.Text = n_invoiceID.ToString();

                //filtering the 'invoicesBuy' table by 'invoiceBuy_id'
                bs_viewItemsBuy.Filter = "invoiceBuy_id = " + n_invoiceID.ToString() + " AND invoiceBuy_kind = " + (!openForReturnSellInvoice).ToString();

                //
                newInvoice();
                //
                btn_print.Enabled = false;
                btn_delete.Enabled = false;
            }
            ///////////////////////////////////////////////////////////
            else if (openForModify)
            {
                // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_itemsBuy' table. You can move, or remove it, as needed.
                this.tbl_itemsBuyTableAdapter.FillBy(this.ds_buyInvoices.tbl_itemsBuy, n_invoiceIDForModify, !openForReturnSellInvoice);
                // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_invoicesBuy' table. You can move, or remove it, as needed.
                this.tbl_invoicesBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_invoicesBuy, n_invoiceIDForModify, !openForReturnSellInvoice);
                // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);
                // TODO: This line of code loads data into the 'ds_buyInvoices.viw_itemsBuy' table. You can move, or remove it, as needed.
                this.viw_itemsBuyTableAdapter1.Fill(this.ds_buyInvoices.viw_itemsBuy, n_invoiceIDForModify, !openForReturnSellInvoice);

                if (openForReturnSellInvoice)
                {
                    this.Text = "اصــــلاح فـــاکتور برگشت از فروش";
                    grp_header.Text = "مشخصات خریدار :";
                }
                else
                {
                    this.Text = "اصـــلاح فــــاکتور خریــــد";
                }

                //bs_persons.Filter = "person_id > 1";

                ////locate the INVOICE in the DATASET
                ////bs_invoicesBuy.Filter = "invoiceBuy_id = " + n_invoiceIDForModify.ToString() + " AND invoiceBuy_kind = " + (!openForReturnSellInvoice).ToString();
                //int n_pos = bs_invoicesBuy.Find("invoiceBuy_id", n_invoiceIDForModify);
                //if (n_pos != -1)
                //{
                //    bs_invoicesBuy.Position = n_pos;
                //}
                             
                //
                n_invoiceID = n_invoiceIDForModify;
                
                tbx_invoiceID.Text = n_invoiceID.ToString();

                ////filtering the 'invoicesBuy' table by 'invoiceBuy_id'
                //bs_viewItemsBuy.Filter = "invoiceBuy_id = " + n_invoiceID.ToString() + " AND invoiceBuy_kind = " + (!openForReturnSellInvoice).ToString();

                int n_accDoc_id = 0;
                n_accDoc_id =(int) ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["accDoc_id"];
                if (cls_accDoc.isThisAccDocExist(n_accDoc_id))//this line make the just added accDoc active
                {
                }

                if (ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_deleted"] != DBNull.Value)
                {
                    btn_delete.Text = "بـازیابی فاکتور";

                    btn_save.Enabled = false;

                    grp_header.Enabled = false;
                    grp_details.Enabled = false;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            frm_itemSelection _frm_itemSelection = new frm_itemSelection();
            _frm_itemSelection.invoiceID = n_invoiceID;
            _frm_itemSelection.isItForReturnInvoice = openForReturnSellInvoice;
            if (_frm_itemSelection.ShowDialog() == DialogResult.OK)
            {
                cls_accDoc.saveTheAccDoc();
                
                updateTheDatabase();

                _frm_itemSelection.Validate();
                _frm_itemSelection.bs_itemsBuy.EndEdit();
                _frm_itemSelection.tbl_itemsBuyTableAdapter.Update(_frm_itemSelection.ds_buyInvoices.tbl_itemsBuy);

                this.viw_itemsBuyTableAdapter1.Fill(this.ds_buyInvoices.viw_itemsBuy, n_invoiceID, !openForReturnSellInvoice);

                tbx_invoiceTotalPrice.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, !openForReturnSellInvoice).ToString();
                tbx_invoiceTotalCount.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalCount(n_invoiceID, !openForReturnSellInvoice).ToString();

                b_theInvoiceHasBeenSaved = false;

                this.AcceptButton = btn_save;
            }
            btn_addOrRemoveRows.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            tbx_invoiceTotalPrice.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, !openForReturnSellInvoice).ToString();
            tbx_invoiceTotalCount.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalCount(n_invoiceID, !openForReturnSellInvoice).ToString();
    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addOrRemoveRows.PerformClick();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                //{                
                //    string s_negativeEntityObjects = "";
                //    if (openForReturnSellInvoice)
                //    {
                //        s_negativeEntityObjects = _storing.checkTheEntity(cls_storing.invoiceType.unSellInvoice, n_invoiceID);
                //    }
                //    else
                //    {
                //        s_negativeEntityObjects = _storing.checkTheEntity(cls_storing.invoiceType.buyInvoic, n_invoiceID);
                //    }
                //    if (s_negativeEntityObjects != "")
                //    {
                //        string s_message = "";
                //        s_message = "کاربر گرامی با ثبت تغییرات این فاکتور موجودی کالاهای زیر منفی خواهد شد";
                //        s_message += "\n\n";
                //        string[] s_negativeEntityObject = s_negativeEntityObjects.Split(';');
                //        for (int i = 0; i <= s_negativeEntityObject.Length - 1; i++)
                //        {
                //            string s_objectTitle = "\n-- " + viw_itemsBuyTableAdapter1.getObjectTitle(Convert.ToInt32(s_negativeEntityObject[i])) + "\n";
                //            s_message += s_objectTitle;
                //            Application.DoEvents();
                //        }
                //        cls_msgBox.show(s_message, "", cls_msgBox.buttons.OKOnly);
                //        return;
                //    }
                //}

                if (bs_viewItemsBuy.Count == 0)
                {
                    if (cls_msgBox.show(" هیچ کالایی به فاکتور اضافه نشده است آیا مایلید کالاها را اضافه نمایید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                    {
                        btn_addOrRemoveRows.PerformClick();
                    }
                    return;
                }

                n_invoiceID = Convert.ToInt32(tbx_invoiceID.Text);
                ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_id"] = n_invoiceID;

                //قبل از فراخوانی این متد باید قبلا سند حسابداری ثبت شده باشد
                updateTheDatabase();

                DialogResult _dlgResult;
                frm_issuseAccDoc _issuseAccDoc = new frm_issuseAccDoc();
                _issuseAccDoc.personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                _issuseAccDoc.n_originalTotalMoney = (long)viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, !openForReturnSellInvoice);
                _issuseAccDoc.n_cashMoney = (long)ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_cashPrice"];
                _issuseAccDoc.n_discountMoney = (long)ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_discountPrice"];
                _issuseAccDoc.n_transportPrice = (long)ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_transportPrice"];
                _issuseAccDoc._invoiceType = frm_issuseAccDoc.invoiceType.buyInvoice;
                //اگر تیک صدور بصورت نسیه زده شده باشد
                if (chk_issuseInvoiceAsIndebted.Checked)
                {
                    _dlgResult = DialogResult.OK;

                    _issuseAccDoc.n_totalMoney = _issuseAccDoc.n_originalTotalMoney;
                    _issuseAccDoc.n_indebtedMoney = _issuseAccDoc.n_originalTotalMoney;
                    _issuseAccDoc.mTbx_accDocDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
                }
                else
                {                                                            
                    _dlgResult = _issuseAccDoc.ShowDialog();
                }
                if (_dlgResult == DialogResult.OK)
                {
                    ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_cashPrice"] = _issuseAccDoc.n_cashMoney;
                    ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_totalPrice"] = _issuseAccDoc.n_totalMoney;
                    ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_discountPrice"] = _issuseAccDoc.n_discountMoney;
                    ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_transportPrice"] = _issuseAccDoc.n_transportPrice;

                    updateTheDatabase();
                    //updateThePersonsTable();

                    if (openForModify)
                    {
                        cls_accDoc.clearAccDocRows();
                    }
                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        if (openForReturnSellInvoice)
                        {
                            s_moeen_id = "9020001";//برگشت فروش                         
                        }
                        else
                        {
                            s_moeen_id = "8010001";//خرید
                        }
                        s_comment = "فاکتور " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                        n_money = _issuseAccDoc.n_totalMoney;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                        if (openForReturnSellInvoice)
                        {
                            s_comment = " برگشت از فروش " + n_invoiceID.ToString();
                        }
                        else
                        {
                            s_comment = "فاکتور خرید " + n_invoiceID.ToString();
                        }
                        s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                        n_money = _issuseAccDoc.n_totalMoney;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);

                        //اگر کل فاکتور نسیه نباشد
                        if (_issuseAccDoc.n_cashMoney > 0 || _issuseAccDoc.n_chequesMoney > 0 || _issuseAccDoc.n_usedChequesMoney > 0)
                        {
                            if (_issuseAccDoc.n_discountMoney > 0)//درصورت وجود تخفیف
                            {
                                if (openForReturnSellInvoice)
                                {
                                    s_comment = "جمع پرداختها با تخفیف بابت برگشت از فروش " + n_invoiceID.ToString();
                                }
                                else
                                {
                                    s_comment = "جمع پرداختها با تخفیف بابت خرید " + n_invoiceID.ToString();
                                }

                                n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney + _issuseAccDoc.n_discountMoney);
                            }
                            else//اگر برای فاکتور تخفیفی در نظر گرفته نشد
                            {
                                if (openForReturnSellInvoice)
                                {
                                    s_comment = "جمع پرداختها بابت برگشت از فروش " + n_invoiceID.ToString();
                                }
                                else
                                {
                                    s_comment = "جمع پرداختها بابت خرید " + n_invoiceID.ToString();
                                }

                                n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney);
                            }
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);
                        }

                        //اگر پولی از صندوق خارج شده است
                        if (_issuseAccDoc.n_cashMoney > 0)
                        {
                            if (openForReturnSellInvoice)
                            {
                                s_comment = "برگشت از فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            }
                            else
                            {
                                s_comment = "خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            }
                            //صندوق
                            cls_accDoc.addRow("1010001", s_comment, 0, 0, _issuseAccDoc.n_cashMoney, 0, 0);
                        }

                        if (_issuseAccDoc.n_chequesMoney > 0)
                        {
                            if (openForReturnSellInvoice)
                            {
                                s_comment = "برگشت از فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text + " پرداخت چک ";
                            }
                            else
                            {
                                s_comment = "خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text + " پرداخت چک ";
                            }

                            //اسناد پرداختی
                            cls_accDoc.addRow("4020001", s_comment, 0, 0, _issuseAccDoc.n_chequesMoney, 0, 0);
                        }

                        if (_issuseAccDoc.n_discountMoney > 0)
                        {
                            if (openForReturnSellInvoice)
                            {
                                s_comment = "بابت برگشت از فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                                s_moeen_id = "9030001";//تخفیفات نقدی فروش
                            }
                            else
                            {
                                s_comment = "بابت خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                                s_moeen_id = "8030001";//تخفیفات نقدی خرید
                            }

                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, _issuseAccDoc.n_discountMoney, 0, 0);
                        }

                        cls_accDoc.accDoc_date = _issuseAccDoc.mTbx_accDocDate.Text;
                        //ثبت سند حسابداری
                        cls_accDoc.saveTheAccDoc();
                    }

                    
                    {
                        //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی   
                        handleTheStoring();

                        handleThePerson();

                        //
                        {
                            cls_invoices.UpdateObjectPrice(n_invoiceID);
                        }

                        string CRLF = "\r\n";
                        string s_message = "";
                        s_message = "فاکتور خرید با شماره " + n_invoiceID.ToString() + " به ثبت رسید " + CRLF;                        
                        s_message += "سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید " + CRLF;                        
                        s_message += "آیا مایل به صدور فاکتور بعدی هستید؟";
                        //نمایش تائید
                        DialogResult _dlgMsg = cls_msgBox.show(s_message, "", cls_msgBox.buttons.YesAndNo);                        

                        if (!openForModify && _dlgMsg == DialogResult.Yes)
                        {                            
                            //آماده ساختن فرم فاکتور فروش برای فاکتور بعدی
                            frm_invoicesBuy_Load(null, null);
                            b_theInvoiceHasBeenSaved = true;
                        }
                        else if(openForModify || _dlgMsg == DialogResult.No)
                        {
                            b_theInvoiceHasBeenSaved = true;
                            this.Close();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void frm_invoicesBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!b_theInvoiceHasBeenSaved)
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
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void cbx_persons_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_persons.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_persons.DataMember;
                frmFindRecords.listDisplayMember = "person_FamilyAndName";
                frmFindRecords.listValueMember = "person_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_persons.Find("person_id", frmFindRecords.foundRecordID);
                        bs_persons.Position = nPosition;
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
            }
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_save;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int n_accDoc_id = 0;

            //حذف فاکتور
            if (ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_deleted"] == DBNull.Value)
            {
                if (cls_msgBox.show("آیا از انداختن این فاکتور به سطل بازیافت مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    if (cls_invoices.moveAnInvoiceToTrash(cls_invoices.invoiceType.buyInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            if (cls_accDoc.moveThisAccDocToTrash())
                            {
                                if (cls_cheques.moveChequesToTrash(n_accDoc_id))
                                {
                                    handleTheStoring();

                                    handleThePerson();

                                    cls_msgBox.show("تمامی اسناد به سطل بازیافت انتقال یافتند");
                                    Close();
                                }
                            }
                        }                                                
                    }
                }
            }
            //بازیابی فاکتور
            else
            {
                if (cls_msgBox.show("آیا از بازیافت این فاکتور مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    if (cls_invoices.recycleAnInvoice(cls_invoices.invoiceType.buyInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            if (cls_accDoc.recycleThisAccDoc())
                            {
                                if (cls_cheques.moveChequesToTrash(n_accDoc_id))
                                {                                    
                                    handleTheStoring();

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

        private void btn_quickAction_Click(object sender, EventArgs e)
        {
            frm_persons _persons = new frm_persons();
            _persons.ShowDialog();

            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);
        }

        private void tbx_invoiceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void grp_details_Enter(object sender, EventArgs e)
        {

        }

        private void frm_invoicesBuy_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.Control)
            {
                if (e.KeyCode == Keys.T)
                {
                    cbx_persons.Focus();
                }
                else if (e.KeyCode == Keys.Space)
                {                    
                    btn_addOrRemoveRows.PerformClick();                    
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    //btn_addOrRemoveRows.Focus();
                    btn_save.PerformClick();
                }
                else if (e.KeyCode == Keys.P)
                {
                    btn_print.PerformClick();
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    btn_delete.PerformClick();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }            
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                string s_where = "WHERE (dbo.tbl_invoicesBuy.invoiceBuy_id = {0})";
                s_where = string.Format(s_where, tbx_invoiceID.Text);

                DataTable dt_invoice = new DataTable();
                frm_print _print = new frm_print();

                _print.s_reportFilePath = cls_myDataAccessLayer.s_pathRun + @"\rpt_invoiceBuy.rpt";
                _print.s_paraName = "totalInChars";
                _print.s_paraValue = cls_numberConvertor.convertToChars(tbx_invoiceTotalPrice.Text) + " ریال ";
                dt_invoice = cls_invoices.viewAnInvoice(cls_invoices.invoiceType.buyInvoice, s_where);

                _print.dt_report = dt_invoice;
                _print.ShowDialog();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

                           
    }
}
