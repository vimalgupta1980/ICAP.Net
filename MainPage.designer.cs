namespace Syscon.IndirectCostAllocation
{
    partial class MainPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMBDir = new System.Windows.Forms.TextBox();
            this.lblAllocationMethod = new System.Windows.Forms.Label();
            this.radByCost = new System.Windows.Forms.RadioButton();
            this.radByHour = new System.Windows.Forms.RadioButton();
            this.radByRevenue = new System.Windows.Forms.RadioButton();
            this.lblFiscalYear = new System.Windows.Forms.Label();
            this.cbnoFiscalYear = new System.Windows.Forms.ComboBox();
            this.cboStartPeriod = new System.Windows.Forms.ComboBox();
            this.lblPeriodBeg = new System.Windows.Forms.Label();
            this.cboPeriodEnd = new System.Windows.Forms.ComboBox();
            this.lblPeriodEnd = new System.Windows.Forms.Label();
            this.lblCostType = new System.Windows.Forms.Label();
            this.lstCostType = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnProgSetup = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(46, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sage Master Builder Directory Location";
            // 
            // txtMBDir
            // 
            this.txtMBDir.BackColor = System.Drawing.SystemColors.Window;
            this.txtMBDir.Enabled = false;
            this.txtMBDir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMBDir.Location = new System.Drawing.Point(49, 25);
            this.txtMBDir.Name = "txtMBDir";
            this.txtMBDir.ReadOnly = true;
            this.txtMBDir.Size = new System.Drawing.Size(554, 21);
            this.txtMBDir.TabIndex = 1;
            // 
            // lblAllocationMethod
            // 
            this.lblAllocationMethod.AutoSize = true;
            this.lblAllocationMethod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocationMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAllocationMethod.Location = new System.Drawing.Point(47, 22);
            this.lblAllocationMethod.Name = "lblAllocationMethod";
            this.lblAllocationMethod.Size = new System.Drawing.Size(123, 16);
            this.lblAllocationMethod.TabIndex = 3;
            this.lblAllocationMethod.Text = "Allocation Method";
            // 
            // radByCost
            // 
            this.radByCost.AutoSize = true;
            this.radByCost.Checked = true;
            this.radByCost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radByCost.Location = new System.Drawing.Point(10, 6);
            this.radByCost.Name = "radByCost";
            this.radByCost.Size = new System.Drawing.Size(67, 19);
            this.radByCost.TabIndex = 4;
            this.radByCost.TabStop = true;
            this.radByCost.Text = "By Cost";
            this.radByCost.UseVisualStyleBackColor = true;
            this.radByCost.CheckedChanged += new System.EventHandler(this.radByCost_CheckedChanged);
            // 
            // radByHour
            // 
            this.radByHour.AutoSize = true;
            this.radByHour.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radByHour.Location = new System.Drawing.Point(77, 6);
            this.radByHour.Name = "radByHour";
            this.radByHour.Size = new System.Drawing.Size(75, 19);
            this.radByHour.TabIndex = 5;
            this.radByHour.Text = "By Hours";
            this.radByHour.UseVisualStyleBackColor = true;
            this.radByHour.CheckedChanged += new System.EventHandler(this.radByHour_CheckedChanged);
            // 
            // radByRevenue
            // 
            this.radByRevenue.AutoSize = true;
            this.radByRevenue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radByRevenue.Location = new System.Drawing.Point(151, 6);
            this.radByRevenue.Name = "radByRevenue";
            this.radByRevenue.Size = new System.Drawing.Size(90, 19);
            this.radByRevenue.TabIndex = 6;
            this.radByRevenue.Text = "By Revenue";
            this.radByRevenue.UseVisualStyleBackColor = true;
            this.radByRevenue.CheckedChanged += new System.EventHandler(this.radByRevenue_CheckedChanged);
            // 
            // lblFiscalYear
            // 
            this.lblFiscalYear.AutoSize = true;
            this.lblFiscalYear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiscalYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFiscalYear.Location = new System.Drawing.Point(47, 98);
            this.lblFiscalYear.Name = "lblFiscalYear";
            this.lblFiscalYear.Size = new System.Drawing.Size(77, 16);
            this.lblFiscalYear.TabIndex = 7;
            this.lblFiscalYear.Text = "Fiscal Year";
            // 
            // cbnoFiscalYear
            // 
            this.cbnoFiscalYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnoFiscalYear.FormattingEnabled = true;
            this.cbnoFiscalYear.Location = new System.Drawing.Point(49, 117);
            this.cbnoFiscalYear.Name = "cbnoFiscalYear";
            this.cbnoFiscalYear.Size = new System.Drawing.Size(164, 23);
            this.cbnoFiscalYear.TabIndex = 8;
            this.cbnoFiscalYear.SelectedIndexChanged += new System.EventHandler(this.cbnoFiscalYear_SelectedIndexChanged);
            // 
            // cboStartPeriod
            // 
            this.cboStartPeriod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStartPeriod.FormattingEnabled = true;
            this.cboStartPeriod.Location = new System.Drawing.Point(50, 173);
            this.cboStartPeriod.Name = "cboStartPeriod";
            this.cboStartPeriod.Size = new System.Drawing.Size(164, 23);
            this.cboStartPeriod.TabIndex = 10;
            this.cboStartPeriod.SelectedIndexChanged += new System.EventHandler(this.cbnoFiscalYear_SelectedIndexChanged);
            // 
            // lblPeriodBeg
            // 
            this.lblPeriodBeg.AutoSize = true;
            this.lblPeriodBeg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodBeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPeriodBeg.Location = new System.Drawing.Point(47, 154);
            this.lblPeriodBeg.Name = "lblPeriodBeg";
            this.lblPeriodBeg.Size = new System.Drawing.Size(104, 16);
            this.lblPeriodBeg.TabIndex = 9;
            this.lblPeriodBeg.Text = "Starting Period";
            // 
            // cboPeriodEnd
            // 
            this.cboPeriodEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodEnd.FormattingEnabled = true;
            this.cboPeriodEnd.Location = new System.Drawing.Point(50, 225);
            this.cboPeriodEnd.Name = "cboPeriodEnd";
            this.cboPeriodEnd.Size = new System.Drawing.Size(164, 23);
            this.cboPeriodEnd.TabIndex = 12;
            this.cboPeriodEnd.SelectedIndexChanged += new System.EventHandler(this.cbnoFiscalYear_SelectedIndexChanged);
            // 
            // lblPeriodEnd
            // 
            this.lblPeriodEnd.AutoSize = true;
            this.lblPeriodEnd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPeriodEnd.Location = new System.Drawing.Point(47, 206);
            this.lblPeriodEnd.Name = "lblPeriodEnd";
            this.lblPeriodEnd.Size = new System.Drawing.Size(98, 16);
            this.lblPeriodEnd.TabIndex = 11;
            this.lblPeriodEnd.Text = "Ending Period";
            // 
            // lblCostType
            // 
            this.lblCostType.AutoSize = true;
            this.lblCostType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCostType.Location = new System.Drawing.Point(334, 22);
            this.lblCostType.Name = "lblCostType";
            this.lblCostType.Size = new System.Drawing.Size(69, 16);
            this.lblCostType.TabIndex = 13;
            this.lblCostType.Text = "Cost Type";
            // 
            // lstCostType
            // 
            this.lstCostType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCostType.FormattingEnabled = true;
            this.lstCostType.ItemHeight = 15;
            this.lstCostType.Location = new System.Drawing.Point(337, 46);
            this.lstCostType.Name = "lstCostType";
            this.lstCostType.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCostType.Size = new System.Drawing.Size(259, 214);
            this.lstCostType.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radByRevenue);
            this.panel1.Controls.Add(this.radByCost);
            this.panel1.Controls.Add(this.radByHour);
            this.panel1.Location = new System.Drawing.Point(49, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 33);
            this.panel1.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.Exit_new;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(531, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(451, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "&Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnProgSetup
            // 
            this.btnProgSetup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgSetup.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.Setup;
            this.btnProgSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProgSetup.Location = new System.Drawing.Point(335, 6);
            this.btnProgSetup.Name = "btnProgSetup";
            this.btnProgSetup.Size = new System.Drawing.Size(112, 34);
            this.btnProgSetup.TabIndex = 16;
            this.btnProgSetup.Text = "Program Setup";
            this.btnProgSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProgSetup.UseVisualStyleBackColor = true;
            this.btnProgSetup.Click += new System.EventHandler(this.btnProgSetup_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.HELP;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.Location = new System.Drawing.Point(256, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 34);
            this.btnHelp.TabIndex = 15;
            this.btnHelp.Text = "&Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.btnHelp);
            this.panelBottom.Controls.Add(this.btnProgSetup);
            this.panelBottom.Controls.Add(this.btnNext);
            this.panelBottom.Controls.Add(this.btnExit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 329);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(635, 51);
            this.panelBottom.TabIndex = 22;
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtMBDir);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(635, 52);
            this.panelTop.TabIndex = 23;
            // 
            // panelMid
            // 
            this.panelMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMid.Controls.Add(this.lblAllocationMethod);
            this.panelMid.Controls.Add(this.lblFiscalYear);
            this.panelMid.Controls.Add(this.panel1);
            this.panelMid.Controls.Add(this.cbnoFiscalYear);
            this.panelMid.Controls.Add(this.lstCostType);
            this.panelMid.Controls.Add(this.lblPeriodBeg);
            this.panelMid.Controls.Add(this.lblCostType);
            this.panelMid.Controls.Add(this.cboStartPeriod);
            this.panelMid.Controls.Add(this.cboPeriodEnd);
            this.panelMid.Controls.Add(this.lblPeriodEnd);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 52);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(635, 277);
            this.panelMid.TabIndex = 24;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(635, 380);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.VisibleChanged += new System.EventHandler(this.MainPage_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMBDir;
        private System.Windows.Forms.Label lblAllocationMethod;

        private System.Windows.Forms.RadioButton radByCost;
        private System.Windows.Forms.RadioButton radByHour;
        private System.Windows.Forms.RadioButton radByRevenue;
        private System.Windows.Forms.Label lblFiscalYear;
        private System.Windows.Forms.ComboBox cbnoFiscalYear;
        private System.Windows.Forms.ComboBox cboStartPeriod;
        private System.Windows.Forms.Label lblPeriodBeg;
        private System.Windows.Forms.ComboBox cboPeriodEnd;
        private System.Windows.Forms.Label lblPeriodEnd;
        private System.Windows.Forms.Label lblCostType;
        private System.Windows.Forms.ListBox lstCostType;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnProgSetup;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMid;
    }
}
