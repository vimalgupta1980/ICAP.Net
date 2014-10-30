using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Algebras.DataTables;
using SysconCommon.Common;
using SysconCommon.Common.Environment;

namespace Syscon.IndirectCostAllocation
{
    public partial class OverheadExpenseAcctPage : UserControl
    {
        BindingSource _bindingSrc = null;
        DataSet _overheadExpenseDS = null;
        IList<ICAPDataModel> _overHeadExpenseData = null;
        private decimal _selectedPerAmount = 0.0M;
        
        /// <summary>
        /// 
        /// </summary>
        public OverheadExpenseAcctPage()
        {
            InitializeComponent();
            
            _bindingSrc = new BindingSource();
            _overheadExpenseDS = new DataSet("ShopExpense");
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
                cboOverheadExpOffsetAcct.DataSource=Offset;
                cboDirExpTarCostCode.DataSource = CostCode;
                cboDirExpTarCostType.DataSource = CostType;                
                
                DataTable dt = con.GetDataTable("OverheadExpenseData", "SELECT * FROM syslgract WHERE recnum >= 6000 AND recnum < 7000");
                dt.TableName = "ExpenseData";
                dt.Columns.Add(new DataColumn("TotalPerAmt", typeof(decimal)));

                _overheadExpenseDS.Tables.Add(dt);

                _overHeadExpenseData = new List<ICAPDataModel>();
                _overHeadExpenseData = DataTableHelper.ToList(dt);

                dgvOverheadExpAccts.DataBindings.Clear();
                dgvOverheadExpAccts.DataSource = null;

                //Restrict to only these 6 columns
                dgvOverheadExpAccts.AutoGenerateColumns = false;
               
                dgvOverheadExpAccts.ColumnCount = 6;
                dgvOverheadExpAccts.DataSource = dt;
                
                dgvOverheadExpAccts.Columns[0].DataPropertyName = "useAct";
                dgvOverheadExpAccts.Columns[1].DataPropertyName = "recnum";
                dgvOverheadExpAccts.Columns[3].DataPropertyName = "subact";
                dgvOverheadExpAccts.Columns[2].DataPropertyName = "lngnme";
                dgvOverheadExpAccts.Columns[4].DataPropertyName = "shtnme";
                dgvOverheadExpAccts.Columns[5].DataPropertyName = "peramt";               

                decimal totalAmount = 0.0M;
                decimal selTotalAmount = 0.0M;
                foreach (ICAPDataModel model in _overHeadExpenseData)
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
                    _overheadExpenseDS.Tables[0].Rows[0].SetField<decimal>("TotalPerAmt", selTotalAmount);

                _selectedPerAmount = selTotalAmount;
            }
        }

        private void UpdateStarTestGridRowColor()
        {

            foreach (DataGridViewRow row in dgvOverheadExpAccts.Rows)
            {
                if (row.Cells[3].Value.ToString() == "0") //**Object reference not set to an instance of an object**
                {
                    row.Cells[3].Style.ForeColor = Color.Red;
                }
            }

        }

        private void bttnPreview_Click(object sender, EventArgs e)
        {
            //Show report
            using (ExpenseReportViewerForm reportViewer = new ExpenseReportViewerForm(_overheadExpenseDS, _selectedPerAmount))
            {
                reportViewer.ShowDialog();
            }
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.OverheadExpensePage);
            this.MainForm.Size = new Size(890, 630);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.OverheadExpensePage);
            this.MainForm.Size = new Size(890, 630);
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                foreach (ICAPDataModel data in _overHeadExpenseData)
                {
                    data.UseAct = true;
                }
                chkUnselectAll.Checked = false;
                dgvOverheadExpAccts.Refresh();
            }
            LoadSelAmount();
        }

        private void chkUnselectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnselectAll.Checked)
            {
                foreach (ICAPDataModel data in _overHeadExpenseData)
                {
                    data.UseAct = false;
                }

                chkSelectAll.Checked = false;
                dgvOverheadExpAccts.Refresh();
            }
            if (_overheadExpenseDS.Tables["ExpenseData"].Rows.Count > 0)
                _overheadExpenseDS.Tables["ExpenseData"].Rows[0].SetField<decimal>("TotalPerAmt", 0.00M);

            _selectedPerAmount = 0.00M;
        }

        private void LoadSelAmount()
        {
            decimal sumSelAmt = 0.00M;
            foreach (ICAPDataModel data in _overHeadExpenseData)
            {
                if (data.UseAct)
                {
                    sumSelAmt += data.PerAmt;
                }
            }

            txtTotalCostSelected.Text = sumSelAmt.ToString();
            if (_overheadExpenseDS.Tables["ExpenseData"].Rows.Count > 0)
                _overheadExpenseDS.Tables["ExpenseData"].Rows[0].SetField<decimal>("TotalPerAmt", sumSelAmt);

            _selectedPerAmount = sumSelAmt;
        }

        private void chkHideZeroAccts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideZeroAccts.Checked)
            {
                IList<ICAPDataModel> tempList = null;

                tempList = _overHeadExpenseData.Where(d => d.PerAmt != 0.0M).ToList();

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
                foreach (ICAPDataModel data in _overHeadExpenseData)
                {
                    _bindingSrc.Add(data);
                }
            }
        }

        private void chkSortBySubAcct_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OverheadExpenseAcctPage_Load(object sender, EventArgs e)
        {
            LoadData();            
        }        

        private void dgvOverheadExpAccts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStarTestGridRowColor();

            if (e.ColumnIndex == dgvOverheadExpAccts.Columns["useAct"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxColumn col = dgvOverheadExpAccts.Columns["useAct"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxCell cell = dgvOverheadExpAccts.Rows[e.RowIndex].Cells["useAct"] as DataGridViewCheckBoxCell;

                bool enqueued = !((bool)cell.EditingCellFormattedValue);

                ICAPDataModel dataRow = (ICAPDataModel)dgvOverheadExpAccts.Rows[e.RowIndex].DataBoundItem;
                dataRow.UseAct = enqueued;

                this.LoadSelAmount();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void dgvOverheadExpAccts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

    }
}
