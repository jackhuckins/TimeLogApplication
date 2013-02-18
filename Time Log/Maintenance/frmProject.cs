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
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
            RefreshData();
        }
        private void RefreshData()
        {
            ugProjects.DataSource = TimeConnector.Data.Project.GetAllProjects();
            ucProjGroup.DataSource = TimeConnector.Data.Project.GetProjectGroups();
            ucProjGroup.DisplayMember = "ProjectGroup";
            ucProjGroup.ValueMember = "ProjectGroup";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TimeConnector.Data.Project.Insert(txtProjName.Text, txtProjDescription.Text, ucProjStatus.Text, ucProjGroup.Text);
            RefreshData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ProjectSelection = TimeConnector.Data.Variables.SelectedProject;
            TimeConnector.Data.Project.Update(Convert.ToInt32(ProjectSelection["ProjectId"]),txtProjName.Text, 
                txtProjDescription.Text, ucProjStatus.Text, ucProjGroup.Text);
            RefreshData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ProjectSelection = TimeConnector.Data.Variables.SelectedProject;
            TimeConnector.Data.Project.Delete(Convert.ToInt32(ProjectSelection["ProjectId"]));
            RefreshData();
            btnClear_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblProjId.Text = "";
            txtProjName.Text = "";
            txtProjDescription.Text = "";
            ucProjStatus.Text = "";
            ucProjGroup.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ugProjects_ClickCell(object sender, Infragistics.Win.UltraWinGrid.ClickCellEventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(ugProjects.Selected.Rows.All[0])).ListObject)).Row;
            TimeConnector.Data.Variables.AssignSelectionData("Project", dr);
            lblProjId.Text = dr.ItemArray[0].ToString();
            txtProjName.Text = dr.ItemArray[1].ToString();
            txtProjDescription.Text = dr.ItemArray[2].ToString();
            ucProjStatus.Text = dr.ItemArray[3].ToString();
            ucProjGroup.Text = dr.ItemArray[4].ToString();
        }
    }
}
