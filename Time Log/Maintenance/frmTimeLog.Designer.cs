namespace Time_Log.Maintenance
{
    partial class frmTimeLog
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TimeLogWeek2", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Day");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("#");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Start");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Finish");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hours");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TimeLogWeek1", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Date");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Day");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("#");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Start");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Finish");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Hours");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.lblInvoice2 = new System.Windows.Forms.Label();
            this.lblInvoice1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPayDate = new System.Windows.Forms.ComboBox();
            this.lblInvoice2Hour = new System.Windows.Forms.Label();
            this.lblInvoice1Hour = new System.Windows.Forms.Label();
            this.lblFinalHour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ugTimeLogWk2 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ugTimeLogWk1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInvoice1Cost = new System.Windows.Forms.Label();
            this.lblInvoice2Cost = new System.Windows.Forms.Label();
            this.lblFinalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLogWk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLogWk1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoice2
            // 
            this.lblInvoice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice2.Location = new System.Drawing.Point(369, 13);
            this.lblInvoice2.Name = "lblInvoice2";
            this.lblInvoice2.Size = new System.Drawing.Size(156, 22);
            this.lblInvoice2.TabIndex = 80;
            this.lblInvoice2.Text = "Invoice 2";
            this.lblInvoice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoice1
            // 
            this.lblInvoice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice1.Location = new System.Drawing.Point(207, 13);
            this.lblInvoice1.Name = "lblInvoice1";
            this.lblInvoice1.Size = new System.Drawing.Size(156, 22);
            this.lblInvoice1.TabIndex = 79;
            this.lblInvoice1.Text = "Invoice 1";
            this.lblInvoice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 76;
            this.label13.Text = "PayDate:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPayDate
            // 
            this.cbPayDate.FormattingEnabled = true;
            this.cbPayDate.Location = new System.Drawing.Point(89, 13);
            this.cbPayDate.Name = "cbPayDate";
            this.cbPayDate.Size = new System.Drawing.Size(112, 21);
            this.cbPayDate.TabIndex = 74;
            this.cbPayDate.SelectedIndexChanged += new System.EventHandler(this.cbPayDate_SelectedIndexChanged);
            // 
            // lblInvoice2Hour
            // 
            this.lblInvoice2Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice2Hour.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice2Hour.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInvoice2Hour.Location = new System.Drawing.Point(369, 40);
            this.lblInvoice2Hour.Name = "lblInvoice2Hour";
            this.lblInvoice2Hour.Size = new System.Drawing.Size(75, 23);
            this.lblInvoice2Hour.TabIndex = 62;
            this.lblInvoice2Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoice1Hour
            // 
            this.lblInvoice1Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice1Hour.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice1Hour.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInvoice1Hour.Location = new System.Drawing.Point(207, 40);
            this.lblInvoice1Hour.Name = "lblInvoice1Hour";
            this.lblInvoice1Hour.Size = new System.Drawing.Size(75, 23);
            this.lblInvoice1Hour.TabIndex = 61;
            this.lblInvoice1Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalHour
            // 
            this.lblFinalHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalHour.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalHour.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFinalHour.Location = new System.Drawing.Point(531, 40);
            this.lblFinalHour.Name = "lblFinalHour";
            this.lblFinalHour.Size = new System.Drawing.Size(75, 23);
            this.lblFinalHour.TabIndex = 60;
            this.lblFinalHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 59;
            this.label2.Text = "Pay Period";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "W E E K  2 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(668, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "W E E K  1 ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ugTimeLogWk2
            // 
            this.ugTimeLogWk2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand1.CardSettings.Width = 150;
            ultraGridColumn20.Header.VisiblePosition = 0;
            ultraGridColumn20.Width = 70;
            ultraGridColumn21.Header.VisiblePosition = 1;
            ultraGridColumn21.Width = 40;
            ultraGridColumn22.Header.VisiblePosition = 2;
            ultraGridColumn22.Width = 20;
            ultraGridColumn12.Header.VisiblePosition = 3;
            ultraGridColumn12.Width = 286;
            ultraGridColumn13.Header.VisiblePosition = 4;
            ultraGridColumn13.Width = 60;
            ultraGridColumn14.Header.VisiblePosition = 5;
            ultraGridColumn14.Width = 60;
            ultraGridColumn15.Header.VisiblePosition = 6;
            ultraGridColumn15.Width = 60;
            ultraGridColumn16.Header.VisiblePosition = 7;
            ultraGridColumn16.Width = 70;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn20,
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14,
            ultraGridColumn15,
            ultraGridColumn16});
            this.ugTimeLogWk2.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugTimeLogWk2.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugTimeLogWk2.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugTimeLogWk2.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugTimeLogWk2.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance1.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance1.FontData.BoldAsString = "True";
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ugTimeLogWk2.DisplayLayout.Override.HeaderAppearance = appearance1;
            this.ugTimeLogWk2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugTimeLogWk2.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk2.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.BackColor2 = System.Drawing.Color.White;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance2.ForeColor = System.Drawing.Color.Black;
            this.ugTimeLogWk2.DisplayLayout.Override.SelectedRowAppearance = appearance2;
            this.ugTimeLogWk2.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLogWk2.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLogWk2.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugTimeLogWk2.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugTimeLogWk2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugTimeLogWk2.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugTimeLogWk2.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugTimeLogWk2.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugTimeLogWk2.Location = new System.Drawing.Point(3, 27);
            this.ugTimeLogWk2.Name = "ugTimeLogWk2";
            this.ugTimeLogWk2.Size = new System.Drawing.Size(668, 206);
            this.ugTimeLogWk2.TabIndex = 56;
            // 
            // ugTimeLogWk1
            // 
            this.ugTimeLogWk1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridBand2.CardSettings.Width = 150;
            ultraGridColumn17.Header.VisiblePosition = 0;
            ultraGridColumn17.Width = 70;
            ultraGridColumn18.Header.VisiblePosition = 1;
            ultraGridColumn18.Width = 40;
            ultraGridColumn19.Header.VisiblePosition = 2;
            ultraGridColumn19.Width = 20;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 286;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 60;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 60;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Width = 60;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Width = 70;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn17,
            ultraGridColumn18,
            ultraGridColumn19,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            this.ugTimeLogWk1.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.ugTimeLogWk1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugTimeLogWk1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugTimeLogWk1.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugTimeLogWk1.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance3.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance3.FontData.BoldAsString = "True";
            appearance3.TextHAlignAsString = "Center";
            appearance3.TextVAlignAsString = "Middle";
            this.ugTimeLogWk1.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.ugTimeLogWk1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugTimeLogWk1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugTimeLogWk1.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance4.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance4.BackColor2 = System.Drawing.Color.White;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance4.ForeColor = System.Drawing.Color.Black;
            this.ugTimeLogWk1.DisplayLayout.Override.SelectedRowAppearance = appearance4;
            this.ugTimeLogWk1.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLogWk1.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugTimeLogWk1.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugTimeLogWk1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugTimeLogWk1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugTimeLogWk1.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugTimeLogWk1.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugTimeLogWk1.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugTimeLogWk1.Location = new System.Drawing.Point(3, 26);
            this.ugTimeLogWk1.Name = "ugTimeLogWk1";
            this.ugTimeLogWk1.Size = new System.Drawing.Size(668, 206);
            this.ugTimeLogWk1.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ugTimeLogWk1);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 236);
            this.panel1.TabIndex = 85;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ugTimeLogWk2);
            this.panel2.Location = new System.Drawing.Point(12, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 236);
            this.panel2.TabIndex = 86;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvoice1Cost
            // 
            this.lblInvoice1Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice1Cost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice1Cost.ForeColor = System.Drawing.Color.Green;
            this.lblInvoice1Cost.Location = new System.Drawing.Point(288, 40);
            this.lblInvoice1Cost.Name = "lblInvoice1Cost";
            this.lblInvoice1Cost.Size = new System.Drawing.Size(75, 23);
            this.lblInvoice1Cost.TabIndex = 88;
            this.lblInvoice1Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInvoice2Cost
            // 
            this.lblInvoice2Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice2Cost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice2Cost.ForeColor = System.Drawing.Color.Green;
            this.lblInvoice2Cost.Location = new System.Drawing.Point(450, 40);
            this.lblInvoice2Cost.Name = "lblInvoice2Cost";
            this.lblInvoice2Cost.Size = new System.Drawing.Size(75, 23);
            this.lblInvoice2Cost.TabIndex = 89;
            this.lblInvoice2Cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalCost
            // 
            this.lblFinalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinalCost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCost.ForeColor = System.Drawing.Color.Green;
            this.lblFinalCost.Location = new System.Drawing.Point(612, 40);
            this.lblFinalCost.Name = "lblFinalCost";
            this.lblFinalCost.Size = new System.Drawing.Size(75, 23);
            this.lblFinalCost.TabIndex = 90;
            this.lblFinalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTimeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 587);
            this.Controls.Add(this.lblFinalCost);
            this.Controls.Add(this.lblInvoice2Cost);
            this.Controls.Add(this.lblInvoice1Cost);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInvoice2);
            this.Controls.Add(this.lblInvoice1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbPayDate);
            this.Controls.Add(this.lblInvoice2Hour);
            this.Controls.Add(this.lblInvoice1Hour);
            this.Controls.Add(this.lblFinalHour);
            this.Controls.Add(this.label2);
            this.Name = "frmTimeLog";
            this.Text = "Pay Period Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLogWk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugTimeLogWk1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice2;
        private System.Windows.Forms.Label lblInvoice1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPayDate;
        private System.Windows.Forms.Label lblInvoice2Hour;
        private System.Windows.Forms.Label lblInvoice1Hour;
        private System.Windows.Forms.Label lblFinalHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugTimeLogWk2;
        private Infragistics.Win.UltraWinGrid.UltraGrid ugTimeLogWk1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInvoice1Cost;
        private System.Windows.Forms.Label lblInvoice2Cost;
        private System.Windows.Forms.Label lblFinalCost;

    }
}