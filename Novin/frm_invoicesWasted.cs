using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_invoicesWasted : Novin.frm_FATHER
    {
        public frm_invoicesWasted()
        {
            InitializeComponent();
        }
        public bool openForModify = false;
        public int n_invoiceIDForModify;

        private bool b_theInvoiceHasBeenSaved = true;
        private int n_invoiceID = 0;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_invoicesWasted.EndEdit();
            tbl_invoicesWastedTableAdapter.Update(ds_wastedInvoices.tbl_invoicesWasted);
        }

        private void handleTheStoring()
        {
            try
            {
                //کم کردن یا اضافه کردن موجودی کالا - انبارگردانی                    
                cls_storing _storing = new cls_storing();
                _storing.setTheEntity(cls_storing.invoiceType.wastedInvoic, n_invoiceID);
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void newInvoice()
        {
            try
            {
                //ساختن سند به صورت موقت در حافظه
                cls_accDoc.createAccDoc(false);

                DataRow row_accDoc;
                row_accDoc = ds_wastedInvoices.tbl_accDocs.NewRow();
                if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
                {
                    row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                    row_accDoc["accDoc_price"] = 0;
                    row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                    row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                    row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
                }
                ds_wastedInvoices.tbl_accDocs.Rows.Add(row_accDoc);

                DataRow row_newInvoiceWasted;
                row_newInvoiceWasted = ds_wastedInvoices.tbl_invoicesWasted.NewRow();
                row_newInvoiceWasted["invoiceWasted_id"] = n_invoiceID; //                                
                row_newInvoiceWasted["accDoc_id"] = cls_accDoc.accDoc_id;//
                row_newInvoiceWasted["invoiceWasted_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newInvoiceWasted["invoiceWasted_totalPrice"] = 0;//                                
                row_newInvoiceWasted["invoiceWasted_comment"] = "";//
                ds_wastedInvoices.tbl_invoicesWasted.Rows.Add(row_newInvoiceWasted);
                //MessageBox.Show(.ToString());
                //n_invoiceID =(int) row_newInvoiceWasted["invoiceWasted_id"];
                bs_invoicesWasted.Position = bs_invoicesWasted.Find("invoiceWasted_id", n_invoiceID);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }            
        }

        private void frm_invoicesWasted_Load(object sender, EventArgs e)
        {
            

            if (!openForModify)
            {
                // TODO: This line of code loads data into the 'ds_wastedInvoices.tbl_invoicesWasted' table. You can move, or remove it, as needed.
                this.tbl_invoicesWastedTableAdapter.Fill(this.ds_wastedInvoices.tbl_invoicesWasted, -1);
                // TODO: This line of code loads data into the 'ds_wastedInvoices.viw_itemsWasted' table. You can move, or remove it, as needed.
                this.viw_itemsWastedTableAdapter.Fill(this.ds_wastedInvoices.viw_itemsWasted, -1);

                //generating the available wasted invoice id
                cls_invoices _invoice = new cls_invoices();

                n_invoiceID = _invoice.getAvailableWastedInvoiceID();

                tbx_invoiceID.Text = n_invoiceID.ToString();

                ////filtering the 'invoicesWasted' table by 'invoiceWasted_id'
                //bs_viewItemsWasted.Filter = "invoiceWasted_id = " + n_invoiceID.ToString();

                //
                newInvoice();
                //
                btn_print.Enabled = false;
                btn_delete.Enabled = false;
            }
            ///////////////////////////////////////////////////////////
            else if (openForModify)
            {
                // TODO: This line of code loads data into the 'ds_wastedInvoices.tbl_invoicesWasted' table. You can move, or remove it, as needed.
                this.tbl_invoicesWastedTableAdapter.Fill(this.ds_wastedInvoices.tbl_invoicesWasted, n_invoiceIDForModify);
                // TODO: This line of code loads data into the 'ds_wastedInvoices.viw_itemsWasted' table. You can move, or remove it, as needed.
                this.viw_itemsWastedTableAdapter.Fill(this.ds_wastedInvoices.viw_itemsWasted, n_invoiceIDForModify);

                this.Text = "اصــــلاح فــــاکتور ضایعات کالا";

                //locate the INVOICE in the DATASET
                int n_pos = bs_invoicesWasted.Find("invoiceWasted_id", n_invoiceIDForModify);
                if (n_pos != -1)
                {
                    bs_invoicesWasted.Position = n_pos;
                }

                //
                n_invoiceID = n_invoiceIDForModify;

                tbx_invoiceID.Text = n_invoiceID.ToString();

                ////filtering the 'invoicesBuy' table by 'invoiceBuy_id'
                //bs_viewItemsWasted.Filter = "invoiceWasted_id = " + n_invoiceID.ToString();

                int n_accDoc_id = 0;
                n_accDoc_id = (int)ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["accDoc_id"];
                if (cls_accDoc.isThisAccDocExist(n_accDoc_id))//this line make the just added accDoc active
                {
                }

                if (ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["invoiceWasted_deleted"] != DBNull.Value)
                {
                    btn_delete.Text = "بـازیابی فاکتور";

                    btn_save.Enabled = false;

                    grp_header.Enabled = false;
                    grp_details.Enabled = false;

                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addOrRemoveRows_Click(object sender, EventArgs e)
        {
            frm_itemSelection _frm_itemSelection = new frm_itemSelection();
            _frm_itemSelection.invoiceID = n_invoiceID;
            _frm_itemSelection.openMode = 2;//wasted
            if (_frm_itemSelection.ShowDialog() == DialogResult.OK)
            {
                cls_accDoc.saveTheAccDoc();

                updateTheDatabase();

                _frm_itemSelection.Validate();
                _frm_itemSelection.bs_itemsWasted.EndEdit();
                _frm_itemSelection.tbl_itemsWastedTableAdapter.Update(_frm_itemSelection.ds_wastedInvoices.tbl_itemsWasted);

                this.viw_itemsWastedTableAdapter.Fill(this.ds_wastedInvoices.viw_itemsWasted, n_invoiceID);

                tbx_invoiceTotalPrice.Text = viw_itemsWastedTableAdapter.getWastedItemsTotalPrice(n_invoiceID).ToString();
                tbx_invoiceTotalCount.Text = viw_itemsWastedTableAdapter.getWastedItemsTotalCount(n_invoiceID).ToString();

                b_theInvoiceHasBeenSaved = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {            
            try
            {
                if (bs_viewItemsWasted.Count == 0)
                {
                    if (cls_msgBox.show(" هیچ کالایی به فاکتور اضافه نشده است آیا مایلید کالاها را اضافه نمایید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                    {
                        btn_addOrRemoveRows.PerformClick();
                        return;
                    }
                }

                n_invoiceID = Convert.ToInt32(tbx_invoiceID.Text);
                ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["invoiceWasted_id"] = n_invoiceID;

                updateTheDatabase();
               
                if (cls_msgBox.show("فاکتور ذخیره شود؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    if (openForModify)
                    {
                        cls_accDoc.clearAccDocRows();
                    }
                    //ساختن سطرهای سند حسابداری 
                    {
                        string s_comment = "";
                        long n_totalPrice =(long) viw_itemsWastedTableAdapter.getWastedItemsTotalPrice(n_invoiceID);

                        s_comment = "ضایعات کالا " + n_invoiceID.ToString();
                        //هزینه ضایعات کالا
                        cls_accDoc.addRow("6010006", s_comment, 0, n_totalPrice, 0, 0, 0);

                        s_comment = "ضایعات کالا " + n_invoiceID.ToString();
                        //خرید
                        cls_accDoc.addRow("8010001", s_comment, 0, 0, n_totalPrice, 0, 0);

                        //ثبت سند حسابداری
                        cls_accDoc.saveTheAccDoc();
                    }

                    handleTheStoring();

                    //نمایش تائید
                    cls_msgBox.show("سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید ");
                    if (!openForModify)
                    {
                        //آماده ساختن فرم فاکتور فروش برای فاکتور بعدی
                        frm_invoicesWasted_Load(null, null);
                        b_theInvoiceHasBeenSaved = true;
                    }
                    else
                    {
                        b_theInvoiceHasBeenSaved = true;
                        this.Close();
                    }    
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

        private void frm_invoicesWasted_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frm_invoicesWasted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {                
                if (e.KeyCode == Keys.Space)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int n_accDoc_id = 0;

            //حذف فاکتور
            if (ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["invoiceWasted_deleted"] == DBNull.Value)
            {
                if (cls_msgBox.show("آیا از انداختن این فاکتور به سطل بازیافت مطمئنید؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
                {
                    //انداختن فاکتور در سطل آشغال
                    if (cls_invoices.moveAnInvoiceToTrash(cls_invoices.invoiceType.wastedInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            //انداختن سند در سطل آشغال
                            if (cls_accDoc.moveThisAccDocToTrash())
                            {
                                //انداختن چک ها در سطل آشغال
                                if (cls_cheques.moveChequesToTrash(n_accDoc_id))
                                {
                                    handleTheStoring();

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
                    if (cls_invoices.recycleAnInvoice(cls_invoices.invoiceType.wastedInvoice, tbx_invoiceID.Text))
                    {
                        n_accDoc_id = (int)ds_wastedInvoices.tbl_invoicesWasted.Rows[bs_invoicesWasted.Position]["accDoc_id"];
                        if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
                        {
                            if (cls_accDoc.recycleThisAccDoc())
                            {
                                if (cls_cheques.recycleCheques(n_accDoc_id))
                                {
                                    handleTheStoring();                                    

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
