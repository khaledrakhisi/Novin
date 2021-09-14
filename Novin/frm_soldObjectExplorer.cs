using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_soldObjectExplorer : Novin.frm_FATHER
    {
        public frm_soldObjectExplorer()
        {
            InitializeComponent();
        }
        DataTable dt_soldObject = new DataTable();
        BindingSource bs_soldObject = new BindingSource();

        private void chbx_object_CheckedChanged(object sender, EventArgs e)
        {
            cbx_object.Enabled = chbx_object.Checked;
        }

        private void chbx_person_CheckedChanged(object sender, EventArgs e)
        {
            cbx_persons.Enabled = chbx_person.Checked;
        }

        private void chbx_date_CheckedChanged(object sender, EventArgs e)
        {
            mTbx_fromDate.Enabled = chbx_date.Checked;
            mTbx_toDate.Enabled = chbx_date.Checked;
        }

        private void frm_soldObjectExplorer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.da_person.Fill(this.ds_persons.tbl_persons);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.da_object.Fill(this.ds_objectGrouping.tbl_objects);

        }

        private string sqlConditionBuilder()
        {
            string s_sqlWhereExpresstion = "";

            if (chbx_object.Checked)
            {
                s_sqlWhereExpresstion = " AND (tbl_objects.object_title = '{0}') ";
            }
            if (chbx_person.Checked)
            {
                s_sqlWhereExpresstion = " AND (tbl_persons.person_familyAndName = '{1}') ";
            }
            if (chbx_date.Checked)
            {
                s_sqlWhereExpresstion = " AND  (tbl_invoicesSell.invoiceSell_date BETWEEN '{2}' AND {3}) ";
            }

            s_sqlWhereExpresstion = string.Format(s_sqlWhereExpresstion, cbx_object.Text, cbx_persons.Text, mTbx_fromDate, mTbx_toDate);
            return s_sqlWhereExpresstion;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string s_where; 
            string s_whereAsly = "WHERE        (tbl_invoicesSell.invoiceSell_kind = 1) ";

            s_where = sqlConditionBuilder();
            if (s_where != "" )
                s_whereAsly += s_where;

            dt_soldObject = cls_invoices.searchObject(s_whereAsly);
            bs_soldObject.DataSource = dt_soldObject;

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bs_soldObject;

            DataGridViewTextBoxColumn invoiceSell_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn objectTitle = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn person_familyAndName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoiceSell_date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoiceSell_totalPrice = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn invoiceSell_comment = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            invoiceSell_id, person_familyAndName,objectTitle, invoiceSell_totalPrice, invoiceSell_date, invoiceSell_comment});

            invoiceSell_id.DataPropertyName = "invoiceSell_id";
            invoiceSell_id.HeaderText = "شماره فاکتور";
            invoiceSell_id.Name = "invoiceSell_id";
            invoiceSell_id.Width = 50;
            invoiceSell_id.ReadOnly = true;

            objectTitle.DataPropertyName = "objectTitle";
            objectTitle.HeaderText = "نام کالا";
            objectTitle.Name = "objectTitle";
            objectTitle.ReadOnly = true;
            objectTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            person_familyAndName.DataPropertyName = "person_familyAndName";
            person_familyAndName.HeaderText = "نام طرف حساب";
            person_familyAndName.Name = "person_familyAndName";
            person_familyAndName.ReadOnly = true;

            invoiceSell_date.DataPropertyName = "invoiceSell_date";
            invoiceSell_date.HeaderText = "تاریخ فاکتور";
            invoiceSell_date.Name = "invoiceSell_date";
            invoiceSell_date.ReadOnly = true;

            invoiceSell_totalPrice.DataPropertyName = "invoiceSell_totalPrice";
            invoiceSell_totalPrice.HeaderText = "مبلغ فاکتور";
            invoiceSell_totalPrice.Name = "invoiceSell_totalPrice";
            invoiceSell_totalPrice.ReadOnly = true;

            invoiceSell_comment.DataPropertyName = "invoiceSell_comment";
            invoiceSell_comment.HeaderText = "مبلغ فاکتور";
            invoiceSell_comment.Name = "invoiceSell_comment";
            invoiceSell_comment.ReadOnly = true;

            if (bs_soldObject.Count > 0)
            {
                btn_showInvoice.Enabled = true;
            }
        }

        private void btn_showInvoice_Click(object sender, EventArgs e)
        {

        }
    }
}
