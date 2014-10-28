using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using SysconCommon;
using SysconCommon.Algebras.DataTables;
using SysconCommon.Common.Environment;

namespace Syscon.IndirectCostAllocation
{
    public enum ICAPPages
    {
        MainPage = 0,
        FiltersPage = 1,
        ShopExpensePage = 2,
        OverheadExpensePage = 3,
        AdminExpensePage = 4,
        AdvanceAllocationPage = 5
    }

    public partial class MainForm : Form
    {
        private SysconCommon.COMMethods mbapi = new SysconCommon.COMMethods();
        private bool loaded = false;
        private SetupForm _setupForm = null;
        private MainPage _mainPage;
        private FiltersPage _filtersPage;
        private ShopExpenseAcctPage _shopExpAcctPage;
        private OverheadExpenseAcctPage _overExpAcctPage;
        private AdminExpenseAcctPage _adminExpAcctPage;
        private AdvanceAllocationPage _advAllocationPage;
        private SetupParams _setupParams;

        public MainForm()
        {
            InitializeComponent();

            //Create first page and add to the panel
            _mainPage = new MainPage();
            //this._mainPage.Location = new System.Drawing.Point(0, 0);
            this._mainPage.Name = ICAPPages.MainPage.ToString();
            //this._mainPage.Size = new System.Drawing.Size(758, 470);
            this._mainPage.TabIndex = 0;
            this._mainPage.Dock = DockStyle.Fill;
            _mainPage.Visible = true;
            _mainPage.BringToFront();
            this.panelPageContainer.Controls.Add(_mainPage);

            _filtersPage = new FiltersPage();
            //this._filtersPage.Location = new System.Drawing.Point(0, 0);
            this._filtersPage.Name = ICAPPages.FiltersPage.ToString();
            //this._filtersPage.Size = new System.Drawing.Size(758, 470);
            this._filtersPage.TabIndex = 0;
            this._filtersPage.Dock = DockStyle.Fill;
            _filtersPage.Visible = false;
            this.panelPageContainer.Controls.Add(_filtersPage);

            _shopExpAcctPage = new ShopExpenseAcctPage();
            //this._shopExpAcctPage.Location = new System.Drawing.Point(0, 0);
            this._shopExpAcctPage.Name = ICAPPages.ShopExpensePage.ToString();
            //this._shopExpAcctPage.Size = new System.Drawing.Size(758, 470);
            this._shopExpAcctPage.TabIndex = 0;
            this._shopExpAcctPage.Dock = DockStyle.Fill;
            _shopExpAcctPage.Visible = false;
            this.panelPageContainer.Controls.Add(_shopExpAcctPage);

            _overExpAcctPage = new OverheadExpenseAcctPage();
            //this._overExpAcctPage.Location = new System.Drawing.Point(0, 0);
            this._overExpAcctPage.Name = ICAPPages.OverheadExpensePage.ToString();
            //this._overExpAcctPage.Size = new System.Drawing.Size(758, 470);
            this._overExpAcctPage.TabIndex = 0;
            this._overExpAcctPage.Dock = DockStyle.Fill;
            _overExpAcctPage.Visible = false;
            this.panelPageContainer.Controls.Add(_overExpAcctPage);

            _adminExpAcctPage = new AdminExpenseAcctPage();
            //this._adminExpAcctPage.Location = new System.Drawing.Point(0, 0);
            this._adminExpAcctPage.Name = ICAPPages.AdminExpensePage.ToString();
            //this._adminExpAcctPage.Size = new System.Drawing.Size(758, 470);
            this._adminExpAcctPage.TabIndex = 0;
            this._adminExpAcctPage.Dock = DockStyle.Fill;
            _adminExpAcctPage.Visible = false;
            this.panelPageContainer.Controls.Add(_adminExpAcctPage);

            _advAllocationPage = new AdvanceAllocationPage();
            //this._overExpAcctPage.Location = new System.Drawing.Point(0, 0);
            this._overExpAcctPage.Name = ICAPPages.AdvanceAllocationPage.ToString();
            //this._overExpAcctPage.Size = new System.Drawing.Size(890, 470);
            this._overExpAcctPage.TabIndex = 0;
            this._overExpAcctPage.Dock = DockStyle.Fill;
            _overExpAcctPage.Visible = false;
            this.panelPageContainer.Controls.Add(_advAllocationPage);

            _setupParams = new SetupParams();
            _setupForm = new SetupForm(_setupParams);

            this._setupParams.SMBDirChanged += new EventHandler(Setup_SMBDirChanged);
        }
       
        public COMMethods MbApi
        {
            get { return mbapi; }
        }

        public void NextPage(ICAPPages currentPage)
        {
            this.panelPageContainer.Controls[(int)currentPage].Visible = false;

            UserControl page = this.panelPageContainer.Controls[(int)currentPage + 1] as UserControl;
            page.Visible = true;
        }

        public void PreviousPage(ICAPPages currentPage)
        {
            this.panelPageContainer.Controls[(int)currentPage].Visible = false;

            UserControl page = this.panelPageContainer.Controls[(int)currentPage - 1] as UserControl;
            page.Visible = true;            
        }

