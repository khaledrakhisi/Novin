using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_invoiceExplorer : Novin.frm_FATHER
    {
        public frm_invoiceExplorer()
        {
            InitializeComponent();
        }

        DataTable dt_report = new DataTable();
        BindingSource bs_report = new BindingSource();

        private string sqlConditionBuilder()
        {            
            string s_sqlWhereExpresstion = "";
            string s_invoiceType = "";
            string s_fieldName = "";
            string s_condition = "";
            string s_value = "";
            string s_value2 = "";
            byte byt_invoiceKind = 0;

            s_sqlWhereExpresstion = "WHERE (dbo.tbl_invoices{0}.invoice{0}_{1} {2} {3})";
            if (tabControl1.SelectedIndex == 3)//جستجو بر اساس نام
            {
                s_sqlWhereExpresstion = "WHERE (dbo.tbl_persons.person_familyAndName LIKE N'%{0}%') AND (dbo.tbl_invoices{1}.invoice{1}_kind = {2})";                 
            }
            if (!rdu_wastedInvoice.Checked)
            {
                s_sqlWhereExpresstion += "AND (dbo.tbl_invoices{0}.invoice{0}_kind = {4})";
            }

            if (rdu_buyInvoice.Checked || rdu_unSellInvoice.Checked)
            {
                s_invoiceType = "Buy";
                byt_invoiceKind = Convert.ToByte(rdu_buyInvoice.Checked);
            }
            else if (rdu_sellInvoice.Checked || rdu_unBuyInvoice.Checked)
            {
                s_invoiceType = "Sell";
                byt_invoiceKind = Convert.ToByte(rdu_sellInvoice.Checked);
            }
            else if (rdu_wastedInvoice.Checked)
            {
                s_invoiceType = "Wasted";
            }

            if (tabControl1.SelectedIndex == 0)//جستجو بر اساس شماره فاکتور
            {
                s_fieldName = "id";
                if (rdu_equalsToNumber.Checked)
                {
                    s_condition = "=";
                    s_value = num_toNumber.Value.ToString();
                }
                else if (rdu_betweensNumber.Checked)
                {
                    s_value = num_fromNumber.Value.ToString();
                    s_value2 = num_toNumber.Value.ToString();
                }
                else if (rdu_lessThanNumber.Checked)
                {
                    s_condition = "<";
                    s_value = num_toNumber.Value.ToString();
                }
                else if (rdu_moreThanNumber.Checked)
                {
                    s_condition = ">";
                    s_value = num_toNumber.Value.ToString();
                }
                else if (rdu_allInvoices.Checked)
                {
                    s_condition = "";
                    s_value = "";
                    if (rdu_wastedInvoice.Checked)
                    {
                        s_condition = ">";
                        s_value = "1";
                    }
                }
            }
            else if (tabControl1.SelectedIndex == 1)//جستجو بر اساس تاریخ فاکتور
            {
                s_fieldName = "date";
                if (rdu_equalsToDate.Checked)
                {
                    s_condition = "=";
                    s_value = "'" + mTbx_toDate.Text.ToString() + "'";
                }
                else if (rdu_betweensDate.Checked)
                {
                    //s_condition = "=";
                    s_value = "'" + mTbx_fromDate.Text.ToString() + "'";
                    s_value2 = "'" + mTbx_toDate.Text.ToString() + "'";
                }
                else if (rdu_lessThanDate.Checked)
                {
                    s_condition = "<";
                    s_value = "'" + mTbx_toDate.Text.ToString() + "'";
                }
                else if (rdu_moreThanDate.Checked)
                {
                    s_condition = ">";
                    s_value = "'" + mTbx_toDate.Text.ToString() + "'";
                }
            }
            else if (tabControl1.SelectedIndex == 2)//جستجو بر اساس مبلغ فاکتور
            {
                s_fieldName = "totalPrice";
                if (rdu_equalsToPrice.Checked)
                {
                    s_condition = "=";
                    s_value = tbx_toPrice.Text.ToString();
                }
                else if (rdu_betweensPrice.Checked)
                {
                    //s_condition = "=";
                    s_value = tbx_fromPrice.Text.ToString();
                    s_value2 = tbx_toPrice.Text.ToString();
                }
                else if (rdu_lessThanPrice.Checked)
                {
                    s_condition = "<";
                    s_value = tbx_toPrice.Text.ToString();
                }
                else if (rdu_moreThanPrice.Checked)
                {
                    s_condition = ">";
                    s_value = tbx_toPrice.Text.ToString();
                }

            }
            else if (tabControl1.SelectedIndex == 3)//جستجو بر اساس نام طرف حساب
            {
                s_value = cbx_persons.Text;
                s_fieldName = "";
            }

            if ((rdu_betweensNumber.Checked && tabControl1.SelectedIndex == 0) || (rdu_betweensDate.Checked && tabControl1.SelectedIndex == 1) || (rdu_betweensPrice.Checked && tabControl1.SelectedIndex == 2))
            {
                s_sqlWhereExpresstion = "WHERE (dbo.tbl_invoices{0}.invoice{0}_{1} between {2} AND {3}) AND (dbo.tbl_invoices{0}.invoice{0}_kind = {4})";
                s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_invoiceType, s_fieldName, s_value, s_value2, byt_invoiceKind);
            }
            else if (rdu_allInvoices.Checked && tabControl1.SelectedIndex==0 && !rdu_wastedInvoice.Checked)
            {
                s_sqlWhereExpresstion = "WHERE (dbo.tbl_invoices{0}.invoice{0}_kind = {1})";
                s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_invoiceType, byt_invoiceKind);
            }
            else
            {
                if (tabControl1.SelectedIndex == 3)//جستجو بر اساس نام طرف حساب
                {
                    s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_value, s_invoiceType, byt_invoiceKind);
                }
                else
                {
                    s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_invoiceType, s_fieldName, s_condition, s_value, byt_invoiceKind);
                }
            }

            return s_sqlWhereExpresstion;
        }

        private void rdu_betweensNumber_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangeNumber.Top = num_toNumber.Top;
            pnl_rangeNumber.Visible = rdu_betweensNumber.Checked;
        }

        private void rdu_betweensDate_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangeDate.Top = mTbx_toDate.Top;
            pnl_rangeDate.Visible = rdu_betweensDate.Checked;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            cls_invoices.invoiceType _invoiceType = cls_invoices.invoiceType.buyInvoice;
            string s_where = sqlConditionBuilder();
            string s_invoiceType = "";

            if (rdu_buyInvoice.Checked || rdu_unSellInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.buyInvoice;
                s_invoiceType = "Buy";
            }
            else if (rdu_sellInvoice.Checked || rdu_unBuyInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.sellInvoice;
                s_invoiceType = "Sell";
            }
            else if (rdu_wastedInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.wastedInvoice;
                s_invoiceType = "Wasted";
            }

            dt_report = cls_invoices.searchInvoicesByCondition(_invoiceType, s_where);            
            bs_report.DataSource = dt_report;            

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bs_report;         
            
            DataGridViewTextBoxColumn invoice_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoice_date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoice_totalPrice = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoice_comment = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn person_familyAndName = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            invoice_id, person_familyAndName,invoice_date, invoice_totalPrice, invoice_comment});

            invoice_id.DataPropertyName = "invoice" + s_invoiceType + "_id";
            invoice_id.HeaderText = "شماره فاکتور";
            invoice_id.Name = "invoice_id";
            invoice_id.ReadOnly = true;

            invoice_date.DataPropertyName = "invoice" + s_invoiceType + "_date";
            invoice_date.HeaderText = "تاریخ فاکتور";
            invoice_date.Name = "invoice_date";
            invoice_date.ReadOnly = true;

            invoice_totalPrice.DataPropertyName = "invoice" + s_invoiceType + "_totalPrice";
            invoice_totalPrice.HeaderText = "مبلغ فاکتور";
            invoice_totalPrice.Name = "invoice_totalPrice";
            invoice_totalPrice.ReadOnly = true;

            invoice_comment.DataPropertyName = "invoice" + s_invoiceType + "_comment";
            invoice_comment.HeaderText = "توضیحات فاکتور";
            invoice_comment.Name = "invoice_comment";
            invoice_comment.ReadOnly = true;

            person_familyAndName.DataPropertyName = "person_familyAndName";
            person_familyAndName.HeaderText = "طرف حساب";
            person_familyAndName.Name = "person_familyAndName";
            person_familyAndName.ReadOnly = true;

            if (bs_report.Count > 0)
            {
                btn_modify.Enabled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                btn_modify.Enabled = false;
            }
            else
            {
                btn_modify.Enabled = true;
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            int n_invoice_id = 0;
            cls_invoices.invoiceType _invoiceType = cls_invoices.invoiceType.buyInvoice;
            cls_invoices _invoices = new cls_invoices();            

            if (rdu_buyInvoice.Checked)
            {                
                _invoiceType = cls_invoices.invoiceType.buyInvoice;
                n_invoice_id = (int)dt_report.Rows[bs_report.Position]["invoiceBuy_id"];

                if (_invoices.isThisInvoiceExists(_invoiceType, n_invoice_id))
                {
                    frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                    _invoiceBuy.openForModify = true;
                    _invoiceBuy.openForReturnSellInvoice = false;
                    _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                    _invoiceBuy.ShowDialog();
                }
            }
            else if (rdu_sellInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.sellInvoice;
                n_invoice_id = (int)dt_report.Rows[bs_report.Position]["invoiceSell_id"];

                if (_invoices.isThisInvoiceExists(_invoiceType, n_invoice_id))
                {
                    frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                    _invoiceSell.openForModify = true;
                    _invoiceSell.openForReturnBuyInvoice = false;
                    _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                    _invoiceSell.ShowDialog();
                }
            }
            else if (rdu_unBuyInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.unBuyInvoice;
                n_invoice_id = (int)dt_report.Rows[bs_report.Position]["invoiceSell_id"];

                if (_invoices.isThisInvoiceExists(_invoiceType, n_invoice_id))
                {
                    frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                    _invoiceSell.openForModify = true;
                    _invoiceSell.openForReturnBuyInvoice = true;
                    _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                    _invoiceSell.ShowDialog();
                }
            }
            else if (rdu_unSellInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.unSellInvoice;
                n_invoice_id = (int)dt_report.Rows[bs_report.Position]["invoiceBuy_id"];

                if (_invoices.isThisInvoiceExists(_invoiceType, n_invoice_id))
                {
                    frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                    _invoiceBuy.openForModify = true;
                    _invoiceBuy.openForReturnSellInvoice = true;
                    _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                    _invoiceBuy.ShowDialog();
                }
            }
            else if (rdu_wastedInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.wastedInvoice;
                n_invoice_id = (int)dt_report.Rows[bs_report.Position]["invoiceWasted_id"];

                if (_invoices.isThisInvoiceExists(_invoiceType, n_invoice_id))
                {
                    frm_invoicesWasted _invoiceWasted = new frm_invoicesWasted();
                    _invoiceWasted.openForModify = true;
                    _invoiceWasted.n_invoiceIDForModify = n_invoice_id;
                    _invoiceWasted.ShowDialog();
                }
            }                       
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dt_invoice = new DataTable();
            frm_print _print = new frm_print();
            cls_invoices.invoiceType _invoiceType = cls_invoices.invoiceType.buyInvoice;
            long n_invoiceTotalMoney = 0;
            string s_appPath = Application.StartupPath;

            string s_where = sqlConditionBuilder();            

            if (rdu_buyInvoice.Checked || rdu_unSellInvoice.Checked)
            {
                n_invoiceTotalMoney = (long)dt_report.Rows[bs_report.Position]["invoiceBuy_totalPrice"];                
                _invoiceType = cls_invoices.invoiceType.buyInvoice;
                _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_invoiceBuy.rpt";
                //_print.s_reportFilePath = s_appPath + @"\rpt_invoiceBuy.rpt";
                _print.s_paraName = "totalInChars";
                _print.s_paraValue = cls_numberConvertor.convertToChars(n_invoiceTotalMoney.ToString()) + " ریال ";

            }
            else if (rdu_sellInvoice.Checked || rdu_unBuyInvoice.Checked)
            {
                n_invoiceTotalMoney = (long)dt_report.Rows[bs_report.Position]["invoiceSell_totalPrice"];                
                _invoiceType = cls_invoices.invoiceType.sellInvoice;
                _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_invoiceSell.rpt";
                //_print.s_reportFilePath = s_appPath + @"\rpt_invoiceSell.rpt";
                _print.s_paraName = "totalInChars";
                _print.s_paraValue = cls_numberConvertor.convertToChars(n_invoiceTotalMoney.ToString()) + " ریال ";
            }
            else if (rdu_wastedInvoice.Checked)
            {
                _invoiceType = cls_invoices.invoiceType.wastedInvoice;                
            }

            dt_invoice = cls_invoices.viewAnInvoice(_invoiceType, s_where);            
                       
            _print.dt_report = dt_invoice;
            _print.ShowDialog();
        }

        private void frm_invoiceExplorer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);

            mTbx_fromDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
            mTbx_toDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
        }

        private void rdu_betweensPrice_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangePrice.Top = tbx_toPrice.Top;
            pnl_rangePrice.Visible = rdu_betweensPrice.Checked;
        }

        private void tbx_toPrice_TextChanged(object sender, EventArgs e)
        {
            lbl_priceInChars.Text = cls_numberConvertor.convertToChars(tbx_toPrice.Text) + " ریال ";
        }

        private void tbx_fromPrice_TextChanged(object sender, EventArgs e)
        {
            lbl_priceInChars.Text = cls_numberConvertor.convertToChars(tbx_fromPrice.Text)+" ریال ";
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btn_modify_Click(null, null);
        }
    }
}
