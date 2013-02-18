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
    public partial class frmLogOn : Form
    {
        public frmLogOn()
        {
            InitializeComponent();
            GetContractorCompany();
        }
        private void GetContractorCompany()
        {
            cbContractor.DataSource = TimeConnector.Data.Company.GetActiveContractors();
            cbContractor.DisplayMember = "CmpName";
            cbContractor.ValueMember = "CompanyId";
            //cbContractor.SelectedIndex = -1;
        }
        private void GetContractorContact()
        {
            int CmpId = Convert.ToInt32((((System.Data.DataRowView)(cbContractor.SelectedItem)).Row).ItemArray[0].ToString());
            cbContact.DataSource = TimeConnector.Data.Contact.GetContactByCompany(CmpId);
            cbContact.DisplayMember = "ConName";
            cbContact.ValueMember = "ContactId";
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataRow ContractorCompany = (((System.Data.DataRowView)(cbContractor.SelectedItem)).Row);
            TimeConnector.Data.Variables.AssignSelectionData("Contractor", ContractorCompany);
            DataRow ContractorContact = (((System.Data.DataRowView)(cbContact.SelectedItem)).Row);
            TimeConnector.Data.Variables.AssignSelectionData("ContractorContact", ContractorContact);
            this.DialogResult = DialogResult.OK;
        }
        private void cbContractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetContractorContact();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
