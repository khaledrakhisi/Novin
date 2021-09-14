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

        private bool b_theInvoiceHasBeenSaved = true;
        private int n_invoiceID = 0;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_invoicesBuy.EndEdit();
            tbl_invoicesBuyTableAdapter.Update(ds_buyInvoices.tbl_invoicesBuy);
        }        

        private void frm_invoicesBuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_itemsBuy' table. You can move, or remove it, as needed.
            this.tbl_itemsBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_itemsBuy);
            // TODO: This line of code loads data into the 'ds_buyInvoices.tbl_invoicesBuy' table. You can move, or remove it, as needed.
            this.tbl_invoicesBuyTableAdapter.Fill(this.ds_buyInvoices.tbl_invoicesBuy);
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);
            // TODO: This line of code loads data into the 'ds_buyInvoices.viw_itemsBuy' table. You can move, or remove it, as needed.
            this.viw_itemsBuyTableAdapter1.Fill(this.ds_buyInvoices.viw_itemsBuy);

            if (openForReturnSellInvoice)
            {
                this.Text = "فـــاکتور برگشت از فروش";
                grp_header.Text = "مشخصات خریدار :";
            }
            else
            {
                this.Text = "فــــاکتور خریــــد";
            }

            bs_persons.Filter = "person_id > 1";     


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
            btn_new.PerformClick();
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

                this.viw_itemsBuyTableAdapter1.Fill(this.ds_buyInvoices.viw_itemsBuy);

                tbx_invoiceTotalPrice.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, openForReturnSellInvoice).ToString();
                tbx_invoiceTotalCount.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalCount(n_invoiceID ,openForReturnSellInvoice).ToString();

                b_theInvoiceHasBeenSaved = false;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {               
                //ساختن سند به صورت موقت در حافظه
                cls_accDoc.createAccDoc();

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
                row_newInvoiceBuy["invoiceBuy_discountPercent"] = 0;//
                row_newInvoiceBuy["invoiceBuy_transportPrice"] = 0;//
                row_newInvoiceBuy["invoiceBuy_Kind"] = !openForReturnSellInvoice;//
                row_newInvoiceBuy["invoiceBuy_comment"] = "";//
                ds_buyInvoices.tbl_invoicesBuy.Rows.Add(row_newInvoiceBuy);
                //MessageBox.Show(.ToString());
                //n_invoiceID =(int) row_newInvoiceBuy["invoiceBuy_id"];
                bs_invoicesBuy.Position = bs_invoicesBuy.Find("invoiceBuy_id", n_invoiceID);
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }            
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            tbx_invoiceTotalPrice.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, openForReturnSellInvoice).ToString();
            tbx_invoiceTotalCount.Text = viw_itemsBuyTableAdapter1.getInvoiceTotalCount(n_invoiceID, openForReturnSellInvoice).ToString();
    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addOrRemoveRows.PerformClick();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_viewItemsBuy.Count == 0)
                {
                    if(cls_msgBox.show(" هیچ کالایی به فاکتور اضافه نشده است آیا مایلید کالاها را اضافه نمایید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                    {
                        btn_addOrRemoveRows.PerformClick();
                        return;
                    }
                }

                n_invoiceID = Convert.ToInt32(tbx_invoiceID.Text);
                ds_buyInvoices.tbl_invoicesBuy.Rows[bs_invoicesBuy.Position]["invoiceBuy_id"] = n_invoiceID;

                updateTheDatabase();

                frm_issuseAccDoc _issuseAccDoc = new frm_issuseAccDoc();
                _issuseAccDoc.personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                _issuseAccDoc.n_totalMoney =(long) viw_itemsBuyTableAdapter1.getInvoiceTotalPrice(n_invoiceID, openForReturnSellInvoice);
                _issuseAccDoc._invoiceType = frm_issuseAccDoc.invoiceType.buyInvoice;                

                if (_issuseAccDoc.ShowDialog() == DialogResult.OK)
                {
                    //ساختن سطرهای سند حسابداری 
                    {                        
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        s_comment = "فاکتور " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                        cls_accDoc.addRow("8010001", s_comment, 0, _issuseAccDoc.n_totalMoney, 0, 0, 0);
                        if (openForReturnSellInvoice)
                        {
                            s_comment = " برگشت از فروش " + n_invoiceID.ToString();
                        }
                        else
                        {
                            s_comment = "فاکتور خرید " + n_invoiceID.ToString();
                        }
                        s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, _issuseAccDoc.n_totalMoney, 0, 0);

                        if (_issuseAccDoc.n_discountMoney > 0)
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
                        else
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
                            }
                            else
                            {
                                s_comment = "بابت خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            }
                            
                            //تخفیفات نقدی خرید
                            cls_accDoc.addRow("8030001", s_comment, 0, 0, _issuseAccDoc.n_discountMoney, 0, 0);
                        }

                        //ثبت سند حسابداری
                        cls_accDoc.saveTheAccDoc();
                    }

                    //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی
                    cls_storing _storing = new cls_storing();
                    if (openForReturnSellInvoice)
                    {
                        _storing.setTheEntity(cls_storing.invoiceType.unSellInvoice, n_invoiceID);
                    }
                    else
                    {
                        _storing.setTheEntity(cls_storing.invoiceType.buyInvoic, n_invoiceID);
                    }

                    //نمایش تائید
                    cls_msgBox.show("سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید ");

                    //آماده ساختن فرم فاکتور فروش برای فاکتور بعدی
                    frm_invoicesBuy_Load(null, null);

                    b_theInvoiceHasBeenSaved = true;
                }
                else
                {                    
                    
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
                cls_accDoc.discardTheAccDoc();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }                    
    }
}
