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

    public enum AllocationMethod
    {
        ByCost = 0,
        ByHours = 1,
        ByRevenue = 2
    }

    public partial class MainPage : UserControl
    {
        private List<string> _periodData = new List<string>();
        private AllocationMethod _allocationMethod = AllocationMethod.ByCost;
        private SetupParams _setupParams = new SetupParams();

        /// <summary>
        /// 
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            _periodData.Add("January");
            _periodData.Add("February");
            _periodData.Add("March");
            _periodData.Add("April");
            _periodData.Add("May");
            _periodData.Add("June");
            _periodData.Add("July");
            _periodData.Add("August");
            _periodData.Add("September");
            _periodData.Add("October");
            _periodData.Add("November");
            _periodData.Add("December");

            cboStartPeriod.DisplayMember = "Name";
            cboStartPeriod.ValueMember = null;

            cboPeriodEnd.DisplayMember = "Name";
            cboPeriodEnd.ValueMember = null;

            lstCostType.DisplayMember = "Name";
            lstCostType.ValueMember = null;
        }

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        public SetupParams SetupParameters
        {
            get { return _setupParams; }
            set { _setupParams = value; }
        }

        private int _fiscalYear;
        public int FiscalYear
        {
            get { return _fiscalYear; }
            set { _fiscalYear = value; }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            List<ListBoxData> startPeriodData = new List<ListBoxData>();
            List<ListBoxData> endPeriodData = new List<ListBoxData>();
            List<ListBoxData> costTypeData = new List<ListBoxData>();
            DataTable dt = null;

            txtMBDir.Text = this.MainForm.MbApi.smartGetSMBDir();

            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                //Fill Start and End period data
                for (int i = 0; i < _periodData.Count; i++)
                {
                    startPeriodData.Add(new ListBoxData() { Name = string.Format("{0} - {1}", i + 1, _periodData[i]), Value = (i+1).ToString() });
                }
                cboStartPeriod.DataSource = startPeriodData;

                //Fill nd period
                for (int i = 0; i < _periodData.Count; i++)
                {
                    endPeriodData.Add(new ListBoxData() { Name = string.Format("{0} - {1}", i + 1, _periodData[i]), Value = (i + 1).ToString() });
                }
                cboPeriodEnd.DataSource = endPeriodData;

                //Fill Cost Type
                string sqlStr = "SELECT RecNum, NVL(typnme, PADR('*-ALL', 20, ' ')) as typnme  FROM csttyp";
                dt = con.GetDataTable("CostType", sqlStr);

                costTypeData.Add(new ListBoxData() { Name = "* - ALL", Value = "0" });
                costTypeData.AddRange(dt.Rows.Select(p => new ListBoxData() { Name = (p[0].ToString().Trim() + " - " + p[1].ToString().Trim()), Value = p[0].ToString() }));
                lstCostType.DataSource = costTypeData;
            }
        }

        private void cbnoFiscalYear_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //If this value is changed, we must re-load the period selection for the new period
            //LOCAL lnFirstPeriod, lnLastPeriod, lnFiscalYear
            //LOCAL ARRAY aryMonths(12)

            //lnFirstPeriod = 1
            //lnLastPeriod = 1		&& There is at least one posting period in each fiscal year

            //WITH frmmain.pageframe1.tab1
            //    lnFiscalYear = VAL(.cboFiscalYear.text) 

            //    //Scan the array of available posting periods for the selected fiscal year
            //    FOR iCount = 1 TO ALEN(gaPostingPeriods,1)
            //        IF gaPostingPeriods(iCount,1) = lnFiscalYear
            //            lnLastPeriod = MAX(gaPostingPeriods(iCount,2),lnLastPeriod)
            //        ENDIF 
            //    NEXT iCount

            //    FOR iCount = 1 TO 12
            //        aryMonths(iCount) = CMONTH(DATE(lnFiscalYear,iCount,1))
            //    NEXT iCount
            //    .cboPeriodBeg.Clear
            //    .cboPeriodEnd.Clear

            //    For x = lnFirstPeriod TO lnLastPeriod
            //        .cboPeriodBeg.AddListItem(ALLTRIM(STR(x))+" - "+aryMonths(x),x)
            //        .cboPeriodEnd.AddListItem(ALLTRIM(STR(x))+" - "+aryMonths(x),x)
            //    EndFor 
            //    .cboPeriodBeg.Value = 1
            //    .cboPeriodEnd.Value = 1
            //ENDWITH 
             
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.MainPage);
            this.MainForm.Size = new Size(730, 530);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }       

        private void btnProgSetup_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_VisibleChanged(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void radByCost_CheckedChanged(object sender, EventArgs e)
        {
            _allocationMethod = AllocationMethod.ByCost;
        }

        private void radByHour_CheckedChanged(object sender, EventArgs e)
        {
            _allocationMethod = AllocationMethod.ByHours;
        }

        private void radByRevenue_CheckedChanged(object sender, EventArgs e)
        {
            _allocationMethod = AllocationMethod.ByRevenue;
        }

    }

}
