using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_accDocExplorer : Novin.frm_FATHER
    {
        public frm_accDocExplorer()
        {
            InitializeComponent();
        }

        DataTable dt_report = new DataTable();
        BindingSource bs_report = new BindingSource();

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

        private void rdu_betweensPrice_CheckedChanged(object sender, EventArgs e)
        {
            pnl_rangePrice.Top = tbx_toPrice.Top;
            pnl_rangePrice.Visible = rdu_betweensPrice.Checked;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string s_where = sqlConditionBuilder();

            try
            {
                dt_report = cls_accDoc.SearchAccDoc(s_where);
                bs_report.DataSource = dt_report;
}
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = bs_report;

                DataGridViewTextBoxColumn accDoc_id = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn accDoc_date = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn accDoc_comment = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn accDocPrice = new DataGridViewTextBoxColumn();

                dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            accDoc_id, accDoc_date,accDoc_comment, accDocPrice});

                accDoc_id.DataPropertyName = "accDoc_id";
                accDoc_id.HeaderText = "شماره ســـند";
                accDoc_id.Name = "accDoc_id";
                accDoc_id.Width = 50;
                accDoc_id.ReadOnly = true;

                accDoc_date.DataPropertyName = "accDoc_date";
                accDoc_date.HeaderText = "تاریخ ســـند";
                accDoc_date.Name = "accDoc_date";
                accDoc_date.ReadOnly = true;

                accDoc_comment.DataPropertyName = "accDoc_comment";
                accDoc_comment.HeaderText = "توضیحات ســـند";
                accDoc_comment.Name = "accDoc_comment";
                accDoc_comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                accDoc_comment.ReadOnly = true;

                accDocPrice.DataPropertyName = "accDocPrice";
                accDocPrice.HeaderText = "مبلغ ســـند";
                accDocPrice.Name = "accDocPrice";
                accDocPrice.ReadOnly = true;

                if (bs_report.Count > 0)
                {
                    btn_modify.Enabled = true;
                }
            }

        private string sqlConditionBuilder()
        {
            string s_sqlWhereExpresstion = "";
            string s_fieldName = "";
            string s_condition = "";
            string s_value = "";
            string s_value2 = "";
            
            if (tabControl1.SelectedIndex == 0)//جستجو بر اساس شماره سند
            {
                s_fieldName = "tbl_accDocs.accDoc_id";
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
                else if (rdu_allAccDocs.Checked)
                {
                    s_condition = "";
                    s_value = "";
                    
                }
            }
            else if (tabControl1.SelectedIndex == 1)//جستجو بر اساس تاریخ سند
            {
                s_fieldName = "tbl_accDocs.accDoc_date";
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
            else if (tabControl1.SelectedIndex == 2)//جستجو بر اساس مبلغ سند
            {
                s_fieldName = "SUM(dbo.tbl_accDocRows.accDocRow_indebted)";
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
            else if (tabControl1.SelectedIndex == 3)//جستجو بر اساس توضیحات
            {
                s_fieldName = "tbl_accDocs.accDoc_comment LIKE '%";
                s_value = tbx_commend.Text + "%'";
            }

            if ((rdu_betweensNumber.Checked && tabControl1.SelectedIndex == 0) || (rdu_betweensDate.Checked && tabControl1.SelectedIndex == 1) || (rdu_betweensPrice.Checked && tabControl1.SelectedIndex == 2))
            {
                s_sqlWhereExpresstion = " ({0} between {1} AND {2}) ";
                s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_fieldName, s_value, s_value2);
            }
            else if (tabControl1.SelectedIndex == 0 && rdu_allAccDocs.Checked)
            {
                s_sqlWhereExpresstion = "";
            }
            else
            {
                s_sqlWhereExpresstion = " ({0}{1}{2})";
                s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_fieldName, s_condition, s_value);
            }
    
            return s_sqlWhereExpresstion;
        }

        private void frm_accDocExplorer_Load(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            try
            {
                cls_invoices _invoices = new cls_invoices();
                int n_accDoc_id = (int)dt_report.Rows[bs_report.Position]["accDoc_id"];
                int n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.buyInvoice);
                if (n_invoice_id != -1)
                {
                    frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                    _invoiceBuy.openForModify = true;
                    _invoiceBuy.openForReturnSellInvoice = false;
                    _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                    _invoiceBuy.ShowDialog();

                    //prepareTheReport();
                }
                n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.sellInvoice);
                if (n_invoice_id != -1)
                {
                    frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                    _invoiceSell.openForModify = true;
                    _invoiceSell.openForReturnBuyInvoice = false;
                    _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                    _invoiceSell.ShowDialog();

                    //prepareTheReport();
                }
                n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.unBuyInvoice);
                if (n_invoice_id != -1)
                {
                    frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                    _invoiceSell.openForModify = true;
                    _invoiceSell.openForReturnBuyInvoice = true;
                    _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                    _invoiceSell.ShowDialog();

                    //prepareTheReport();
                }
                n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.unSellInvoice);
                if (n_invoice_id != -1)
                {
                    frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                    _invoiceBuy.openForModify = true;
                    _invoiceBuy.openForReturnSellInvoice = true;
                    _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                    _invoiceBuy.ShowDialog();

                    //prepareTheReport();
                }
                n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.wastedInvoice);
                if (n_invoice_id != -1)
                {
                    frm_invoicesWasted _invoiceWasted = new frm_invoicesWasted();
                    _invoiceWasted.openForModify = true;
                    _invoiceWasted.n_invoiceIDForModify = n_invoice_id;
                    _invoiceWasted.ShowDialog();

                    //prepareTheReport();
                }
                if (cls_accDoc.isThisFinActExist(n_accDoc_id))
                {
                    frm_finActions _finActs = new frm_finActions();
                    _finActs.openForModify = true;
                    _finActs.n_finAct_id_forModify = n_accDoc_id;
                    _finActs.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            string s_rowIdSelected = "";
            frm_reportPreview _reportPreview = new frm_reportPreview();

            _reportPreview.openMode = frm_reportPreview.reportType.rt_accDoc;
            try
            {
                s_rowIdSelected = dt_report.Rows[bs_report.Position]["accDoc_id"].ToString();
                _reportPreview.s_whereExpresstion = "tbl_accDocs.accDoc_id = " + s_rowIdSelected;

                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }

        }

        private void btn_printAll_Click(object sender, EventArgs e)
        {
            frm_reportPreview _reportPreview = new frm_reportPreview();

            _reportPreview.openMode = frm_reportPreview.reportType.rt_accDoc;
            _reportPreview.s_whereExpresstion = sqlConditionBuilder();

            _reportPreview.prepareTheReport();
            _reportPreview.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modify.PerformClick();
        }
    }
}
