namespace Time_Log.Maintenance
{
    partial class frmProject
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Projects", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectDescription");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectStatus");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectGroup");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectsTimeAssignment");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ProjectsTimeAssignment", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AssignmentId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeLogId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectId");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance25 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            this.btnDelete = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.btnUpdate = new Infragistics.Win.Misc.UltraButton();
            this.btnAdd = new Infragistics.Win.Misc.UltraButton();
            this.ugProjects = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ucProjStatus = new System.Windows.Forms.ComboBox();
            this.lblProjId = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.txtProjName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.txtProjDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ucProjGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ugProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(482, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 21);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(560, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 21);
            this.btnClear.TabIndex = 73;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(729, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(404, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 21);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(326, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 21);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ugProjects
            // 
            this.ugProjects.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.Caption = "Project Name";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 278;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.Header.Caption = "Status";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 100;
            ultraGridColumn5.Header.Caption = "Group";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 100;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridColumn9.Header.VisiblePosition = 2;
            ultraGridColumn10.Header.VisiblePosition = 3;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10});
            ultraGridBand2.Hidden = true;
            this.ugProjects.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugProjects.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ugProjects.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugProjects.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugProjects.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugProjects.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugProjects.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugProjects.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.FontData.BoldAsString = "True";
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.ugProjects.DisplayLayout.Override.HeaderAppearance = appearance2;
            this.ugProjects.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugProjects.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugProjects.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance3.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance3.BackColor2 = System.Drawing.Color.White;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.ugProjects.DisplayLayout.Override.SelectedRowAppearance = appearance3;
            this.ugProjects.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugProjects.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugProjects.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugProjects.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugProjects.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugProjects.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugProjects.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugProjects.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugProjects.Location = new System.Drawing.Point(326, 13);
            this.ugProjects.Name = "ugProjects";
            this.ugProjects.Size = new System.Drawing.Size(478, 320);
            this.ugProjects.TabIndex = 62;
            this.ugProjects.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugProjects_ClickCell);
            // 
            // ucProjStatus
            // 
            this.ucProjStatus.FormattingEnabled = true;
            this.ucProjStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.ucProjStatus.Location = new System.Drawing.Point(114, 125);
            this.ucProjStatus.Name = "ucProjStatus";
            this.ucProjStatus.Size = new System.Drawing.Size(204, 21);
            this.ucProjStatus.TabIndex = 85;
            // 
            // lblProjId
            // 
            this.lblProjId.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            this.lblProjId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjId.Location = new System.Drawing.Point(12, 95);
            this.lblProjId.Name = "lblProjId";
            this.lblProjId.Size = new System.Drawing.Size(70, 24);
            this.lblProjId.TabIndex = 83;
            // 
            // ultraLabel11
            // 
            appearance1.ForeColor = System.Drawing.Color.Green;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraLabel11.Appearance = appearance1;
            this.ultraLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel11.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel11.Location = new System.Drawing.Point(12, 13);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(306, 49);
            this.ultraLabel11.TabIndex = 82;
            this.ultraLabel11.Text = "Project Information";
            // 
            // txtProjName
            // 
            this.txtProjName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjName.Location = new System.Drawing.Point(88, 95);
            this.txtProjName.Name = "txtProjName";
            this.txtProjName.Size = new System.Drawing.Size(230, 24);
            this.txtProjName.TabIndex = 81;
            // 
            // ultraLabel10
            // 
            appearance27.TextHAlignAsString = "Left";
            appearance27.TextVAlignAsString = "Middle";
            this.ultraLabel10.Appearance = appearance27;
            this.ultraLabel10.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel10.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel10.Location = new System.Drawing.Point(88, 68);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(230, 21);
            this.ultraLabel10.TabIndex = 80;
            this.ultraLabel10.Text = "Name";
            // 
            // ultraLabel4
            // 
            appearance23.TextHAlignAsString = "Left";
            appearance23.TextVAlignAsString = "Middle";
            this.ultraLabel4.Appearance = appearance23;
            this.ultraLabel4.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel4.Location = new System.Drawing.Point(11, 312);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(97, 21);
            this.ultraLabel4.TabIndex = 79;
            this.ultraLabel4.Text = "Project Group";
            // 
            // ultraLabel3
            // 
            appearance25.TextHAlignAsString = "Left";
            appearance25.TextVAlignAsString = "Middle";
            this.ultraLabel3.Appearance = appearance25;
            this.ultraLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel3.Location = new System.Drawing.Point(12, 125);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(96, 26);
            this.ultraLabel3.TabIndex = 78;
            this.ultraLabel3.Text = "Project Status";
            // 
            // txtProjDescription
            // 
            this.txtProjDescription.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjDescription.Location = new System.Drawing.Point(12, 184);
            this.txtProjDescription.Multiline = true;
            this.txtProjDescription.Name = "txtProjDescription";
            this.txtProjDescription.Size = new System.Drawing.Size(306, 117);
            this.txtProjDescription.TabIndex = 77;
            // 
            // ultraLabel2
            // 
            appearance24.TextHAlignAsString = "Left";
            appearance24.TextVAlignAsString = "Middle";
            this.ultraLabel2.Appearance = appearance24;
            this.ultraLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(11, 157);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(307, 21);
            this.ultraLabel2.TabIndex = 76;
            this.ultraLabel2.Text = "Project Description";
            // 
            // ultraLabel1
            // 
            appearance26.TextHAlignAsString = "Center";
            appearance26.TextVAlignAsString = "Middle";
            this.ultraLabel1.Appearance = appearance26;
            this.ultraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(12, 68);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(70, 21);
            this.ultraLabel1.TabIndex = 75;
            this.ultraLabel1.Text = "Project ID";
            // 
            // ucProjGroup
            // 
            this.ucProjGroup.FormattingEnabled = true;
            this.ucProjGroup.Location = new System.Drawing.Point(114, 312);
            this.ucProjGroup.Name = "ucProjGroup";
            this.ucProjGroup.Size = new System.Drawing.Size(204, 21);
            this.ucProjGroup.TabIndex = 86;
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 372);
            this.Controls.Add(this.ucProjGroup);
            this.Controls.Add(this.ucProjStatus);
            this.Controls.Add(this.lblProjId);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.txtProjName);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.txtProjDescription);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ugProjects);
            this.Name = "frmProject";
            this.Text = "Manage Projects";
            ((System.ComponentModel.ISupportInitialize)(this.ugProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton btnDelete;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private Infragistics.Win.Misc.UltraButton btnUpdate;
        private Infragistics.Win.Misc.UltraButton btnAdd;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugProjects;
        private System.Windows.Forms.ComboBox ucProjStatus;
        private Infragistics.Win.Misc.UltraLabel lblProjId;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtProjName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtProjDescription;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.ComboBox ucProjGroup;
    }
}