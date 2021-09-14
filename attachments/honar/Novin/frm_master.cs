using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Novin
{
    public partial class frm_master : Form
    {
        public frm_master()
        {
            InitializeComponent();
            selectPersianKeyboard();
            //showLogForm();
            InitializeRegistryKeys();
        }

        private string sBGPath = "";
        private string[] files;
        private int nPicIndex = 0;
        private bool b_unwanterUser, b_showHelp; 

        private void selectPersianKeyboard()
        {
            //********Change the current Input Language to the farsi (Persian)*************\\
            try
            {
                // Gets the list of installed languages.
                foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
                {
                    if ((lang.Culture.EnglishName.IndexOf("Iran") > -1) || lang.Culture.EnglishName.IndexOf("Farsi") > -1 || lang.Culture.EnglishName.IndexOf("Persian") > -1)
                    {
                        InputLanguage.CurrentInputLanguage = lang;
                        break;
                    }
                }
            }
            catch
            {
            }
            //.................................................................................  
        }

        private void showLogForm()
        {            
            if (cls_users.usersCount() == 2)
            {
                DataTable dt_users = cls_users.selectAllUsers();
                if (dt_users.Rows[1]["user_password"] != DBNull.Value)
                {
                    frm_logOn frmLog = new frm_logOn();
                    if (frmLog.ShowDialog() == DialogResult.Cancel)
                    {
                        b_unwanterUser = true;
                    }
                    else
                    {
                        //n_userID = frmLog.n_userID;
                        //usersTableBindingSource.Position = usersTableBindingSource.Find("user_id", n_userID);
                        //limitString = (string)dt_users.Rows[usersTableBindingSource.Position]["user_limitString"];
                        //limitString = limitString.Replace(";", "");
                    }
                }
                else
                {
                    //n_userID = (int)pSDatabase5DataSet.usersTable.Rows[1]["user_id"];
                    //limitString = (string)pSDatabase5DataSet.usersTable.Rows[1]["user_limitString"];
                    //limitString = limitString.Replace(";", "");
                }
            }
            else if (cls_users.usersCount() > 2 || cls_users.usersCount() == 1)
            {
                frm_logOn frmLog = new frm_logOn();
                if (frmLog.ShowDialog() == DialogResult.Cancel)
                {
                    b_unwanterUser = true;
                }
                else
                {
                    //n_userID = frmLog.n_userID;
                    //usersTableBindingSource.Position = usersTableBindingSource.Find("user_id", n_userID);
                    //limitString = (string)pSDatabase5DataSet.usersTable.Rows[usersTableBindingSource.Position]["user_limitString"];
                    //limitString = limitString.Replace(";", "");
                }
            }

            //load current user info
            try
            {                
                if (cls_users.user_picPath != "")
                {
                    try
                    {
                        pic_user.Image = Image.FromFile(cls_users.user_picPath);
                    }
                    catch
                    {
                        pic_user.Image = imageList1.Images[8];
                    }
                }
                else
                {
                    pic_user.Image = imageList1.Images[cls_users.user_picIndex];
                }
                lbl_userName.Text = cls_users.user_name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeRegistryKeys()
        {
            //-- make sure that GENERAL sub keys is exist...
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\jaavid\\General");
            // If the return value is null, the key doesn't exist
            if (key == null)
            {
                // The key doesn't exist; create it / open it
                key = Registry.CurrentUser.CreateSubKey("Software\\coreCodes\\jaavid\\General");
            }

            if (key.GetValue("noMoreHelp") != null)
            {
                // The value exists; load the data that stored in the registry.
                int bNoMoreHelp = (int)key.GetValue("noMoreHelp");
                if (bNoMoreHelp == 1)
                {

                }
            }
            key.Close();

            //-- make sure that PREFERENCE sub keys is exist...
            key = Registry.CurrentUser.OpenSubKey("Software\\coreCodes\\jaavid\\Preferences\\" + cls_users.user_id.ToString());
            // If the return value is null, the key doesn't exist
            if (key == null)
            {
                // The key doesn't exist; create it / open it
                key = Registry.CurrentUser.CreateSubKey("Software\\coreCodes\\jaavid\\Preferences\\" + cls_users.user_id.ToString());
            }
            if (key.GetValue("BGImagePath") != null)
            {
                try
                {
                    // The value exists; load the data that stored in the registry.                    
                    sBGPath = (string)key.GetValue("BGImagePath");
                    pic_bg.Image = Image.FromFile(sBGPath);
                }
                catch
                {
                }
            }

            if (key.GetValue("BGImagePosition") != null)
            {
                // The value exists; load the data that stored in the registry.
                int nPosition = 0;

                nPosition = (int)key.GetValue("BGImagePosition");
                if (nPosition == 0)
                {
                    pic_bg.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else if (nPosition == 1)
                {
                    pic_bg.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (nPosition == 2)
                {
                    pic_bg.SizeMode = PictureBoxSizeMode.CenterImage;
                }

            }

            //load the main menu settings
            if (key.GetValue("noMainMenu") != null)
            {
                // The value exists; load the data that stored in the registry.
                int nState = 0;

                nState = (int)key.GetValue("noMainMenu");
                if (nState == 1)
                {
                    //grp_MainMenu.Visible = false;
                }
                else
                {
                    //grp_MainMenu.Visible = true;
                }

            }

            //load the showSamePathPics state
            if (key.GetValue("delaySeconds") != null)
            {
                tmr_showDelay.Enabled = false;
                // The value exists; load the data that stored in the registry.
                int nSeconds = 0;

                nSeconds = (int)key.GetValue("delaySeconds");
                if (nSeconds > 1)
                {
                    string sPath = sBGPath;
                    sPath = sPath.Substring(0, sPath.LastIndexOf("\\"));
                    //Load the fiels path into the Array
                    files = Directory.GetFiles(sPath, "*.jpg");
                    nPicIndex = 0;

                    tmr_showDelay.Interval = nSeconds * 1000;
                    tmr_showDelay.Enabled = true;
                }
            }
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
            frm_finActions _finActions = new frm_finActions();
            _finActions.ShowDialog();
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
            if (b_unwanterUser)
            {
                this.Close();
            }

            cls_accDoc _accDoc = new cls_accDoc();
            if (cls_accDoc.isItPrimaryCycle)
            {
                enableDisableMenues(false);

                if (!cls_accDoc.isThisAccDocExist(1))
                {
                    cls_accDoc.createAccDoc(true);
                    cls_accDoc.saveTheAccDoc();
                }
                if (!cls_accDoc.isThisAccDocExist(2))
                {
                    cls_accDoc.createAccDoc(true);
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
            _frm_buyInvoice.openForModify = false;
            _frm_buyInvoice.ShowDialog();
        }

        private void mnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesSell _frm_sellInvoice = new frm_invoicesSell();
            _frm_sellInvoice.openForReturnBuyInvoice = false;
            _frm_sellInvoice.openForModify = false;
            _frm_sellInvoice.ShowDialog();
        }

        private void mnuinvoicesunBuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesSell _frm_sellInvoice = new frm_invoicesSell();
            _frm_sellInvoice.openForReturnBuyInvoice = true;
            _frm_sellInvoice.openForModify = false;
            _frm_sellInvoice.ShowDialog();
        }

        private void mnuinvoicesunSellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_invoicesBuy _frm_buyInvoice = new frm_invoicesBuy();
            _frm_buyInvoice.openForReturnSellInvoice = true;
            _frm_buyInvoice.openForModify = false;
            _frm_buyInvoice.ShowDialog();
        }

        private void mnu_actions_modifications_Click(object sender, EventArgs e)
        {
            frm_invoiceExplorer _invoiceExplorer = new frm_invoiceExplorer();
            _invoiceExplorer.ShowDialog();
        }

        private void mnu_reports_jurnal_Click(object sender, EventArgs e)
        {
            frm_books _books = new frm_books();
            _books.rdu_journal.Checked = true;
            _books.ShowDialog();
        }

        private void mnu_reports_bigLedger_Click(object sender, EventArgs e)
        {
            frm_books _books = new frm_books();
            _books.rdu_bigLedger.Checked = true;
            _books.ShowDialog();
        }

        private void mnu_reports_smallLedger_Click(object sender, EventArgs e)
        {
            frm_books _books = new frm_books();
            _books.rdu_smallLedger.Checked = true;
            _books.ShowDialog();
        }

        private void mnu_reports_personsLedger_Click(object sender, EventArgs e)
        {
            frm_books _books = new frm_books();
            _books.rdu_smallLedger.Checked = true;
            _books.chk_personsMoeenOnly.Checked = true;
            _books.ShowDialog();
        }

        private void mnu_reports_experBalance_twoColsBalance_Click(object sender, EventArgs e)
        {
            frm_experBalance _experBalance = new frm_experBalance();
            _experBalance.ShowDialog();
        }

        private void mnu_report_objectEntity_Click(object sender, EventArgs e)
        {
            frm_objectEntityReport _frm_objectEntityReport = new frm_objectEntityReport();
            _frm_objectEntityReport.openMode = frm_objectEntityReport.objectReportType.objectEntity;
            _frm_objectEntityReport.ShowDialog();
        }

        private void toolStripMenuItem61_Click(object sender, EventArgs e)
        {
            frm_accDocExplorer _accDocExplorer = new frm_accDocExplorer();
            _accDocExplorer.ShowDialog();
        }

        private void mnu_report_objectWasted_Click(object sender, EventArgs e)
        {
            frm_objectEntityReport _objectWasted = new frm_objectEntityReport();
            _objectWasted.openMode = frm_objectEntityReport.objectReportType.objectWasted;
            _objectWasted.ShowDialog();
        }

        private void mnu_reports_experBalance_fourColsBalance_Click(object sender, EventArgs e)
        {
            frm_experBalance _experBalance = new frm_experBalance();
            _experBalance.rdu_fourColumnsBalance.Checked = true;
            _experBalance.ShowDialog();
        }

        private void mnuToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_objectEntityReport _objectLessSell = new frm_objectEntityReport();
            _objectLessSell.openMode = frm_objectEntityReport.objectReportType.objectLessSell;

            _objectLessSell.ShowDialog();
        }

        private void chequesExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chequesExplorer _cheguesExplorer = new frm_chequesExplorer();
            _cheguesExplorer.ShowDialog();
        }

        private void mnu_persons_indCreList_Click(object sender, EventArgs e)
        {
            frm_personExplorer _personExplorer = new frm_personExplorer();
            _personExplorer.ShowDialog();
        }

        private void mnu_preference_visiotrs_Click(object sender, EventArgs e)
        {
            frm_visitors _visiotrs = new frm_visitors();
            _visiotrs.ShowDialog();
        }

        private void mnu_primaryCycle_primaryCycleObjectEntity_Click(object sender, EventArgs e)
        {
            frm_objects _frm_objects = new frm_objects();
            _frm_objects.b_userCanEditThePrimaryCycleEntity = true;
            _frm_objects.tabControl1.SelectedIndex = 1;
            _frm_objects.ShowDialog();
        }

        private void mnu_preferences_software_Click(object sender, EventArgs e)
        {
            frm_preferences _preference = new frm_preferences();
            if (_preference.ShowDialog() != DialogResult.Cancel)
            {
                InitializeRegistryKeys();
            }
        }

        private void tmr_showDelay_Tick(object sender, EventArgs e)
        {
            try
            {
                pic_bg.Image = Image.FromFile(files[nPicIndex++]);
                if (nPicIndex >= files.Length)
                {
                    nPicIndex = 0;
                }
            }
            catch
            {
            }
        }

        private void pic_bg_DoubleClick(object sender, EventArgs e)
        {
            mnu_preferences_software_Click(null, null);
        }

        private void mnu_actions_issusePensionForm_Click(object sender, EventArgs e)
        {
            frm_pensionForm _pensionForm = new frm_pensionForm();
            _pensionForm.ShowDialog();
        }

        private void mnu_report_objectAdvDisadv_Click(object sender, EventArgs e)
        {
            DataTable dt_report = cls_storing.viewProfitLoss();
            frm_print _print = new frm_print();
            _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_profLoss.rpt";
            _print.dt_report = dt_report;
            _print.ShowDialog();
        }

        private void mnu_jaavidAndReza_database_Click(object sender, EventArgs e)
        {
            frm_backupAndRestore _backAndRes = new frm_backupAndRestore();
            _backAndRes.ShowDialog();
        }

    }
}
