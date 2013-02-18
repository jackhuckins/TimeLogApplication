namespace Time_Log.Maintenance
{
    partial class frmInvoice
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PayDatesByCmpId", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CompanyId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekStart");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekEnd");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("InvoiceNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WeekNumber");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDatesTimeAssignment1");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PayDatesTimeAssignment1", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AssignmentId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TimeLogId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PayDateId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectId");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblEmails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.ugPaydates = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.axInvoice = new AxAcroPDFLib.AxAcroPDF();
            this.btnCreate = new System.Windows.Forms.Button();
            this.chkTest = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ugPaydates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdated
            // 
            this.lblUpdated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdated.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblUpdated.Location = new System.Drawing.Point(661, 39);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(88, 23);
            this.lblUpdated.TabIndex = 81;
            this.lblUpdated.Text = "0";
            this.lblUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmails
            // 
            this.lblEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmails.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmails.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmails.Location = new System.Drawing.Point(661, 9);
            this.lblEmails.Name = "lblEmails";
            this.lblEmails.Size = new System.Drawing.Size(88, 23);
            this.lblEmails.TabIndex = 80;
            this.lblEmails.Text = "0";
            this.lblEmails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(412, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "Emails sent for this Invoice:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(412, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Times this Invoice has been Created / Updated:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "Company Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCompany
            // 
            this.cbCompany.DisplayMember = "CmpName";
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(154, 72);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(252, 21);
            this.cbCompany.TabIndex = 76;
            this.cbCompany.ValueMember = "CompanyId";
            this.cbCompany.SelectedIndexChanged += new System.EventHandler(this.cbCompany_SelectedIndexChanged);
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEmail.Location = new System.Drawing.Point(242, 552);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(79, 23);
            this.btnEmail.TabIndex = 75;
            this.btnEmail.Tag = "45, 23";
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // chkNo
            // 
            this.chkNo.Location = new System.Drawing.Point(588, 71);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(45, 21);
            this.chkNo.TabIndex = 74;
            this.chkNo.Text = "No";
            this.chkNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // chkYes
            // 
            this.chkYes.Location = new System.Drawing.Point(537, 71);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(45, 21);
            this.chkYes.TabIndex = 73;
            this.chkYes.Text = "Yes";
            this.chkYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(412, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Invoice Exists?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ultraLabel11
            // 
            appearance1.ForeColor = System.Drawing.Color.Green;
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ultraLabel11.Appearance = appearance1;
            this.ultraLabel11.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.None;
            this.ultraLabel11.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraLabel11.Location = new System.Drawing.Point(12, 12);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(394, 57);
            this.ultraLabel11.TabIndex = 71;
            this.ultraLabel11.Text = "Invoice Information";
            // 
            // ugPaydates
            // 
            this.ugPaydates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ugPaydates.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn5.Header.VisiblePosition = 5;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn11.Header.VisiblePosition = 1;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn1.Header.Caption = "Start";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.Caption = "Finish";
            ultraGridColumn2.Header.VisiblePosition = 2;
            ultraGridColumn3.Header.Caption = "Pay Date";
            ultraGridColumn3.Header.VisiblePosition = 3;
            ultraGridColumn4.Header.Caption = "Invoice #";
            ultraGridColumn4.Header.VisiblePosition = 4;
            ultraGridColumn12.Header.VisiblePosition = 6;
            ultraGridColumn12.Hidden = true;
            ultraGridColumn6.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn5,
            ultraGridColumn11,
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn12,
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
            this.ugPaydates.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugPaydates.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ugPaydates.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugPaydates.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugPaydates.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugPaydates.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugPaydates.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugPaydates.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance4.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance4.FontData.BoldAsString = "True";
            appearance4.TextHAlignAsString = "Center";
            appearance4.TextVAlignAsString = "Middle";
            this.ugPaydates.DisplayLayout.Override.HeaderAppearance = appearance4;
            this.ugPaydates.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugPaydates.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugPaydates.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance5.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance5.BackColor2 = System.Drawing.Color.White;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance5.ForeColor = System.Drawing.Color.Black;
            this.ugPaydates.DisplayLayout.Override.SelectedRowAppearance = appearance5;
            this.ugPaydates.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugPaydates.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugPaydates.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugPaydates.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugPaydates.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugPaydates.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugPaydates.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugPaydates.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugPaydates.Location = new System.Drawing.Point(12, 99);
            this.ugPaydates.Name = "ugPaydates";
            this.ugPaydates.Size = new System.Drawing.Size(394, 447);
            this.ugPaydates.TabIndex = 70;
            this.ugPaydates.ClickCell += new Infragistics.Win.UltraWinGrid.ClickCellEventHandler(this.ugPaydates_ClickCell);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(327, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 23);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Location = new System.Drawing.Point(157, 552);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 23);
            this.btnPreview.TabIndex = 68;
            this.btnPreview.Tag = "45, 23";
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // axInvoice
            // 
            this.axInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axInvoice.Enabled = true;
            this.axInvoice.Location = new System.Drawing.Point(412, 99);
            this.axInvoice.Name = "axInvoice";
            this.axInvoice.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axInvoice.OcxState")));
            this.axInvoice.Size = new System.Drawing.Size(719, 476);
            this.axInvoice.TabIndex = 67;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(72, 552);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(79, 23);
            this.btnCreate.TabIndex = 82;
            this.btnCreate.Tag = "45, 23";
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // chkTest
            // 
            this.chkTest.AutoSize = true;
            this.chkTest.Location = new System.Drawing.Point(755, 13);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(75, 17);
            this.chkTest.TabIndex = 83;
            this.chkTest.Text = "Test Email";
            this.chkTest.UseVisualStyleBackColor = true;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 587);
            this.Controls.Add(this.chkTest);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.lblEmails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ultraLabel11);
            this.Controls.Add(this.ugPaydates);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.axInvoice);
            this.Name = "frmInvoice";
            this.Text = "Manage Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.ugPaydates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblEmails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel11;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugPaydates;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private AxAcroPDFLib.AxAcroPDF axInvoice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkTest;
    }
}