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
    public partial class FiltersPage : UserControl
    {        

        /// <summary>
        /// 
        /// </summary>
        public FiltersPage()
        {
            InitializeComponent();

            lstJobStatus.DisplayMember = "Name";
            lstJobStatus.ValueMember = null;

            lstJobType.DisplayMember = "Name";
            lstJobType.ValueMember = null;

            lstJobSup.DisplayMember = "Name";
            lstJobSup.ValueMember = null;
        }

        private MainForm MainForm
        {
            get { return this.ParentForm as MainForm; }
        }

        private void FiltersPage_Load(object sender, EventArgs e)
        {
            this.lstJobStatus.SelectedIndex = 0;
            this.lstJobType.SelectedIndex = 0;
            this.lstJobSup.SelectedIndex = 0;

            LoadCombos();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.FiltersPage);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.FiltersPage);
        }

        private void LoadCombos()
        {
            List<ListBoxData> jobStatusData = new List<ListBoxData>{ 
                                                                        new ListBoxData{Name = "* - All", Value="0"},
                                                                        new ListBoxData{Name = "1 - Bid", Value="1"},
                                                                        new ListBoxData{Name = "2 - Refused", Value="2"},
                                                                        new ListBoxData{Name = "3 - Contract", Value="3"},
                                                                        new ListBoxData{Name = "4 - Current", Value="4"},
                                                                        new ListBoxData{Name = "5 - Complete", Value="5"},
                                                                        new ListBoxData{Name = "6 - Closed", Value="6"}
                                                                    };
            lstJobStatus.DataSource = jobStatusData;

            DataTable dt = null;
            List<ListBoxData> jobTypeData = new List<ListBoxData>();
            List<ListBoxData> jobSupData = new List<ListBoxData>();

            using (var con = SysconCommon.Common.Environment.Connections.GetOLEDBConnection())
            {
                //Fill job Type
                string sqlStr = "SELECT RecNum, NVL(typnme, PADR('*-ALL', 20, ' ')) as typnme  FROM jobtyp";
                dt = con.GetDataTable("jobtype", sqlStr);

                jobTypeData.Add(new ListBoxData() { Name = "* - ALL", Value = "0" });
                jobTypeData.AddRange(dt.Rows.Select(p => new ListBoxData() { Name = (p[0].ToString().Trim() + " - " + p[1].ToString().Trim()), Value = p[0].ToString() }));
                lstJobType.DataSource = jobTypeData;

                //Fill Cost Type
                sqlStr = "SELECT DISTINCT actrec.sprvsr, employ.fulfst FROM actrec "
                            + "LEFT JOIN employ ON employ.recnum = actrec.sprvsr "
                            + " WHERE BETWEEN(actrec.status,4,5) AND actrec.sprvsr > 0 "
                            + " AND !DELETED() ORDER BY actrec.sprvsr";
                dt = con.GetDataTable("JobSupervisor", sqlStr);

                jobSupData.Add(new ListBoxData() { Name = "* - ALL", Value = "0" });
                jobSupData.AddRange(dt.Rows.Select(p => new ListBoxData() { Name = (p[0].ToString().Trim() + " - " + p[1].ToString().Trim()), Value = p[0].ToString() }));
                lstJobSup.DataSource = jobSupData;
            }
        }

        private void bttnBack_Click_1(object sender, EventArgs e)
        {
            this.MainForm.PreviousPage(ICAPPages.FiltersPage);
            this.MainForm.Size = new Size(750, 530);
        }

        private void bttnNext_Click_1(object sender, EventArgs e)
        {
            this.MainForm.NextPage(ICAPPages.FiltersPage);
            this.MainForm.Size = new Size(890, 630);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

    }
}
