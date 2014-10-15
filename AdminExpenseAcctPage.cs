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

        /// <summary>
        /// 
        /// </summary>
        public AdminExpenseAcctPage()
        {
            InitializeComponent();

            _bindingSrc = new BindingSource();
            _adminExpenseDS = new DataSet("AdminExpense");
        }

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        public void LoadData()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                DataTable dt = con.GetDataTable("AdminExpenseData", "SELECT * FROM syslgract WHERE recnum > 7000 AND recnum < 8000");
                dt.TableName = "AdminExpenseData";
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
            }
        }

        private void bttnPreview_Click(object sender, EventArgs e)
        {

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
    }
}
