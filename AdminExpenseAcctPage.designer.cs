namespace Syscon.IndirectCostAllocation
{
    partial class AdminExpenseAcctPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.chkUnSelectAll = new System.Windows.Forms.CheckBox();
            this.chkHideZeroAccts = new System.Windows.Forms.CheckBox();
            this.chkSortBySubAcct = new System.Windows.Forms.CheckBox();
            this.dgvOverheadExpAcct = new System.Windows.Forms.DataGridView();
            this.useAct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Acc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDirectExpTarAcct = new System.Windows.Forms.ComboBox();
            this.cboDirExpTarCostCode = new System.Windows.Forms.ComboBox();
            this.cboDirExpTarCostType = new System.Windows.Forms.ComboBox();
            this.cboOverheadExpOffsetAcct = new System.Windows.Forms.ComboBox();
            this.txtTotalCostSelected = new System.Windows.Forms.TextBox();
            this.txtTotalCostInPeriod = new System.Windows.Forms.TextBox();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.bttnPreview = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnBack = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverheadExpAcct)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Expense Accounts";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.Location = new System.Drawing.Point(201, 8);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(75, 19);
            this.chkSelectAll.TabIndex = 1;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // chkUnSelectAll
            // 
            this.chkUnSelectAll.AutoSize = true;
            this.chkUnSelectAll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnSelectAll.Location = new System.Drawing.Point(290, 8);
            this.chkUnSelectAll.Name = "chkUnSelectAll";
            this.chkUnSelectAll.Size = new System.Drawing.Size(95, 19);
            this.chkUnSelectAll.TabIndex = 2;
            this.chkUnSelectAll.Text = "Un-Select All";
            this.chkUnSelectAll.UseVisualStyleBackColor = true;
            this.chkUnSelectAll.CheckedChanged += new System.EventHandler(this.chkUnSelectAll_CheckedChanged);
            // 
            // chkHideZeroAccts
            // 
            this.chkHideZeroAccts.AutoSize = true;
            this.chkHideZeroAccts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHideZeroAccts.Location = new System.Drawing.Point(402, 8);
            this.chkHideZeroAccts.Name = "chkHideZeroAccts";
            this.chkHideZeroAccts.Size = new System.Drawing.Size(121, 19);
            this.chkHideZeroAccts.TabIndex = 3;
            this.chkHideZeroAccts.Text = "Hide $0 Accounts";
            this.chkHideZeroAccts.UseVisualStyleBackColor = true;
            this.chkHideZeroAccts.CheckedChanged += new System.EventHandler(this.chkHideZeroAccts_CheckedChanged);
            // 
            // chkSortBySubAcct
            // 
            this.chkSortBySubAcct.AutoSize = true;
            this.chkSortBySubAcct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSortBySubAcct.Location = new System.Drawing.Point(540, 8);
            this.chkSortBySubAcct.Name = "chkSortBySubAcct";
            this.chkSortBySubAcct.Size = new System.Drawing.Size(131, 19);
            this.chkSortBySubAcct.TabIndex = 4;
            this.chkSortBySubAcct.Text = "Sort by Subaccount";
            this.chkSortBySubAcct.UseVisualStyleBackColor = true;
            this.chkSortBySubAcct.CheckedChanged += new System.EventHandler(this.chkSortBySubAcct_CheckedChanged);
            // 
            // dgvOverheadExpAcct
            // 
            this.dgvOverheadExpAcct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvOverheadExpAcct.AllowUserToAddRows = false;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOverheadExpAcct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOverheadExpAcct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOverheadExpAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverheadExpAcct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOverheadExpAcct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverheadExpAcct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useAct,
            this.Account,
            this.Account_Name,
            this.Sub_Account,
            this.Sub_Acc_Name,
            this.Period});
            this.dgvOverheadExpAcct.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvOverheadExpAcct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOverheadExpAcct.EnableHeadersVisualStyles = false;
            this.dgvOverheadExpAcct.GridColor = System.Drawing.Color.Navy;
            this.dgvOverheadExpAcct.Location = new System.Drawing.Point(0, 0);
            this.dgvOverheadExpAcct.Name = "dgvOverheadExpAcct";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverheadExpAcct.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvOverheadExpAcct.RowHeadersWidth = 20;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            this.dgvOverheadExpAcct.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvOverheadExpAcct.RowTemplate.Height = 18;
            this.dgvOverheadExpAcct.ShowCellToolTips = false;
            this.dgvOverheadExpAcct.Size = new System.Drawing.Size(858, 312);
            this.dgvOverheadExpAcct.TabIndex = 5;
            this.dgvOverheadExpAcct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverheadExpAcct_CellClick);
            // 
            // useAct
            // 
            this.useAct.HeaderText = "";
            this.useAct.Name = "useAct";
            this.useAct.Width = 20;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 90;
            // 
            // Account_Name
            // 
            this.Account_Name.HeaderText = "Account Name";
            this.Account_Name.Name = "Account_Name";
            this.Account_Name.ReadOnly = true;
            this.Account_Name.Width = 200;
            // 
            // Sub_Account
            // 
            this.Sub_Account.HeaderText = "Sub-Account";
            this.Sub_Account.Name = "Sub_Account";
            this.Sub_Account.ReadOnly = true;
            this.Sub_Account.Width = 120;
            // 
            // Sub_Acc_Name
            // 
            this.Sub_Acc_Name.HeaderText = "Sub-Account Name";
            this.Sub_Acc_Name.Name = "Sub_Acc_Name";
            this.Sub_Acc_Name.ReadOnly = true;
            this.Sub_Acc_Name.Width = 175;
            // 
            // Period
            // 
            this.Period.HeaderText = "Period $ Amt";
            this.Period.Name = "Period";
            this.Period.ReadOnly = true;
            this.Period.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Direct Expense Target Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direct Expense Target Cost Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direct Expense Target Cost Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "O/H Expense Offset Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Costs in Period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(459, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Costs Selected";
            // 
            // cboDirectExpTarAcct
            // 
            this.cboDirectExpTarAcct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDirectExpTarAcct.FormattingEnabled = true;
            this.cboDirectExpTarAcct.Location = new System.Drawing.Point(202, 15);
            this.cboDirectExpTarAcct.Name = "cboDirectExpTarAcct";
            this.cboDirectExpTarAcct.Size = new System.Drawing.Size(240, 23);
            this.cboDirectExpTarAcct.TabIndex = 12;
            // 
            // cboDirExpTarCostCode
            // 
            this.cboDirExpTarCostCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDirExpTarCostCode.FormattingEnabled = true;
            this.cboDirExpTarCostCode.Location = new System.Drawing.Point(202, 41);
            this.cboDirExpTarCostCode.Name = "cboDirExpTarCostCode";
            this.cboDirExpTarCostCode.Size = new System.Drawing.Size(240, 23);
            this.cboDirExpTarCostCode.TabIndex = 13;
            // 
            // cboDirExpTarCostType
            // 
            this.cboDirExpTarCostType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDirExpTarCostType.FormattingEnabled = true;
            this.cboDirExpTarCostType.Location = new System.Drawing.Point(202, 67);
            this.cboDirExpTarCostType.Name = "cboDirExpTarCostType";
            this.cboDirExpTarCostType.Size = new System.Drawing.Size(240, 23);
            this.cboDirExpTarCostType.TabIndex = 14;
            // 
            // cboOverheadExpOffsetAcct
            // 
            this.cboOverheadExpOffsetAcct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOverheadExpOffsetAcct.FormattingEnabled = true;
            this.cboOverheadExpOffsetAcct.Location = new System.Drawing.Point(202, 92);
            this.cboOverheadExpOffsetAcct.Name = "cboOverheadExpOffsetAcct";
            this.cboOverheadExpOffsetAcct.Size = new System.Drawing.Size(240, 23);
            this.cboOverheadExpOffsetAcct.TabIndex = 15;
            // 
            // txtTotalCostSelected
            // 
            this.txtTotalCostSelected.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalCostSelected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCostSelected.Location = new System.Drawing.Point(581, 44);
            this.txtTotalCostSelected.Name = "txtTotalCostSelected";
            this.txtTotalCostSelected.ReadOnly = true;
            this.txtTotalCostSelected.Size = new System.Drawing.Size(194, 21);
            this.txtTotalCostSelected.TabIndex = 16;
            // 
            // txtTotalCostInPeriod
            // 
            this.txtTotalCostInPeriod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalCostInPeriod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCostInPeriod.Location = new System.Drawing.Point(581, 18);
            this.txtTotalCostInPeriod.Name = "txtTotalCostInPeriod";
            this.txtTotalCostInPeriod.ReadOnly = true;
            this.txtTotalCostInPeriod.Size = new System.Drawing.Size(194, 21);
            this.txtTotalCostInPeriod.TabIndex = 17;
            // 
            // bttnPrint
            // 
            this.bttnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrint.Location = new System.Drawing.Point(526, 74);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(65, 37);
            this.bttnPrint.TabIndex = 19;
            this.bttnPrint.Text = "&Print";
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // bttnPreview
            // 
            this.bttnPreview.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPreview.Location = new System.Drawing.Point(462, 74);
            this.bttnPreview.Name = "bttnPreview";
            this.bttnPreview.Size = new System.Drawing.Size(64, 37);
            this.bttnPreview.TabIndex = 20;
            this.bttnPreview.Text = "Pre&view";
            this.bttnPreview.UseVisualStyleBackColor = true;
            this.bttnPreview.Click += new System.EventHandler(this.bttnPreview_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnNext.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNext.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.next;
            this.bttnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnNext.Location = new System.Drawing.Point(655, 74);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(65, 37);
            this.bttnNext.TabIndex = 21;
            this.bttnNext.Text = "&Next";
            this.bttnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // bttnBack
            // 
            this.bttnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBack.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.back;
            this.bttnBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttnBack.Location = new System.Drawing.Point(591, 74);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(64, 37);
            this.bttnBack.TabIndex = 18;
            this.bttnBack.Text = "&Back";
            this.bttnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttnBack.UseVisualStyleBackColor = true;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.chkSelectAll);
            this.panelTop.Controls.Add(this.chkUnSelectAll);
            this.panelTop.Controls.Add(this.chkHideZeroAccts);
            this.panelTop.Controls.Add(this.chkSortBySubAcct);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(858, 30);
            this.panelTop.TabIndex = 22;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnExit);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.bttnNext);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.bttnPreview);
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.bttnPrint);
            this.panelBottom.Controls.Add(this.label6);
            this.panelBottom.Controls.Add(this.bttnBack);
            this.panelBottom.Controls.Add(this.label7);
            this.panelBottom.Controls.Add(this.txtTotalCostInPeriod);
            this.panelBottom.Controls.Add(this.cboDirectExpTarAcct);
            this.panelBottom.Controls.Add(this.txtTotalCostSelected);
            this.panelBottom.Controls.Add(this.cboDirExpTarCostCode);
            this.panelBottom.Controls.Add(this.cboOverheadExpOffsetAcct);
            this.panelBottom.Controls.Add(this.cboDirExpTarCostType);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 342);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(858, 130);
            this.panelBottom.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::Syscon.IndirectCostAllocation.Properties.Resources.Exit_new;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(720, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 38);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "&Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.dgvOverheadExpAcct);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 30);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(858, 312);
            this.panelMid.TabIndex = 24;
            // 
            // AdminExpenseAcctPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "AdminExpenseAcctPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(788, 472);
            this.Load += new System.EventHandler(this.AdminExpenseAcctPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverheadExpAcct)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.CheckBox chkUnSelectAll;
        private System.Windows.Forms.CheckBox chkHideZeroAccts;
        private System.Windows.Forms.CheckBox chkSortBySubAcct;
        private System.Windows.Forms.DataGridView dgvOverheadExpAcct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDirectExpTarAcct;
        private System.Windows.Forms.ComboBox cboDirExpTarCostCode;
        private System.Windows.Forms.ComboBox cboDirExpTarCostType;
        private System.Windows.Forms.ComboBox cboOverheadExpOffsetAcct;
        private System.Windows.Forms.TextBox txtTotalCostSelected;
        private System.Windows.Forms.TextBox txtTotalCostInPeriod;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.Button bttnPreview;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Acc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.Button btnExit;
    }
}