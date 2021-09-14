using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Novin
{
    public partial class frm_print : Form
    {
        public frm_print()
        {
            InitializeComponent();
        }

        public string s_paraName = "";
        public string s_paraValue = "";
        public string s_reportFilePath = "";
        public DataTable dt_report;
        public DataSet ds_report;
        public bool b_useDataset = false;


        private void SetParameterFieldInfo(String fieldName, String fieldValue)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterDiscreteValue.Value = fieldValue;

            ParameterValues currentParameterValues = new ParameterValues();

            currentParameterValues.Add(parameterDiscreteValue);

            ParameterField parameterField = new ParameterField();

            parameterField.Name = fieldName;
            parameterField.CurrentValues = currentParameterValues;

            ParameterFields parameterFields = new ParameterFields();

            parameterFields.Add(parameterField);

            crystalReportViewer1.ParameterFieldInfo = parameterFields;
        }

        private void frm_print_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rp = new ReportDocument();
                rp.Load(s_reportFilePath);

                if (b_useDataset)
                {
                    rp.SetDataSource(ds_report);
                }
                else
                {
                    rp.SetDataSource(dt_report);
                }
                
                crystalReportViewer1.ReportSource = rp;

                //SetParameterFieldInfo("TotalInChars", numberConvertor.convertToChars(s_total) + " ریال ");
                if (s_paraName != "")
                {
                    SetParameterFieldInfo(s_paraName, s_paraValue);
                }
                crystalReportViewer1.Zoom(100);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_print_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.P)
                {
                    crystalReportViewer1.PrintReport();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
