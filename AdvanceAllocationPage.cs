using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.MainForm.Size = new System.Drawing.Size(880, 630);
        }

        private void bttnReCalc_Click(object sender, EventArgs e)
        {

        }

        private void bttnRun_Click(object sender, EventArgs e)
        {

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //Save data and exit
        }
    }
}
