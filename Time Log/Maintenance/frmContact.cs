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
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
            RefreshData();
            cbCompany.Text = "";
        }
        private void RefreshData()
        {
            ugContacts.DataSource = TimeConnector.Data.Joins.GetJoinCompanyContact();
            cbCompany.DataSource = TimeConnector.Data.Company.GetAllCompanies();
            cbCompany.DisplayMember = "CmpName";
            cbCompany.ValueMember = "CompanyId";
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCompany.SelectedItem == null)
            {
                lblCmpId.Text = "";
            }
            else
            {
                lblCmpId.Text = (((System.Data.DataRowView)(cbCompany.SelectedItem)).Row).ItemArray[0].ToString();
            }
        }

        private void ugContacts_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugContacts.Selected.Rows.All[0])).ListObject)).Row;
            TimeConnector.Data.Variables.AssignSelectionData("Contact", dr);
            lblContactId.Text = dr.ItemArray[0].ToString();
            txtConName.Text = dr.ItemArray[1].ToString();
            txtConPhone.Text = dr.ItemArray[2].ToString();
            txtConEmail.Text = dr.ItemArray[3].ToString();
            lblCmpId.Text = dr.ItemArray[4].ToString();
            cbCompany.SelectedIndex = (Convert.ToInt32(lblCmpId.Text) - 2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.Contact.Insert(txtConName.Text, txtConPhone.Text, txtConEmail.Text, Convert.ToInt32(lblCmpId.Text));
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ContactSelection = TimeConnector.Data.Variables.SelectedContact;
            TimeConnector.Data.Contact.Update(Convert.ToInt32(ContactSelection["ContactId"]),txtConName.Text, 
                txtConPhone.Text, txtConEmail.Text, Convert.ToInt32(lblCmpId.Text));
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ContactSelection = TimeConnector.Data.Variables.SelectedContact;
            TimeConnector.Data.Contact.Delete(Convert.ToInt32(ContactSelection["ContactId"]));
            RefreshData();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblContactId.Text = "";
            txtConName.Text = "";
            txtConPhone.Text = "";
            txtConEmail.Text = "";
            lblCmpId.Text = "";
            cbCompany.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
