namespace Syscon.IndirectCostAllocation
{
    partial class AdvanceAllocationPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceAllocationPage));
            this.lblMethod = new System.Windows.Forms.Label();
            this.dgvAdvAllocation = new System.Windows.Forms.DataGridView();
            this.job_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.method1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop_orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop_ed_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dh_orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dh_ed_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adm_orig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adm_ed_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnRun = new System.Windows.Forms.Button();
            this.bttnReCalc = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.bttnPreview = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvAllocation)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(734, 5);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(138, 15);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Using Method 1 (Costs)";
            // 
            // dgvAdvAllocation
            // 
            this.dgvAdvAllocation.AllowUserToAddRows = false;
            this.dgvAdvAllocation.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvAllocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.job_name,
            this.method1,
            this.perc,
            this.shop_orig,
            this.shop_ed_cost,
            this.dh_orig,
            this.dh_ed_cost,
            this.adm_orig,
            this.adm_ed_cost});
            this.dgvAdvAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdvAllocation.Location = new System.Drawing.Point(0, 0);
            this.dgvAdvAllocation.Name = "dgvAdvAllocation";
            this.dgvAdvAllocation.RowHeadersWidth = 25;
            this.dgvAdvAllocation.Size = new System.Drawing.Size(940, 376);
            this.dgvAdvAllocation.TabIndex = 1;
            // 
            // job_name
            // 
            this.job_name.HeaderText = "Job Name";
            this.job_name.Name = "job_name";
            this.job_name.Width = 150;
            // 
            // method1
            // 
            this.method1.HeaderText = "(Method 1) Costs";
            this.method1.Name = "method1";
            // 
            // perc
            // 
            this.perc.HeaderText = "%";
            this.perc.Name = "perc";
            this.perc.Width = 60;
            // 
            // shop_orig
            // 
            this.shop_orig.HeaderText = "Shop Orig. Alloc.";
            this.shop_orig.Name = "shop_orig";
            // 
            // shop_ed_cost
            // 
            this.shop_ed_cost.HeaderText = "Shop Edited Costs";
            this.shop_ed_cost.Name = "shop_ed_cost";
            // 
            // dh_orig
            // 
            this.dh_orig.HeaderText = "D/H Orig. Alloc.";
            this.dh_orig.Name = "dh_orig";
            // 
            // dh_ed_cost
            // 
            this.dh_ed_cost.HeaderText = "D/H Edited Costs";
            this.dh_ed_cost.Name = "dh_ed_cost";
            // 
            // adm_orig
            // 
            this.adm_orig.HeaderText = "Admin Orig. Alloc.";
            this.adm_orig.Name = "adm_orig";
            // 
            // adm_ed_cost
            // 
            this.adm_ed_cost.HeaderText = "Admin Edited Costs";
            this.adm_ed_cost.Name = "adm_ed_cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Column Totals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(740, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Indirect Costs Allocated $";
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(22, 46);
            this.checkBox1.MaximumSize = new System.Drawing.Size(150, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 50);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Copy percentages to notes field of job costs records";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.Exit_new;
            this.bttnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnExit.Location = new System.Drawing.Point(826, 53);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(80, 38);
            this.bttnExit.TabIndex = 13;
            this.bttnExit.Text = "E&xit";
            this.bttnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnRun
            // 
            this.bttnRun.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRun.Image = global::Syscon.IndirectCostAllocation.Properties.Resources._save;
            this.bttnRun.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnRun.Location = new System.Drawing.Point(746, 53);
            this.bttnRun.Name = "bttnRun";
            this.bttnRun.Size = new System.Drawing.Size(80, 38);
            this.bttnRun.TabIndex = 12;
            this.bttnRun.Text = "&Run";
            this.bttnRun.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnRun.UseVisualStyleBackColor = true;
            this.bttnRun.Click += new System.EventHandler(this.bttnRun_Click);
            // 
            // bttnReCalc
            // 
            this.bttnReCalc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReCalc.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.fc_refresh;
            this.bttnReCalc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnReCalc.Location = new System.Drawing.Point(666, 53);
            this.bttnReCalc.Name = "bttnReCalc";
            this.bttnReCalc.Size = new System.Drawing.Size(80, 38);
            this.bttnReCalc.TabIndex = 11;
            this.bttnReCalc.Text = "Rec&alc";
            this.bttnReCalc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnReCalc.UseVisualStyleBackColor = true;
            this.bttnReCalc.Click += new System.EventHandler(this.bttnReCalc_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.back;
            this.bttnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnBack.Location = new System.Drawing.Point(586, 53);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(80, 38);
            this.bttnBack.TabIndex = 10;
            this.bttnBack.Text = "&Back";
            this.bttnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnPrint
            // 
            this.bttnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrint.Image = ((System.Drawing.Image)(resources.GetObject("bttnPrint.Image")));
            this.bttnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnPrint.Location = new System.Drawing.Point(506, 53);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(80, 38);
            this.bttnPrint.TabIndex = 9;
            this.bttnPrint.Text = "&Print";
            this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // bttnPreview
            // 
            this.bttnPreview.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPreview.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.p_PREVIEW;
            this.bttnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnPreview.Location = new System.Drawing.Point(426, 53);
            this.bttnPreview.Name = "bttnPreview";
            this.bttnPreview.Size = new System.Drawing.Size(80, 38);
            this.bttnPreview.TabIndex = 8;
            this.bttnPreview.Text = "Pre&view";
            this.bttnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnPreview.UseVisualStyleBackColor = true;
            this.bttnPreview.Click += new System.EventHandler(this.bttnPreview_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblMethod);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(940, 25);
            this.panelTop.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bttnRun);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bttnReCalc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bttnBack);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.bttnPrint);
            this.panel1.Controls.Add(this.bttnPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 114);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAdvAllocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 376);
            this.panel2.TabIndex = 16;
            // 
            // AdvanceAllocationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Name = "AdvanceAllocationPage";
            this.Size = new System.Drawing.Size(940, 515);
            this.Load += new System.EventHandler(this.AdvanceAllocationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvAllocation)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.DataGridView dgvAdvAllocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bttnPreview;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnReCalc;
        private System.Windows.Forms.Button bttnRun;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn method1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perc;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop_orig;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop_ed_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dh_orig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dh_ed_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn adm_orig;
        private System.Windows.Forms.DataGridViewTextBoxColumn adm_ed_cost;
    }
}