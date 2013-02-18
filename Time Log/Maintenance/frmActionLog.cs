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
    public partial class frmActionLog : Form
    {
        public frmActionLog()
        {
            InitializeComponent();
        }
        private void RefreshLog()
        {
            if (chkToday.Checked == false)
            {
                ugActionLog.DataSource = TimeConnector.Data.ActionLog.GetAllActionLog();
            }
            else
            {
                ugActionLog.DataSource = TimeConnector.Data.ActionLog.GetTodayActionLog();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLog();
        }

        private void chkToday_CheckedChanged(object sender, EventArgs e)
        {
            RefreshLog();
        }
    }
}
