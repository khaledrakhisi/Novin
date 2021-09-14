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
        private bool b_isItPrimaryCycle;
        public bool isItPrimaryCycle
        {
            get { return b_isItPrimaryCycle; }
            set { b_isItPrimaryCycle = value; }
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
            //bs_cheques.Filter = "";

            this.Validate();
            bs_cheques.EndEdit();
            tbl_chequesTableAdapter.Update(ds_cheques.tbl_cheques);

            showTheChequesTotalPrice();//in fact set the 'totalPrice' property

            //b_dataHasChanged = false;
        }

        private void frm_cheques_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);
            // TODO: This line of code loads data into the 'ds_cheques.tbl_chqStates' table. You can move, or remove it, as needed.
            this.tbl_chqStatesTableAdapter.Fill(this.ds_cheques.tbl_chqStates);
            // TODO: This line of code loads data into the 'ds_accounts.tbl_accounts' table. You can move, or remove it, as needed.
            this.tbl_accountsTableAdapter.Fill(this.ds_accounts.tbl_accounts);            
            // TODO: This line of code loads data into the 'ds_accounts.tbl_banks' table. You can move, or remove it, as needed.
            this.tbl_banksTableAdapter.Fill(this.ds_accounts.tbl_banks);
            // TODO: This line of code loads data into the 'ds_cheques.tbl_cheques' table. You can move, or remove it, as needed.
            this.tbl_chequesTableAdapter.Fill(this.ds_cheques.tbl_cheques);

            DataRow row_accDoc;
            row_accDoc = ds_cheques.tbl_accDocs.NewRow();
            if (cls_accDoc.isThisAccDocExist(n_accDoc_id))
            {
                row_accDoc["accDoc_id"] = cls_accDoc.accDoc_id;
                row_accDoc["accDoc_price"] = 0;
                row_accDoc["accDoc_isItPerm"] = cls_accDoc.accDoc_isItPermenantly;
                row_accDoc["accDoc_comment"] = cls_accDoc.accDoc_comment;
                row_accDoc["accDoc_date"] = cls_accDoc.accDoc_date;
            }
            ds_cheques.tbl_accDocs.Rows.Add(row_accDoc);            

            bs_cheques.Filter = "accDoc_id = " + n_accDoc_id.ToString();
            
            if (theChequeIsMine)
            {              
                this.Text = "چــــــک پــــرداخــــتــی";                

                cmb_accounts.Visible = true;
                tbx_accountNumber.Visible = false;

                if (b_isItPrimaryCycle)
                {
                    bs_persons_from.Position = 0;
                    //bs_persons_to.Filter = "person_id > 1";
                    cbx_to.Enabled = true;
                }
                else
                {
                    bs_persons_from.Position = bs_persons_from.Find("person_id", 1);
                    bs_persons_to.Position = bs_persons_to.Find("person_id", n_person_id);
                }
            }
            else
            {
                this.Text = "چـــــــک دریــــافــــتـــی";

                //bs_cheques.Filter = "chq_isItMine = false";

                cmb_accounts.Visible = false;
                tbx_accountNumber.Visible = true;

                if (b_isItPrimaryCycle)
                {
                    bs_persons_from.Position = 0;
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
                }
            }

            showTheChequesTotalPrice();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int n_account_id = (int)ds_accounts.tbl_accounts.Rows[0]["account_id"];
                int n_bank_id = (int)ds_accounts.tbl_accounts.Rows[0]["bank_id"];

                DataRow row_newCheque;
                row_newCheque = ds_cheques.tbl_cheques.NewRow();

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
                row_newCheque["person_id"] = 1;//
                row_newCheque["account_id"] = n_account_id; //
                row_newCheque["bank_id"] = n_bank_id;
                row_newCheque["chqState_id"] = 1;//کارتن
                row_newCheque["chq_hisAccount"] = "";//
                row_newCheque["chq_number"] = "";//
                row_newCheque["chq_issDate"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newCheque["chq_usaDate"] = cls_numberConvertor.nowDateInAppropriateFormat();//
                row_newCheque["chq_isItMine"] = this.theChequeIsMine;//
                row_newCheque["chq_price"] = 0;//
                //drw_newCheque["chq_comment"] = "";//

                ds_cheques.tbl_cheques.Rows.Add(row_newCheque);

                bs_cheques.MoveLast();
                //bs_cheques.Position = bs_cheques.Find("chq_number", );                

                //b_dataHasChanged = true;

                showTheChequesTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bs_banks_CurrentChanged(object sender, EventArgs e)
        {
            bs_accounts.Filter = "bank_id = " + ds_accounts.tbl_banks.Rows[bs_banks.Position]["bank_id"].ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cls_msgBox.show("آیا از حذف کردن چک مطمئنید ؟", "", cls_msgBox.buttons.YesAndNo) == DialogResult.Yes)
            {
                {
                    bs_cheques.RemoveCurrent();

                    showTheChequesTotalPrice();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (bs_persons_to.Position == 0 && b_isItPrimaryCycle)
            {
                cls_msgBox.show("طرف حساب دیگری را انتخاب نمایید");
            }
            else
            {
                if (b_isItPrimaryCycle)
                {
                    updateTheDatabase();
                    showTheChequesTotalPrice();
                }
            }
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
            if (b_isItPrimaryCycle)
            {
                updateTheDatabase();                
            }
        }

        private void bs_cheques_CurrentChanged(object sender, EventArgs e)
        {
            //int n_fromPerson_id =(int) ds_cheques.tbl_cheques.Rows[bs_cheques.Position]["person_id"];
            //bs_persons_to.Position = bs_persons_to.Find("person_id", n_fromPerson_id); 
            updatePositionLabel();            
        }

        private void cbx_to_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bs_persons_to_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //ds_cheques.tbl_cheques.Rows[bs_cheques.Position]["person_id"] = (int)ds_persons.tbl_persons.Rows[bs_persons_to.Position]["person_id"];
            }
            catch
            {
            }
        }

        private void tbx_totalprice_TextChanged(object sender, EventArgs e)
        {
            
        }

      
    }
}
