using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_reportPreview : Novin.frm_FATHER
    {
        public frm_reportPreview()
        {
            InitializeComponent();            
        }

        public enum reportType { rt_jurnal = 1, rt_bigLedger, rt_smallLedger, rt_tinyLedger, rt_accDoc, rt_experBalance, rt_objectsEntity };
        public reportType openMode;

        public DataSet ds_ = new DataSet();
        private BindingSource bs_ = new BindingSource();

        private long n_total1 = 0;
        private long n_total2 = 0;
        private long n_total3 = 0;

        private long n_prior1 = 0;
        private long n_prior2 = 0;
        private long n_prior3 = 0;

        public string s_whereExpresstion = "";
        public string s_whereExpresstionForPriorTotals = "";
        public string s_KOL_id = "";
        public string s_MOEEN_id = "";

        public bool b_balance_moeens = false;
        public bool b_balance_fourCols = false;

        private void initTheLedger()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn accDoc_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDoc_date = new DataGridViewTextBoxColumn();            
            DataGridViewTextBoxColumn accDocRow_comment = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_indebted = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_creditor = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_remain = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_detect = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            accDoc_id, accDoc_date, accDocRow_comment, accDocRow_indebted, accDocRow_creditor, accDocRow_remain, accDocRow_detect});

            accDoc_id.DataPropertyName = "accDoc_id";
            accDoc_id.HeaderText = "شماره سند";
            accDoc_id.Name = "accDoc_id";
            accDoc_id.Width = 50;
            accDoc_id.ReadOnly = true;

            accDoc_date.DataPropertyName = "accDoc_date";
            accDoc_date.HeaderText = "تاریخ سند";
            accDoc_date.Name = "accDoc_date";
            accDoc_date.Width = 100;
            accDoc_date.ReadOnly = true;            

            accDocRow_comment.DataPropertyName = "accDocRow_comment";
            accDocRow_comment.HeaderText = "شــــرح";
            accDocRow_comment.Name = "accDocRow_comment";
            accDocRow_comment.Width = 200;
            accDocRow_comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accDocRow_comment.ReadOnly = true;

            accDocRow_indebted.DataPropertyName = "accDocRow_indebted";
            accDocRow_indebted.HeaderText = "بدهـــکار";
            accDocRow_indebted.Name = "accDocRow_indebted";
            accDocRow_indebted.Width = 120;
            accDocRow_indebted.ReadOnly = true;

            accDocRow_creditor.DataPropertyName = "accDocRow_creditor";
            accDocRow_creditor.HeaderText = "بستــــانکار";
            accDocRow_creditor.Name = "accDocRow_creditor";
            accDocRow_creditor.Width = 120;
            accDocRow_creditor.ReadOnly = true;

            accDocRow_remain.DataPropertyName = "accDocRow_remain";
            accDocRow_remain.HeaderText = "بـــاقیمانده";
            accDocRow_remain.Name = "accDocRow_remain";
            accDocRow_remain.Width = 120;
            accDocRow_remain.ReadOnly = true;

            accDocRow_detect.DataPropertyName = "detect";
            accDocRow_detect.HeaderText = "تشخیص";
            accDocRow_detect.Name = "detect";
            accDocRow_detect.Width = 50;
            accDocRow_detect.ReadOnly = true;

            if (openMode == reportType.rt_bigLedger)
            {
                lbl_title2.Text = "دفتر کـــــــــل";
            }
            else if(openMode == reportType.rt_smallLedger)
            {
                lbl_title2.Text = "دفتر معـــــین";
            }
            else if (openMode == reportType.rt_tinyLedger)
            {
                lbl_title2.Text = "دفتر تفصیلی";
            }
        }


        private void initTheJurnal()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn accDoc_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDoc_date = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn KOL_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_comment = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_indebted = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn accDocRow_creditor = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            accDoc_id, accDoc_date,KOL_id, accDocRow_comment, accDocRow_indebted, accDocRow_creditor});

            accDoc_id.DataPropertyName = "accDoc_id";
            accDoc_id.HeaderText = "شماره سند";
            accDoc_id.Name = "accDoc_id";
            accDoc_id.Width = 50;
            accDoc_id.ReadOnly = true;

            accDoc_date.DataPropertyName = "accDoc_date";
            accDoc_date.HeaderText = "تاریخ سند";
            accDoc_date.Name = "accDoc_date";
            accDoc_date.Width = 100;
            accDoc_date.ReadOnly = true;

            KOL_id.DataPropertyName = "KOL_id";
            KOL_id.HeaderText = "دفترکل";
            KOL_id.Name = "KOL_id";
            KOL_id.Width = 50;
            KOL_id.ReadOnly = true;

            accDocRow_comment.DataPropertyName = "accDocRow_comment";
            accDocRow_comment.HeaderText = "شــــرح";
            accDocRow_comment.Name = "accDocRow_comment";
            accDocRow_comment.Width = 200;
            accDocRow_comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accDocRow_comment.ReadOnly = true;

            accDocRow_indebted.DataPropertyName = "accDocRow_indebted";
            accDocRow_indebted.HeaderText = "بدهـــکار";
            accDocRow_indebted.Name = "accDocRow_indebted";
            accDocRow_indebted.Width = 100;
            accDocRow_indebted.ReadOnly = true;

            accDocRow_creditor.DataPropertyName = "accDocRow_creditor";
            accDocRow_creditor.HeaderText = "بستــــانکار";
            accDocRow_creditor.Name = "accDocRow_creditor";
            accDocRow_creditor.Width = 100;
            accDocRow_creditor.ReadOnly = true;

            lbl_title2.Text = "دفتر روزنـــــامه";
            pnl_remainSet.Visible = false;
            pnl_priorRemainSet.Visible = false;            
        }

        private void initTheObjectEntity()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn object_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn objectTitle = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn object_entity = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn object_retailBuyPrice = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn buyPrice = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn buyPriceTotall = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            object_id, objectTitle,object_entity, object_retailBuyPrice, buyPrice, buyPriceTotall});

            object_id.DataPropertyName = "object_id";
            object_id.HeaderText = "شماره کالا";
            object_id.Name = "object_id";
            object_id.Width = 50;
            object_id.ReadOnly = true;

            objectTitle.DataPropertyName = "objectTitle";
            objectTitle.HeaderText = "نام کالا";
            objectTitle.Name = "objectTitle";
            objectTitle.Width = 200;
            objectTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            objectTitle.ReadOnly = true;

            object_entity.DataPropertyName = "object_entity";
            object_entity.HeaderText = "موجودی کالا";
            object_entity.Name = "object_entity";
            object_entity.Width = 50;
            object_entity.ReadOnly = true;

            object_retailBuyPrice.DataPropertyName = "object_retailBuyPrice";
            object_retailBuyPrice.HeaderText = "فی خرید";
            object_retailBuyPrice.Name = "object_retailBuyPrice";
            object_retailBuyPrice.Width = 100;
            object_retailBuyPrice.ReadOnly = true;

            buyPrice.DataPropertyName = "buyPrice";
            buyPrice.HeaderText = "مبلغ خرید";
            buyPrice.Name = "buyPrice";
            buyPrice.Width = 100;
            buyPrice.ReadOnly = true;

            buyPriceTotall.DataPropertyName = "buyPriceTotall";
            buyPriceTotall.HeaderText = "مبلغ کل";
            buyPriceTotall.Name = "buyPriceTotall";
            buyPriceTotall.Width = 100;
            buyPriceTotall.ReadOnly = true;

            lbl_title2.Text = "موجودی کــــالا";
            pnl_remainSet.Visible = false;
            pnl_priorRemainSet.Visible = false;
        }

        private void initTheExperBalance()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn kol_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn moeen_id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn kol_title = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn moeen_title = new DataGridViewTextBoxColumn();            
            DataGridViewTextBoxColumn indTotal = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn creTotal = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn indRemain = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn creRemain = new DataGridViewTextBoxColumn();

            if (b_balance_moeens)
            {
                if (b_balance_fourCols)
                {
                    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { moeen_id, moeen_title, indTotal, creTotal, indRemain, creRemain});
                }
                else
                {
                    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { moeen_id, moeen_title, indRemain, creRemain});
                }
            }
            else
            {
                if (b_balance_fourCols)
                {
                    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kol_id, kol_title, indTotal, creTotal, indRemain, creRemain });
                }
                else
                {
                    dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kol_id, kol_title, indRemain, creRemain});
                }
            }

            kol_id.DataPropertyName = "kol_id";
            kol_id.HeaderText = "کـــد حساب";
            kol_id.Name = "kol_id";
            kol_id.Width = 50;
            kol_id.ReadOnly = true;

            moeen_id.DataPropertyName = "moeen_id";
            moeen_id.HeaderText = "کـــد حساب";
            moeen_id.Name = "moeen_id";
            moeen_id.Width = 80;
            moeen_id.ReadOnly = true;

            kol_title.DataPropertyName = "kol_title";
            kol_title.HeaderText = "عنوان حساب";
            kol_title.Name = "kol_title";
            kol_title.Width = 20;
            kol_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kol_title.ReadOnly = true;

            moeen_title.DataPropertyName = "moeen_title";
            moeen_title.HeaderText = "عنوان حساب";
            moeen_title.Name = "moeen_title";
            moeen_title.Width = 200;
            moeen_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            moeen_title.ReadOnly = true;

            indTotal.DataPropertyName = "indTotal";
            indTotal.HeaderText = "بدهـــکار";
            indTotal.Name = "indTotal";
            indTotal.Width = 100;
            indTotal.ReadOnly = true;

            creTotal.DataPropertyName = "creTotal";
            creTotal.HeaderText = "بستــــانکار";
            creTotal.Name = "creTotal";
            creTotal.Width = 100;
            creTotal.ReadOnly = true;

            indRemain.DataPropertyName = "indRemain";
            indRemain.HeaderText = "بدهـــکار";
            indRemain.Name = "indRemain";
            indRemain.Width = 100;
            indRemain.ReadOnly = true;

            creRemain.DataPropertyName = "creRemain";
            creRemain.HeaderText = "بستــــانکار";
            creRemain.Name = "creRemain";
            creRemain.Width = 100;
            creRemain.ReadOnly = true;

            lbl_title2.Text = "تراز آزمایشی";
            pnl_remainSet.Visible = false;
            pnl_priorRemainSet.Visible = false;
            pnl_indebtedCreditor.Visible = false;
        }

        public void prepareTheReport()
        {
            if (openMode == reportType.rt_jurnal)
            {
                int n_pos = bs_.Position;

                ds_.Clear();
                ds_ = cls_accDoc.viewTheJurnal(s_whereExpresstion);
                if (ds_.Tables[0].Rows.Count > 0)
                {
                    DataTable dt_totals = new DataTable();
                    if (s_whereExpresstionForPriorTotals != "")
                    {
                        //جمع منقول از صفحه قبل در صورت وجود
                        dt_totals = cls_accDoc.getTheJurnalTotals(s_whereExpresstionForPriorTotals);
                        try
                        {
                            n_prior1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                            n_prior2 = (long)dt_totals.Rows[0]["creditorTotal"];
                        }
                        catch
                        {
                        }
                        tbx_prior1.Text = n_prior1.ToString();
                        tbx_prior2.Text = n_prior2.ToString();
                    }
                    //جمع همین صفحه
                    dt_totals = cls_accDoc.getTheJurnalTotals(s_whereExpresstion);
                    try
                    {
                        n_total1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                        n_total2 = (long)dt_totals.Rows[0]["creditorTotal"];
                    }
                    catch
                    {
                    }
                    tbx_total1.Text = (n_total1 + n_prior1).ToString();
                    tbx_total2.Text = (n_total2 + n_prior2).ToString();
                }

                frm_reportPreview_Load(null, null);

                bs_.Position = n_pos;
            }
            else if (openMode == reportType.rt_bigLedger)
            {
                int n_pos = bs_.Position;

                ds_.Clear();
                ds_ = cls_accDoc.viewTheBigLedger(s_KOL_id, s_whereExpresstion);
                if (ds_.Tables["viw_ledger"].Rows.Count > 0)
                {
                    DataTable dt_totals = new DataTable();
                    if (s_whereExpresstionForPriorTotals != "")
                    {
                        //جمع منقول از صفحه قبل در صورت وجود
                        dt_totals = cls_accDoc.getTheTotalsOfLedger(s_KOL_id, s_whereExpresstionForPriorTotals);
                        try
                        {
                            n_prior1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                            n_prior2 = (long)dt_totals.Rows[0]["creditorTotal"];
                        }
                        catch
                        {
                        }
                        n_prior3 = n_prior1 - n_prior2;
                        if (n_prior3 > 0)
                        {
                            tbx_priorDetect.Text = "بد";
                        }
                        else if (n_prior3 < 0)
                        {
                            tbx_priorDetect.Text = "بس";
                        }                        
                        tbx_prior1.Text = n_prior1.ToString();
                        tbx_prior2.Text = n_prior2.ToString();
                        tbx_prior3.Text = Math.Abs(n_prior3).ToString();
                    }
                    //جمع همین صفحه
                    dt_totals = cls_accDoc.getTheTotalsOfLedger(s_KOL_id, s_whereExpresstion);

                    n_total1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                    n_total2 = (long)dt_totals.Rows[0]["creditorTotal"];
                    n_total3 = (n_prior1 + n_total1) - (n_prior2 + n_total2);
                    if (n_total3 > 0)
                    {
                        tbx_detect.Text = "بد";
                    }
                    else if (n_total3 < 0)
                    {
                        tbx_detect.Text = "بس";
                    }       
                    tbx_total1.Text = (n_prior1 + n_total1).ToString();
                    tbx_total2.Text = (n_prior2 + n_total2).ToString();
                    tbx_total3.Text = Math.Abs(n_total3).ToString();
                }

                frm_reportPreview_Load(null, null);

                bs_.Position = n_pos;
            }

            else if (openMode == reportType.rt_smallLedger)
            {
                int n_pos = bs_.Position;

                ds_.Clear();
                ds_ = cls_accDoc.viewTheSmallLedger(s_MOEEN_id, s_whereExpresstion);
                if (ds_.Tables["viw_ledger"].Rows.Count > 0)
                {
                    DataTable dt_totals = new DataTable();
                    if (s_whereExpresstionForPriorTotals != "")
                    {
                        //جمع منقول از صفحه قبل در صورت وجود
                        dt_totals = cls_accDoc.getTheSmallLedgerTotals(s_MOEEN_id, s_whereExpresstionForPriorTotals);
                        try
                        {
                            n_prior1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                            n_prior2 = (long)dt_totals.Rows[0]["creditorTotal"];
                        }
                        catch
                        {
                        }
                        n_prior3 = n_prior1 - n_prior2;
                        if (n_prior3 > 0)
                        {
                            tbx_priorDetect.Text = "بد";
                        }
                        else if (n_prior3 < 0)
                        {
                            tbx_priorDetect.Text = "بس";
                        }
                        tbx_prior1.Text = n_prior1.ToString();
                        tbx_prior2.Text = n_prior2.ToString();
                        tbx_prior3.Text = Math.Abs(n_prior3).ToString();
                    }
                    //جمع همین صفحه
                    dt_totals = cls_accDoc.getTheSmallLedgerTotals(s_MOEEN_id, s_whereExpresstion);

                    n_total1 = (long)dt_totals.Rows[0]["indebtedTotal"];
                    n_total2 = (long)dt_totals.Rows[0]["creditorTotal"];
                    n_total3 = (n_prior1 + n_total1) - (n_prior2 + n_total2);
                    if (n_total3 > 0)
                    {
                        tbx_detect.Text = "بد";
                    }
                    else if (n_total3 < 0)
                    {
                        tbx_detect.Text = "بس";
                    }
                    tbx_total1.Text = (n_prior1 + n_total1).ToString();
                    tbx_total2.Text = (n_prior2 + n_total2).ToString();
                    tbx_total3.Text = Math.Abs(n_total3).ToString();
                }

                frm_reportPreview_Load(null, null);

                bs_.Position = n_pos;
            }

            else if (openMode == reportType.rt_experBalance)
            {
                int n_pos = bs_.Position;

                ds_.Clear();
                ds_ = cls_accDoc.viewTheExperBalance(b_balance_moeens, b_balance_fourCols, s_whereExpresstion);

                frm_reportPreview_Load(null, null);

                bs_.Position = n_pos;
            }
            else if (openMode == reportType.rt_objectsEntity)
            {
                int n_pos = bs_.Position;

                ds_.Clear();
                cls_storing _storing = new cls_storing();
                ds_ = _storing.viewObjectsEntity(s_whereExpresstion);

                frm_reportPreview_Load(null, null);

                bs_.Position = n_pos;
            }
        }

        private void frm_reportPreview_Load(object sender, EventArgs e)
        {
            // Declare and set the alternating rows style...   | رنگ سطر هاي زوج تغيير مي کند
            DataGridViewCellStyle objAlternatingCellStyle = new
            DataGridViewCellStyle();
            objAlternatingCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle; 

            if (openMode == reportType.rt_jurnal)
            {
                initTheJurnal();
                this.bs_.DataMember = "viw_jurnal";
            }
            else if (openMode == reportType.rt_bigLedger || openMode == reportType.rt_smallLedger)
            {
                initTheLedger();
                this.bs_.DataMember = "viw_ledger";
            }
            else if (openMode == reportType.rt_experBalance)
            {
                initTheExperBalance();
                this.bs_.DataMember = "viw_experBalance";
            }
            else if (openMode == reportType.rt_objectsEntity)
            {
                initTheObjectEntity();
                this.bs_.DataMember = "viw_objectEntity";
            }
            this.bs_.DataSource = ds_;            
            this.dataGridView1.DataSource = bs_;            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cls_invoices _invoices = new cls_invoices();
            int n_accDoc_id = (int)ds_.Tables[0].Rows[bs_.Position]["accDoc_id"];
            int n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.buyInvoice);
            if (n_invoice_id != -1)
            {
                frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                _invoiceBuy.openForModify = true;
                _invoiceBuy.openForReturnSellInvoice = false;
                _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                _invoiceBuy.ShowDialog();

                prepareTheReport();
            }
            n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.sellInvoice);
            if (n_invoice_id != -1)
            {
                frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                _invoiceSell.openForModify = true;
                _invoiceSell.openForReturnBuyInvoice = false;
                _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                _invoiceSell.ShowDialog();

                prepareTheReport();
            }
            n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.unBuyInvoice);
            if (n_invoice_id != -1)
            {
                frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                _invoiceSell.openForModify = true;
                _invoiceSell.openForReturnBuyInvoice = true;
                _invoiceSell.n_invoiceIDForModify = n_invoice_id;
                _invoiceSell.ShowDialog();

                prepareTheReport();
            }
            n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.unSellInvoice);
            if (n_invoice_id != -1)
            {
                frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                _invoiceBuy.openForModify = true;
                _invoiceBuy.openForReturnSellInvoice = true;
                _invoiceBuy.n_invoiceIDForModify = n_invoice_id;
                _invoiceBuy.ShowDialog();

                prepareTheReport();
            }
            n_invoice_id = _invoices.getTheInvoiceID(n_accDoc_id, cls_invoices.invoiceType.wastedInvoice);
            if (n_invoice_id != -1)
            {
                frm_invoicesWasted _invoiceWasted = new frm_invoicesWasted();
                _invoiceWasted.openForModify = true;
                _invoiceWasted.n_invoiceIDForModify = n_invoice_id;
                _invoiceWasted.ShowDialog();

                prepareTheReport();
            }


        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modifyInvoice_Click(object sender, EventArgs e)
        {
            dataGridView1_CellDoubleClick(null, null);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            frm_print _print = new frm_print();
            if (openMode == reportType.rt_experBalance)
            {
                if (b_balance_fourCols)
                {
                    _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_balance.rpt";
                }
                else
                {
                    _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_dualBalance.rpt";
                }
                _print.s_paraName = "dateString";
                _print.s_paraValue = lbl_reportComment.Text;                
            }
            else if (openMode == reportType.rt_jurnal)
            {
                _print.s_reportFilePath = @"D:\develop\csharp\Novin\Novin\rpt_journal.rpt";
            }
            _print.ds_report = ds_;
            _print.ShowDialog();
              
        }

        
    }
}
