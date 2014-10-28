namespace Syscon.IndirectCostAllocation
{
    partial class ExpenseReportViewerForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseReportViewerForm));
            this.ShopExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ShopExpenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopExpenseBindingSource
            // 
            this.ShopExpenseBindingSource.DataMember = "ExpenseData";
            this.ShopExpenseBindingSource.DataSource = typeof(Syscon.IndirectCostAllocation.Reports.ExpenseDS);
            // 
            // _reportViewer
            // 
            this._reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ExpenseDataSet";
            reportDataSource1.Value = this.ShopExpenseBindingSource;
            this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this._reportViewer.LocalReport.ReportEmbeddedResource = "Syscon.IndirectCostAllocation.Reports.tt_syslgract.rdlc";
            this._reportViewer.Location = new System.Drawing.Point(0, 0);
            this._reportViewer.Name = "_reportViewer";
            this._reportViewer.Size = new System.Drawing.Size(1084, 712);
            this._reportViewer.TabIndex = 0;
            // 
            // ExpenseReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 712);
            this.Controls.Add(this._reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpenseReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.Load += new System.EventHandler(this.ReportViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShopExpenseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer _reportViewer;
        private System.Windows.Forms.BindingSource ShopExpenseBindingSource;
    }
}