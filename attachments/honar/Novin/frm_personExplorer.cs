using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_personExplorer : Novin.frm_FATHER
    {
        public frm_personExplorer()
        {
            InitializeComponent();
        }

        private string sqlWhereStatementBuilder()
        {
            string s_sqlWhereStatement = "  (CASE WHEN dbo.tbl_persons.person_nowRemainMoney > 0 THEN dbo.tbl_persons.person_nowRemainMoney WHEN dbo.tbl_persons.person_nowRemainMoney < 0 THEN dbo.tbl_persons.person_nowRemainMoney ELSE 0 END {0} 0)";
            string s_value = "";

            if (chk_creditorPersons.Checked == chk_indebtedPersons.Checked && chk_unIndebtedUnCreditorPersons.Checked == chk_indebtedPersons.Checked)
            {
                s_sqlWhereStatement = "";
            }
            else
            {
                if (chk_creditorPersons.Checked)
                {
                    s_value += "<";
                }
                if (chk_indebtedPersons.Checked)
                {
                    s_value += ">";
                }                
                if (chk_unIndebtedUnCreditorPersons.Checked)
                {
                    s_value += "=";
                }
            }
            s_sqlWhereStatement = string.Format(s_sqlWhereStatement, s_value);
            
            if (chk_filterByVisitor.Checked)
            {
                if (s_sqlWhereStatement != "")
                {
                    s_sqlWhereStatement += " AND ";
                }
                s_value = ds_visitors.tbl_visitors.Rows[bs_visitors.Position]["visitor_id"].ToString();
                s_sqlWhereStatement += "(dbo.tbl_visitors.visitor_id = {0})";
                s_sqlWhereStatement = string.Format(s_sqlWhereStatement, s_value);
            }
            if (chk_filterByZone.Checked)
            {
                if (s_sqlWhereStatement != "")
                {
                    s_sqlWhereStatement += " AND ";
                }
                s_value = ds_visitors.tbl_zones.Rows[bs_zones.Position]["zone_id"].ToString();
                s_sqlWhereStatement += "(dbo.tbl_zones.zone_id = {0})";
                s_sqlWhereStatement = string.Format(s_sqlWhereStatement, s_value);
            }
                        
            return s_sqlWhereStatement;
        }

        private void frm_personExplorer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_visitors.tbl_zones' table. You can move, or remove it, as needed.
            this.tbl_zonesTableAdapter.Fill(this.ds_visitors.tbl_zones);
            // TODO: This line of code loads data into the 'ds_visitors.tbl_visitors' table. You can move, or remove it, as needed.
            this.tbl_visitorsTableAdapter.Fill(this.ds_visitors.tbl_visitors);

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            frm_reportPreview _reportPreview = new frm_reportPreview();

            _reportPreview.openMode = frm_reportPreview.reportType.rt_indebtedAndCreditors;
            _reportPreview.s_whereExpresstion = sqlWhereStatementBuilder();

            _reportPreview.prepareTheReport();
            _reportPreview.ShowDialog();
        }

        private void chk_filterByVisitor_CheckedChanged(object sender, EventArgs e)
        {
            grp_visitorSet.Enabled = chk_filterByVisitor.Checked;
            if (chk_filterByVisitor.Checked)
            {
                chk_filterByZone.Checked = false;
            }
        }

        private void chk_filterByZone_CheckedChanged(object sender, EventArgs e)
        {
            grp_zonesSet.Enabled = chk_filterByZone.Checked;
            if (chk_filterByZone.Checked)
            {
                chk_filterByVisitor.Checked = false;
            }
        }

        private void btn_newVisitor_Click(object sender, EventArgs e)
        {
            frm_visitors _visiotrs = new frm_visitors();
            _visiotrs.tabControl1.SelectedIndex = 0;
            _visiotrs.ShowDialog();
        }

        private void btn_newZone_Click(object sender, EventArgs e)
        {
            frm_visitors _visiotrs = new frm_visitors();
            _visiotrs.tabControl1.SelectedIndex = 1;
            _visiotrs.ShowDialog();
        }
    }
}
