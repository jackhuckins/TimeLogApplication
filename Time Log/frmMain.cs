using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Log
{
    public partial class frmMain : Form
    {
        private int WorkDateIdSelected = 0;
        public frmMain()
        {
            InitializeComponent();
            try
            {
                UpdateContractorLabels();
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void UpdateContractorLabels()
        {
            lblContractorName.Text = TimeConnector.Data.Variables.SelectedContractor["CmpName"];
            lblContractorAddress.Text = TimeConnector.Data.Variables.SelectedContractor["CmpAddress"];
            string CityStateZip = "" + TimeConnector.Data.Variables.SelectedContractor["CmpCity"] + "" +
                ", " + TimeConnector.Data.Variables.SelectedContractor["CmpState"] + "" +
                "  " + TimeConnector.Data.Variables.SelectedContractor["CmpZip"] + "";
            lblContractorCityStateZip.Text = CityStateZip;
            lblContact.Text = "" + TimeConnector.Data.Variables.SelectedContractorContact["ConName"] + " is logged in";
            lblContractorPhone.Text = TimeConnector.Data.Variables.SelectedContractorContact["ConPhone"];
            lblContractorEmail.Text = TimeConnector.Data.Variables.SelectedContractorContact["ConEmail"];
            pbContractorLogo.ImageLocation = TimeConnector.Data.Variables.SelectedContractor["CmpLogoPath"];
        }
        private void RefreshGrid(DataTable dt)
        {
            ugTimeLog.DataSource = dt;
            int width = ((System.Windows.Forms.Control)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Grid)).Size.Width;
            int Description = 0;
            int AllOthers = 70 * 4;
            Description = (width - 5) - AllOthers;
            ((Infragistics.Win.UltraWinGrid.UltraGridColumn)(((Infragistics.Win.UltraWinGrid.UltraGridBand)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Bands.All[0])).Columns.All[3])).Width = 70;
            ((Infragistics.Win.UltraWinGrid.UltraGridColumn)(((Infragistics.Win.UltraWinGrid.UltraGridBand)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Bands.All[0])).Columns.All[4])).Width = 70;
            //((Infragistics.Win.UltraWinGrid.UltraGridColumn)(((Infragistics.Win.UltraWinGrid.UltraGridBand)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Bands.All[0])).Columns.All[6])).Width = 70;
            //((Infragistics.Win.UltraWinGrid.UltraGridColumn)(((Infragistics.Win.UltraWinGrid.UltraGridBand)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Bands.All[0])).Columns.All[7])).Width = 70;
            ((Infragistics.Win.UltraWinGrid.UltraGridColumn)(((Infragistics.Win.UltraWinGrid.UltraGridBand)((((Infragistics.Win.UltraWinGrid.UltraGridBase)(ugTimeLog)).DisplayLayout).Bands.All[0])).Columns.All[2])).Width = Description;
        }
        private void LoadData()
        {
            cbCompany.DataSource = TimeConnector.Data.Company.GetActiveCompanies();
            cbCompany.DisplayMember = "CmpName";
            cbCompany.ValueMember = "CompanyId";
        }
        private void LoadPaydates(int CmpId)
        {
            cbPaydate.DataSource = TimeConnector.Data.Paydate.GetPaydatesByCompany(CmpId);
            cbPaydate.DisplayMember = "InvoiceNumber";
            cbPaydate.ValueMember = "PayDateId";
        }
        private void btnCompany_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmCompany fcom = new Maintenance.frmCompany();
            fcom.Show();
        }
        private void btnContact_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmContact fcon = new Maintenance.frmContact();
            fcon.Show();
        }
        private void btnPayDate_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmPaydate fpay = new Maintenance.frmPaydate();
            fpay.Show();
        }
        private void btnProject_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmProject fpro = new Maintenance.frmProject();
            fpro.Show();
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmInvoice finv = new Maintenance.frmInvoice();
            finv.Show();
        }
        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCompany.SelectedValue == null)
            {
            }
            else
            {
                int CmpId = Convert.ToInt32(cbCompany.SelectedValue.ToString());
                DataRow dr = TimeConnector.Data.Company.GetCompanyById(CmpId);
                TimeConnector.Data.Variables.AssignSelectionData("Company", dr);
                LoadPaydates(CmpId);
                DataTable dt = TimeConnector.Data.Contact.GetContactByCompany(CmpId);
                TimeConnector.Data.Variables.AssignSelectionData("Contact", dt.Rows[0]);  
                if (cbPaydate.Items.Count == 0)
                {
                    cbPaydate.Text = "";
                }
                else
                {
                    cbPaydate.SelectedIndex = 5;
                }
            }
        }
        private void cbPaydate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaydate.SelectedValue == null)
            {
            }
            else
            {
                int PayDateId = Convert.ToInt32(cbPaydate.SelectedValue.ToString());
                ugWorkdate.DataSource = TimeConnector.Data.Workdate.GetWorkDatesByPayDate(PayDateId);
                DataRow dr = TimeConnector.Data.Paydate.GetPaydateById(PayDateId);
                TimeConnector.Data.Variables.AssignSelectionData("Paydate", dr);
            }
        }
        private DataTable GetTimeLogStats(DataTable dt)
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("TimeLogId");
            dt2.Columns.Add("WorkDate");
            dt2.Columns.Add("Description");
            dt2.Columns.Add("Start");
            dt2.Columns.Add("Finish");
            dt2.Columns.Add("ProjectId");
            dt2.Columns.Add("Hours");
            dt2.Columns.Add("Cost");
            foreach (DataRow row in dt.Rows)
            {
                DateTime Start = Convert.ToDateTime(row.ItemArray[3].ToString());
                DateTime Finish = Convert.ToDateTime(row.ItemArray[4].ToString());
                System.TimeSpan diff1 = Finish.Subtract(Start);
                double Hours = Convert.ToDouble(diff1.TotalHours);
                double Cost = (Hours * Convert.ToDouble(TimeConnector.Data.Variables.SelectedCompany["CmpPayrate"]));
                dt2.Rows.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString(), row.ItemArray[5].ToString(), String.Format("{0:0.00}", Hours), String.Format("{0:C}", Cost));
            }
            return dt2;
        }
        private void ugWorkdate_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            ClearLabels();
            int WorkDateId = Convert.ToInt32(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugWorkdate.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0].ToString());
            WorkDateIdSelected = WorkDateId;
            string WorkDate = Convert.ToDateTime(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugWorkdate.Selected.Rows.All[0])).ListObject)).Row.ItemArray[1].ToString()).ToShortDateString();
            //DateTime SelectedDate = Convert.ToDateTime((((System.Data.DataRowView)(ugWorkdate.ActiveCell.Row.ListObject)).Row).ItemArray[0].ToString());
            //LoadTimeLog(WorkDateId);
            DataTable dt = TimeConnector.Data.TimeLog.GetTimeLogByWorkdate(WorkDateId);
            DataTable dt2 = GetTimeLogStats(dt);
            RefreshGrid(dt2);
            chkOvertime_CheckedChanged(sender, e);
            //Database.Values.CustomCombos.LoadTimeCombos(cbStartTime, cbEndTime, WorkDate, "Normal");
            cbProject.DataSource = TimeConnector.Data.Project.GetOpenProjects();
            cbProject.DisplayMember = "ProjectName";
            cbProject.ValueMember = "ProjectId";
        }
        private void ugTimeLog_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            ClearLabels();
            int TimeLogId = Convert.ToInt32(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugTimeLog.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0]);
            int ProjectId = Convert.ToInt32(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugTimeLog.Selected.Rows.All[0])).ListObject)).Row.ItemArray[5]);
            DataRow dr = TimeConnector.Data.TimeLog.GetTimeLogById(TimeLogId);
            GetTimeLogDetail(dr);
        }
        private void ClearLabels()
        {
            lblDescription.Text = "";
            lblStart.Text = "";
            lblFinish.Text = "";
            lblHours.Text = "";
            lblCost.Text = "";
        }
        private void GetTimeLogDetail(DataRow row)
        {
            string tleTimeLogId = row.ItemArray[0].ToString();
            string tleDateWorked = row.ItemArray[1].ToString();
            DateTime wDate = Convert.ToDateTime(tleDateWorked);
            string wDateString = wDate.ToShortDateString();
            string tleWeekNumber = row.ItemArray[2].ToString();
            string tleDescription = row.ItemArray[3].ToString();
            string tleStartTime = row.ItemArray[4].ToString();
            string tleEndTime = row.ItemArray[5].ToString();
            //lblDate.Text = wDateString;
            //lblDay.Text = wDate.DayOfWeek.ToString().Substring(0, 3).ToUpper();
            //lblWeek.Text = tleWeekNumber;
            lblDescription.Text = tleDescription;
            DateTime sTime = Convert.ToDateTime(tleStartTime);
            DateTime eTime = Convert.ToDateTime(tleEndTime);
            lblStart.Text = sTime.ToShortTimeString();
            lblFinish.Text = eTime.ToShortTimeString();
            string Hours = lblHours.Text = (((eTime - sTime).TotalMinutes) / 60).ToString();
            double dblHours = Convert.ToDouble(Hours);
            double dblPayrate = Convert.ToDouble(TimeConnector.Data.Variables.SelectedCompany["CmpPayrate"]);
            double dblCost = (dblHours * dblPayrate);
            lblCost.Text = String.Format("{0:C}", dblCost);
        }
        private void btnTimeLog_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmTimeLog ftim = new Maintenance.frmTimeLog();
            ftim.Show();
        }
        private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selected = Convert.ToDateTime(((System.Data.DataRowView)(cbStartTime.SelectedItem)).Row.ItemArray[1].ToString());
            string SelectedStart = selected.ToString();
            int IndexSelected = cbStartTime.SelectedIndex;
            int IndexChange = IndexSelected + 32;
            try
            {
                cbEndTime.SelectedIndex = IndexChange;
            }
            catch (Exception ex)
            {
                string test = ex.Message;
            }
            lblStartTime.Text = SelectedStart;
        }
        private void cbEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selected = Convert.ToDateTime(((System.Data.DataRowView)(cbEndTime.SelectedItem)).Row.ItemArray[1].ToString());
            string SelectedEnd = selected.ToString();
            lblEndTime.Text = SelectedEnd;
        }
        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblProjDesc.Text = (((System.Data.DataRowView)(cbProject.SelectedItem)).Row).ItemArray[2].ToString();
            }
            catch (Exception ex)
            {
                string test = ex.Message;
            }
        }
        private void chkOvertime_CheckedChanged(object sender, EventArgs e)
        {
            string WorkDate = Convert.ToDateTime(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugWorkdate.Selected.Rows.All[0])).ListObject)).Row.ItemArray[1].ToString()).ToShortDateString();
            if (chkOvertime.Checked == true)
            {
                TimeConnector.Data.Variables.CustomCombos.LoadTimeCombos(cbStartTime, cbEndTime, WorkDate, "Overtime");
            }
            else
            {
                TimeConnector.Data.Variables.CustomCombos.LoadTimeCombos(cbStartTime, cbEndTime, WorkDate, "Normal");
                cbStartTime.SelectedIndex = 1;
                cbStartTime.SelectedIndex = 0;
            }
        }
        private void btnActionLog_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            Maintenance.frmActionLog actionlogform = new Maintenance.frmActionLog();
            actionlogform.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            TimeConnector.Data.TimeLog.Insert(WorkDateIdSelected, Convert.ToInt32((((System.Data.DataRowView)(cbProject.SelectedItem)).Row).ItemArray[0].ToString()), lblStartTime.Text, lblEndTime.Text);
            DataTable dt = TimeConnector.Data.TimeLog.GetTimeLogByWorkdate(WorkDateIdSelected);
            dt = GetTimeLogStats(dt);
            RefreshGrid(dt);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            int TimeLogId = Convert.ToInt32(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugTimeLog.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0].ToString());
            TimeConnector.Data.TimeLog.Update(TimeLogId,WorkDateIdSelected, Convert.ToInt32((((System.Data.DataRowView)(cbProject.SelectedItem)).Row).ItemArray[0].ToString()), lblStartTime.Text, lblEndTime.Text);
            DataTable dt = TimeConnector.Data.TimeLog.GetTimeLogByWorkdate(WorkDateIdSelected);
            dt = GetTimeLogStats(dt);
            RefreshGrid(dt);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            int TimeLogId = Convert.ToInt32(((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugTimeLog.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0].ToString());
            TimeConnector.Data.TimeLog.Delete(TimeLogId);
            DataTable dt = TimeConnector.Data.TimeLog.GetTimeLogByWorkdate(WorkDateIdSelected);
            dt = GetTimeLogStats(dt);
            RefreshGrid(dt);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Clicked " + ((System.Windows.Forms.ButtonBase)(sender)).Text + "", this.Name);
            this.Close();

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Stop Application", DateTime.Now.ToShortDateString());
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            TimeConnector.Data.ActionLog.Insert("Start Application", DateTime.Now.ToShortDateString());
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("TimeLogId");
            dt2.Columns.Add("WorkDate");
            dt2.Columns.Add("Description");
            dt2.Columns.Add("Start");
            dt2.Columns.Add("Finish");
            dt2.Columns.Add("ProjectId");
            dt2.Columns.Add("Hours");
            dt2.Columns.Add("Cost");
            RefreshGrid(dt2);
        }

        private void frmMain_StyleChanged(object sender, EventArgs e)
        {

        }
    }
}
