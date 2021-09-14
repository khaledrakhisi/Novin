using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_books : Novin.frm_FATHER
    {        
        public frm_books()
        {
            InitializeComponent();
        }
        string s_whereForPriorTotals = "";

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            s_whereForPriorTotals = "";
            try
            {
                if (rdu_showAll.Checked)
                {
                    sWhere = "";
                }
                else if (rdu_showInDate.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_date = '{0}') ";
                    sWhere = string.Format(sWhere, mTbx_inDate.Text);

                    s_whereForPriorTotals = "(tbl_accDocs.accDoc_date < '{0}') ";
                    s_whereForPriorTotals = string.Format(s_whereForPriorTotals, mTbx_inDate.Text);
                }
                else if (rdu_showBetweenDates.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_date >= '{0}' AND tbl_accDocs.accDoc_date <= '{1}') ";
                    sWhere = string.Format(sWhere, mTbx_fromDate.Text, mTbx_toDate.Text);

                    s_whereForPriorTotals = "(tbl_accDocs.accDoc_date < '{0}') ";
                    s_whereForPriorTotals = string.Format(s_whereForPriorTotals, mTbx_inDate.Text);
                }
                else if (rdu_showBetweenAccDoc_ids.Checked)
                {
                    sWhere = "(tbl_accDocs.accDoc_id >= {0} AND tbl_accDocs.accDoc_id <= {1})  ";
                    sWhere = string.Format(sWhere, tbx_fromID.Text, tbx_toID.Text);

                    s_whereForPriorTotals = "(tbl_accDocs.accDoc_id < {0}) ";
                    s_whereForPriorTotals = string.Format(s_whereForPriorTotals, tbx_fromID.Text);
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
            return sWhere;
        }

        private void frm_books_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ds_accounting.tbl_MOEENs' table. You can move, or remove it, as needed.
                this.tbl_MOEENsTableAdapter.Fill(this.ds_accounting.tbl_MOEENs);
                // TODO: This line of code loads data into the 'ds_accounting.tbl_KOLs' table. You can move, or remove it, as needed.
                this.tbl_KOLsTableAdapter.Fill(this.ds_accounting.tbl_KOLs);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                cls_msgBox.show(ex.Message);
            }

            try
            {
                mTbx_inDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
                mTbx_toDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
                mTbx_fromDate.Text = cls_numberConvertor.nowDateInAppropriateFormat();
            }
            catch
            {
            }

        }

        private void rdu_journal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_journal.Checked)
                {
                    pnl_detail.Enabled = false;
                    pnl_masterSpent.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void rdu_bigJournal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_bigLedger.Checked)
                {
                    pnl_masterSpent.Enabled = true;
                    pnl_detail.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void rdu_smallJournal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_smallLedger.Checked)
                {
                    pnl_masterSpent.Enabled = false;
                    pnl_detail.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void cmb_masterSpentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_KOLs.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_KOLs.DataMember;
                frmFindRecords.listDisplayMember = "KOL_title";
                frmFindRecords.listValueMember = "KOL_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_KOLs.Find("KOL_id", frmFindRecords.foundRecordID);
                        bs_KOLs.Position = nPosition;
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
            finally
            {
            }
        }

        private void cmb_detail_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                frm_findRecords frmFindRecords = new frm_findRecords();
                frmFindRecords.bindingSource1.DataSource = bs_MOEENs.DataSource;
                frmFindRecords.bindingSource1.DataMember = bs_MOEENs.DataMember;
                frmFindRecords.listDisplayMember = "MOEEN_title";
                frmFindRecords.listValueMember = "MOEEN_id";
                frmFindRecords.firstCharPressed = e.KeyChar.ToString();
                if (frmFindRecords.ShowDialog() == DialogResult.OK)
                {
                    if (frmFindRecords.foundRecordID != "-1")
                    {
                        int nPosition = bs_MOEENs.Find("MOEEN_id", frmFindRecords.foundRecordID);
                        bs_MOEENs.Position = nPosition;
                    }

                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
            finally
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                frm_reportPreview _reportPreview = new frm_reportPreview();
                if (rdu_bigLedger.Checked)
                {
                    string s_KOL_id = "";
                    //s_KOL_id = (string)ds_accounting.tbl_KOLs.Rows[bs_KOLs.Position]["KOL_id"];
                    s_KOL_id = tbx_ledgerCode.Text;

                    _reportPreview.openMode = frm_reportPreview.reportType.rt_bigLedger;
                    _reportPreview.s_KOL_id = s_KOL_id;
                    _reportPreview.s_whereExpresstion = buildTheWhereStatement();
                    _reportPreview.s_whereExpresstionForPriorTotals = s_whereForPriorTotals;
                }

                else if (rdu_journal.Checked)
                {
                    _reportPreview.openMode = frm_reportPreview.reportType.rt_jurnal;
                    _reportPreview.s_whereExpresstion = buildTheWhereStatement();
                    _reportPreview.s_whereExpresstionForPriorTotals = s_whereForPriorTotals;
                }

                else if (rdu_smallLedger.Checked)
                {

                    string s_MOEEN_id = "";
                    //s_MOEEN_id = (string)ds_accounting.tbl_MOEENs.Rows[bs_MOEENs.Position]["MOEEN_id"];
                    s_MOEEN_id = tbx_detailCode.Text;

                    _reportPreview.openMode = frm_reportPreview.reportType.rt_smallLedger;
                    _reportPreview.s_MOEEN_id = s_MOEEN_id;
                    _reportPreview.s_whereExpresstion = buildTheWhereStatement();
                    _reportPreview.s_whereExpresstionForPriorTotals = s_whereForPriorTotals;
                }

                //نمایش اسناد حذف شده  
                if (!chk_searchInDeletedInvoices.Checked)
                {
                    if (_reportPreview.s_whereExpresstion != "")
                    {
                        _reportPreview.s_whereExpresstion += " AND ";
                    }
                    _reportPreview.s_whereExpresstion += " (accDoc_deleted is null)";
                }

                if (!chk_searchInDeletedInvoices.Checked)
                {
                    if (_reportPreview.s_whereExpresstionForPriorTotals != "")
                    {
                        _reportPreview.s_whereExpresstionForPriorTotals += " AND ";
                        _reportPreview.s_whereExpresstionForPriorTotals += " (accDoc_deleted is null)";
                    }                    
                }
                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void rdu_showInDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                mTbx_inDate.Enabled = rdu_showInDate.Checked;
            }
            catch
            {
            }
        }

        private void rdu_showBetweenDates_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_betweenDates.Enabled = rdu_showBetweenDates.Checked;
            }
            catch
            {
            }
        }

        private void rdu_showBetweenAccDoc_ids_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_betweenIDs.Enabled = rdu_showBetweenAccDoc_ids.Checked;
            }
            catch
            {
            }
        }

        private void cmb_masterSpentName_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //cmb_masterSpentName_KeyPress(this, new KeyPressEventArgs(''));
            }
        }

        private void mTbx_inDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTbx_inDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_inDate.Text = cls_numberConvertor.makeChangeToDateString(mTbx_inDate.Text);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void mTbx_fromDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_fromDate.Text = cls_numberConvertor.makeChangeToDateString(mTbx_fromDate.Text);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void mTbx_toDate_Leave(object sender, EventArgs e)
        {
            try
            {
                mTbx_toDate.Text = cls_numberConvertor.makeChangeToDateString(mTbx_toDate.Text);
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }
        }

        private void chk_personsMoeenOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_personsMoeenOnly.Checked)
            {
                bs_MOEENs.Filter = "kol_id = '103'";
            }
            else
            {
                bs_MOEENs.RemoveFilter();
            }
        }

        private void bs_KOLs_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
