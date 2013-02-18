namespace Time_Log.Maintenance
{
    partial class frmContact
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Contacts", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ContactId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConPhone");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ConEmail");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompanyId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CmpName", 0);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.txtConPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCmpId = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Infragistics.Win.Misc.UltraButton();
            this.btnClear = new Infragistics.Win.Misc.UltraButton();
            this.lblContactId = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.btnUpdate = new Infragistics.Win.Misc.UltraButton();
            this.btnAdd = new Infragistics.Win.Misc.UltraButton();
            this.txtConName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtConEmail = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ugContacts = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.txtConName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConPhone
            // 
            this.txtConPhone.Location = new System.Drawing.Point(106, 144);
            this.txtConPhone.Mask = "(999) 000-0000";
            this.txtConPhone.Name = "txtConPhone";
            this.txtConPhone.Size = new System.Drawing.Size(100, 20);
            this.txtConPhone.TabIndex = 82;
            // 
            // lblCmpId
            // 
            this.lblCmpId.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            this.lblCmpId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmpId.Location = new System.Drawing.Point(13, 254);
            this.lblCmpId.Name = "lblCmpId";
            this.lblCmpId.Size = new System.Drawing.Size(33, 21);
            this.lblCmpId.TabIndex = 81;
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel5.Location = new System.Drawing.Point(13, 227);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(193, 21);
            this.ultraLabel5.TabIndex = 80;
            this.ultraLabel5.Text = "Company ID / Name";
            // 
            // cbCompany
            // 
            this.cbCompany.DisplayMember = "CmpName";
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(52, 254);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(154, 21);
            this.cbCompany.TabIndex = 79;
            this.cbCompany.ValueMember = "CompanyId";
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(368, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 21);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(446, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 21);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblContactId
            // 
            this.lblContactId.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.InsetSoft;
            this.lblContactId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactId.Location = new System.Drawing.Point(13, 114);
            this.lblContactId.Name = "lblContactId";
            this.lblContactId.Size = new System.Drawing.Size(33, 24);
            this.lblContactId.TabIndex = 76;
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
            this.ultraLabel11.Size = new System.Drawing.Size(193, 68);
            this.ultraLabel11.TabIndex = 75;
            this.ultraLabel11.Text = "Contact Information";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(729, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(290, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 21);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(212, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 21);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtConName
            // 
            this.txtConName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConName.Location = new System.Drawing.Point(52, 114);
            this.txtConName.Name = "txtConName";
            this.txtConName.Size = new System.Drawing.Size(154, 24);
            this.txtConName.TabIndex = 71;
            // 
            // txtConEmail
            // 
            this.txtConEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConEmail.Location = new System.Drawing.Point(13, 197);
            this.txtConEmail.Name = "txtConEmail";
            this.txtConEmail.Size = new System.Drawing.Size(193, 24);
            this.txtConEmail.TabIndex = 70;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel3.Location = new System.Drawing.Point(13, 170);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(193, 21);
            this.ultraLabel3.TabIndex = 69;
            this.ultraLabel3.Text = "Email";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel2.Location = new System.Drawing.Point(13, 144);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(71, 20);
            this.ultraLabel2.TabIndex = 68;
            this.ultraLabel2.Text = "Phone #";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel1.Location = new System.Drawing.Point(13, 87);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(193, 21);
            this.ultraLabel1.TabIndex = 67;
            this.ultraLabel1.Text = "Contact ID / Name";
            // 
            // ugContacts
            // 
            this.ugContacts.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn2.Header.Caption = "Name";
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn2.Width = 140;
            ultraGridColumn3.Header.Caption = "Phone";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn3.Width = 100;
            ultraGridColumn4.Header.Caption = "Email";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn4.Width = 188;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.Header.Caption = "Company";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 164;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ugContacts.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugContacts.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugContacts.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugContacts.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugContacts.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugContacts.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugContacts.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.FontData.BoldAsString = "True";
            appearance2.TextHAlignAsString = "Center";
            appearance2.TextVAlignAsString = "Middle";
            this.ugContacts.DisplayLayout.Override.HeaderAppearance = appearance2;
            this.ugContacts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugContacts.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugContacts.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance3.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance3.BackColor2 = System.Drawing.Color.White;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.ugContacts.DisplayLayout.Override.SelectedRowAppearance = appearance3;
            this.ugContacts.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugContacts.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugContacts.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugContacts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugContacts.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugContacts.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugContacts.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugContacts.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugContacts.Location = new System.Drawing.Point(212, 13);
            this.ugContacts.Name = "ugContacts";
            this.ugContacts.Size = new System.Drawing.Size(592, 320);
            this.ugContacts.TabIndex = 66;
            this.ugContacts.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugContacts_ClickCell);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 372);
            this.Controls.Add(this.txtConPhone);
            this.Controls.Add(this.lblCmpId);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblContactId);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtConName);
            this.Controls.Add(this.txtConEmail);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.ugContacts);
            this.Name = "frmContact";
            this.Text = "Manage Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.txtConName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtConPhone;
        private Infragistics.Win.Misc.UltraLabel lblCmpId;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private System.Windows.Forms.ComboBox cbCompany;
        private Infragistics.Win.Misc.UltraButton btnDelete;
        private Infragistics.Win.Misc.UltraButton btnClear;
        private Infragistics.Win.Misc.UltraLabel lblContactId;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.Misc.UltraButton btnClose;
        private Infragistics.Win.Misc.UltraButton btnUpdate;
        private Infragistics.Win.Misc.UltraButton btnAdd;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtConName;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtConEmail;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugContacts;
    }
}