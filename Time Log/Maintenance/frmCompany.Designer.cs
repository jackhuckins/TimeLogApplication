namespace Time_Log.Maintenance
{
    partial class frmCompany
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Companies", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompanyId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpAddress");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpCity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpState");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpZip");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpPayRate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpLogoPath");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Initials");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompaniesContacts");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompaniesPayDates");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CompaniesContacts", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPhone");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompanyId");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("CompaniesPayDates", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompanyId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekStart");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekEnd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("InvoiceNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDatesTimeAssignment");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PayDatesTimeAssignment", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AssignmentId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeLogId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectId");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ugCompanies = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btnDelete = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.pbCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnLogoBrowse = new Infragistics.Win.Misc.UltraButton();
            this.lblCmpId = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.btnUpdate = new Infragistics.Win.Misc.UltraButton();
            this.btnAdd = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCmpName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpType = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpInitials = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpLogoPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpPayRate = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpZip = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpState = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpCity = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCmpAddress = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ofdLogoPath = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ugCompanies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpInitials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpLogoPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpPayRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // ugCompanies
            // 
            this.ugCompanies.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn2.Header.Caption = "Company Name";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 276;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn7.Header.Caption = "Pay Rate";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Width = 100;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
            ultraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ultraGridColumn10.Header.Caption = "Type";
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Width = 100;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            ultraGridColumn13.Header.VisiblePosition = 0;
            ultraGridColumn13.Hidden = true;
            ultraGridColumn14.Header.VisiblePosition = 1;
            ultraGridColumn15.Header.VisiblePosition = 2;
            ultraGridColumn16.Header.VisiblePosition = 3;
            ultraGridColumn17.Header.VisiblePosition = 4;
            ultraGridColumn17.Hidden = true;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16,
            ultraGridColumn17});
            ultraGridBand2.Hidden = true;
            ultraGridColumn18.Header.VisiblePosition = 0;
            ultraGridColumn18.Hidden = true;
            ultraGridColumn19.Header.VisiblePosition = 1;
            ultraGridColumn19.Hidden = true;
            ultraGridColumn20.Header.VisiblePosition = 2;
            ultraGridColumn21.Header.VisiblePosition = 3;
            ultraGridColumn22.Header.VisiblePosition = 4;
            ultraGridColumn23.Header.VisiblePosition = 5;
            ultraGridColumn24.Header.VisiblePosition = 6;
            ultraGridColumn25.Header.VisiblePosition = 7;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25});
            ultraGridBand3.Hidden = true;
            ultraGridColumn26.Header.VisiblePosition = 0;
            ultraGridColumn27.Header.VisiblePosition = 1;
            ultraGridColumn28.Header.VisiblePosition = 2;
            ultraGridColumn29.Header.VisiblePosition = 3;
            ultraGridBand4.Columns.AddRange(new object[] {
            ultraGridColumn26,
            ultraGridColumn27,
            ultraGridColumn28,
            ultraGridColumn29});
            ultraGridBand4.Hidden = true;
            this.ugCompanies.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugCompanies.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ugCompanies.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.ugCompanies.DisplayLayout.BandsSerializer.Add(ultraGridBand4);
            this.ugCompanies.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugCompanies.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugCompanies.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugCompanies.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugCompanies.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugCompanies.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.FontData.BoldAsString = "True";
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.ugCompanies.DisplayLayout.Override.HeaderAppearance = appearance2;
            this.ugCompanies.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugCompanies.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugCompanies.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance3.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance3.BackColor2 = System.Drawing.Color.White;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.ugCompanies.DisplayLayout.Override.SelectedRowAppearance = appearance3;
            this.ugCompanies.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugCompanies.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugCompanies.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugCompanies.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugCompanies.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugCompanies.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugCompanies.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugCompanies.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugCompanies.Location = new System.Drawing.Point(325, 13);
            this.ugCompanies.Name = "ugCompanies";
            this.ugCompanies.Size = new System.Drawing.Size(478, 320);
            this.ugCompanies.TabIndex = 31;
            this.ugCompanies.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugCompanies_ClickCell);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(481, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 21);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(559, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 21);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbCompanyLogo
            // 
            this.pbCompanyLogo.Location = new System.Drawing.Point(13, 260);
            this.pbCompanyLogo.Name = "pbCompanyLogo";
            this.pbCompanyLogo.Size = new System.Drawing.Size(100, 100);
            this.pbCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyLogo.TabIndex = 47;
            this.pbCompanyLogo.TabStop = false;
            // 
            // btnLogoBrowse
            // 
            this.btnLogoBrowse.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoBrowse.Location = new System.Drawing.Point(256, 258);
            this.btnLogoBrowse.Name = "btnLogoBrowse";
            this.btnLogoBrowse.Size = new System.Drawing.Size(63, 21);
            this.btnLogoBrowse.TabIndex = 46;
            this.btnLogoBrowse.Text = "Browse";
            this.btnLogoBrowse.Click += new System.EventHandler(this.btnLogoBrowse_Click);
            // 
            // lblCmpId
            // 
            this.lblCmpId.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            this.lblCmpId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpId.Location = new System.Drawing.Point(13, 95);
            this.lblCmpId.Name = "lblCmpId";
            this.lblCmpId.Size = new System.Drawing.Size(70, 21);
            this.lblCmpId.TabIndex = 45;
            // 
            // ultraLabel11
            // 
            appearance1.ForeColor = System.Drawing.Color.Green;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraLabel11.Appearance = appearance1;
            this.ultraLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel11.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel11.Location = new System.Drawing.Point(13, 13);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(251, 49);
            this.ultraLabel11.TabIndex = 44;
            this.ultraLabel11.Text = "Company Information";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(728, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(403, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 21);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(325, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 21);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel10.Location = new System.Drawing.Point(89, 68);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(230, 21);
            this.ultraLabel10.TabIndex = 40;
            this.ultraLabel10.Text = "Name";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel9.Location = new System.Drawing.Point(142, 203);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(177, 21);
            this.ultraLabel9.TabIndex = 39;
            this.ultraLabel9.Text = "Type";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel8.Location = new System.Drawing.Point(13, 203);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(56, 21);
            this.ultraLabel8.TabIndex = 38;
            this.ultraLabel8.Text = "Initials";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel7.Location = new System.Drawing.Point(119, 258);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(131, 21);
            this.ultraLabel7.TabIndex = 37;
            this.ultraLabel7.Text = "Logo Path";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel6.Location = new System.Drawing.Point(75, 203);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(61, 21);
            this.ultraLabel6.TabIndex = 36;
            this.ultraLabel6.Text = "Pay Rate";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel4.Location = new System.Drawing.Point(13, 176);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(90, 21);
            this.ultraLabel4.TabIndex = 35;
            this.ultraLabel4.Text = "State / Zip";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel3.Location = new System.Drawing.Point(13, 149);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(90, 21);
            this.ultraLabel3.TabIndex = 34;
            this.ultraLabel3.Text = "City";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(13, 122);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(90, 21);
            this.ultraLabel2.TabIndex = 33;
            this.ultraLabel2.Text = "Street Address";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(13, 68);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(70, 21);
            this.ultraLabel1.TabIndex = 32;
            this.ultraLabel1.Text = "Company ID";
            // 
            // txtCmpName
            // 
            this.txtCmpName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpName.Location = new System.Drawing.Point(89, 95);
            this.txtCmpName.Name = "txtCmpName";
            this.txtCmpName.Size = new System.Drawing.Size(230, 24);
            this.txtCmpName.TabIndex = 58;
            // 
            // txtCmpType
            // 
            this.txtCmpType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpType.Location = new System.Drawing.Point(142, 230);
            this.txtCmpType.Name = "txtCmpType";
            this.txtCmpType.Size = new System.Drawing.Size(177, 24);
            this.txtCmpType.TabIndex = 57;
            // 
            // txtCmpInitials
            // 
            this.txtCmpInitials.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpInitials.Location = new System.Drawing.Point(13, 230);
            this.txtCmpInitials.Name = "txtCmpInitials";
            this.txtCmpInitials.Size = new System.Drawing.Size(56, 24);
            this.txtCmpInitials.TabIndex = 56;
            // 
            // txtCmpLogoPath
            // 
            this.txtCmpLogoPath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpLogoPath.Location = new System.Drawing.Point(119, 285);
            this.txtCmpLogoPath.Multiline = true;
            this.txtCmpLogoPath.Name = "txtCmpLogoPath";
            this.txtCmpLogoPath.Size = new System.Drawing.Size(200, 75);
            this.txtCmpLogoPath.TabIndex = 55;
            this.txtCmpLogoPath.ValueChanged += new System.EventHandler(this.txtCmpLogoPath_ValueChanged);
            // 
            // txtCmpPayRate
            // 
            this.txtCmpPayRate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpPayRate.Location = new System.Drawing.Point(75, 230);
            this.txtCmpPayRate.Name = "txtCmpPayRate";
            this.txtCmpPayRate.Size = new System.Drawing.Size(61, 24);
            this.txtCmpPayRate.TabIndex = 54;
            // 
            // txtCmpZip
            // 
            this.txtCmpZip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpZip.Location = new System.Drawing.Point(230, 176);
            this.txtCmpZip.Name = "txtCmpZip";
            this.txtCmpZip.Size = new System.Drawing.Size(89, 24);
            this.txtCmpZip.TabIndex = 53;
            // 
            // txtCmpState
            // 
            this.txtCmpState.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpState.Location = new System.Drawing.Point(109, 176);
            this.txtCmpState.Name = "txtCmpState";
            this.txtCmpState.Size = new System.Drawing.Size(115, 24);
            this.txtCmpState.TabIndex = 52;
            // 
            // txtCmpCity
            // 
            this.txtCmpCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpCity.Location = new System.Drawing.Point(109, 149);
            this.txtCmpCity.Name = "txtCmpCity";
            this.txtCmpCity.Size = new System.Drawing.Size(210, 24);
            this.txtCmpCity.TabIndex = 51;
            // 
            // txtCmpAddress
            // 
            this.txtCmpAddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCmpAddress.Location = new System.Drawing.Point(109, 122);
            this.txtCmpAddress.Name = "txtCmpAddress";
            this.txtCmpAddress.Size = new System.Drawing.Size(210, 24);
            this.txtCmpAddress.TabIndex = 50;
            // 
            // ofdLogoPath
            // 
            this.ofdLogoPath.FileName = "openFileDialog1";
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 372);
            this.Controls.Add(this.txtCmpName);
            this.Controls.Add(this.txtCmpType);
            this.Controls.Add(this.txtCmpInitials);
            this.Controls.Add(this.txtCmpLogoPath);
            this.Controls.Add(this.txtCmpPayRate);
            this.Controls.Add(this.txtCmpZip);
            this.Controls.Add(this.txtCmpState);
            this.Controls.Add(this.txtCmpCity);
            this.Controls.Add(this.txtCmpAddress);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbCompanyLogo);
            this.Controls.Add(this.btnLogoBrowse);
            this.Controls.Add(this.lblCmpId);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ugCompanies);
            this.Name = "frmCompany";
            this.Text = "Company Manager";
            ((System.ComponentModel.ISupportInitialize)(this.ugCompanies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpInitials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpLogoPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpPayRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmpAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ugCompanies;
        private Infragistics.Win.Misc.UltraButton btnDelete;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private System.Windows.Forms.PictureBox pbCompanyLogo;
        private Infragistics.Win.Misc.UltraButton btnLogoBrowse;
        private Infragistics.Win.Misc.UltraLabel lblCmpId;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private Infragistics.Win.Misc.UltraButton btnUpdate;
        private Infragistics.Win.Misc.UltraButton btnAdd;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpType;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpInitials;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpLogoPath;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpPayRate;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpZip;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpState;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpCity;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCmpAddress;
        private System.Windows.Forms.OpenFileDialog ofdLogoPath;
    }
}