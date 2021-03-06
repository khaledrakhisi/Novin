using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_invoicesSell : Novin.frm_FATHER
    {
        public frm_invoicesSell()
        {
            InitializeComponent();
        }
        public bool b_isItPreInvoice = false;
        public bool openForReturnBuyInvoice = false;
        public bool openForModify = false;
        public int n_invoiceIDForModify;

        private bool b_theInvoiceHasBeenSaved = true;
        private int n_invoiceID = 0;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_invoicesSell.EndEdit();
            tbl_invoicesSellTableAdapter.Update(ds_sellInvoices.tbl_invoicesSell);
        }

        private void handleTheStoring()
        {
            cls_storing _storing = new cls_storing();
            //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی                    
            _storing = new cls_storing();
            if (openForReturnBuyInvoice)
            {
                _storing.setTheEntity(cls_storing.invoiceType.unBuyInvoice, n_invoiceID);
            }
            else
            {
                _storing.setTheEntity(cls_storing.invoiceType.sellInvoic, n_invoiceID);
            }
        }

        private void handleThePerson()
        {
            //محاسبه مانده فعلی و ذخیره در فیلد مربوطه
            string s_person_moeen_id = "";
            s_person_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
            cls_visitors.setPersonNowRemainMoney(s_person_moeen_id);
        }

        private void newInvoice()
        {
            try
            {
                if (bs_persons.Count <= 0)
                {
                    cls_msgBox.show("طرف حسابی به برنامه معرفی نشده است");
                    return;
                }

                ////اگر پیش فاکتور نباشد باید سندی ساخته شود
                //if (b_isItPreInvoice)
                //{
                    //ساختن سند به صورت موقت در حافظه
                    cls_accDoc.createAccDoc(false);

                    DataRow row_accDoc;
                    row_accDoc = ds_sellInvoices.tbl_accDocs.NewRow();
                    if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
                    {
                        row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                        row_accDoc["accDoc_price"] = 0;
                        row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                        row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                        row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
                    }
                    ds_sellInvoices.tbl_accDocs.Rows.Add(row_accDoc);
                //}

                int n_personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];

                DataRow row_newInvoiceSell;
                row_newInvoiceSell = ds_sellInvoices.tbl_invoicesSell.NewRow();

                row_newInvoiceSell["invoiceSell_id"] = n_invoiceID; //                
                row_newInvoiceSell["person_id"] = n_personID;//
                row_newInvoiceSell["accDoc_id"] = cls_accDoc.accDoc_id;//
                row_newInvoiceSell["invoiceSell_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newInvoiceSell["invoiceSell_totalPrice"] = 0;//
                row_newInvoiceSell["invoiceSell_discountPrice"] = 0;//
                row_newInvoiceSell["invoiceSell_transportPrice"] = 0;//
                row_newInvoiceSell["invoiceSell_cashPrice"] = 0;//
                row_newInvoiceSell["invoiceSell_Kind"] = !openForReturnBuyInvoice;//
                row_newInvoiceSell["invoiceSell_comment"] = "";//
                row_newInvoiceSell["invoiceSell_isItPreInvoice"] = b_isItPreInvoice;//
                ds_sellInvoices.tbl_invoicesSell.Rows.Add(row_newInvoiceSell);

                bs_invoicesSell.MoveLast();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }            
        }

        private void frm_invoicesSell_Load(object sender, EventArgs e)
        {
            if (!openForModify)
            {
                // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_itemsSell' table. You can move, or remove it, as needed.
                this.tbl_itemsSellTableAdapter.Fill(this.ds_sellInvoices.tbl_itemsSell, -1, false);
                // TODO: This line of code loads data into the 'ds_sellInvoices.viw_itemsSell' table. You can move, or remove it, as needed.
                this.viw_itemsSellTableAdapter.Fill(this.ds_sellInvoices.viw_itemsSell, -1, false);
                // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_invoicesSell' table. You can move, or remove it, as needed.
                this.tbl_invoicesSellTableAdapter.Fill(this.ds_sellInvoices.tbl_invoicesSell, -1, false);
                // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);

                //bs_persons.Filter = "person_id > 1";

                if (openForReturnBuyInvoice)
                {
                    this.Text = "فـــاکتور برگشت از خرید";
                    grp_header.Text = "مشخصات فروشنده :";
                }
                else
                {
                    this.Text = "";
                    if (b_isItPreInvoice)
                    {
                        this.Text = "پــــیش ";
                    }
                    this.Text += "فــــاکتور فــــروش";
                }
                //generating the available buy invoice id
                cls_invoices _invoice = new cls_invoices();
                if (openForReturnBuyInvoice)
                {
                    n_invoiceID = _invoice.getAvailableUnBuyInvoiceID();
                }
                else
                {
                    n_invoiceID = _invoice.getAvailableSellInvoiceID();
                }
                //generating the available Sell invoice id
                tbx_invoiceID.Text = n_invoiceID.ToString();

                //filtering the 'invoicesBuy' table by 'invoiceBuy_id'
                bs_viewItemsSell.Filter = "invoiceSell_id = " + n_invoiceID.ToString() + " AND invoiceSell_kind = " + (!openForReturnBuyInvoice).ToString();

                //
                newInvoice();
                //
                btn_print.Enabled = false;
                btn_delete.Enabled = false;

                //
                if (b_isItPreInvoice)
                {
                    chk_issuseInvoiceAsIndebted.Enabled = false;                    
                }
            }
            ///////////////////////////////////////////////////////////
            else if (openForModify)
            {
                // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_itemsSell' table. You can move, or remove it, as needed.
                this.tbl_itemsSellTableAdapter.Fill(this.ds_sellInvoices.tbl_itemsSell, n_invoiceIDForModify, !openForReturnBuyInvoice);
                // TODO: This line of code loads data into the 'ds_sellInvoices.viw_itemsSell' table. You can move, or remove it, as needed.
                this.viw_itemsSellTableAdapter.Fill(this.ds_sellInvoices.viw_itemsSell, n_invoiceIDForModify, !openForReturnBuyInvoice);
                // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_invoicesSell' table. You can move, or remove it, as needed.
                this.tbl_invoicesSellTableAdapter.Fill(this.ds_sellInvoices.tbl_invoicesSell, n_invoiceIDForModify, !openForReturnBuyInvoice);
                // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.FillByFilter(this.ds_persons.tbl_persons, 1);

                if (openForReturnBuyInvoice)
                {
                    this.Text = "اصــــلاح فـــاکتور برگشت از خرید";
                    grp_header.Text = "مشخصات فروشنده :";
                }
                else
                {
                    this.Text = "اصــــلاح فــــاکتور فــــروش";
                }

                //bs_persons.Filter = "person_id > 1";

                ////locate the INVOICE in the DATASET
                //int n_pos = bs_invoicesSell.Find("invoiceSell_id", n_invoiceIDForModify);
                //if (n_pos != -1)
                //{
                //    bs_invoicesSell.Position = n_pos;
                //}

                //
                n_invoiceID = n_invoiceIDForModify;

                tbx_invoiceID.Text = n_invoiceID.ToString();

                ////filtering the 'invoicesBuy' table by 'invoiceBuy_id'
                //bs_viewItemsSell.Filter = "invoiceSell_id = " + n_invoiceID.ToString() + " AND invoiceSell_kind = " + (!openForReturnBuyInvoice).ToString();

                int n_accDoc_id = 0;
                n_accDoc_id = (int)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["accDoc_id"];
                if (cls_accDoc.isThisAccDocExist(n_accDoc_id))//this line make the just added accDoc active
                {
                }

                if (ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_deleted"] != DBNull.Value)
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
            //n_invoiceID = (int)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_id"];
            frm_itemSelection _frm_itemSelection = new frm_itemSelection();
            _frm_itemSelection.openMode = 1;
            _frm_itemSelection.invoiceID = n_invoiceID;
            _frm_itemSelection.isItForReturnInvoice = openForReturnBuyInvoice;
            try
            {
                _frm_itemSelection.rangePrice = (Int16)ds_persons.tbl_persons[bs_persons.Position]["person_rangePrice"];
            }
            catch 
            {

                _frm_itemSelection.rangePrice = 1;
            }

            if (_frm_itemSelection.ShowDialog() == DialogResult.OK)
            {
                cls_accDoc.saveTheAccDoc();

                updateTheDatabase();

                _frm_itemSelection.Validate();
                _frm_itemSelection.bs_itemsSell.EndEdit();
                _frm_itemSelection.tbl_itemsSellTableAdapter.Update(_frm_itemSelection.ds_sellInvoices.tbl_itemsSell);

                this.viw_itemsSellTableAdapter.Fill(this.ds_sellInvoices.viw_itemsSell, n_invoiceID, !openForReturnBuyInvoice);
                
                tbx_invoiceTotalPrice.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID, !openForReturnBuyInvoice).ToString();
                tbx_invoiceTotalCount.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalCount(n_invoiceID, !openForReturnBuyInvoice).ToString();

                b_theInvoiceHasBeenSaved = false;
            }

            btn_save.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {           
            tbx_invoiceTotalPrice.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID, !openForReturnBuyInvoice).ToString();
            tbx_invoiceTotalCount.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalCount(n_invoiceID, !openForReturnBuyInvoice).ToString();
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
                //    if (openForReturnBuyInvoice)
                //    {
                //        s_negativeEntityObjects = _storing.checkTheEntity(cls_storing.invoiceType.unBuyInvoice, n_invoiceID);
                //    }
                //    else
                //    {
                //        s_negativeEntityObjects = _storing.checkTheEntity(cls_storing.invoiceType.sellInvoic, n_invoiceID);
                //    }
                //    if (s_negativeEntityObjects != "")
                //    {
                //        string s_message = "";
                //        s_message = "کاربر گرامی با ثبت تغییرات این فاکتور موجودی کالاهای زیر منفی خواهد شد";
                //        s_message += "\n\n";
                //        string[] s_negativeEntityObject = s_negativeEntityObjects.Split(';');
                //        for (int i = 0; i <= s_negativeEntityObject.Length - 1; i++)
                //        {
                //            string s_objectTitle = "\n-- " + viw_itemsSellTableAdapter.getObjectTitle(Convert.ToInt32(s_negativeEntityObject[i])) + "\n";
                //            s_message += s_objectTitle;
                //            Application.DoEvents();
                //        }
                //        cls_msgBox.show(s_message, "", cls_msgBox.buttons.OKOnly);
                //        return;
                //    }
                //}
                if (bs_viewItemsSell.Count == 0)
                {
                    if (cls_msgBox.show(" هیچ کالایی به فاکتور اضافه نشده است آیا مایلید کالاها را اضافه نمایید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                    {
                        btn_addOrRemoveRows.PerformClick();
                    }
                    return;
                }
                n_invoiceID = Convert.ToInt32(tbx_invoiceID.Text);
                ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_id"] = n_invoiceID;

                updateTheDatabase();

                if (b_isItPreInvoice)
                {
                    //ثبت سند حسابداری
                    cls_accDoc.saveTheAccDoc();

                }
                else
                {

                    DialogResult _dlgResult;
                    frm_issuseAccDoc _issuseAccDoc = new frm_issuseAccDoc();
                    _issuseAccDoc.personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                    _issuseAccDoc.n_originalTotalMoney = (long)viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID, !openForReturnBuyInvoice);
                    _issuseAccDoc.n_cashMoney = (long)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_cashPrice"];
                    _issuseAccDoc.n_discountMoney = (long)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_discountPrice"];
                    _issuseAccDoc.n_transportPrice = (long)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_transportPrice"];
                    _issuseAccDoc._invoiceType = frm_issuseAccDoc.invoiceType.sellInvoice;

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
                        ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_cashPrice"] = _issuseAccDoc.n_cashMoney;
                        ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_totalPrice"] = _issuseAccDoc.n_totalMoney;
                        ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_discountPrice"] = _issuseAccDoc.n_discountMoney;
                        ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_transportPrice"] = _issuseAccDoc.n_transportPrice;

                        updateTheDatabase();

                        if (openForModify)
                        {
                            cls_accDoc.clearAccDocRows();
                        }
                        //ساختن سطرهای سند حسابداری 
                        {
                            string s_comment = "";
                            string s_moeen_id = "";
                            long n_money = 0;

                            if (openForReturnBuyInvoice)
                            {
                                s_comment = "فاکتور برگشت از خرید " + n_invoiceID.ToString();
                            }
                            else
                            {
                                s_comment = "فاکتور فروش " + n_invoiceID.ToString();
                            }

                            s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, _issuseAccDoc.n_totalMoney, 0, 0, 0);

                            s_comment = "فاکتور " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            if (openForReturnBuyInvoice)
                            {
                                s_moeen_id = "8020002";//برگشت از خرید
                            }
                            else
                            {
                                s_moeen_id = "9010001"; //فروش
                            }

                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, _issuseAccDoc.n_totalMoney, 0, 0);

                            if (openForReturnBuyInvoice)
                            {
                                s_comment = "برگشت از خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            }
                            else
                            {
                                s_comment = "بابت فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            }
                            //صندوق
                            cls_accDoc.addRow("1010001", s_comment, 0, _issuseAccDoc.n_cashMoney, 0, 0, 0);

                            if (_issuseAccDoc.n_chequesMoney > 0)
                            {
                                if (openForReturnBuyInvoice)
                                {
                                    s_comment = "برگشت از خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text + " دریافت چک ";
                                }
                                else
                                {
                                    s_comment = "فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text + " دریافت چک ";
                                }
                                //اسناد دریافتی
                                cls_accDoc.addRow("1040001", s_comment, 0, _issuseAccDoc.n_chequesMoney, 0, 0, 0);
                            }

                            if (_issuseAccDoc.n_discountMoney > 0)
                            {
                                if (openForReturnBuyInvoice)
                                {
                                    s_comment = "بابت برگشت از خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                                    s_moeen_id = "8030001";//تخفیفات نقدی خرید
                                }
                                else
                                {
                                    s_comment = "بابت فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                                    s_moeen_id = "9030001";//تخفیفات نقدی فروش
                                }
                                cls_accDoc.addRow(s_moeen_id, s_comment, 0, _issuseAccDoc.n_discountMoney, 0, 0, 0);
                            }

                            s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                            if (_issuseAccDoc.n_discountMoney > 0)
                            {
                                if (openForReturnBuyInvoice)
                                {
                                    s_comment = "جمع دریافتی با تخفیف بابت برگشت از خرید " + n_invoiceID.ToString();
                                }
                                else
                                {
                                    s_comment = "جمع دریافتی با تخفیف بابت فروش " + n_invoiceID.ToString();
                                }
                                n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney + _issuseAccDoc.n_discountMoney);
                            }
                            else
                            {
                                if (openForReturnBuyInvoice)
                                {
                                    s_comment = "جمع دریافتی بابت برگشت از خرید " + n_invoiceID.ToString();
                                }
                                else
                                {
                                    s_comment = "جمع دریافتی بابت فروش " + n_invoiceID.ToString();
                                }
                                n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney);
                            }
                            cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);

                            //ثبت سند حسابداری
                            cls_accDoc.saveTheAccDoc();
                        }

                        handleTheStoring();

                        handleThePerson();
                    }
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
                    frm_invoicesSell_Load(null, null);
                    b_theInvoiceHasBeenSaved = true;
                }
                else if (openForModify || _dlgMsg == DialogResult.No)
                {
                    b_theInvoiceHasBeenSaved = true;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_invoicesSell_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tbx_invoiceID_TextChanged(object sender, EventArgs e)
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

                        btn_addOrRemoveRows.Focus();
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

        private void frm_invoicesSell_KeyDown(object sender, KeyEventArgs e)
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
                
                e.SuppressKeyPress = true;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                string s_where = "WHERE (dbo.tbl_invoicesSell.invoiceSell_id = {0})";
                s_where = string.Format(s_where, tbx_invoiceID.Text);

                DataTable dt_invoice = new DataTable();
                frm_print _print = new frm_print();

                _print.s_reportFilePath = cls_myDataAccessLayer.s_pathRun + @"\rpt_invoiceSell.rpt";
                _print.s_paraName = "totalInChars";
                _print.s_paraValue = cls_numberConvertor.convertToChars(tbx_invoiceTotalPrice.Text) + " ریال ";
                dt_invoice = cls_invoices.viewAnInvoice(cls_invoices.invoiceType.sellInvoice, s_where);

                _print.dt_report = dt_invoice;
                _print.ShowDialog();
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int n_accDoc_id = 0;

            //حذف فاکتور
            if (ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_deleted"] == DBNull.Value)
            {
                if (cls_msgBox.show("آیا از انداختن این فاکتور به سطل بازیافت مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    //انداختن فاکتور در سطل آشغال
                    if (cls_invoices.moveAnInvoiceToTrash(cls_invoices.invoiceType.sellInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            //انداختن سند در سطل آشغال
                            if (cls_accDoc.moveThisAccDocToTrash())
                            {
                                //انداختن چک ها در سطل آشغال
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
                    if (cls_invoices.recycleAnInvoice(cls_invoices.invoiceType.sellInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            if (cls_accDoc.recycleThisAccDoc())
                            {
                                if (cls_cheques.recycleCheques(n_accDoc_id))
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
    }
}
