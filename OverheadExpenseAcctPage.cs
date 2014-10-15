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

        /// <summary>
        /// 
        /// </summary>
        public OverheadExpenseAcctPage()
        {
            InitializeComponent();

            _bindingSrc = new BindingSource();
            _overheadExpenseDS = new DataSet("OverheadExpense");
        }

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        public void LoadData()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                DataTable dt = con.GetDataTable("OverheadExpenseData", "SELECT * FROM syslgract WHERE recnum > 6000 AND recnum < 7000");
                dt.TableName = "OverheadExpenseData";
                _overheadExpenseDS.Tables.Add(dt);

                _overHeadExpenseData = new List<ICAPDataModel>();
                _overHeadExpenseData = DataTableHelper.ToList(dt);

                dgvOverheadExpAccts.DataBindings.Clear();
                dgvOverheadExpAccts.DataSource = null;

                //Restrict to only these 6 columns
                dgvOverheadExpAccts.AutoGenerateColumns = false;
                dgvOverheadExpAccts.ColumnCount = 6;
                dgvOverheadExpAccts.DataSource = _bindingSrc;

                dgvOverheadExpAccts.Columns[0].DataPropertyName = "useAct";
                dgvOverheadExpAccts.Columns[1].DataPropertyName = "recnum";
                dgvOverheadExpAccts.Columns[2].DataPropertyName = "lngnme";
                dgvOverheadExpAccts.Columns[3].DataPropertyName = "subact";
                dgvOverheadExpAccts.Columns[4].DataPropertyName = "shtnme";
                dgvOverheadExpAccts.Columns[5].DataPropertyName = "peramt";

                _overheadExpenseDS.WriteXml(@"D:\OverheadExpenseData.xml");

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
            }
        }

        private void bttnPreview_Click(object sender, EventArgs e)
        {
            //Show report
        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.OverheadExpensePage);
            this.MainForm.Size = new Size(880, 630);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.OverheadExpensePage);
            this.MainForm.Size = new Size(880, 630);
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
    }
}
