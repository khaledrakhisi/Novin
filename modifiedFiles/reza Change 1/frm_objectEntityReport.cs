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

        private void frm_objectEntityReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_objects' table. You can move, or remove it, as needed.
            this.tbl_objectsTableAdapter.Fill(this.ds_objectGrouping.tbl_objects);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);
        }

        private void rdu_slaveGroups_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_slaveGroups.Checked)
                {
                    pnl_slaveGroups.Enabled = true;
                    pnl_Object.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void rdu_object_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdu_object.Checked)
                {
                    pnl_Object.Enabled = true;
                    pnl_slaveGroups.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            frm_reportPreview _reportPreview = new frm_reportPreview();

            _reportPreview.openMode = frm_reportPreview.reportType.rt_objectsEntity;
            _reportPreview.s_whereExpresstion = buildTheWhereStatement();

            _reportPreview.prepareTheReport();
            _reportPreview.ShowDialog();
        }

        private string buildTheWhereStatement()
        {
            string sWhere = "";
            if (chk_showAllObject.Checked)
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
            return sWhere;
        }

        private void chk_showAllObject_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_showAllObject.Checked)
            {
                pnl_Object.Enabled = false;
                pnl_slaveGroups.Enabled = false;
                gbx_TypeReport.Enabled = false;
            }
            else
            {
                pnl_Object.Enabled = true;
                pnl_slaveGroups.Enabled = true;
                gbx_TypeReport.Enabled = true;
            }
        }
    }//end class
}//end namespace
