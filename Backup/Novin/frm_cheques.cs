using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_cheques : Novin.frm_FATHER
    {
        public frm_cheques()
        {
            InitializeComponent();

            n_person_id = 1;
            n_totalPrice = 0;
        }        

        private bool b_theChequeIsMine;
        public bool theChequeIsMine
        {
            get { return b_theChequeIsMine; }
            set { b_theChequeIsMine = value; }
        }
        private int n_person_id;
        public int person_id
        {
            get { return n_person_id; }
            set { n_person_id = value; }
        }
        private bool b_isItPrimaryCycleCheques;
        public bool isItPrimaryCycleCheques
        {
            get { return b_isItPrimaryCycleCheques; }
            set { b_isItPrimaryCycleCheques = value; }
        }
        private int n_accDoc_id;
        public int accDoc_id
        {
            get { return n_accDoc_id; }
            set { n_accDoc_id = value; }
        }
        private int n_totalPrice;
        public int totalPrice
        {
            get { return n_totalPrice; }            
        }
        public static long getSumOfChequesPrice(int n_accDoc_id)
        {
            long n_sumOfChequesPrice = 0;
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            try
            {
                n_sumOfChequesPrice = (long)_mydal.doCommandScalar("select max(chq_price) from tbl_cheques where accDoc_id = " + n_accDoc_id);
            }
            catch
            {
            }
            _mydal.disconnect();

            return n_sumOfChequesPrice;
        }

        private void updatePositionLabel()
        {
            lbl_currentChequePosition.Text = "چک " + (bs_cheques.Position + 1).ToString() + " از " + bs_cheques.Count.ToString();            
        }

        private void showTheChequesTotalPrice()
        {
            try
            {
                n_totalPrice = (int)tbl_chequesTableAdapter.getSumOfChequesPrice(n_accDoc_id);
            }
            catch
            {
                n_totalPrice = 0;
            }
            finally
            {
                tbx_chequesTotal.Text = cls_numberConvertor.splitNumber(n_totalPrice.ToString(), false);
            }            
        }

        public void updateTheDatabase()
        {
            this.Validate();
            bs_cheques.EndEdit();
            tbl_chequesTableAdapter.Update(ds_chqs.tbl_cheques);

            showTheChequesTotalPrice();//in fact set the 'totalPrice' property

            //b_dataHasChanged = false;
        }

        private void frm_cheques_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_chqs.tbl_chqStates' table. You can move, or remove it, as needed.
            this.tbl_chqStatesTableAdapter.Fill(this.ds_chqs.tbl_chqStates);
            // TODO: This line of code loads data into the 'ds_chqs.tbl_cheques' table. You can move, or remove it, as needed.
            this.tbl_chequesTableAdapter.FillBy(this.ds_chqs.tbl_cheques, n_accDoc_id);
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);            
            // TODO: This line of code loads data into the 'ds_accounts.tbl_accounts' table. You can move, or remove it, as needed.
            this.tbl_accountsTableAdapter.FillWithoutCash(this.ds_accounts.tbl_accounts);            
            // TODO: This line of code loads data into the 'ds_accounts.tbl_banks' table. You can move, or remove it, as needed.
            this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);

            DataRow row_accDoc;
            row_accDoc = ds_chqs.tbl_accDocs.NewRow();
            if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
            {
                row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                row_accDoc["accDoc_price"] = 0;
                row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
            }
            ds_chqs.tbl_accDocs.Rows.Add(row_accDoc);            

            //bs_cheques.Filter = "accDoc_id = " + n_accDoc_id.ToString();

            if (theChequeIsMine)
            {
                this.Text = "چــــــک پــــرداخــــتــی";

                cmb_accounts.Visible = true;
                tbx_accountNumber.Visible = false;

                if (b_isItPrimaryCycleCheques)
                {
                    cbx_to.Enabled = true;
                    //bs_persons_from.Position = 0;
                    try
                    {
                        int n_person_to_id = (int)ds_chqs.tbl_cheques.Rows[bs_cheques.Position]["person_id"];
                        bs_persons_to.Position = bs_persons_to.Find("person_id", n_person_to_id);
                    }
                    catch
                    {
                    }
                }
                else
                {
                    bs_persons_from.Position = bs_persons_from.Find("person_id", 1);
                    bs_persons_to.Position = bs_persons_to.Find("person_id", n_person_id);

                    btn_showPersonForm.Visible = false;
                }
            }
            else
            {
                this.Text = "چـــــــک دریــــافــــتـــی";

                //bs_cheques.Filter = "chq_isItMine = false";

                cmb_accounts.Visible = false;
                tbx_accountNumber.Visible = true;

                if (b_isItPrimaryCycleCheques)
                {
                    try
                    {
                        int n_person_to_id = (int)ds_chqs.tbl_cheques.Rows[bs_cheques.Position]["person_id"];
                        bs_persons_to.Position = bs_persons_to.Find("person_id", n_person_to_id);
                    }
                    catch
                    {
                    }
                    //bs_persons_from.Position = 0;
                    //bs_persons_to.Filter = "person_id > 1";
                    cbx_to.Enabled = true;

                    //swap the persons comboboxes
                    int n_label_y = lbl_from.Top;
                    lbl_from.Top = lbl_to.Top;
                    lbl_to.Top = n_label_y;
                }
                else
                {
                    bs_persons_from.Position = bs_persons_from.Find("person_id", n_person_id);
                    bs_persons_to.Position = bs_persons_to.Find("person_id", 1);

                    btn_showPersonForm.Visible = false;
                }
            }

            showTheChequesTotalPrice();
            bs_cheques_CurrentChanged(null, null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (bs_accounts.Count <= 0)
                {
                    cls_msgBox.show("حساب بانکی تعریف نکرده اید");
                    btn_showAccountsForm_Click(null, null);
                    return;
                }

                if (bs_banks.Count <= 0)
                {
                    cls_msgBox.show("بانکی تعریف نکرده اید");
                    btn_showAccountsForm.PerformClick();
                    return;
                }
                int n_account_id = 0;
                try
                {
                    n_account_id = (int)ds_accounts.tbl_accounts.Rows[0]["account_id"];
                }
                catch (Exception ex)
                {
                    cls_msgBox.show(ex.Message);
                }

                int n_bank_id = (int)ds_accounts.tbl_accounts.Rows[0]["bank_id"];

                DataRow row_newCheque;
                row_newCheque = ds_chqs.tbl_cheques.NewRow();

                ////drw_newCheque["chq_id"] = 1;
                ////اگر در اول دوره باشیم و کاربر بخواهد چک دریافتی صادر کند
                ////از آنجایی که هر چک باید متعلق به یک سند حسابداری باشد 
                ////حتما باید آن چک دریافتی متعلق به سند شماره 1 باشد
                //if (b_isItPrimaryCycle && !b_theChequeIsMine)
                //{
                //    row_newCheque["accDoc_id"] = 1;
                //}
                ////اگر چک پرداختی در اول دوره صادر شود حتما باید متعلق به سند شماره 2 باشد                 
                //else if (b_isItPrimaryCycle && b_theChequeIsMine)
                //{
                //    row_newCheque["accDoc_id"] = 2;
                //}
                ////در غیر این صورت اگر چک صادر شده در اول دوره نباشد و چه پرداختی باشد یا دریافتی شماره سند باید فرستاده شود
                //else
                //{                    
                //    row_newCheque["accDoc_id"] = n_accDoc_id;
                //}
                
                row_newCheque["accDoc_id"] = n_accDoc_id;
                row_newCheque["person_id"] = n_person_id;//pakhsh bahrami
                row_newCheque["account_id"] = n_account_id; //
                row_newCheque["bank_id"] = n_bank_id;
                row_newCheque["chqState_id"] = 1;//
                row_newCheque["chq_hisAccount"] = "";//
                row_newCheque["chq_number"] = "";//
                row_newCheque["chq_issDate"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newCheque["chq_usaDate"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newCheque["chq_isItMine"] = this.theChequeIsMine;//
                row_newCheque["chq_price"] = 0;//
                //drw_newCheque["chq_comment"] = "";//

                ds_chqs.tbl_cheques.Rows.Add(row_newCheque);

                updateTheDatabase();

                bs_cheques.MoveLast();

                showTheChequesTotalPrice();

                btn_add.Enabled = false;
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void bs_banks_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                bs_accounts.Filter = "bank_id = " + ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_id"].ToString();
            }
            catch
            {
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (bs_cheques.Count <= 0) return;
            if (cls_msgBox.show("آیا از حذف کردن چک مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {
                {
                    bs_cheques.RemoveCurrent();

                    showTheChequesTotalPrice();

                    btn_add.Enabled = true;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (bs_persons_to.Count <= 1)
            {
                cls_msgBox.show("طرف حسابی تعریف نشده است");
                btn_showPersonForm.PerformClick();
                return;
            }

            //اگر فرم چک ها از طریق منوی اول دوره و سپس چکهای پرداختی یا دریافتی باز شده باشد شرکت پخش بهرامی نباید انتخاب شده باشد
            if (bs_persons_to.Position == 0 && b_isItPrimaryCycleCheques)
            {
                if (bs_cheques.Count > 0)
                {
                    cls_msgBox.show("طرف حساب دیگری را انتخاب نمایید");
                    return;
                }
            }
            updateTheDatabase();
            showTheChequesTotalPrice();

            btn_add.Enabled = true;
        }

        private void btn_nextCheque_Click(object sender, EventArgs e)
        {
            bs_cheques.MoveNext();
        }

        private void btn_priorCheque_Click(object sender, EventArgs e)
        {
            bs_cheques.MovePrevious();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (bs_persons_to.Count <= 1)
            {
                cls_msgBox.show("طرف حسابی تعریف نشده است");
                btn_showPersonForm.PerformClick();
                return;
            }

            //اگر فرم چک ها از طریق منوی اول دوره و سپس چکهای پرداختی یا دریافتی باز شده باشد شرکت پخش بهرامی نباید انتخاب شده باشد
            if (bs_persons_to.Position == 0 && b_isItPrimaryCycleCheques)
            {
                if (bs_cheques.Count > 0)
                {
                    cls_msgBox.show("طرف حساب دیگری را انتخاب نمایید");
                    return;
                }
            }

            btn_edit.PerformClick();
            Close();
        }

        private void bs_cheques_CurrentChanged(object sender, EventArgs e)
        {
            updatePositionLabel();
            if (bs_cheques.Count == 0)
            {
                grp_chqInformationSet.Enabled = false;
            }
            else
            {
                grp_chqInformationSet.Enabled = true;
            }
                        
        }

        private void cbx_to_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bs_persons_to_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //ds_chqs.tbl_cheques.Rows[bs_cheques.Position]["person_id"] = (int)ds_persons.tbl_persons.Rows[bs_persons_to.Position]["person_id"];
            }
            catch
            {
            }
        }

        private void tbx_totalprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbl_priceToChare.Text = cls_numberConvertor.convertToChars(tbx_totalprice.Text) + " " + "ريال";

            }
            catch (Exception)
            {
                
                throw;
            }
        }

       private void preToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_priorCheque.PerformClick();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_edit.PerformClick();
        }

        private void saveexitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_ok.PerformClick();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_delete.PerformClick();
        }

        private void nextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_nextCheque_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbx_help.Visible = !gbx_help.Visible;
        }

        private void bs_cheques_CurrentChanged_1(object sender, EventArgs e)
        {
            
        }

        private void tbx_totalprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void btn_showAccountsForm_Click(object sender, EventArgs e)
        {
            frm_accounts _frm_accounts = new frm_accounts();
            _frm_accounts.ShowDialog();

            // TODO: This line of code loads data into the 'ds_accounts.tbl_accounts' table. You can move, or remove it, as needed.
            this.tbl_accountsTableAdapter.FillWithoutCash(this.ds_accounts.tbl_accounts);
            // TODO: This line of code loads data into the 'ds_accounts.tbl_banks' table. You can move, or remove it, as needed.
            this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);
        }

        private void btn_showPersonForm_Click(object sender, EventArgs e)
        {
            
            frm_persons frmPersons = new frm_persons();
            frmPersons.ShowDialog();
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons); 
        }

        private void mTbx_usanceDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                mTbx_issuseDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                mTbx_issuseDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
            }
        }

        private void frm_cheques_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (b_isItPrimaryCycleCheques && !cls_accDoc.isItPrimaryCycle)
            {
                if (cls_accDoc.isThisAccDocExist(1))
                {
                    //در اینجا باید سطرهای سندهای افتتاحیه باید از اول ساخته بشوند
                    frm_primaryCycleEnd _primaryCycleEnd = new frm_primaryCycleEnd();
                    _primaryCycleEnd.frm_primaryCycleEnd_Load(null, null);
                    _primaryCycleEnd.issuseFirstAndSecondAccdoc();
                }
            }
        }

        private void cbx_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_persons_from.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_persons_from.DataMember;
                frmFindRecords.listDisplayMember = "person_FamilyAndName";
                frmFindRecords.listValueMember = "person_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_persons_from.Find("person_id", frmFindRecords.foundRecordID);
                        bs_persons_from.Position = nPosition;
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

        private void cbx_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_persons_to.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_persons_to.DataMember;
                frmFindRecords.listDisplayMember = "person_FamilyAndName";
                frmFindRecords.listValueMember = "person_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_persons_to.Find("person_id", frmFindRecords.foundRecordID);
                        bs_persons_to.Position = nPosition;
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

      
    }
}
