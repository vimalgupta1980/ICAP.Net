namespace Syscon.IndirectCostAllocation
{
    partial class FiltersPage
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lstJobSup = new System.Windows.Forms.ListBox();
            this.lstJobType = new System.Windows.Forms.ListBox();
            this.lstJobStatus = new System.Windows.Forms.ListBox();
            this.lblJobSup = new System.Windows.Forms.Label();
            this.lblJobType = new System.Windows.Forms.Label();
            this.lblJobSts = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.bttnBack);
            this.panelBottom.Controls.Add(this.bttnNext);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 364);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(701, 61);
            this.panelBottom.TabIndex = 12;
            // 
            // bttnBack
            // 
            this.bttnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.ForeColor = System.Drawing.Color.Black;
            this.bttnBack.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.back;
            this.bttnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnBack.Location = new System.Drawing.Point(526, 11);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(75, 39);
            this.bttnBack.TabIndex = 3;
            this.bttnBack.Text = "&Back";
            this.bttnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click_1);
            // 
            // bttnNext
            // 
            this.bttnNext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNext.ForeColor = System.Drawing.Color.Black;
            this.bttnNext.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.next;
            this.bttnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnNext.Location = new System.Drawing.Point(607, 11);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(75, 39);
            this.bttnNext.TabIndex = 2;
            this.bttnNext.Text = "&Next";
            this.bttnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click_1);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lstJobSup);
            this.panelMain.Controls.Add(this.lstJobType);
            this.panelMain.Controls.Add(this.lstJobStatus);
            this.panelMain.Controls.Add(this.lblJobSup);
            this.panelMain.Controls.Add(this.lblJobType);
            this.panelMain.Controls.Add(this.lblJobSts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(701, 364);
            this.panelMain.TabIndex = 13;
            // 
            // lstJobSup
            // 
            this.lstJobSup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobSup.FormattingEnabled = true;
            this.lstJobSup.ItemHeight = 15;
            this.lstJobSup.Items.AddRange(new object[] {
            "* - All"});
            this.lstJobSup.Location = new System.Drawing.Point(387, 51);
            this.lstJobSup.Name = "lstJobSup";
            this.lstJobSup.Size = new System.Drawing.Size(293, 289);
            this.lstJobSup.TabIndex = 13;
            // 
            // lstJobType
            // 
            this.lstJobType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobType.FormattingEnabled = true;
            this.lstJobType.ItemHeight = 15;
            this.lstJobType.Items.AddRange(new object[] {
            "* - All"});
            this.lstJobType.Location = new System.Drawing.Point(169, 51);
            this.lstJobType.Name = "lstJobType";
            this.lstJobType.Size = new System.Drawing.Size(196, 289);
            this.lstJobType.TabIndex = 12;
            // 
            // lstJobStatus
            // 
            this.lstJobStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobStatus.FormattingEnabled = true;
            this.lstJobStatus.ItemHeight = 15;
            this.lstJobStatus.Items.AddRange(new object[] {
            "* - All"});
            this.lstJobStatus.Location = new System.Drawing.Point(23, 49);
            this.lstJobStatus.Name = "lstJobStatus";
            this.lstJobStatus.Size = new System.Drawing.Size(128, 289);
            this.lstJobStatus.TabIndex = 11;
            // 
            // lblJobSup
            // 
            this.lblJobSup.AutoSize = true;
            this.lblJobSup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblJobSup.Location = new System.Drawing.Point(384, 24);
            this.lblJobSup.Name = "lblJobSup";
            this.lblJobSup.Size = new System.Drawing.Size(105, 17);
            this.lblJobSup.TabIndex = 10;
            this.lblJobSup.Text = "Job Supervisor";
            // 
            // lblJobType
            // 
            this.lblJobType.AutoSize = true;
            this.lblJobType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblJobType.Location = new System.Drawing.Point(166, 24);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(66, 17);
            this.lblJobType.TabIndex = 9;
            this.lblJobType.Text = "Job Type";
            // 
            // lblJobSts
            // 
            this.lblJobSts.AutoSize = true;
            this.lblJobSts.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobSts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblJobSts.Location = new System.Drawing.Point(20, 24);
            this.lblJobSts.Name = "lblJobSts";
            this.lblJobSts.Size = new System.Drawing.Size(77, 17);
            this.lblJobSts.TabIndex = 8;
            this.lblJobSts.Text = "Job Status";
            // 
            // FiltersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FiltersPage";
            this.Size = new System.Drawing.Size(701, 425);
            this.Load += new System.EventHandler(this.FiltersPage_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox lstJobSup;
        private System.Windows.Forms.ListBox lstJobType;
        private System.Windows.Forms.ListBox lstJobStatus;
        private System.Windows.Forms.Label lblJobSup;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblJobSts;
    }
}

