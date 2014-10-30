using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SysconCommon.Common.Environment;
using System.Reflection;
using System.IO;

namespace Syscon.IndirectCostAllocation
{
    public partial class SetupForm : Form
    {
        private string _originalAppTitle = string.Empty;
        private SysconCommon.COMMethods _mbApi = new SysconCommon.COMMethods();

        //public event EventHandler SMBDirChanged;
        private SetupParams _setupParams = null;

        public SetupForm(SetupParams setupParams)
        {
            InitializeComponent();

            _originalAppTitle = this.Text;
            _setupParams = setupParams;
        }

        private void FormSetup_Load(object sender, EventArgs e)
        {
            //Save params
            txtCompanyName.Text = Env.GetConfigVar("Company_Name");
            chkCopyPercent.Checked = Env.GetConfigVar<bool>("CopyPercentToJobcst", false, true);
            chkCreateReversal.Checked = Env.GetConfigVar<bool>("CreateReversalEntry", false, true);
           // txtSMBDir.Text = this.MainForm.MbApi.smartGetSMBDir();
        }

        public MainForm MainForm
        {
            get { return this.Owner as MainForm; }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://syscon-inc.com/product-support/CustomApplication/support.asp");
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save params
            _setupParams.CompanyName = txtCompanyName.Text;
            _setupParams.CopyPercentToJobcst = this.chkCopyPercent.Checked;
            _setupParams.CreateReversalEntry = this.chkCreateReversal.Checked;
            _setupParams.MBDir = this.txtSMBDir.Text;

            //Save Configuration to XML file
            Env.SetConfigVar("Company_Name", _setupParams.CompanyName);
            Env.SetConfigVar("CopyPercentToJobcst", _setupParams.CopyPercentToJobcst.ToString());
            Env.SetConfigVar("CreateReversalEntry", _setupParams.CreateReversalEntry);   

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            this.MainForm.MbApi.smartSelectSMBDirByGUI();
            var usr = this.MainForm.MbApi.RequireSMBLogin();
            if (usr != null)
            {
                txtSMBDir.Text = this.MainForm.MbApi.smartGetSMBDir();
                _setupParams.MBDir = txtSMBDir.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
