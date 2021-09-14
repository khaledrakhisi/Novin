using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_modify : Novin.frm_FATHER
    {
        public frm_modify()
        {
            InitializeComponent();
        }

        private void rdu_invoiceModification_CheckedChanged(object sender, EventArgs e)
        {
            pnl_invoiceControls.Enabled = rdu_invoiceModification.Checked;

            if (tbx_invoiceNO.Text == "")
            {
                btn_ok.Enabled = false;
            }
            else
            {
                btn_ok.Enabled = true;
            }
        }

        private void rdu_accDocModification_CheckedChanged(object sender, EventArgs e)
        {
            tbx_accDocNO.Enabled = rdu_accDocModification.Checked;

            if (tbx_accDocNO.Text == "")
            {
                btn_ok.Enabled = false;
            }
            else
            {
                btn_ok.Enabled = true;
            }
        }

        private void frm_modify_Load(object sender, EventArgs e)
        {
            cbx_invoiceType.SelectedIndex = 0;
        }

        private void tbx_invoiceNO_TextChanged(object sender, EventArgs e)
        {
            if (tbx_invoiceNO.Text == "")
            {
                btn_ok.Enabled = false;
            }
            else
            {
                btn_ok.Enabled = true;
            }
        }

        private void tbx_accDocNO_TextChanged(object sender, EventArgs e)
        {
            if (tbx_accDocNO.Text == "")
            {
                btn_ok.Enabled = false;
            }
            else
            {
                btn_ok.Enabled = true;
            }
                   
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {            
            if (rdu_invoiceModification.Checked)
            {                
                cls_invoices _invoices = new cls_invoices();
                cls_invoices.invoiceType _invoiceType = cls_invoices.invoiceType.buyInvoice;

                int n_invoiceID = 0;

                n_invoiceID = Convert.ToInt32(tbx_invoiceNO.Text);
                if (cbx_invoiceType.SelectedIndex == 0)//خرید
                {
                    _invoiceType = cls_invoices.invoiceType.buyInvoice;
                    if (_invoices.isThisInvoiceExists(_invoiceType, n_invoiceID))
                    {
                        frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                        _invoiceBuy.openForModify = true;
                        _invoiceBuy.openForReturnSellInvoice = false;
                        _invoiceBuy.n_invoiceIDForModify = n_invoiceID;
                        _invoiceBuy.ShowDialog();
                    }
                }
                else if (cbx_invoiceType.SelectedIndex == 1)//فروش
                {
                    _invoiceType = cls_invoices.invoiceType.sellInvoice;
                    if (_invoices.isThisInvoiceExists(_invoiceType, n_invoiceID))
                    {
                        frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                        _invoiceSell.openForModify = true;
                        _invoiceSell.openForReturnBuyInvoice = false;
                        _invoiceSell.n_invoiceIDForModify = n_invoiceID;
                        _invoiceSell.ShowDialog();
                    }
                }
                else if (cbx_invoiceType.SelectedIndex == 2)
                {
                }
                else if (cbx_invoiceType.SelectedIndex == 3)//برگشت از خرید
                {
                    _invoiceType = cls_invoices.invoiceType.unBuyInvoice;
                    if (_invoices.isThisInvoiceExists(_invoiceType, n_invoiceID))
                    {
                        frm_invoicesSell _invoiceSell = new frm_invoicesSell();
                        _invoiceSell.openForModify = true;
                        _invoiceSell.openForReturnBuyInvoice = true;
                        _invoiceSell.n_invoiceIDForModify = n_invoiceID;
                        _invoiceSell.ShowDialog();
                    }
                }
                else if (cbx_invoiceType.SelectedIndex == 4)//برگشت از فروش
                {
                    _invoiceType = cls_invoices.invoiceType.unSellInvoice;
                    if (_invoices.isThisInvoiceExists(_invoiceType, n_invoiceID))
                    {
                        frm_invoicesBuy _invoiceBuy = new frm_invoicesBuy();
                        _invoiceBuy.openForModify = true;
                        _invoiceBuy.openForReturnSellInvoice = true;
                        _invoiceBuy.n_invoiceIDForModify = n_invoiceID;
                        _invoiceBuy.ShowDialog();
                    }
                }
                else if (cbx_invoiceType.SelectedIndex == 5)
                {
                }
                else if (cbx_invoiceType.SelectedIndex == 6)//ضایعات
                {
                    _invoiceType = cls_invoices.invoiceType.wastedInvoice;
                    if (_invoices.isThisInvoiceExists(_invoiceType, n_invoiceID))
                    {
                        frm_invoicesWasted _invoiceWasted = new frm_invoicesWasted();
                        _invoiceWasted.openForModify = true;                        
                        _invoiceWasted.n_invoiceIDForModify = n_invoiceID;
                        _invoiceWasted.ShowDialog();
                    }
                }
                
            }
            else if (rdu_accDocModification.Checked)
            {
            }
        }
    }
}
