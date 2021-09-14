using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_issuseAccDoc : Novin.frm_FATHER
    {
        public frm_issuseAccDoc()
        {
            InitializeComponent();
        }       
        public enum invoiceType { buyInvoice = 1, sellInvoice, wastedInvoice };

        public long n_totalMoney = 0;
        public long n_cashMoney = 0;
        public long n_chequesMoney = 0;
        public long n_usedChequesMoney = 0;
        public long n_discountMoney = 0;
        public long n_indebtedMoney = 0;
        public long n_remainMoney = 0;        
        public string s_comment = "";

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
                n_cashMoney = Convert.ToInt64(tbx_cashMoney.Text);
                n_chequesMoney = Convert.ToInt64(tbx_chequesMoney.Text);
                n_discountMoney = Convert.ToInt64(tbx_discountMoney.Text);
                n_indebtedMoney = Convert.ToInt64(tbx_indebtedMoney.Text);

                n_remainMoney = n_totalMoney - (n_cashMoney + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney);

                tbx_uesedChequesMoney.Text = n_usedChequesMoney.ToString();
                tbx_totalPaidMoney.Text = (n_cashMoney + n_chequesMoney + n_usedChequesMoney + n_discountMoney + n_indebtedMoney).ToString();
                tbx_remainMoney.Text = n_remainMoney.ToString();

                if (n_remainMoney > 0 || n_remainMoney < 0)
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
            _cheques.isItPrimaryCycle = false;
            _cheques.person_id = this.personID;
            _cheques.accDoc_id = cls_accDoc.accDoc_id;
            //_cheques._accDoc = _accDoc;
            if (_cheques.ShowDialog() == DialogResult.OK)
            {
                //ابتدا سند حسابداری ثبت میشود سپس چکهای تعریف شده
                cls_accDoc.saveTheAccDoc();
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

            //نشان دادن تاریخ جاری
            mTbx_accDocDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();            

            //تغییر موقعیت به شخص فعلی
            bs_persons.Position = bs_persons.Find("person_id", n_personID);

            //
            tbx_totalMoney.Text = n_totalMoney.ToString();

            reCalculateThePureMoney();
        }
      
        private void tbx_cashMoney_TextChanged(object sender, EventArgs e)
        {
            if (tbx_cashMoney.Text == "")
            {
                tbx_cashMoney.Text = "0";
            }
            else if (tbx_cashMoney.Text == "0")
            {
                tbx_cashMoney.Text = tbx_cashMoney.Text.Replace("0", tbx_cashMoney.Text);
            }
            reCalculateThePureMoney();            
        }

        private void tbx_chequesMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_chequesMoney.Text == "")
            {
                tbx_chequesMoney.Text = "0";
            }
            reCalculateThePureMoney();
        }

        private void tbx_uesedChequesMoney_TextChanged(object sender, EventArgs e)
        {           
            if (tbx_uesedChequesMoney.Text == "")
            {
                tbx_uesedChequesMoney.Text = "0";
            }
            reCalculateThePureMoney();
        }

        private void tbx_discountMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_discountMoney.Text == "")
            {
                tbx_discountMoney.Text = "0";
            }
            reCalculateThePureMoney();
        }

        private void tbx_indebtedMoney_TextChanged(object sender, EventArgs e)
        {            
            if (tbx_indebtedMoney.Text == "")
            {
                tbx_indebtedMoney.Text = "0";
            }
            reCalculateThePureMoney();
        }

        private void tbx_cashMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbx_cashMoney_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void tbx_cashMoney_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tbx_cashMoney_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbx_discountMoney_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbx_indebtedMoney_KeyDown(object sender, KeyEventArgs e)
        {
           
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

    }
}
