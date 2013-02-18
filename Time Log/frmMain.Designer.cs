namespace Time_Log
{
    partial class frmMain
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("WorkDateByPayDate", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WorkDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WorkDate", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CurrentTimeLogShort", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeLogId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WorkDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Start");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Finish");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hours");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProjDesc = new System.Windows.Forms.Label();
            this.chkOvertime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbEndTime = new System.Windows.Forms.ComboBox();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.btnTimeLog = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.cbPaydate = new System.Windows.Forms.ComboBox();
            this.ugWorkdate = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.lblContact = new System.Windows.Forms.Label();
            this.ugTimeLog = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.lblContractorEmail = new System.Windows.Forms.Label();
            this.lblContractorPhone = new System.Windows.Forms.Label();
            this.lblContractorCityStateZip = new System.Windows.Forms.Label();
            this.lblContractorAddress = new System.Windows.Forms.Label();
            this.pbContractorLogo = new System.Windows.Forms.PictureBox();
            this.lblContractorName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnPayDate = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnActionLog = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ugWorkdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContractorLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(668, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 35);
            this.label12.TabIndex = 93;
            this.label12.Text = "Project Description:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProjDesc
            // 
            this.lblProjDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjDesc.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjDesc.Location = new System.Drawing.Point(746, 304);
            this.lblProjDesc.Name = "lblProjDesc";
            this.lblProjDesc.Size = new System.Drawing.Size(219, 35);
            this.lblProjDesc.TabIndex = 92;
            // 
            // chkOvertime
            // 
            this.chkOvertime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOvertime.Location = new System.Drawing.Point(860, 363);
            this.chkOvertime.Name = "chkOvertime";
            this.chkOvertime.Size = new System.Drawing.Size(104, 20);
            this.chkOvertime.TabIndex = 91;
            this.chkOvertime.Text = "Overtime Hours";
            this.chkOvertime.UseVisualStyleBackColor = true;
            this.chkOvertime.CheckedChanged += new System.EventHandler(this.chkOvertime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Project:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(761, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Finish:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "Start:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndTime.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(761, 386);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(86, 39);
            this.lblEndTime.TabIndex = 87;
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartTime.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(669, 387);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(86, 38);
            this.lblStartTime.TabIndex = 86;
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbProject
            // 
            this.cbProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProject.DisplayMember = "ProjectName";
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(745, 280);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(219, 21);
            this.cbProject.TabIndex = 85;
            this.cbProject.ValueMember = "ProjectId";
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
            // 
            // cbEndTime
            // 
            this.cbEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEndTime.FormattingEnabled = true;
            this.cbEndTime.Location = new System.Drawing.Point(761, 362);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(86, 21);
            this.cbEndTime.TabIndex = 84;
            this.cbEndTime.SelectedIndexChanged += new System.EventHandler(this.cbEndTime_SelectedIndexChanged);
            // 
            // cbStartTime
            // 
            this.cbStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Location = new System.Drawing.Point(669, 362);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(86, 21);
            this.cbStartTime.TabIndex = 83;
            this.cbStartTime.SelectedIndexChanged += new System.EventHandler(this.cbStartTime_SelectedIndexChanged);
            // 
            // btnTimeLog
            // 
            this.btnTimeLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeLog.Location = new System.Drawing.Point(205, 48);
            this.btnTimeLog.Name = "btnTimeLog";
            this.btnTimeLog.Size = new System.Drawing.Size(92, 23);
            this.btnTimeLog.TabIndex = 82;
            this.btnTimeLog.Tag = "";
            this.btnTimeLog.Text = "Time Log";
            this.btnTimeLog.UseVisualStyleBackColor = true;
            this.btnTimeLog.Click += new System.EventHandler(this.btnTimeLog_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(820, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 81;
            this.label14.Text = "Hours";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.Maroon;
            this.lblHours.Location = new System.Drawing.Point(820, 257);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(69, 20);
            this.lblHours.TabIndex = 80;
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Maroon;
            this.lblCost.Location = new System.Drawing.Point(895, 257);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(70, 20);
            this.lblCost.TabIndex = 79;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Maroon;
            this.lblDescription.Location = new System.Drawing.Point(667, 179);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(297, 41);
            this.lblDescription.TabIndex = 78;
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(895, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Cost";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(667, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Description";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            this.lblFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinish.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.Maroon;
            this.lblFinish.Location = new System.Drawing.Point(744, 257);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(70, 20);
            this.lblFinish.TabIndex = 75;
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Maroon;
            this.lblStart.Location = new System.Drawing.Point(669, 257);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(69, 20);
            this.lblStart.TabIndex = 74;
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Finish";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Start";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(561, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Company / Invoice:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCompany
            // 
            this.cbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompany.DisplayMember = "CmpName";
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(672, 126);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(186, 21);
            this.cbCompany.TabIndex = 70;
            this.cbCompany.ValueMember = "CompanyId";
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // cbPaydate
            // 
            this.cbPaydate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaydate.DisplayMember = "InvoiceNumber";
            this.cbPaydate.FormattingEnabled = true;
            this.cbPaydate.Location = new System.Drawing.Point(865, 126);
            this.cbPaydate.Name = "cbPaydate";
            this.cbPaydate.Size = new System.Drawing.Size(99, 21);
            this.cbPaydate.TabIndex = 69;
            this.cbPaydate.ValueMember = "PayDateId";
            this.cbPaydate.SelectedIndexChanged += new System.EventHandler(this.cbPaydate_SelectedIndexChanged);
            // 
            // ugWorkdate
            // 
            this.ugWorkdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ugWorkdate.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn12.Header.VisiblePosition = 0;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn12.Width = 45;
            ultraGridColumn11.Header.Caption = "Work Date";
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.Width = 137;
            ultraGridColumn13.Header.VisiblePosition = 2;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn13.Width = 68;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn12,
            ultraGridColumn11,
            ultraGridColumn13});
            this.ugWorkdate.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugWorkdate.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugWorkdate.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugWorkdate.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugWorkdate.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugWorkdate.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugWorkdate.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance1.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance1.FontData.BoldAsString = "True";
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ugWorkdate.DisplayLayout.Override.HeaderAppearance = appearance1;
            this.ugWorkdate.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugWorkdate.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugWorkdate.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.BackColor2 = System.Drawing.Color.White;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance2.ForeColor = System.Drawing.Color.Black;
            this.ugWorkdate.DisplayLayout.Override.SelectedRowAppearance = appearance2;
            this.ugWorkdate.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugWorkdate.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugWorkdate.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugWorkdate.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugWorkdate.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugWorkdate.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugWorkdate.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugWorkdate.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.ugWorkdate.Location = new System.Drawing.Point(8, 153);
            this.ugWorkdate.Name = "ugWorkdate";
            this.ugWorkdate.Size = new System.Drawing.Size(139, 356);
            this.ugWorkdate.TabIndex = 68;
            this.ugWorkdate.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugWorkdate_ClickCell);
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblContact.Location = new System.Drawing.Point(562, 14);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(402, 23);
            this.lblContact.TabIndex = 59;
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ugTimeLog
            // 
            this.ugTimeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ugTimeLog.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand2.CardSettings.Width = 150;
            ultraGridColumn14.Header.VisiblePosition = 0;
            ultraGridColumn14.Hidden = true;
            ultraGridColumn6.Header.Caption = "Work Date";
            ultraGridColumn6.Header.VisiblePosition = 1;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 90;
            ultraGridColumn7.Header.VisiblePosition = 2;
            ultraGridColumn7.Width = 217;
            ultraGridColumn8.Header.VisiblePosition = 3;
            ultraGridColumn8.Width = 70;
            ultraGridColumn9.Header.VisiblePosition = 4;
            ultraGridColumn9.Width = 70;
            ultraGridColumn10.Header.VisiblePosition = 5;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn1.Header.VisiblePosition = 6;
            ultraGridColumn1.Width = 70;
            ultraGridColumn2.Header.VisiblePosition = 7;
            ultraGridColumn2.Width = 70;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn14,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn1,
            ultraGridColumn2});
            this.ugTimeLog.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ugTimeLog.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugTimeLog.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLog.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLog.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugTimeLog.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugTimeLog.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance5.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance5.FontData.BoldAsString = "True";
            appearance5.TextHAlignAsString = "Center";
            appearance5.TextVAlignAsString = "Middle";
            this.ugTimeLog.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.ugTimeLog.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugTimeLog.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLog.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance6.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance6.BackColor2 = System.Drawing.Color.White;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.ugTimeLog.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.ugTimeLog.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLog.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLog.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugTimeLog.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugTimeLog.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugTimeLog.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugTimeLog.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugTimeLog.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugTimeLog.Location = new System.Drawing.Point(161, 153);
            this.ugTimeLog.Name = "ugTimeLog";
            this.ugTimeLog.Size = new System.Drawing.Size(501, 356);
            this.ugTimeLog.TabIndex = 67;
            this.ugTimeLog.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugTimeLog_ClickCell);
            // 
            // lblContractorEmail
            // 
            this.lblContractorEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblContractorEmail.Location = new System.Drawing.Point(153, 124);
            this.lblContractorEmail.Name = "lblContractorEmail";
            this.lblContractorEmail.Size = new System.Drawing.Size(404, 23);
            this.lblContractorEmail.TabIndex = 66;
            this.lblContractorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContractorPhone
            // 
            this.lblContractorPhone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorPhone.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblContractorPhone.Location = new System.Drawing.Point(153, 101);
            this.lblContractorPhone.Name = "lblContractorPhone";
            this.lblContractorPhone.Size = new System.Drawing.Size(404, 23);
            this.lblContractorPhone.TabIndex = 65;
            this.lblContractorPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContractorCityStateZip
            // 
            this.lblContractorCityStateZip.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorCityStateZip.Location = new System.Drawing.Point(153, 78);
            this.lblContractorCityStateZip.Name = "lblContractorCityStateZip";
            this.lblContractorCityStateZip.Size = new System.Drawing.Size(404, 23);
            this.lblContractorCityStateZip.TabIndex = 64;
            this.lblContractorCityStateZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContractorAddress
            // 
            this.lblContractorAddress.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorAddress.Location = new System.Drawing.Point(153, 55);
            this.lblContractorAddress.Name = "lblContractorAddress";
            this.lblContractorAddress.Size = new System.Drawing.Size(404, 23);
            this.lblContractorAddress.TabIndex = 63;
            this.lblContractorAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbContractorLogo
            // 
            this.pbContractorLogo.Location = new System.Drawing.Point(8, 8);
            this.pbContractorLogo.Name = "pbContractorLogo";
            this.pbContractorLogo.Size = new System.Drawing.Size(139, 139);
            this.pbContractorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContractorLogo.TabIndex = 62;
            this.pbContractorLogo.TabStop = false;
            // 
            // lblContractorName
            // 
            this.lblContractorName.Font = new System.Drawing.Font("Tempus Sans ITC", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContractorName.ForeColor = System.Drawing.Color.Green;
            this.lblContractorName.Location = new System.Drawing.Point(153, 8);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(404, 47);
            this.lblContractorName.TabIndex = 60;
            this.lblContractorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCompany);
            this.groupBox1.Controls.Add(this.btnContact);
            this.groupBox1.Controls.Add(this.btnPayDate);
            this.groupBox1.Controls.Add(this.btnProject);
            this.groupBox1.Controls.Add(this.btnInvoice);
            this.groupBox1.Controls.Add(this.btnActionLog);
            this.groupBox1.Controls.Add(this.btnTimeLog);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(562, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 82);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenance";
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(9, 19);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(92, 23);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(107, 19);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(92, 23);
            this.btnContact.TabIndex = 1;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnPayDate
            // 
            this.btnPayDate.Location = new System.Drawing.Point(205, 19);
            this.btnPayDate.Name = "btnPayDate";
            this.btnPayDate.Size = new System.Drawing.Size(92, 23);
            this.btnPayDate.TabIndex = 2;
            this.btnPayDate.Text = "Pay Date";
            this.btnPayDate.UseVisualStyleBackColor = true;
            this.btnPayDate.Click += new System.EventHandler(this.btnPayDate_Click);
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(303, 19);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(92, 23);
            this.btnProject.TabIndex = 3;
            this.btnProject.Text = "Project";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.Location = new System.Drawing.Point(303, 48);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(92, 23);
            this.btnInvoice.TabIndex = 58;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnActionLog
            // 
            this.btnActionLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionLog.Location = new System.Drawing.Point(107, 48);
            this.btnActionLog.Name = "btnActionLog";
            this.btnActionLog.Size = new System.Drawing.Size(92, 23);
            this.btnActionLog.TabIndex = 95;
            this.btnActionLog.Tag = "";
            this.btnActionLog.Text = "Action Log";
            this.btnActionLog.UseVisualStyleBackColor = true;
            this.btnActionLog.Click += new System.EventHandler(this.btnActionLog_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(668, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 23);
            this.btnAdd.TabIndex = 101;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(743, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 23);
            this.btnUpdate.TabIndex = 102;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(818, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 23);
            this.btnDelete.TabIndex = 103;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(893, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 104;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(895, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 23);
            this.btnClose.TabIndex = 105;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 518);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblProjDesc);
            this.Controls.Add(this.chkOvertime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.cbStartTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.cbPaydate);
            this.Controls.Add(this.ugWorkdate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.ugTimeLog);
            this.Controls.Add(this.lblContractorEmail);
            this.Controls.Add(this.lblContractorPhone);
            this.Controls.Add(this.lblContractorCityStateZip);
            this.Controls.Add(this.lblContractorAddress);
            this.Controls.Add(this.pbContractorLogo);
            this.Controls.Add(this.lblContractorName);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Time Log Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.StyleChanged += new System.EventHandler(this.frmMain_StyleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ugWorkdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContractorLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblProjDesc;
        private System.Windows.Forms.CheckBox chkOvertime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbEndTime;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.Button btnTimeLog;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.ComboBox cbPaydate;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugWorkdate;
        public System.Windows.Forms.Label lblContact;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugTimeLog;
        private System.Windows.Forms.Label lblContractorEmail;
        private System.Windows.Forms.Label lblContractorPhone;
        private System.Windows.Forms.Label lblContractorCityStateZip;
        private System.Windows.Forms.Label lblContractorAddress;
        private System.Windows.Forms.PictureBox pbContractorLogo;
        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnPayDate;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnActionLog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}