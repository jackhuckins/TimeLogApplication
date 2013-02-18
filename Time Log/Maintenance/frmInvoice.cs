using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Log.Maintenance
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
            cbCompany.DataSource = TimeConnector.Data.Company.GetActiveCompanies();
            cbCompany.DisplayMember = "CmpName";
            cbCompany.ValueMember = "CompanyId";
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            axInvoice.LoadFile(TimeConnector.Export.ReportPath);
        }
        private void btnEmail_Click(object sender, EventArgs e)
        {
            TimeConnector.Export.SendMail(chkTest.Checked);
            UpdateForm();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateForm()
        {
            if (TimeConnector.Export.PDFCheck() == true)
            {
                chkYes.Checked = true;
                chkNo.Checked = false;
            }
            else
            {
                chkYes.Checked = false;
                chkNo.Checked = true;
            }

            DataRow drEmail = TimeConnector.Data.ActionLog.GetCountByActionType("Send Email", TimeConnector.Export.SelectedInvoiceNumber);
            DataRow drInv = TimeConnector.Data.ActionLog.GetCountByActionType("PDF Export", TimeConnector.Export.SelectedInvoiceNumber);
            string EmailCount = drEmail.ItemArray[0].ToString();
            string InvCount = drInv.ItemArray[0].ToString();
            lblEmails.Text = EmailCount;
            lblUpdated.Text = InvCount;
        }
        private void ugPaydates_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugPaydates.Selected.Rows.All[0])).ListObject)).Row;
            TimeConnector.Export.SelectedInvoiceNumber = dr.ItemArray[5].ToString();
            TimeConnector.Export.SetReportPath();
            UpdateForm();
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CmpId;
            if (cbCompany.SelectedItem == null)
            {
                CmpId = 2;
                TimeConnector.Export.SelectedCompanyName = "Advantage Cable Services";
            }
            else
            {
                CmpId = Convert.ToInt32((((System.Data.DataRowView)(cbCompany.SelectedItem)).Row).ItemArray[0].ToString());
                TimeConnector.Export.SelectedCompanyName = (((System.Data.DataRowView)(cbCompany.SelectedItem)).Row).ItemArray[1].ToString();
            }
            ugPaydates.DataSource = TimeConnector.Data.Paydate.GetPaydatesByCompany(CmpId);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugPaydates.Selected.Rows.All[0])).ListObject)).Row;
            string Paydate = dr.ItemArray[4].ToString();
            TimeConnector.Export.PDFExport(Paydate);
            axInvoice.LoadFile(TimeConnector.Export.ReportPath);
            UpdateForm();
        }
    }
}
