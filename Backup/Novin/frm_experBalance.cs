using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_experBalance : Novin.frm_FATHER
    {
        public frm_experBalance()
        {
            InitializeComponent();
        }

        private string buildTheReportComment()
        {
            string s_comment = "";
            try
            {
                if (rdu_showInDate.Checked)
                {
                    s_comment = "تراز منتهی به تاریخ " + mTbx_tilDate.Text;
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    s_comment = "تراز از تاریخ " + mTbx_fromDate.Text + " تا تاریخ " + mTbx_toDate.Text;
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    s_comment = "تراز از سند " + mTbx_fromDate.Text + " تا سند " + mTbx_toDate.Text;
                }
            }
            catch
            {
            }

            return s_comment;
        }

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            string s_kol_id = "";
            try
            {
                s_kol_id = tbx_ledgerCode.Text;
                if (rdu_showInDate.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_date <= '{0}') ";
                    sWhere = string.Format(sWhere, mTbx_tilDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_date >= '{0}' AND tbl_accDocs.accDoc_date <= '{1}') ";
                    sWhere = string.Format(sWhere, mTbx_fromDate.Text, mTbx_toDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_id >= {0} AND tbl_accDocs.accDoc_id <= {1})  ";
                    sWhere = string.Format(sWhere, tbx_fromID.Text, tbx_toID.Text);
                }

                if (rdu_onlyShowDetailBalance.Checked && chk_ledger.Checked)
                {
                    sWhere += " AND (dbo.tbl_MOEENs.kol_id = '{0}')";
                    sWhere = string.Format(sWhere, s_kol_id);
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
            return sWhere;
        }

        private void frm_experBalance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_accounting.tbl_KOLs' table. You can move, or remove it, as needed.
            this.tbl_KOLsTableAdapter.Fill(this.ds_accounting.tbl_KOLs);

            try
            {
                mTbx_tilDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
                mTbx_fromDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
                mTbx_toDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
            }
            catch
            {
            }
        }

        private void rdu_showInDate_CheckedChanged(object sender, EventArgs e)
        {
            mTbx_tilDate.Enabled = rdu_showInDate.Checked;
        }

        private void rdu_showBetweenDates_CheckedChanged(object sender, EventArgs e)
        {
            pnl_betweenDates.Enabled = rdu_showBetweenDates.Checked;
        }

        private void rdu_showBetweenAccDoc_ids_CheckedChanged(object sender, EventArgs e)
        {
            pnl_betweenIDs.Enabled = rdu_showBetweenAccDoc_ids.Checked;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reportPreview _reportPreview = new frm_reportPreview();
                _reportPreview.openMode = frm_reportPreview.reportType.rt_experBalance;
                _reportPreview.s_whereExpresstion = buildTheWhereStatement();
                _reportPreview.b_balance_moeens = rdu_onlyShowDetailBalance.Checked;
                _reportPreview.b_balance_fourCols = rdu_fourColumnsBalance.Checked;
                _reportPreview.lbl_reportComment.Text = buildTheReportComment();
                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void rdu_onlyShowDetailBalance_CheckedChanged(object sender, EventArgs e)
        {
            pnl_showDetailBalance.Enabled = rdu_onlyShowDetailBalance.Checked;
        }

        private void chk_ledger_CheckedChanged(object sender, EventArgs e)
        {
            cmb_masterSpentName.Enabled = chk_ledger.Checked;
        }
    }
}
