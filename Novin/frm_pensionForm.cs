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

        private int n_pension_id = 0;
        private int n_person_id = 0;

        private void updateTheDatabase()
        {
            this.Validate();
            bs_pensionForms.EndEdit();
            tbl_pensionFormsTableAdapter.Update(ds_pensionForms.tbl_pensionForms);

            this.Validate();
            bs_pensDets.EndEdit();
            tbl_pensionsDetractsTableAdapter.Update(ds_pensionForms.tbl_pensionsDetracts);
        }

        private void upDateCurrentPositionLabel()
        {            
            if (bs_pensionForms.Count > 0)
            {
                lbl_currentPosition.Text = "فیش " + (bs_pensionForms.Position + 1).ToString() + " از " + bs_pensionForms.Count.ToString();                
            }
            else
            {
                lbl_currentPosition.Text = "*****";
            }
        }

        private void enableControls(bool bEnable)
        {
            try
            {
                pnl_wholeForm.Enabled = bEnable;
                btn_saveChanges.Enabled = bEnable;
                btn_printForm.Enabled = bEnable;
                btn_deletePensionForm.Enabled = bEnable;
                //btn_nextPensionForm.Enabled = bEnable;
                //btn_priorPensionForm.Enabled = bEnable;
                mTbx_pensionDate.Enabled = bEnable;
            }
            catch
            {
            }
        }

        private void recalculateThePension()
        {
            long n_addedPensSum = 0;
            long n_addedDetsSum = 0;
            long n_purePension = 0;
            long n_basePension = 0;
            long n_pentionsSum = 0;
            long n_detractsSum = 0;
            long n_overTimeMoney = 0;
            long n_insuranceMoney = 0;
            long n_taxMoney = 0;
            
            try
            {
                n_basePension = Convert.ToInt64(tbx_basePensionPrice.Text);
            }
            catch
            {
            }

            try
            {
                n_overTimeMoney = Convert.ToInt64(tbx_overtimePensionPrice.Text);
            }
            catch
            {
            }

            try
            {
                n_taxMoney = Convert.ToInt64(tbx_taxDetractPrice.Text);
            }
            catch
            {
            }

            try
            {
                n_insuranceMoney = Convert.ToInt64(tbx_insuranceDetractPrice.Text);
            }
            catch
            {
            }

            try
            {                
                n_addedDetsSum = (long)tbl_pensionsDetractsTableAdapter.getDetsTotalMoney(n_pension_id);
            }
            catch
            {
            }

            try
            {                
                n_addedPensSum = (long)tbl_pensionsDetractsTableAdapter.getPensTotalMoney(n_pension_id);
            }
            catch
            {
            }

            try
            {
                n_pentionsSum = (n_basePension + n_addedPensSum + n_overTimeMoney);
            }
            catch
            {                
            }

            try
            {
                n_detractsSum = (n_addedDetsSum + n_insuranceMoney + n_taxMoney);
            }
            catch
            {
            }

            try
            {
                tbx_taxDetractPrice.Text = (n_pentionsSum * (int)num_taxPercent.Value / 100).ToString();
            }
            catch
            {                
            }

            try
            {
                tbx_insuranceDetractPrice.Text = (n_pentionsSum * (int)num_insurancePercent.Value / 100).ToString();
            }
            catch
            {
            }
            
            n_purePension = n_pentionsSum - n_detractsSum;

            lbl_pensionsTotal.Text = n_pentionsSum.ToString();
            lbl_detractionsTotal.Text = n_detractsSum.ToString();

            lbl_purePensionINDigit.Text = n_purePension.ToString();
            lbl_purePensionINChars.Text = cls_numberConvertor.convertToChars(lbl_purePensionINDigit.Text);
        }

        private void newPensionForm()
        {            
            n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];
            n_pension_id = cls_pensionForms.getNextPensionFormID();

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
            row_newPensionForm["pension_id"] = n_pension_id; //
            row_newPensionForm["accDoc_id"] = cls_accDoc.accDoc_id;//
            row_newPensionForm["person_id"] = n_person_id; //
            row_newPensionForm["pension_date"] = cls_numberConvertor.nowDateInAppropriateFormat();//            
            row_newPensionForm["pension_baseMoney"] = 0;//
            row_newPensionForm["pension_overtimeMoney"] = 0;//
            row_newPensionForm["pension_taxPercent"] = 5;//
            row_newPensionForm["pension_taxMoney"] = 0;//
            row_newPensionForm["pension_insuranceMoney"] = 0;//
            row_newPensionForm["pension_insurancePercent"] = 7;//
            row_newPensionForm["pension_workedDays"] = 0;//
            row_newPensionForm["pension_overtimeHours"] = 0;//
            ds_pensionForms.tbl_pensionForms.Rows.Add(row_newPensionForm);

            bs_pensionForms.MoveLast();

            //b_theInvoiceHasBeenSaved = false;
        }

        private void frm_pensionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_pensionForms.tbl_persons);            
            try
            {
                n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];
            }
            catch
            {
            }

            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_pensionForms' table. You can move, or remove it, as needed.
            this.tbl_pensionFormsTableAdapter.Fill(this.ds_pensionForms.tbl_pensionForms, n_person_id);               
        }

        private void btn_newPensionForm_Click(object sender, EventArgs e)
        {
            if (bs_persons.Count == 0)
            {
                cls_msgBox.show("کارمندی به برنامه تعریف نکردید");
                btn_showPersonsForm.PerformClick();

                return;
            }
            newPensionForm();
            //btn_addDetractDef.PerformClick();
            enableControls(true);
        }

        private void tbx_basePensionPrice_TextChanged(object sender, EventArgs e)
        {
            recalculateThePension();
        }

        private void tbx_overtimePensionPrice_TextChanged(object sender, EventArgs e)
        {
            recalculateThePension();
        }

        private void num_taxPercent_ValueChanged(object sender, EventArgs e)
        {
            recalculateThePension();
        }

        private void num_insurancePercent_ValueChanged(object sender, EventArgs e)
        {
            recalculateThePension();
        }

        private void bs_pensionForms_CurrentChanged(object sender, EventArgs e)
        {
            upDateCurrentPositionLabel();

            try
            {
                n_pension_id = (int)ds_pensionForms.tbl_pensionForms.Rows[bs_pensionForms.Position]["pension_id"];
            }
            catch
            {
            }
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            recalculateThePension();
            try
            {
                n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];
                ds_pensionForms.tbl_pensionForms.Rows[bs_pensionForms.Position]["person_id"] = n_person_id;
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
                return;
            }
           
            cls_accDoc.saveTheAccDoc();

            //قبل از فراخوانی این متد باید قبلا سند حسابداری ثبت شده باشد
            updateTheDatabase();            

            frm_issuseAccDoc _issuseAccDoc = new frm_issuseAccDoc();
            _issuseAccDoc.personID = n_person_id;
            _issuseAccDoc.n_originalTotalMoney = Convert.ToInt64(lbl_purePensionINDigit.Text);
            _issuseAccDoc.n_cashMoney = 0;
            _issuseAccDoc.n_discountMoney = 0;
            _issuseAccDoc.n_transportPrice = 0;

            _issuseAccDoc._invoiceType = frm_issuseAccDoc.invoiceType.pensionForm;

            if (_issuseAccDoc.ShowDialog() == DialogResult.OK)
            {
                cls_accDoc.clearAccDocRows();

                //ساختن سطرهای سند حسابداری 
                {
                    string s_comment = "";
                    string s_moeen_id = "";
                    long n_money = 0;

                    s_moeen_id = "6010060";//هزینه حقوق                    
                    s_comment = "پرداخت بصورت نقد ";
                    n_money = _issuseAccDoc.n_cashMoney;
                    if (_issuseAccDoc.n_chequesMoney > 0)
                    {
                        s_comment += " چک ";
                        n_money = _issuseAccDoc.n_originalTotalMoney;
                    }
                   
                    cls_accDoc.addRow(s_moeen_id, s_comment, 0, n_money, 0, 0, 0);

                    if (_issuseAccDoc.n_cashMoney > 0)
                    {
                        s_moeen_id = "1010001";//صندوق
                        s_comment = "پرداخت حقوق پرسنل ";
                        n_money = _issuseAccDoc.n_cashMoney;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                    }
                    if (_issuseAccDoc.n_chequesMoney > 0)
                    {
                        s_moeen_id = "4020001";//اسناد پرداختی
                        s_comment = "پرداخت چک جهت حقوق پرسنل ";
                        n_money = _issuseAccDoc.n_chequesMoney;
                        cls_accDoc.addRow(s_moeen_id, s_comment, 0, 0, n_money, 0, 0);
                    }

                    cls_accDoc.accDoc_date = _issuseAccDoc.mTbx_accDocDate.Text;
                    //ثبت سند حسابداری
                    cls_accDoc.saveTheAccDoc();

                    //نمایش تائید
                    cls_msgBox.show("سند با شماره " + cls_accDoc.accDoc_id.ToString() + " به ثبت رسید ");
                }
            }
        }

        private void btn_nextPensionForm_Click(object sender, EventArgs e)
        {
            bs_pensionForms.MoveNext();
        }

        private void btn_priorPensionForm_Click(object sender, EventArgs e)
        {
            bs_pensionForms.MovePrevious();
        }

        private void bs_persons_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];
            }
            catch
            {
            }
            
            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_pensionForms' table. You can move, or remove it, as needed.
            this.tbl_pensionFormsTableAdapter.Fill(this.ds_pensionForms.tbl_pensionForms, n_person_id);

            if (bs_pensionForms.Count == 0)
            {
                enableControls(false);
            }
            else
            {
                enableControls(true);
            }

            try
            {
                n_pension_id = (int)ds_pensionForms.tbl_pensionForms.Rows[bs_pensionForms.Position]["pension_id"];
            }
            catch
            {
                n_pension_id = 0;
            }

            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_pensionsDetracts' table. You can move, or remove it, as needed.
            this.tbl_pensionsDetractsTableAdapter.Fill(this.ds_pensionForms.tbl_pensionsDetracts, n_pension_id);                        

            if(bs_pensionForms.Count > 0 )
            {
                //انتخاب سند 
                int n_accDoc_id = 0;                
                n_accDoc_id = (int)ds_pensionForms.tbl_pensionForms.Rows[bs_pensionForms.Position]["accDoc_id"];
                if (cls_accDoc.isThisAccDocExist(n_accDoc_id))//this line make the just added accDoc active
                {
                }

                //خالی کردن دیتا تیبل مربوط به سند حسابداری
                ds_pensionForms.tbl_accDocs.Clear();
            }
        }

        private void btn_deletePensionForm_Click(object sender, EventArgs e)
        {
            if (cls_msgBox.show("آیا از حذف کردن فیش حقوقی مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {               
                bs_pensionForms.RemoveCurrent();

                updateTheDatabase();
                //حذف سند فعال و فیش و تمامی چک ها            
                cls_accDoc.removeAnAccDoc();

                ds_pensionForms.tbl_accDocs.Clear();
            }
        }

        private void btn_addPension_Click(object sender, EventArgs e)
        {
            DataRow row_pen;
            row_pen = ds_pensionForms.tbl_pensionsDetracts.NewRow();
            if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
            {
                row_pen["penDet_id"] = cls_pensionForms.getNextPensionDetractID();
                row_pen["pension_id"] = n_pension_id;
                row_pen["penDet_penName"] = "مزایا";
                row_pen["penDet_penValue"] = 0;
                row_pen["penDet_detName"] = "-";
                row_pen["penDet_detValue"] = 0;
            }
            ds_pensionForms.tbl_pensionsDetracts.Rows.Add(row_pen);

            updateTheDatabase();
        }

        private void btn_addDetractDef_Click(object sender, EventArgs e)
        {
            DataRow row_pen;
            row_pen = ds_pensionForms.tbl_pensionsDetracts.NewRow();
            if (cls_accDoc.isThisAccDocExist(cls_accDoc.accDoc_id))//this line make the just added accDoc active
            {
                row_pen["penDet_id"] = cls_pensionForms.getNextPensionDetractID();
                row_pen["pension_id"] = n_pension_id;
                row_pen["penDet_penName"] = "-";
                row_pen["penDet_penValue"] = 0;
                row_pen["penDet_detName"] = "کسورات";
                row_pen["penDet_detValue"] = 0;
            }
            ds_pensionForms.tbl_pensionsDetracts.Rows.Add(row_pen);

            updateTheDatabase();
        }

        private void btn_deletePensionDef_Click(object sender, EventArgs e)
        {
            bs_pensDets.RemoveCurrent();
        }

        private void btn_deleteDetractDef_Click(object sender, EventArgs e)
        {
            bs_pensDets.RemoveCurrent();
        }

        private void btn_printForm_Click(object sender, EventArgs e)
        {
            frm_print _print = new frm_print();

            _print.s_reportFilePath = cls_myDataAccessLayer.s_pathRun + @"\rpt_pensionForm.rpt";
            //_print.s_paraName = "totalInChars";
            //_print.s_paraValue = cls_numberConvertor.convertToChars(n_invoiceTotalMoney.ToString()) + " ریال ";            

            _print.b_useDataset = true;
            _print.ds_report = ds_pensionForms;
            _print.ShowDialog();
        }

        private void btn_persons_Click(object sender, EventArgs e)
        {
            frm_persons frmPersons = new frm_persons();
            frmPersons.ShowDialog();

            // TODO: This line of code loads data into the 'ds_pensionForms.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_pensionForms.tbl_persons);
            try
            {
                n_person_id = (int)ds_pensionForms.tbl_persons.Rows[bs_persons.Position]["person_id"];
            }
            catch
            {
            }
        }

        private void cmb_familyAndName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lbl_purePensionINChars_Click(object sender, EventArgs e)
        {

        }
    }
}
