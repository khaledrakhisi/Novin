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

        private bool b_theInvoiceHasBeenSaved = true;
        private int n_invoiceID = 0;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_invoicesSell.EndEdit();
            tbl_invoicesSellTableAdapter.Update(ds_sellInvoices.tbl_invoicesSell);
        }        

        private void frm_invoicesSell_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_itemsSell' table. You can move, or remove it, as needed.
            this.tbl_itemsSellTableAdapter.Fill(this.ds_sellInvoices.tbl_itemsSell);
            // TODO: This line of code loads data into the 'ds_sellInvoices.viw_itemsSell' table. You can move, or remove it, as needed.
            this.viw_itemsSellTableAdapter.Fill(this.ds_sellInvoices.viw_itemsSell);
            // TODO: This line of code loads data into the 'ds_sellInvoices.tbl_invoicesSell' table. You can move, or remove it, as needed.
            this.tbl_invoicesSellTableAdapter.Fill(this.ds_sellInvoices.tbl_invoicesSell);
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);

            bs_persons.Filter = "person_id > 1";

            //generating the available Sell invoice id
            cls_invoices _invoice = new cls_invoices();
            n_invoiceID = _invoice.getAvailableSellInvoiceID();
            tbx_invoiceID.Text = n_invoiceID.ToString();

            //filtering the 'invoicesSell' table by 'invoiceSell_id'
            bs_viewItemsSell.Filter = "invoiceSell_id = " + n_invoiceID.ToString();            

            //
            btn_new.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            //n_invoiceID = (int)ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_id"];
            frm_itemSelection _frm_itemSelection = new frm_itemSelection();
            _frm_itemSelection.openMode = 1;
            _frm_itemSelection.invoiceID = n_invoiceID;
            if (_frm_itemSelection.ShowDialog() == DialogResult.OK)
            {
                cls_accDoc.saveTheAccDoc();

                updateTheDatabase();

                _frm_itemSelection.Validate();
                _frm_itemSelection.bs_itemsSell.EndEdit();
                _frm_itemSelection.tbl_itemsSellTableAdapter.Update(_frm_itemSelection.ds_sellInvoices.tbl_itemsSell);

                this.viw_itemsSellTableAdapter.Fill(this.ds_sellInvoices.viw_itemsSell);

                tbx_invoiceTotalPrice.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID).ToString();
                tbx_invoiceTotalCount.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalCount(n_invoiceID).ToString();

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

                int n_personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];

                DataRow row_newInvoiceSell;
                row_newInvoiceSell = ds_sellInvoices.tbl_invoicesSell.NewRow();

                //row_newItemSell["itemSell_id"] = 1;//
                row_newInvoiceSell["invoiceSell_id"] = n_invoiceID; //
                row_newInvoiceSell["person_id"] = n_personID;//
                row_newInvoiceSell["accDoc_id"] = cls_accDoc.accDoc_id;//
                row_newInvoiceSell["invoiceSell_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newInvoiceSell["invoiceSell_totalPrice"] = 0;//
                row_newInvoiceSell["invoiceSell_Kind"] = true;//
                row_newInvoiceSell["invoiceSell_comment"] = "";//

                ds_sellInvoices.tbl_invoicesSell.Rows.Add(row_newInvoiceSell);

                bs_invoicesSell.Position = bs_invoicesSell.Find("invoiceSell_id", n_invoiceID);
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }            
        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {           
            tbx_invoiceTotalPrice.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID).ToString();
            tbx_invoiceTotalCount.Text = viw_itemsSellTableAdapter.getInvoiceSellTotalCount(n_invoiceID).ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addOrRemoveRows.PerformClick();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_viewItemsSell.Count == 0)
                {
                    if (cls_msgBox.show(" هیچ کالایی به فاکتور اضافه نشده است آیا مایلید کالاها را اضافه نمایید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                    {
                        btn_addOrRemoveRows.PerformClick();
                        return;
                    }
                }
                n_invoiceID = Convert.ToInt32(tbx_invoiceID.Text);
                ds_sellInvoices.tbl_invoicesSell.Rows[bs_invoicesSell.Position]["invoiceSell_id"] = n_invoiceID;

                updateTheDatabase();

                frm_issuseAccDoc _issuseAccDoc = new frm_issuseAccDoc();
                _issuseAccDoc.personID = (int)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_id"];
                _issuseAccDoc.n_totalMoney = (long)viw_itemsSellTableAdapter.getInvoiceSellTotalPrice(n_invoiceID);
                _issuseAccDoc._invoiceType = frm_issuseAccDoc.invoiceType.sellInvoice;

                if (_issuseAccDoc.ShowDialog() == DialogResult.OK)
                {
                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        string s_moeen_id = "";
                        long n_money = 0;

                        s_comment = "فاکتور فروش " + n_invoiceID.ToString();
                        s_moeen_id = (string)ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"];
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, _issuseAccDoc.n_totalMoney, 0, 0, 0);

                        s_comment = "فاکتور " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                        //فروش
                        cls_accDoc.addRow("9010001", s_comment, 0, 0, _issuseAccDoc.n_totalMoney, 0, 0);

                        s_comment = "بابت فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                        //صندوق
                        cls_accDoc.addRow("1010001", s_comment, 0, _issuseAccDoc.n_cashMoney, 0, 0, 0);

                        if (_issuseAccDoc.n_chequesMoney > 0)
                        {
                            s_comment = "خرید " + n_invoiceID.ToString() + " " + cbx_persons.Text + " پرداخت چک ";
                            //اسناد دریافتی
                            cls_accDoc.addRow("1040001", s_comment, 0, _issuseAccDoc.n_chequesMoney, 0, 0, 0);
                        }

                        if (_issuseAccDoc.n_discountMoney > 0)
                        {
                            s_comment = "بابت فروش " + n_invoiceID.ToString() + " " + cbx_persons.Text;
                            //تخفیفات نقدی فروش
                            cls_accDoc.addRow("9030001", s_comment, 0, _issuseAccDoc.n_discountMoney, 0, 0, 0);
                        }                        

                        if (_issuseAccDoc.n_discountMoney > 0)
                        {
                            s_comment = "جمع دریافتی با تخفیف بابت فروش " + n_invoiceID.ToString();
                            n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney + _issuseAccDoc.n_discountMoney);
                        }
                        else
                        {
                            s_comment = "جمع دریافتی بابت فروش " + n_invoiceID.ToString();
                            n_money = (_issuseAccDoc.n_cashMoney + _issuseAccDoc.n_chequesMoney + _issuseAccDoc.n_usedChequesMoney);
                        }
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);                                               
                       
                        //ثبت سند حسابداری
                        cls_accDoc.saveTheAccDoc();
                    }

                    //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی
                    cls_storing _storing = new cls_storing();
                    _storing.setTheEntity(cls_storing.invoiceType.buyInvoic, n_invoiceID);

                    //نمایش تائید
                    cls_msgBox.show("سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید ");

                    //آماده ساختن فرم فاکتور فروش برای فاکتور بعدی
                    frm_invoicesSell_Load(null, null);

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
                cls_accDoc.discardTheAccDoc();
            }
        }

        private void tbx_invoiceID_TextChanged(object sender, EventArgs e)
        {
            
        }

               
      
    }
}
