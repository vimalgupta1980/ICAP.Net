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
    /// <summary>
    /// UI for the shop expense accounts page.
    /// </summary>
    public partial class ShopExpenseAcctPage : UserControl
    {
        BindingSource _bindingSrc = null;
        DataSet _shopExpenseDS = null;
        IList<ICAPDataModel> _shopExpenseData = null;

        /// <summary>
        /// Ctor
        /// </summary>
        public ShopExpenseAcctPage()
        {
            InitializeComponent();

            _bindingSrc = new BindingSource();
            _shopExpenseDS = new DataSet("ShopExpense");
            
        }

        public void LoadData()
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                DataTable dt = con.GetDataTable("ShopExpenseData", "SELECT * FROM syslgract WHERE recnum > 5000 AND recnum < 6000");
                dt.TableName = "ShopExpenseData";
                _shopExpenseDS.Tables.Add(dt);

                _shopExpenseData = new List<ICAPDataModel>();
                _shopExpenseData = DataTableHelper.ToList(dt);

                dgvShopExpAccts.DataBindings.Clear();
                dgvShopExpAccts.DataSource = null;

                //Restrict to only these 6 columns
                dgvShopExpAccts.AutoGenerateColumns = false;
                dgvShopExpAccts.ColumnCount = 6;
                dgvShopExpAccts.DataSource = _bindingSrc;

                dgvShopExpAccts.Columns[0].DataPropertyName = "useAct";
                dgvShopExpAccts.Columns[1].DataPropertyName = "recnum";
                dgvShopExpAccts.Columns[2].DataPropertyName = "lngnme";
                dgvShopExpAccts.Columns[3].DataPropertyName = "subact";
                dgvShopExpAccts.Columns[4].DataPropertyName = "shtnme";
                dgvShopExpAccts.Columns[5].DataPropertyName = "peramt";

                _shopExpenseDS.WriteXml(@"D:\ShopExpenseData.xml");

                decimal totalAmount = 0.0M;
                decimal selTotalAmount = 0.0M;
                foreach (ICAPDataModel model in _shopExpenseData)
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
        

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        private void bttnPreview_Click(object sender, EventArgs e)
        {

        }

        private void bttnPrint_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.ShopExpensePage);
            this.MainForm.Size = new Size(730, 530);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.ShopExpensePage);
            this.MainForm.Size = new Size(880, 630);
        }

        private void ShopExpenseAcctPage_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void ShopExpenseAcctPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboDirExpTarAcct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDirExpTarCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboShopExpOffAcct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboData()
        {
            //cboDirExpTarAcct

            //cboDirExpTarCC

            //cboShopExpTarCT

            //cboShopExpOffAcct

            //cboEquipment

        }

        private void LoadSelAmount()
        {
            decimal sumSelAmt = 0.0M;
            foreach (ICAPDataModel data in _shopExpenseData)
            {
                if (data.UseAct)
                {
                    sumSelAmt += data.PerAmt;
                }
            }

            txtTotalCostSelected.Text = sumSelAmt.ToString();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked)
            {
                foreach (ICAPDataModel data in _shopExpenseData)
                {
                    data.UseAct = true;
                }
                chkUnselectAll.Checked = false;
                dgvShopExpAccts.Refresh();
            }

            LoadSelAmount();
        }

        private void chkUnselectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnselectAll.Checked)
            {
                foreach (ICAPDataModel data in _shopExpenseData)
                {
                    data.UseAct = false;
                }

                chkSelectAll.Checked = false;
                dgvShopExpAccts.Refresh();

                txtTotalCostSelected.Text = "0.00";
            }
        }

        private void chkHideZeroAccts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHideZeroAccts.Checked)
            {
                IList<ICAPDataModel> tempList = null;

                tempList = _shopExpenseData.Where(d => d.PerAmt != 0.0M).ToList();

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
                foreach (ICAPDataModel data in _shopExpenseData)
                {
                    _bindingSrc.Add(data);
                }
            }
        }

        private void chkSortBySubAcct_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvShopExpAccts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvShopExpAccts.Columns["useAct"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxColumn col = dgvShopExpAccts.Columns["useAct"] as DataGridViewCheckBoxColumn;
                DataGridViewCheckBoxCell cell = dgvShopExpAccts.Rows[e.RowIndex].Cells["useAct"] as DataGridViewCheckBoxCell;

                bool enqueued = !((bool)cell.EditingCellFormattedValue);

                ICAPDataModel dataRow = (ICAPDataModel)dgvShopExpAccts.Rows[e.RowIndex].DataBoundItem;
                dataRow.UseAct = enqueued;

                this.LoadSelAmount();
            }
        }

    }
}
