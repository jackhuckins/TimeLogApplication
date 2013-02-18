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
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
            RefreshData();
        }
        private void RefreshData()
        {
            ugCompanies.DataSource = TimeConnector.Data.Company.GetAllCompanies(); 
        }
        private void ugCompanies_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugCompanies.Selected.Rows.All[0])).ListObject)).Row;
            TimeConnector.Data.Variables.AssignSelectionData("Company", dr);
            lblCmpId.Text = dr.ItemArray[0].ToString();          
            txtCmpName.Text = dr.ItemArray[1].ToString();
            txtCmpAddress.Text = dr.ItemArray[2].ToString();
            txtCmpCity.Text = dr.ItemArray[3].ToString();
            txtCmpState.Text = dr.ItemArray[4].ToString();
            txtCmpZip.Text = dr.ItemArray[5].ToString();
            txtCmpPayRate.Text = dr.ItemArray[6].ToString();
            txtCmpLogoPath.Text = dr.ItemArray[7].ToString();
            txtCmpInitials.Text = dr.ItemArray[8].ToString();
            txtCmpType.Text = dr.ItemArray[9].ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.Company.Insert(txtCmpName.Text, txtCmpAddress.Text, txtCmpCity.Text,
                txtCmpState.Text, txtCmpZip.Text, txtCmpPayRate.Text,
                txtCmpLogoPath.Text, txtCmpInitials.Text, txtCmpType.Text);
            RefreshData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> CompanySelection = TimeConnector.Data.Variables.SelectedCompany;
            TimeConnector.Data.Company.Update(Convert.ToInt32(CompanySelection["CompanyId"]),txtCmpName.Text, txtCmpAddress.Text, txtCmpCity.Text,
                txtCmpState.Text, txtCmpZip.Text, txtCmpPayRate.Text,
                txtCmpLogoPath.Text, txtCmpInitials.Text, txtCmpType.Text);
            RefreshData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> CompanySelection = TimeConnector.Data.Variables.SelectedCompany;
            TimeConnector.Data.Company.Delete(Convert.ToInt32(CompanySelection["CompanyId"]));
            RefreshData();
            btnClear_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCmpId.Text = "";
            txtCmpName.Text = "";
            txtCmpAddress.Text = "";
            txtCmpCity.Text = "";
            txtCmpState.Text = "";
            txtCmpZip.Text = "";
            txtCmpPayRate.Text = "";
            txtCmpLogoPath.Text = "";
            txtCmpInitials.Text = "";
            txtCmpType.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogoBrowse_Click(object sender, EventArgs e)
        {
            ofdLogoPath.ShowDialog();
            txtCmpLogoPath.Text = ofdLogoPath.FileName;
        }
        private void txtCmpLogoPath_ValueChanged(object sender, EventArgs e)
        {
            string LogoPath;
            int intLocation, intLength;

            intLength = txtCmpLogoPath.Text.Length;
            intLocation = txtCmpLogoPath.Text.IndexOf("Time Log");

            if (intLocation > 0)
            {
                LogoPath = txtCmpLogoPath.Text;
            }
            else
            {
                LogoPath = "" + Application.StartupPath + @"\" + txtCmpLogoPath.Text.Replace(@"/", @"\") + "";
            }
            string test = LogoPath;
            txtCmpLogoPath.Text = LogoPath;
            pbCompanyLogo.ImageLocation = LogoPath;
        }
    }
}
