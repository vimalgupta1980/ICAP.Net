using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Syscon.IndirectCostAllocation
{
    public partial class ExpenseReportViewerForm : Form
    {
        private DataSet _sourceDS = null;

        public ExpenseReportViewerForm(DataSet sourceDS, decimal selectedPerAmt)
        {
            InitializeComponent();

            _sourceDS = sourceDS;

            this._reportViewer.LocalReport.SetParameters(new ReportParameter("paramTotalPerAmt", selectedPerAmt.ToString()));
            this._reportViewer.LocalReport.SetParameters(new ReportParameter("paramStartPeriod", "Period " + Globals.Instance.PeriodBeginning));
            this._reportViewer.LocalReport.SetParameters(new ReportParameter("paramEndPeriod", "Period " + Globals.Instance.PeriodEnd));
        }

        public void SetReport(string report)
        {
            this._reportViewer.LocalReport.ReportEmbeddedResource = report;
        }        

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            this.ShopExpenseBindingSource.DataSource = _sourceDS;
            this._reportViewer.RefreshReport();
        }
    }
}
