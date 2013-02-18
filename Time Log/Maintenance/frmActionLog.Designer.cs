namespace Time_Log.Maintenance
{
    partial class frmActionLog
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
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActionId");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActionDate");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActionTime");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActionType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActionExtra");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.ugActionLog = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkToday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ugActionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // ugActionLog
            // 
            this.ugActionLog.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 70;
            ultraGridColumn2.Header.Caption = "Date";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 70;
            ultraGridColumn3.Header.Caption = "Time";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 70;
            ultraGridColumn4.Header.Caption = "Action";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 200;
            ultraGridColumn5.Header.Caption = "Detail";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 100;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5});
            this.ugActionLog.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ugActionLog.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ugActionLog.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ugActionLog.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ugActionLog.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ugActionLog.DisplayLayout.Override.CellMultiLine = Infragistics.Win.DefaultableBoolean.True;
            this.ugActionLog.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            appearance1.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance1.FontData.BoldAsString = "True";
            appearance1.TextHAlignAsString = "Center";
            appearance1.TextVAlignAsString = "Middle";
            this.ugActionLog.DisplayLayout.Override.HeaderAppearance = appearance1;
            this.ugActionLog.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ugActionLog.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ugActionLog.DisplayLayout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.AutoFree;
            appearance2.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance2.BackColor2 = System.Drawing.Color.White;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.GlassBottom37Bright;
            appearance2.ForeColor = System.Drawing.Color.Black;
            this.ugActionLog.DisplayLayout.Override.SelectedRowAppearance = appearance2;
            this.ugActionLog.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugActionLog.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ugActionLog.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            this.ugActionLog.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ugActionLog.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ugActionLog.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.ugActionLog.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.ugActionLog.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ugActionLog.Location = new System.Drawing.Point(12, 41);
            this.ugActionLog.Name = "ugActionLog";
            this.ugActionLog.Size = new System.Drawing.Size(443, 460);
            this.ugActionLog.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(380, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkToday
            // 
            this.chkToday.AutoSize = true;
            this.chkToday.Location = new System.Drawing.Point(12, 16);
            this.chkToday.Name = "chkToday";
            this.chkToday.Size = new System.Drawing.Size(112, 17);
            this.chkToday.TabIndex = 2;
            this.chkToday.Text = "Results For Today";
            this.chkToday.UseVisualStyleBackColor = true;
            this.chkToday.CheckedChanged += new System.EventHandler(this.chkToday_CheckedChanged);
            // 
            // frmActionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 513);
            this.Controls.Add(this.chkToday);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ugActionLog);
            this.Name = "frmActionLog";
            this.Text = "Log Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ugActionLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ugActionLog;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkToday;
    }
}