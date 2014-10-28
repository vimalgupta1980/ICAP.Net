using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Common.Environment;

namespace Syscon.IndirectCostAllocation
{
    public partial class AdminExpenseAcctPage : UserControl
    {
        BindingSource _bindingSrc = null;
        DataSet _adminExpenseDS = null;
        IList<ICAPDataModel> _adminExpenseData = null;
        private decimal _selectedPerAmount = 0.0M;

        /// <summary>
        /// 
        /// </summary>
        public AdminExpenseAcctPage()
        {
            InitializeComponent();

            _bindingSrc = new BindingSource();
            _adminExpenseDS = new DataSet("Expense");
        }

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        List<string> Target = new List<string>();
        List<string> Offset = new List<string>();
        List<string> CostCode = new List<string>();
        List<string> CostType = new List<string>();

        public void LoadData()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                DataTable _dt = con.GetDataTable("TargetAccount", "SELECT * FROM lgract");
                foreach (DataRow row in _dt.Rows)
                {
                    if (Convert.ToInt32(row["acttyp"]) == 13)
                    {
                        Target.Add(row["recnum"].ToString() + " - " + row["lngnme"].ToString());
                    }

                }

                DataTable _dtOffset = con.GetDataTable("Offset", "SELECT * FROM syslgract");
                foreach (DataRow row in _dtOffset.Rows)
                {

                    if (Convert.ToInt32(row["acttyp"]) == 14)
                    {
                        Offset.Add(row["recnum"].ToString() + " - " + row["lngnme"].ToString());
                    }

                }

                DataTable _dtCostCode = con.GetDataTable("CostCode", "SELECT * FROM cstcde");
                foreach (DataRow row in _dtCostCode.Rows)
                {
                    CostCode.Add(row["recnum"].ToString() + " - " + row["cdenme"].ToString());
                    CostCode.Sort();
                }

                DataTable _dtCostType = con.GetDataTable("CostType", "SELECT * FROM csttyp");
                foreach (DataRow row in _dtCostType.Rows)
                {
                    CostType.Add(row["recnum"].ToString() + " - " + row["typnme"].ToString());

                }

                cboDirectExpTarAcct.DataSource = Target;
                cboOverheadExpOffsetAcct.DataSource = Offset;
                cboDirExpTarCostCode.DataSource = CostCode;
                cboDirExpTarCostType.DataSource = CostType;

                DataTable dt = con.GetDataTable("AdminExpenseData", "SELECT * FROM syslgract WHERE recnum > 7000 AND recnum < 8000");
                dt.TableName = "ExpenseData";
                dt.Columns.Add(new DataColumn("TotalPerAmt", typeof(decimal)));
                _adminExpenseDS.Tables.Add(dt);

                _adminExpenseData = new List<ICAPDataModel>();
                _adminExpenseData = DataTableHelper.ToList(dt);

                dgvOverheadExpAcct.DataBindings.Clear();
                dgvOverheadExpAcct.DataSource = null;

                //Restrict to only these 6 columns
                dgvOverheadExpAcct.AutoGenerateColumns = false;
                dgvOverheadExpAcct.ColumnCount = 6;
                dgvOverheadExpAcct.DataSource = _bindingSrc;

                dgvOverheadExpAcct.Columns[0].DataPropertyName = "useAct";
                dgvOverheadExpAcct.Columns[1].DataPropertyName = "recnum";
                dgvOverheadExpAcct.Columns[2].DataPropertyName = "lngnme";
                dgvOverheadExpAcct.Columns[3].DataPropertyName = "subact";
                dgvOverheadExpAcct.Columns[4].DataPropertyName = "shtnme";
                dgvOverheadExpAcct.Columns[5].DataPropertyName = "peramt";

                _adminExpenseDS.WriteXml(@"D:\AdminExpenseData.xml");
                _adminExpenseDS.WriteXmlSchema(@"D:\AdminExpenseData.xsd");