        void Setup_SMBDirChanged(object sender, EventArgs e)
        {

            CheckDefaults();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            // resets it everytime it is run so that the user can't just change to a product they already have a license for
            Env.SetConfigVar("product_id", 322504);

            var product_id = Env.GetConfigVar("product_id", 0, false);
            var product_version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            bool require_login = false;

            if (!loaded)
            {
                require_login = true;
                loaded = true;
                this.Text += " (version " + product_version + ")";
            }

            try
            {
                var license = SysconCommon.Protection.ProtectionInfo.GetLicense(product_id, product_version);
                if (license.IsTrial)
                {
                    if (!license.IsValid())
                    {
                        SetupInvalid();
                    }
                    else
                    {
                        var l = license as SysconCommon.Protection.TrialLicense;
                        SetupTrial(l.DaysLeft);
                    }
                }
                else
                {
                    SetupFull();
                }
            }
            catch
            {
                SetupInvalid();
            }

            if (require_login)
            {
                mbapi.smartGetSMBDir();

                if (mbapi.RequireSMBLogin() == null)
                    this.Close();
            }

            //CheckDefaults();
        }

        private void CheckDefaults()
        {
            string dataDir = mbapi.smartGetSMBDir();
            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                try
                {
                    string sqlSysLgractCreate = "CREATE TABLE SysLgract FREE ( RecNum	N, ShtNme	C(20), LngNme	C(30), "
                                                 + "SubAct	N, actnme	C(30), CtrAct	N, ActTyp	N, PerAmt	N(12,2), UseAct	L )";

                    string sqlSysTargetCreate = "CREATE TABLE SysTarget FREE ( tgrecnum	n(10,0), tgcstcde	n(10,0), tgcsttyp	n(10,0), " + 
                        "ofrecnum	n(10,0), serecnum	n(10,0), secstcde	n(11,3), secsttyp	n(10,0), seeqpnum	n(10,0), sorecnum	n(10,0), " 
                        + "ohrecnum	n(10,0), ohcstcde	n(11,3), ohcsttyp	n(10,0), oorecnum	n(10,0), adrecnum	n(10,0), adcstcde	n(11,3), " 
                        + "adcsttyp	n(10,0), aorecnum	n(10,0), rcrecnum	n(10,0), rvrecnum	n(10,0), o_method 	n(1,0) )";

                    string sysLgractFile = Path.Combine(dataDir, "SysLgract.dbf");
                    string sysTargetFile = Path.Combine(dataDir, "SysTarget.dbf");

                    if (!File.Exists(sysLgractFile))
                    {
                        //Create table
                        con.ExecuteNonQuery(sqlSysLgractCreate);

                        //Create Indexes
                        con.ExecuteNonQuery("EXECSCRIPT([SELECT syslgract])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON STR(subact,10,0)+STR(recnum,10,0) TAG actidx])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON STR(recnum,10,0)+STR(subact,10,0) TAG lgract])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON recnum TAG recnum])");                        
                    }
                    else
                    {
                        //Check that table is newest layout
	                    //force an update

                        //If old format
                        con.ExecuteNonQuery("EXECSCRIPT([COPY TO SysLgrTemp WITH cdx])");

                        //Create table
                        con.ExecuteNonQuery(sqlSysLgractCreate);

                        //Create Indexes
                        con.ExecuteNonQuery("EXECSCRIPT([SELECT syslgract])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON STR(subact,10,0)+STR(recnum,10,0) TAG actidx])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON STR(recnum,10,0)+STR(subact,10,0) TAG lgract])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON recnum TAG recnum])"); 

                    }

                    if (!File.Exists(sysTargetFile))
                    {
                        //Create table SysTarget
                        con.ExecuteNonQuery(sqlSysTargetCreate);
                        con.ExecuteNonQuery("EXECSCRIPT([SELECT systarget])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON serecnum TAG serecnum])");
                    }
                    else
                    {
                        //Check that table is newest layout

                        //If old format                        
                        con.ExecuteNonQuery("EXECSCRIPT([COPY TO SysTargetTemp WITH cdx])");

                        //Create table SysTarget
                        con.ExecuteNonQuery(sqlSysTargetCreate);
                        con.ExecuteNonQuery("EXECSCRIPT([SELECT systarget])");
                        con.ExecuteNonQuery("EXECSCRIPT([INDEX ON serecnum TAG serecnum])");
                    }
                }
                finally
                {
                    con.ExecuteNonQuery("EXECSCRIPT([SET EXCLUSIVE OFF])");
                }

                //Fill data to the tables

            }

        }

        private void BackupDbFile(string fileName, bool backUpCdx)
        {
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
        }
        
        #region Licencing

        private void SetupTrial(int daysLeft)
        {
            var msg = string.Format("You have {0} days left to evaluate this software. \nDo you want to activate it now?", daysLeft);
            if (MessageBox.Show(msg, "License info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //Show activation dialog
                TryActivation();
            }
            {
                InitializeFiscalYearSettings();
                this.Text = this.Text + string.Format(" - Trial ({0} days remaining)", daysLeft);
            }
        }

        private void InitializeFiscalYearSettings()
        {
            Globals globalData = Globals.Instance;

            globalData.DataSetVersion = SMBHelper.GetDataSetVersion();
            globalData.CurrentFiscalYear = SMBHelper.GetDataSetCurrentFY();
        }

        private void SetupInvalid()
        {
            //pageMain.Enabled = false;
            //this.demoLabel.Text = "Your License has expired or is invalid";
            if (MessageBox.Show("Your License has expired or is invalid. \nDo you want to activate the software?", "License info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //Show activation dialog
                TryActivation();
            }
            else
            {
                //TODO: Disable the screen

                this.Text = this.Text + "License expired";
            }
        }

        private void SetupFull()
        {
            InitializeFiscalYearSettings();
        }

        private void TryActivation()
        {
            var product_id = Env.GetConfigVar("product_id", 0, false);
            var product_version = Env.GetConfigVar("product_version", "1.0.0.0", false);

            var frm = new SysconCommon.Protection.ProtectionPlusOnlineActivationForm(product_id, product_version);
            frm.ShowDialog();
            this.OnLoad(null);
        }

        #endregion

    }  

}
