using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_master : Form
    {
        public frm_master()
        {
            InitializeComponent();
        }

        private void enableDisableMenues(bool b_enable)
        {
            mnu_actions.Enabled = b_enable;
            mnu_reports.Enabled = b_enable;
            mnu_preferences_stores.Enabled = b_enable;
            mnu_preferences_SARFASL.Enabled = b_enable;
            mnu_tools.Enabled = b_enable;
            mnu_help.Enabled = b_enable;
        }

        private void frm_master_Resize(object sender, EventArgs e)
        {
            lbl_cactusTitle.Width = this.Width - 40;

            //pnl_companyIcon.Left = lbl_cactusTitle.Width - pic_companyIcon.Width - 50;
            pnl_userInfo.Left = lbl_cactusTitle.Width - pnl_userInfo.Width - 50;

            pic_underline.Width = lbl_cactusTitle.Width;

            pic_bg.Width = lbl_cactusTitle.Width;
            pic_bg.Height = this.Height - lbl_cactusTitle.Height-70;

            ////pic_companyIcon.Left = lbl_cactusTitle.Width - pic_companyIcon.Width + 30;
            //grp_MainMenu.Left = (this.Width / 2) - (grp_MainMenu.Width / 2);

            //collapseTheMainMenu();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            frm_persons frmPersons = new frm_persons();
            frmPersons.ShowDialog();
        }

        private void mnuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesWasted _frmWasted = new frm_invoicesWasted();
            _frmWasted.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            frm_objects _frm_objects = new frm_objects();
            _frm_objects.ShowDialog();
        }

        private void mnudataInputobjectgroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_objectGrouping frmObjectGrouping = new frm_objectGrouping();
            frmObjectGrouping.ShowDialog();
        }

        private void mnuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        {
            frm_accounts _frm_accounts = new frm_accounts();
            _frm_accounts.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_store _frm_store = new frm_store();
            _frm_store.ShowDialog();
        }

        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {
            frm_cheques _frm_cheques = new frm_cheques();
            _frm_cheques.theChequeIsMine = false;
            _frm_cheques.person_id = 8;
            _frm_cheques.ShowDialog();
        }

        private void lbl_cactusTitle_Click(object sender, EventArgs e)
        {

        }

        private void mnu_dataInput_primary_mineCheques_Click(object sender, EventArgs e)
        {
            frm_cheques _frm_cheques = new frm_cheques();
            _frm_cheques.theChequeIsMine = true;
            _frm_cheques.isItPrimaryCycle = true;
            //چونکه فرم چک ها از طریق منوی اول دوره فراخوانی شده است و نوع چک ها پرداختنی هستند باید شماره سند را 2 قرار دهیم
            _frm_cheques.accDoc_id = 2;//
            _frm_cheques.ShowDialog();
        }

        private void mnu_dataInput_primary_himCheques_Click(object sender, EventArgs e)
        {
            frm_cheques _frm_cheques = new frm_cheques();
            _frm_cheques.theChequeIsMine = false;
            _frm_cheques.isItPrimaryCycle = true;
            //چونکه فرم چک ها از طریق منوی اول دوره فراخوانی شده است و نوع چک ها پرداختنی هستند باید شماره سند را 1 قرار دهیم
            _frm_cheques.accDoc_id = 1;//
            _frm_cheques.ShowDialog();
        }

        private void mnuprimaryDatapersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_accountsPrimaryMoney _frm_accountPrimaryMoney = new frm_accountsPrimaryMoney();
            _frm_accountPrimaryMoney.ShowDialog();
        }

        private void mnu_primary_endOfPrimary_Click(object sender, EventArgs e)
        {
            frm_primaryCycleEnd _frm_primaryCycleEnd = new frm_primaryCycleEnd();
            _frm_primaryCycleEnd.ShowDialog();
        }

        private void frm_master_Load(object sender, EventArgs e)
        {
            cls_accDoc _accDoc = new cls_accDoc();
            if (cls_accDoc.isItPrimaryCycle)
            {
                enableDisableMenues(false);

                if (!cls_accDoc.isThisAccDocExist(1))
                {
                    cls_accDoc.createAccDoc();
                    cls_accDoc.saveTheAccDoc();
                }
                if (!cls_accDoc.isThisAccDocExist(2))
                {
                    cls_accDoc.createAccDoc();
                    cls_accDoc.saveTheAccDoc();
                }
            }
            else
            {
                enableDisableMenues(true);
                mnu_primary_endOfPrimary.Enabled = false;
            }
        }

        private void mnuinvoicesbuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesBuy _frm_buyInvoice = new frm_invoicesBuy();
            _frm_buyInvoice.openForReturnSellInvoice = false;
            _frm_buyInvoice.ShowDialog();
        }

        private void mnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesSell _frm_sellInvoice = new frm_invoicesSell();
            _frm_sellInvoice.ShowDialog();
        }

        private void mnuinvoicesunBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesSell _frm_sellInvoice = new frm_invoicesSell();
            _frm_sellInvoice.openForReturnBuyInvoice = true;
            _frm_sellInvoice.ShowDialog();
        }

        private void mnuinvoicesunSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesBuy _frm_buyInvoice = new frm_invoicesBuy();
            _frm_buyInvoice.openForReturnSellInvoice = true;
            _frm_buyInvoice.ShowDialog();
        }

       
    }
}