                decimal totalAmount = 0.0M;
                decimal selTotalAmount = 0.0M;
                foreach (ICAPDataModel model in _adminExpenseData)
                {
                    _bindingSrc.Add(model);

                    if (model.UseAct)
                    {
                        selTotalAmount += model.PerAmt;
                    }
                    totalAmount += model.PerAmt;
                }

                txtTotalCostInPeriod.Text = totalAmount.ToString();
                txtTotalCostSelected.Text = selTotalAmount.ToString();

                if (dt.Rows.Count > 0)
                    _adminExpenseDS.Tables[0].Rows[0].SetField<decimal>("TotalPerAmt", selTotalAmount);

                _selectedPerAmount = selTotalAmount;
            }
        }

        private void bttnPreview_Click(object sender, EventArgs e)
        {
            using (ExpenseReportViewerForm reportViewer = new ExpenseReportViewerForm(_adminExpenseDS, 0.0M))
            {
                reportViewer.ShowDialog();
            }
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.AdminExpensePage);
            this.MainForm.Size = new Size(880, 630);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.AdminExpensePage);
            this.MainForm.Size = new System.Drawing.Size(1050, 720);
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                foreach (ICAPDataModel data in _adminExpenseData)
                {
                    data.UseAct = true;
                }
                chkUnSelectAll.Checked = false;
                dgvOverheadExpAcct.Refresh();
            }
            this.LoadSelAmount();
        }

        private void chkUnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnSelectAll.Checked)
            {
                foreach (ICAPDataModel data in _adminExpenseData)
                {
                    data.UseAct = false;
                }

                chkSelectAll.Checked = false;
                dgvOverheadExpAcct.Refresh();
            }

            if (_adminExpenseDS.Tables["ExpenseData"].Rows.Count > 0)
                _adminExpenseDS.Tables["ExpenseData"].Rows[0].SetField<decimal>("TotalPerAmt", 0.0M);

            _selectedPerAmount = 0.0M;
        }

        private void chkHideZeroAccts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideZeroAccts.Checked)
            {
                IList<ICAPDataModel> tempList = null;

                tempList = _adminExpenseData.Where(d => d.PerAmt != 0.0M).ToList();

                if (tempList != null)
                {
                    _bindingSrc.Clear();
                    foreach (ICAPDataModel data in tempList)
                    {
                        _bindingSrc.Add(data);
                    }
                }
            }
            else
            {
                _bindingSrc.Clear();
                foreach (ICAPDataModel data in _adminExpenseData)
                {
                    _bindingSrc.Add(data);
                }
            }
        }

        private void chkSortBySubAcct_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminExpenseAcctPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvOverheadExpAcct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOverheadExpAcct.Columns["useAct"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxColumn col = dgvOverheadExpAcct.Columns["useAct"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxCell cell = dgvOverheadExpAcct.Rows[e.RowIndex].Cells["useAct"] as DataGridViewCheckBoxCell;

                bool enqueued = !((bool)cell.EditingCellFormattedValue);

                ICAPDataModel dataRow = (ICAPDataModel)dgvOverheadExpAcct.Rows[e.RowIndex].DataBoundItem;
                dataRow.UseAct = enqueued;

                this.LoadSelAmount();
            }
        }

        private void LoadSelAmount()
        {
            decimal sumSelAmt = 0.0M;
            foreach (ICAPDataModel data in _adminExpenseData)
            {
                if (data.UseAct)
                {
                    sumSelAmt += data.PerAmt;
                }
            }

            txtTotalCostSelected.Text = sumSelAmt.ToString();
            if (_adminExpenseDS.Tables["ExpenseData"].Rows.Count > 0)
                _adminExpenseDS.Tables["ExpenseData"].Rows[0].SetField<decimal>("TotalPerAmt", sumSelAmt);

            _selectedPerAmount = sumSelAmt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
