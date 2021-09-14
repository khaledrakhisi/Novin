using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    public partial class frm_objectGrouping : Novin.frm_FATHER
    {
        public frm_objectGrouping()
        {
            InitializeComponent();
        }

        private void upDateTheDatabase()
        {
            try
            {
                this.Validate();

                bs_slaveGroups.EndEdit();
                tbl_slaveGroupsTableAdapter.Update(ds_objectGrouping.tbl_slaveGroups);//changed method Update

                bs_masterGroups.EndEdit();
                tbl_masterGroupsTableAdapter.Update(ds_objectGrouping.tbl_masterGroups);
            }
            catch
            {
            }
        }

        private void loadGroups()
        {
            int i = 0;

            treeView1.Nodes.Clear();

            try
            {
                foreach (DataRow _masterRow in ds_objectGrouping.tbl_masterGroups.Rows)
                {
                    bs_slaveGroups.Filter = "masterGroup_id = " + _masterRow["masterGroup_id"].ToString();

                    TreeNode[] treeNode = new TreeNode[bs_slaveGroups.Count];

                    i = 0;
                    int j = 0;
                    foreach (DataRow _slaveRow in ds_objectGrouping.tbl_slaveGroups.Rows)
                    {
                        if (ds_objectGrouping.tbl_slaveGroups.Rows[i]["masterGroup_id"].ToString() == _masterRow["masterGroup_id"].ToString())
                        {
                            //collecting the child nodes                    
                            TreeNode tt = new TreeNode(_slaveRow["slaveGroup_title"].ToString());
                            treeNode[j] = tt;
                            treeNode[j].Tag = _slaveRow["slaveGroup_id"].ToString();
                            j++;
                        }
                        i++;
                    }
                    //adding the root node
                    TreeNode treeRoot = new TreeNode(_masterRow["masterGroup_title"].ToString(), treeNode);
                    treeRoot.ForeColor = Color.Blue;

                    this.treeView1.Nodes.Add(treeRoot);
                    treeRoot.Tag = _masterRow["masterGroup_id"].ToString();
                }
                this.treeView1.RightToLeftLayout = true;

                bs_slaveGroups.RemoveFilter();
            }
            catch
            {
            }
        }        

        private void frm_objectGrouping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_slaveGroups' table. You can move, or remove it, as needed.
            this.tbl_slaveGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_slaveGroups);
            // TODO: This line of code loads data into the 'ds_objectGrouping.tbl_masterGroups' table. You can move, or remove it, as needed.
            this.tbl_masterGroupsTableAdapter.Fill(this.ds_objectGrouping.tbl_masterGroups);

            loadGroups();
        }

        private void btn_newMaster_Click(object sender, EventArgs e)
        {
            try
            {
                //make the record in the dataset
                DataRow drw_newMasterGroup;
                drw_newMasterGroup = ds_objectGrouping.tbl_masterGroups.NewRow();
                drw_newMasterGroup["masterGroup_title"] = "گروه اصلی بدون عنوان";
                int maxID = getMaxMasterGroupID();
                drw_newMasterGroup["masterGroup_id"] = maxID;
                ds_objectGrouping.tbl_masterGroups.Rows.Add(drw_newMasterGroup);

                //make the node
                TreeNode node = treeView1.Nodes.Add("گروه اصلی بدون عنوان");
                node.Tag = drw_newMasterGroup["masterGroup_id"];
                node.ForeColor = Color.Blue;
                treeView1.SelectedNode = node;
                this.tbx_selectedNodeText.Focus();

                upDateTheDatabase();
                //loadGroups();
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
            }           
        }

        private void btn_newSlave_Click(object sender, EventArgs e)
        {
            try
            {
                //make the record in the dataset
                DataRow drw_newSlaveGroup;
                drw_newSlaveGroup = ds_objectGrouping.tbl_slaveGroups.NewRow();
                int maxID = getMaxSlaveGroupID();
                drw_newSlaveGroup["slaveGroup_id"] = maxID;

                if (treeView1.SelectedNode.Level == 0)// if root entekhab bod
                    drw_newSlaveGroup["masterGroup_id"] = treeView1.SelectedNode.Tag;
                else //if children entekhab bod  bayad masterGroup_id az root gerefte shavad
                    drw_newSlaveGroup["masterGroup_id"] = treeView1.SelectedNode.Parent.Tag;

                drw_newSlaveGroup["slaveGroup_title"] = "گروه فرعی";
                ds_objectGrouping.tbl_slaveGroups.Rows.Add(drw_newSlaveGroup);

                TreeNode node;
                if (treeView1.SelectedNode.Level < 1)
                {
                    //make the node
                    node = treeView1.SelectedNode;
                }
                else
                {
                    node = treeView1.SelectedNode.Parent;
                }
                TreeNode childNode = node.Nodes.Add("گروه فرعی");
                childNode.Tag = drw_newSlaveGroup["slaveGroup_id"];
                treeView1.SelectedNode = childNode;
                this.tbx_selectedNodeText.Focus();

                upDateTheDatabase();
            }
            catch
            {
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                treeView1.LabelEdit = true;
                treeView1.SelectedNode.BeginEdit();
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upDateTheDatabase();
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            //baraye update shodan text dakhele treeView bayad be textBox beravat
            if (e.Label == null)
                tbx_selectedNodeText.Text = treeView1.SelectedNode.Text;
            else
                tbx_selectedNodeText.Text = e.Label;
            
            btn_modify.PerformClick();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //tbx_selectedNodeText.Text = e.Node.Text;
            tbx_selectedNodeText.Text = treeView1.SelectedNode.Text;
        }

        private void btn_deletePerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Level == 0)//if the selected node is root
                {
                    if (treeView1.SelectedNode.Nodes.Count > 0)//if the root has children
                    {
                        cls_msgBox.show("ابتدا زیر مجموعه را حذف کنید");
                    }
                    else//if the root has not children
                    {
                        bs_masterGroups.RemoveAt(bs_masterGroups.Find("masterGroup_id", treeView1.SelectedNode.Tag));
                        treeView1.SelectedNode.Remove();
                        upDateTheDatabase();
                    }
                }
                else if (treeView1.SelectedNode.Level > 0)//if the selected node is child
                {
                    //MessageBox.Show( ds_objectGrouping.tbl_slaveGroups.Rows.ToString());
                    int pos = bs_slaveGroups.Find("slaveGroup_id", treeView1.SelectedNode.Tag);
                    bs_slaveGroups.RemoveAt(pos);
                    treeView1.SelectedNode.Remove();
                    upDateTheDatabase();
                }
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)//edit
        {
            try
            {
                if (treeView1.SelectedNode.Level == 0)//if the selected node is root
                {
                    int pos = bs_masterGroups.Find("masterGroup_id", treeView1.SelectedNode.Tag);
                    ds_objectGrouping.tbl_masterGroups.Rows[pos]["masterGroup_title"] = tbx_selectedNodeText.Text;
                    treeView1.SelectedNode.Text = tbx_selectedNodeText.Text;
                    upDateTheDatabase();
                }
                else if (treeView1.SelectedNode.Level > 0)//if the selected node is child
                {
                    int pos = bs_slaveGroups.Find("slaveGroup_id", treeView1.SelectedNode.Tag);
                    ds_objectGrouping.tbl_slaveGroups.Rows[pos]["slaveGroup_title"] = tbx_selectedNodeText.Text;
                    treeView1.SelectedNode.Text = tbx_selectedNodeText.Text;
                    upDateTheDatabase();
                }
            }
            catch
            {
            }
        }

        private int getMaxMasterGroupID()
        {
            cls_myDataAccessLayer _myDal = new cls_myDataAccessLayer();

            _myDal.connect();
            int n_maxID = 1;
            try
            {
                n_maxID = (int)_myDal.doCommandScalar("Select MAX(masterGroup_id) FROM tbl_masterGroups") + 1;
                _myDal.disconnect();
            }
            catch{}
            return n_maxID;

        }


        private int getMaxSlaveGroupID()
        {
            cls_myDataAccessLayer _myDal = new cls_myDataAccessLayer();

            _myDal.connect();
            int n_maxID = 1;
            try
            {
                n_maxID = (int)_myDal.doCommandScalar("Select MAX(slaveGroup_id) FROM tbl_slaveGroups") + 1;
                _myDal.disconnect();
            }
            catch { }
            return n_maxID;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            upDateTheDatabase();
        }

        private void frm_objectGrouping_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_newMaster.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btn_modify.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_newSlave.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btn_deletePerson.PerformClick();
            }
        }
        
    }
}
