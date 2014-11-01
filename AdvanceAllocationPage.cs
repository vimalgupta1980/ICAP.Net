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
    /// <summary>
    /// 
    /// </summary>
    public partial class AdvanceAllocationPage : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public AdvanceAllocationPage()
        {
            InitializeComponent();

        }

        public void LoadData()
        {
            List<string> cosetyp = Globals.Instance.CostTypes;
            List<string> listJobType = Globals.Instance.JobStatus;
            List<string> listCostType = Globals.Instance.jobTypes;
            List<string> listJobSup = Globals.Instance.JobSupervisors;

            string strDirectExpTarAcct = Globals.Instance.GetDirectExpTarAcct;
            string strDirExpTarCostCode = Globals.Instance.GetDirExpTarCostCode;
            string strDirExpTarCostType = Globals.Instance.GetDirExpTarCostType;
            string strOverheadExpOffsetAcct = Globals.Instance.GetOverheadExpOffsetAcct;
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
            this.MainForm.PreviousPage(ICAPPages.AdvanceAllocationPage);
            this.MainForm.Size = new System.Drawing.Size(890, 630);
        }

        private void bttnReCalc_Click(object sender, EventArgs e)
        {

        }

       
        private void bttnRun_Click(object sender, EventArgs e)
        {
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                DataTable _dt = con.GetDataTable("lgtnln", "SELECT sum (lgtnln.dbtamt - lgtnln.crdamt) as lgrttl FROM lgrtrn LEFT JOIN lgtnln ON lgrtrn.recnum = lgtnln.recnum LEFT JOIN syslgract ON lgtnln.lgract = syslgract.recnum AND lgtnln.subact = sysLgrAct.subact WHERE lgrtrn.actprd BETWEEN 6 AND 8 AND lgrtrn.status < 3 AND SysLgrAct.acttyp in(14,15,16) AND syslgract.useact = .T.");
               
            }
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //Save data and exit
        }

        private void AdvanceAllocationPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
