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
    public partial class frmTimeLog : Form
    {
        public frmTimeLog()
        {
            InitializeComponent();
            cbPayDate.DataSource = TimeConnector.Data.Paydate.GetPaydatesByCompany(Convert.ToInt32(TimeConnector.Data.Variables.SelectedCompany["CompanyId"]));
            cbPayDate.DisplayMember = "InvoiceNumber";
            cbPayDate.ValueMember = "PayDateId";
            GetData();
            cbPayDate.SelectedIndex = 5;
        }
        private void GetData()
        {
            int PayDateId = Convert.ToInt32(((System.Data.DataRowView)(cbPayDate.SelectedItem)).Row.ItemArray[0].ToString());
            string Paydate = ((System.Data.DataRowView)(cbPayDate.SelectedItem)).Row.ItemArray[4].ToString();
            DataTable dt = TimeConnector.Data.Paydate.GetPaydateIDsByPaydate(Paydate);
            int PaydateId1 = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            int PaydateId2 = Convert.ToInt32(dt.Rows[1].ItemArray[0].ToString());
            string Invoice1 = dt.Rows[0].ItemArray[1].ToString();
            string Invoice2 = dt.Rows[1].ItemArray[1].ToString();
            TimeConnector.Data.Invoice.LoadPayPeriodTables(PaydateId1, PaydateId2);
            ugTimeLogWk1.DataSource = TimeConnector.Data.Invoice.Wk1Data;
            ugTimeLogWk2.DataSource = TimeConnector.Data.Invoice.Wk2Data;
            lblInvoice1.Text = Invoice1;
            lblInvoice2.Text = Invoice2;
            TimeConnector.Data.Invoice.Calculate();
            TimeConnector.Data.Invoice.Display(lblInvoice1Hour,lblInvoice2Hour,lblFinalHour,lblInvoice1Cost,lblInvoice2Cost,lblFinalCost);
        }
        private void cbPayDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
