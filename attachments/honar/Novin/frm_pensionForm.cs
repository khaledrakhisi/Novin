using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_pensionForm : Novin.frm_FATHER
    {
        public frm_pensionForm()
        {
            InitializeComponent();
        }

        private void newPensionForm()
        {
            int n_person_id = 0;
            n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];

            //ساختن سند به صورت موقت در حافظه
            cls_accDoc.createAccDoc(false);

            DataRow row_accDoc;
            row_accDoc = ds_pensionForms.tbl_accDocs.NewRow();
            if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
            {
                row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                row_accDoc["accDoc_price"] = 0;
                row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
            }
            ds_pensionForms.tbl_accDocs.Rows.Add(row_accDoc);

            DataRow row_newPensionForm;
            row_newPensionForm = ds_pensionForms.tbl_pensionForms.NewRow();
            row_newPensionForm["pension_id"] = cls_pensionForms.getNextPensionFormID(); //
            row_newPensionForm["accDoc_id"] = cls_accDoc.accDoc_id;//
            row_newPensionForm["person_id"] = n_person_id; //
            row_newPensionForm["pension_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//            
            row_newPensionForm["pension_baseMoney"] = 0;//
            row_newPensionForm["pension_overtimeMoney"] = 0;//
            row_newPensionForm["pension_taxMoney"] = 0;//
            row_newPensionForm["pension_insuranceMoney"] = 0;//
            row_newPensionForm["pension_workedDays"] = 0;//
            row_newPensionForm["pension_overtimeHours"] = 0;//
            ds_pensionForms.tbl_pensionForms.Rows.Add(row_newPensionForm);

            bs_pensionForms.MoveLast();

            //b_theInvoiceHasBeenSaved = false;
        }

        private void frm_pensionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_pensionsDetracts' table. You can move, or remove it, as needed.
            this.tbl_pensionsDetractsTableAdapter.Fill(this.ds_pensionForms.tbl_pensionsDetracts);
            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_pensionForms' table. You can move, or remove it, as needed.
            this.tbl_pensionFormsTableAdapter.Fill(this.ds_pensionForms.tbl_pensionForms);
            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_pensionForms.tbl_persons);
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.            

        }

        private void btn_newPensionForm_Click(object sender, EventArgs e)
        {
            newPensionForm();
        }
    }
}
