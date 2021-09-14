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
    public partial class frm_accountingChapters : frm_FATHER
    {
        public frm_accountingChapters()
        {
            InitializeComponent();
        }

        private void loadGroups()
        {
            int i = 0;

            treeView1.Nodes.Clear();            

            foreach (DataRow _KOLRow in ds_accounting.tbl_KOLs.Rows)
            {
                bs_MOEENs.Filter = "kol_id = " + _KOLRow["kol_id"].ToString();
                if (bs_MOEENs.Count > 0)
                {
                    TreeNode[] treeNode = new TreeNode[bs_MOEENs.Count];

                    i = 0;
                    int j = 0;
                    foreach (DataRow _MOEENRow in ds_accounting.tbl_MOEENs.Rows)
                    {
                        if (ds_accounting.tbl_MOEENs.Rows[i]["kol_id"].ToString() == _KOLRow["kol_id"].ToString())
                        {
                            //collecting the child nodes                    
                            TreeNode tt = new TreeNode(_MOEENRow["moeen_title"].ToString() + "  [" + _MOEENRow["moeen_id"].ToString() + "]");
                            treeNode[j] = tt;
                            treeNode[j].Tag = _MOEENRow["kol_id"].ToString();
                            treeNode[j].ForeColor = Color.Green;
                            j++;
                        }
                        i++;
                    }
                    //adding the root node
                    TreeNode treeRoot = new TreeNode(_KOLRow["kol_title"].ToString() + "  [" + _KOLRow["kol_id"].ToString() + "]", treeNode);
                    treeRoot.ForeColor = Color.Blue;

                    this.treeView1.Nodes.Add(treeRoot);
                    treeRoot.Tag = _KOLRow["kol_id"].ToString();
                }
            }
            this.treeView1.RightToLeftLayout = true;

            bs_MOEENs.RemoveFilter();
        }

        private void frm_accountingChapters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_accounting.tbl_TAFs' table. You can move, or remove it, as needed.
            this.tbl_TAFsTableAdapter.Fill(this.ds_accounting.tbl_TAFs);
            // TODO: This line of code loads data into the 'ds_accounting.tbl_MOEENs' table. You can move, or remove it, as needed.
            this.tbl_MOEENsTableAdapter.Fill(this.ds_accounting.tbl_MOEENs);
            // TODO: This line of code loads data into the 'ds_accounting.tbl_KOLs' table. You can move, or remove it, as needed.
            this.tbl_KOLsTableAdapter.Fill(this.ds_accounting.tbl_KOLs);

            loadGroups();

            if (cls_users.user_accountType != cls_users.userAccountTypes.uat_programmer)
            {
                lbl_prompt.Text = "دسترسی محدود است";    

                grp_actionsSet.Enabled = false;
                pnl_chapterPropsSet.Enabled = false;
            }
        }
    }
}
