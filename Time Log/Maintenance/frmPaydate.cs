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
    public partial class frmPaydate : Form
    {
        private string TmpCompanyId = "";
        private string TmpCompanyName = "";
        private string TmpCompanyInitials = "";
        private DataTable CompanyInfo = new DataTable();
        public frmPaydate()
        {
            InitializeComponent();
            RefreshData();
        }
        private void RefreshData()
        {
            ugPaydates.DataSource = TimeConnector.Data.Paydate.GetPaydates();
        }

        private void CalculateValues()
        {
            DataRow dr = TimeConnector.Data.Paydate.GetLastPaydateWithCompany();
            string LastPayDateId = dr.ItemArray[0].ToString();
            string LastCompanyId = dr.ItemArray[1].ToString();
            string LastWeekStart = dr.ItemArray[2].ToString();
            string LastInvoiceNumber = dr.ItemArray[5].ToString();
            string LastWeekNumber = dr.ItemArray[6].ToString();
            string LastCompanyName = dr.ItemArray[8].ToString();
            string LastCmpInitials = dr.ItemArray[9].ToString();
            string NextPayDateId = (Convert.ToInt32(LastPayDateId) + 1).ToString();
            if (LastCompanyId == "") { LastCompanyId = "2"; }
            string NextCompanyId = LastCompanyId;
            string NextCompanyName = LastCompanyName;
            string NextCmpInitials = LastCmpInitials;
            string NextWeekNumber;
            if (LastWeekNumber == "1")
            {
                NextWeekNumber = (Convert.ToInt32(LastWeekNumber) + 1).ToString();
            }
            else
            {
                NextWeekNumber = (Convert.ToInt32(LastWeekNumber) - 1).ToString();
            }
            string NextWeekStart = Convert.ToDateTime(LastWeekStart).AddDays(7).ToShortDateString();
            string NextWeekEnd = Convert.ToDateTime(NextWeekStart).AddDays(7).ToShortDateString();
            string NextPayDate = "";
            if (NextWeekNumber == "1")
            {
                NextPayDate = Convert.ToDateTime(NextWeekEnd).AddDays(19).ToShortDateString();
            }
            else
            {
                NextPayDate = Convert.ToDateTime(NextWeekEnd).AddDays(12).ToShortDateString();
            }
            string NextInvoiceNumber = "";
            Int32 InvNum = (Convert.ToInt32(LastInvoiceNumber.Substring(3)) + 1);
            NextInvoiceNumber = LastCmpInitials;
            if (InvNum.ToString().Length == 4)
            {
                NextInvoiceNumber = "" + NextInvoiceNumber + "" + InvNum.ToString() + "";
            }
            else if (InvNum.ToString().Length == 3)
            {
                NextInvoiceNumber = "" + NextInvoiceNumber + "0" + InvNum.ToString() + "";
            }
            else if (InvNum.ToString().Length == 2)
            {
                NextInvoiceNumber = "" + NextInvoiceNumber + "00" + InvNum.ToString() + "";
            }
            else
            {
                NextInvoiceNumber = "" + NextInvoiceNumber + "000" + InvNum.ToString() + "";
            }
            lblPaydateId.Text = NextPayDateId;
            lblCmpId.Text = NextCompanyId;
            lblCmpName.Text = NextCompanyName;
            lblWeekStart.Text = NextWeekStart;
            lblWeekEnd.Text = NextWeekEnd;
            lblPayDate.Text = NextPayDate;
            lblInvNumber.Text = NextInvoiceNumber;
            lblWeekNumber.Text = NextWeekNumber;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.Paydate.Insert(Convert.ToInt32(lblCmpId.Text), lblWeekStart.Text,
                lblWeekEnd.Text, lblPayDate.Text, lblInvNumber.Text, Convert.ToInt32(lblWeekNumber.Text));
            RefreshData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> PaydateSelection = TimeConnector.Data.Variables.SelectedPaydate;
            TimeConnector.Data.Paydate.Update(Convert.ToInt32(PaydateSelection["PayDateId"]),Convert.ToInt32(lblCmpId.Text), 
            lblWeekStart.Text, lblWeekEnd.Text, lblPayDate.Text, lblInvNumber.Text, Convert.ToInt32(lblWeekNumber.Text));
            RefreshData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> PaydateSelection = TimeConnector.Data.Variables.SelectedPaydate;
            TimeConnector.Data.Paydate.Delete(Convert.ToInt32(PaydateSelection["PayDateId"]));
            RefreshData();
            btnClear_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPaydateId.Text = "";
            lblCmpId.Text = "";
            lblWeekStart.Text = "";
            lblWeekEnd.Text = "";
            lblPayDate.Text = "";
            lblInvNumber.Text = "";
            lblWeekNumber.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ugPaydates_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugPaydates.Selected.Rows.All[0])).ListObject)).Row;
            TimeConnector.Data.Variables.AssignSelectionData("Paydate", dr);
            int PaydateId = Convert.ToInt32(dr.ItemArray[0].ToString());
            DataRow dr2 = TimeConnector.Data.Paydate.GetPaydateByIdWithCompany(PaydateId);
            lblPaydateId.Text = dr2.ItemArray[0].ToString();
            lblWeekStart.Text = dr2.ItemArray[2].ToString();
            lblWeekEnd.Text = dr2.ItemArray[3].ToString();
            lblPayDate.Text = dr2.ItemArray[4].ToString();
            lblInvNumber.Text = dr2.ItemArray[5].ToString();
            lblWeekNumber.Text = dr2.ItemArray[6].ToString();
            lblCmpId.Text = dr2.ItemArray[7].ToString();
            lblCmpName.Text = dr2.ItemArray[8].ToString();
        }
        private void btnNextPaydate_Click(object sender, EventArgs e)
        {
            CalculateValues();
        }
    }
}
