using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Novin
{
    public partial class frm_issuseAccDoc : Novin.frm_FATHER
    {
        public frm_issuseAccDoc()
        {
            InitializeComponent();
        }       
        public enum invoiceType { buyInvoice = 1, sellInvoice, wastedInvoice, pensionForm };

        public long n_originalTotalMoney = 0;
        public long n_totalMoney = 0;
        public long n_cashMoney = 0;
        public long n_chequesMoney = 0;
        public long n_usedChequesMoney = 0;
        public long n_discountMoney = 0;
        public long n_indebtedMoney = 0;
        public long n_remainMoney = 0;
        public long n_transportPrice = 0;
        public string s_comment = "";
        long n_personRemainMoney = 0;
        long n_personCreditCiel = 0;
        
        private int n_personID;
        public int personID
        {
            get { return n_personID;}
            set { n_personID = value; }
        }

        private invoiceType enm_invoiceType;
        public invoiceType _invoiceType
        {
            get { return enm_invoiceType; }
            set { enm_invoiceType = value; }
        }

        private void reCalculateThePureMoney()
        {
            try
            {                                                                             
                n_totalMoney = n_originalTotalMoney + n_transportPrice;

                long n_pardakht = (Math.Abs( n_cashMoney) + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney);
                
                n_remainMoney =  n_totalMoney - n_pardakht;

                tbx_uesedChequesMoney.Text = n_usedChequesMoney.ToString();
                tbx_totalPaidMoney.Text = (n_cashMoney + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney).ToString();
                tbx_remainMoney.Text = n_remainMoney.ToString();
                tbx_totalMoney.Text = n_totalMoney.ToString();

                if (n_remainMoney > 0 || n_remainMoney < 0 || n_pardakht > n_totalMoney)
                {
                    btn_ok.Enabled = false;
                }
                else
                {
                    btn_ok.Enabled = true;
                }                
            }
            catch
            {
            }
        }

        private void btn_newCheque_Click(object sender, EventArgs e)
        {
            frm_cheques _cheques = new frm_cheques();
            if (enm_invoiceType == invoiceType.buyInvoice)
            {
                _cheques.theChequeIsMine = true;
            }
            else if (enm_invoiceType == invoiceType.sellInvoice)
            {
                _cheques.theChequeIsMine = false;
            }
            _cheques.isItPrimaryCycleCheques = false;
            _cheques.person_id = this.personID;
            _cheques.accDoc_id = cls_accDoc.accDoc_id;
            //_cheques._accDoc = _accDoc;
            if (_cheques.ShowDialog() == DialogResult.OK)
            {
                //ابتدا سند حسابداری ثبت میشود 
                cls_accDoc.saveTheAccDoc();
                //سپس چکهای تعریف شده
                _cheques.updateTheDatabase();
                tbx_chequesMoney.Text = _cheques.totalPrice.ToString();
            }
        }

        private void frm_issuseAccDoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_persons.tbl_persons' table. You can move, or remove it, as needed.
            this.tbl_personsTableAdapter.Fill(this.ds_persons.tbl_persons);

            //قرار دادن شماره سند ساخته شده در مکان مناسبش
            num_accDocNO.Value = cls_accDoc.accDoc_id;
            num_accDocNO.Minimum = num_accDocNO.Value;

            try
            {
                //تغییر موقعیت به شخص فعلی
                bs_persons.Position = bs_persons.Find("person_id", n_personID);
                //تعیین حد اعتبار طرف حساب
                n_personCreditCiel = (long)ds_persons.tbl_persons.Rows[bs_persons.Position]["person_creditCeil"];
                //تعیین مانده طرف حساب
                string s_moeen_id = "";
                s_moeen_id = ds_persons.tbl_persons.Rows[bs_persons.Position]["moeen_id"].ToString();
                n_personRemainMoney = cls_visitors.getPersonIndebtedOrCreditorMoney(s_moeen_id, "");
                if (n_personRemainMoney < 0)
                {
                    lbl_detect.Text = "بس";
                }
                else if (n_personRemainMoney > 0)
                {
                    lbl_detect.Text = "بد";
                }
                tbx_personRemainMoney.Text = (Math.Abs(n_personRemainMoney)).ToString();

                //display person face
                try
                {
                    byte[] arrPic = (byte[])(ds_persons.tbl_persons.Rows[bs_persons.Position]["person_pic"]); //(ds.Tables["Persons"].Rows[0]["Photo"]);
                    MemoryStream ms = new MemoryStream(arrPic);
                    pic_personFace.Image = Image.FromStream(ms);
                }
                catch
                {
                    pic_personFace.Image = null;
                }
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }

            //نشان دادن تاریخ جاری
            mTbx_accDocDate.Text = cls_accDoc.accDoc_date;           

            //مقدار دهی کادرهای متنی هنگام اصلاح فاکتورها
            tbx_totalMoney.Text = n_originalTotalMoney.ToString();
            tbx_discountMoney.Text = n_discountMoney.ToString();
            tbx_transportPrice.Text = n_transportPrice.ToString();
            tbx_cashMoney.Text = n_cashMoney.ToString();

            //بدست آوردن مبلغ چک های تعریف شده قبلی هنگام اصلاح فاکتور
            int n_accDoc_id =(int) num_accDocNO.Value;
            long n_chequesTotalPrice = frm_cheques.getSumOfChequesPrice(n_accDoc_id);
            tbx_chequesMoney.Text = n_chequesTotalPrice.ToString();

            reCalculateThePureMoney();

            if (_invoiceType == invoiceType.pensionForm)
            {
                pnl_transferMoneySet.Visible = false;
                tbx_discountMoney.Enabled = false;
                tbx_indebtedMoney.Enabled = false;
            }

            if (n_personRemainMoney > 0 && n_personRemainMoney >= n_personCreditCiel && n_personCreditCiel > 0)
            {
                cls_msgBox.show("مبلغ بدهکاری این طرف حساب از حد اعتبارش بیشتر شده است");
                return;
            }
        }
      
        private void tbx_cashMoney_TextChanged(object sender, EventArgs e)
        {
            if (tbx_cashMoney.Text.Trim() == "")
            {
                tbx_cashMoney.Text = "0";
            }
            try
            {
                n_cashMoney = Convert.ToInt64(tbx_cashMoney.Text);
            }
            catch { }
            reCalculateThePureMoney();            
        }

        private void tbx_chequesMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_chequesMoney.Text.Trim() == "")
            {
                tbx_chequesMoney.Text = "0";
            }
            try
            {
                n_chequesMoney = Convert.ToInt64(tbx_chequesMoney.Text);
            }
            catch { }
            if (n_chequesMoney > n_totalMoney)
            {
                errorProvider1.SetError(tbx_chequesMoney, "مبلغ وارد شده بیشتر از مبلغ فاکتور است");
            }
            else
            {
                errorProvider1.SetError(tbx_chequesMoney, "");
            }
            reCalculateThePureMoney();
        }

        private void tbx_uesedChequesMoney_TextChanged(object sender, EventArgs e)
        {           
            if (tbx_uesedChequesMoney.Text.Trim() == "")
            {
                tbx_uesedChequesMoney.Text = "0";
            }
            reCalculateThePureMoney();
        }

        private void tbx_discountMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_discountMoney.Text.Trim() == "")
            {
                tbx_discountMoney.Text = "0";
            }
            try
            {
                n_discountMoney = Convert.ToInt64(tbx_discountMoney.Text);
            }
            catch { }
            reCalculateThePureMoney();
        }

        private void tbx_indebtedMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_indebtedMoney.Text.Trim() == "")
            {
                tbx_indebtedMoney.Text = "0";
            }
            try
            {
                n_indebtedMoney = Convert.ToInt64(tbx_indebtedMoney.Text);
            }
            catch { }
            reCalculateThePureMoney();
        }

        

        private void tbx_cashMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_cashMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_discountMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_discountMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_indebtedMoney_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tbx_indebtedMoney.Text = n_remainMoney.ToString();
            }
        }

        private void tbx_transportPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbx_transportPrice.Text.Trim() == "")
            {
                tbx_transportPrice.Text = "0";
            }
            try
            {
                n_transportPrice = Convert.ToInt64(tbx_transportPrice.Text);
            }
            catch { }
            reCalculateThePureMoney();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {            
            int n_personID = (int)ds_persons.tbl_persons[bs_persons.Position]["person_id"];
            string s_sqlCommand = "update   dbo.tbl_cheques    set  dbo.tbl_cheques.person_id = {0} where      dbo.tbl_cheques.chq_id = {1}";
            s_sqlCommand = string.Format(s_sqlCommand, n_personID, num_accDocNO.Value.ToString());
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            _mydal.connect();
            _mydal.doCommandScalar(s_sqlCommand);
            _mydal.disconnect();
        }

        private void tbx_cashMoney_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_transportPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_discountMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void tbx_indebtedMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return;
            long isNumber = 0;

            e.Handled = !long.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void btn_showPersonLedger_Click(object sender, EventArgs e)
        {
            try
            {
                //frm_reportPreview _reportPreview = new frm_reportPreview();
                //string s_MOEEN_id = "";
                //s_MOEEN_id = ds_persons.tbl_persons.Rows[bs_persons.Position]["MOEEN_id"].ToString();

                //_reportPreview.openMode = frm_reportPreview.reportType.rt_smallLedger;
                //_reportPreview.s_MOEEN_id = s_MOEEN_id;
                //_reportPreview.s_whereExpresstion = "";
                //_reportPreview.s_whereExpresstionForPriorTotals = "";
                //_reportPreview.prepareTheReport();
                //_reportPreview.ShowDialog();
                frm_books _books = new frm_books();
                _books.rdu_smallLedger.Checked = true;
                _books.chk_personsMoeenOnly.Checked = true;
                _books.ShowDialog();
            }
            catch(Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void chk_personHisory_CheckedChanged(object sender, EventArgs e)
        {
            grp_personHistorySet.Visible = chk_personHisory.Checked;
        }

        private void frm_issuseAccDoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Right)
                {
                    btn_showPersonLedger.PerformClick();
                }
                else if (e.KeyCode == Keys.Left)
                {
                    chk_personHisory.Checked = !chk_personHisory.Checked;
                }
                else if (e.KeyCode == Keys.Space)
                {
                    tbx_cashMoney.Focus();
                }
            }
        }

        private void num_personDiscountPercent_ValueChanged(object sender, EventArgs e)
        {
            tbx_discountMoney.Text = (n_originalTotalMoney * (int)num_personDiscountPercent.Value / 100).ToString();
            reCalculateThePureMoney();
        }

    }
}
