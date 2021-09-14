using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_chequesExplorer : Novin.frm_FATHER
    {
        public frm_chequesExplorer()
        {
            InitializeComponent();
        }
        private string sqlConditionBuilder()
        {
            bool b_existOR = false;
            string s_sqlWhereExpresstion = "WHERE        dbo.tbl_cheques.chq_isItMine = {0} ";
            string s_values = "";
            string s_values2 = "";

            //no filter
            if (!chbx_allCheques.Checked) return "";

            //by filter ==> chbx_allCheques.Checked = true
            if (chk_mineCheques.Checked == chk_notMineCheques.Checked)
            {
                s_sqlWhereExpresstion = "";
                if (chk_filterWithPerson.Checked)
                {
                    s_sqlWhereExpresstion = "WHERE        dbo.tbl_cheques.person_id = {0}";
                    s_values = ds_chqs.tbl_persons[bs_persons.Position]["person_id"].ToString();
                    b_existOR = true;
                }
            }
            else if (chk_notMineCheques.Checked)//daryafti
            {
                s_values = "0";

                //filterWithPerson
                if (chk_filterWithPerson.Checked) s_values += " AND (dbo.tbl_cheques.person_id = {0})";
                s_values = string.Format(s_values, ds_chqs.tbl_persons[bs_persons.Position]["person_id"].ToString());

                //darsorat filtershodan vazayat in motaghayer estefade mishavad
                b_existOR = true;
            }
            else if (chk_mineCheques.Checked)
            {
                s_values = "1";
                b_existOR = true;
            }

            //cheques Status
            if (!b_existOR && rdu_allChequesStates.Checked)
            {
                s_sqlWhereExpresstion = "";
            }
            else if (b_existOR && !rdu_allChequesStates.Checked)
            {
                s_sqlWhereExpresstion += " AND   ( dbo.tbl_chqStates.chqState_id = {1} )";
            }
            else if (!b_existOR )
            {
                s_sqlWhereExpresstion = "WHERE        dbo.tbl_chqStates.chqState_id = {0}{1}";
            }


            if (rdu_unUsedCheques.Checked)//وصول نشده
            {
                s_values2 = "2";
            }
            else if (rdu_usedCheques.Checked)//وصول شده
            {
                s_values2 = "1";
            }
            else if (rdu_returnedCheques.Checked)//برگشتی
            {
                s_values2 = "3";
            }

            s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, s_values, s_values2);
            
            return s_sqlWhereExpresstion;
        }

        private DataTable dt_ = new DataTable();
        private BindingSource bs_ = new BindingSource();

        private void initTheCheguesReport()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn chq_number = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn person_familyAndName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn chq_price = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn chequeType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn account_number = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn chq_stateTitle = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn bank_name = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn chq_comment = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            chq_number, person_familyAndName, chq_price, chequeType, account_number, bank_name, chq_stateTitle, chq_comment});

            chq_number.DataPropertyName = "chq_number";
            chq_number.HeaderText = "شماره چک";
            chq_number.Name = "chq_number";
            chq_number.Width = 50;
            chq_number.ReadOnly = true;

            person_familyAndName.DataPropertyName = "person_familyAndName";
            person_familyAndName.HeaderText = "طرف حساب";
            person_familyAndName.Name = "person_familyAndName";
            person_familyAndName.Width = 200;
            person_familyAndName.ReadOnly = true;

            chq_price.DataPropertyName = "chq_price";
            chq_price.HeaderText = "مبلغ چک";
            chq_price.Name = "chq_price";
            chq_price.Width = 80;
            chq_price.ReadOnly = true;

            chequeType.DataPropertyName = "chequeType";
            chequeType.HeaderText = "نوع چک";
            chequeType.Name = "chequeType";
            chequeType.Width = 60;
            chequeType.ReadOnly = true;
            

            account_number.DataPropertyName = "account_number";
            account_number.HeaderText = "شماره حساب بانکی";
            account_number.Name = "account_number";
            account_number.Width = 80;
            account_number.ReadOnly = true;

            chq_stateTitle.DataPropertyName = "chqState_title";
            chq_stateTitle.HeaderText = "وضعیت چک";
            chq_stateTitle.Name = "chqState_title";
            chq_stateTitle.Width = 100;
            chq_stateTitle.ReadOnly = true;

            bank_name.DataPropertyName = "bank_name";
            bank_name.HeaderText = "نام بانک";
            bank_name.Name = "bank_name";
            bank_name.Width = 80;
            bank_name.ReadOnly = true;

            chq_comment.DataPropertyName = "chq_comment";
            chq_comment.HeaderText = "توضیحات چک";
            chq_comment.Name = "chq_comment";
            chq_comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chq_comment.ReadOnly = true;
        }

        private void frm_chequesExplorer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_chqs.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_chqs.tbl_persons);
            // TODO: This line of code loads data into the 'ds_chqs.tbl_cheques' table. You can move, or remove it, as needed.
            this.tbl_chequesTableAdapter.Fill(this.ds_chqs.tbl_cheques);
            try
            {
                // TODO: This line of code loads data into the 'ds_chqs.tbl_persons' table. You can move, or remove it, as needed.
                this.tbl_personsTableAdapter.Fill(this.ds_chqs.tbl_persons);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }

            initTheCheguesReport();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string s_whereExpresstion = sqlConditionBuilder();

                dt_.Clear();
                dt_ = cls_cheques.viewCheques(s_whereExpresstion);

                bs_.DataSource = dt_;

                //initTheCheguesReport();

                dataGridView1.DataSource = bs_;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void chk_filterWithPerson_CheckedChanged(object sender, EventArgs e)
        {
            grp_personSet.Enabled = chk_filterWithPerson.Checked;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_print _frm_print = new frm_print();
            //_frm_print.s_reportFilePath = @"F:\Novin\Novin\rpt_chequesList.rpt";
            _frm_print.s_reportFilePath = cls_myDataAccessLayer.s_pathRun + @"\rpt_chequesList.rpt";
            _frm_print.dt_report = dt_;
            _frm_print.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cls_invoices _invoices = new cls_invoices();
                int n_accDoc_id = (int)dt_.Rows[bs_.Position]["accDoc_id"];
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
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void chbx_allCheques_CheckedChanged(object sender, EventArgs e)
        {
            gbx_allChegues.Enabled = chbx_allCheques.Checked;
        }
    }
}
