using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_objectEntityReport : Novin.frm_FATHER
    {
        public frm_objectEntityReport()
        {
            InitializeComponent();
        }

        public enum objectReportType { objectEntity = 1, objectWasted , objectLessSell, objectCardex};
        public objectReportType openMode;
        private void frm_objectEntityReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_stores' table. You can move, or remove it, as needed.
            this.tbl_storesTableAdapter.Fill(this.ds_objectGrouping.tbl_stores);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);

            if (openMode == objectReportType.objectEntity)
            {
                this.Text = "   گــــزارش کــــالا";
                toolTip1.SetToolTip(chk_showAllObject, " نمایش تمام کالاها ");
            }
            else if (openMode == objectReportType.objectLessSell)
            {
                this.Text = "    گــــزارش کــــالا کم فروش";
                toolTip1.SetToolTip(chk_showAllObject, " نمایش تمام کالاهای کم مصرف ");
            }
            else
            {
                this.Text = "   گزارش ضایعات کــــالا";
                toolTip1.SetToolTip(chk_showAllObject, " نمایش تمام کالاها ضایعاتی ");
            }
        }

        private void rdu_slaveGroups_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_slaveGroups.Enabled = rdu_slaveGroups.Checked;
            }
            catch
            {
            }
        }

        private void rdu_object_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnl_Object.Enabled = rdu_object.Checked;
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (openMode == objectReportType.objectEntity)
            {
                frm_reportPreview _reportPreview = new frm_reportPreview();

                _reportPreview.openMode = frm_reportPreview.reportType.rt_objectsEntity;
                _reportPreview.s_whereExpresstion = buildTheWhereStatement();

                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            else if(openMode == objectReportType.objectWasted)
            {
                frm_reportPreview _reportPreview = new frm_reportPreview();

                _reportPreview.openMode = frm_reportPreview.reportType.rt_objectWasted;
                _reportPreview.s_whereExpresstion = buildTheWhereStatement();

                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            else if (openMode == objectReportType.objectLessSell)
            {
                frm_reportPreview _reportPreview = new frm_reportPreview();

                _reportPreview.openMode = frm_reportPreview.reportType.rt_objectLessSell;
                if (chk_showAllObject.Checked)
                {
                    _reportPreview.n_objectID = Convert.ToInt32(tbx_objectID.Text);
                    _reportPreview.n_slaveGroupID = Convert.ToInt32(tbx_SlaveGroupsID.Text);
                }
                else
                {
                    _reportPreview.n_objectID = -1;
                    _reportPreview.n_slaveGroupID = -1;
                }
                _reportPreview.prepareTheReport();
                _reportPreview.ShowDialog();
            }
            else if (openMode == objectReportType.objectCardex)
            {

            }
        }

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            if (!chk_showAllObject.Checked)
            {
                sWhere = "";
            }
            else if (rdu_slaveGroups.Checked)
            {
                sWhere = "dbo.tbl_objects.slaveGroup_id = " + tbx_SlaveGroupsID.Text;
            }
            else if (rdu_object.Checked)
            {
                sWhere = "dbo.tbl_objects.object_id = " + tbx_objectID.Text;
            }
            else if (rdu_filterByStore.Checked)
            {
                sWhere = "dbo.tbl_objects.store_id = " + tbx_store_id.Text;
            }
            return sWhere;
        }

        private void chk_showAllObject_CheckedChanged(object sender, EventArgs e)
        {
            gbx_TypeReport.Enabled = chk_showAllObject.Checked;
        }

        private void rdu_filterByStore_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                pnln_storesSet.Enabled = rdu_filterByStore.Checked;
            }
            catch
            {
            }
        }
    }//end class
}//end namespace
