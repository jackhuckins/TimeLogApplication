using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeConnector
{
    public static class Data
    {
        public static class Variables
        {
            public static Dictionary<string, string> SelectedActionLog = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedAssignment = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedCompany = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedContractor = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedContractorContact = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedContact = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedPaydate = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedProject = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedTimeLog = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedTimeLogQuery = new Dictionary<string, string>();
            public static Dictionary<string, string> SelectedWorkDate = new Dictionary<string, string>();
            public static void AssignSelectionData(string Type, DataRow row)
            {
                switch (Type)
                {
                    case "ActionLog":
                        SelectedActionLog.Clear();
                        SelectedActionLog.Add("ActionId", row.ItemArray[0].ToString());
                        SelectedActionLog.Add("ActionDate", row.ItemArray[1].ToString());
                        SelectedActionLog.Add("ActionType", row.ItemArray[2].ToString());
                        SelectedActionLog.Add("ActionExtra", row.ItemArray[3].ToString());
                        break;
                    case "Assignment":
                        SelectedAssignment.Clear();
                        SelectedAssignment.Add("AssignmentId", row.ItemArray[0].ToString());
                        SelectedAssignment.Add("TimeLogId", row.ItemArray[1].ToString());
                        SelectedAssignment.Add("PayDateId", row.ItemArray[2].ToString());
                        SelectedAssignment.Add("ProjectId", row.ItemArray[3].ToString());
                        break;
                    case "Company":
                        SelectedCompany.Clear();
                        SelectedCompany.Add("CompanyId", row.ItemArray[0].ToString());
                        SelectedCompany.Add("CmpName", row.ItemArray[1].ToString());
                        SelectedCompany.Add("CmpAddress", row.ItemArray[2].ToString());
                        SelectedCompany.Add("CmpCity", row.ItemArray[3].ToString());
                        SelectedCompany.Add("CmpState", row.ItemArray[4].ToString());
                        SelectedCompany.Add("CmpZip", row.ItemArray[5].ToString());
                        SelectedCompany.Add("CmpPayrate", row.ItemArray[6].ToString());
                        SelectedCompany.Add("CmpLogoPath", row.ItemArray[7].ToString());
                        SelectedCompany.Add("CmpInitials", row.ItemArray[8].ToString());
                        SelectedCompany.Add("CmpType", row.ItemArray[9].ToString());
                        break;
                    case "Contractor":
                        SelectedContractor.Clear();
                        SelectedContractor.Add("CompanyId", row.ItemArray[0].ToString());
                        SelectedContractor.Add("CmpName", row.ItemArray[1].ToString());
                        SelectedContractor.Add("CmpAddress", row.ItemArray[2].ToString());
                        SelectedContractor.Add("CmpCity", row.ItemArray[3].ToString());
                        SelectedContractor.Add("CmpState", row.ItemArray[4].ToString());
                        SelectedContractor.Add("CmpZip", row.ItemArray[5].ToString());
                        SelectedContractor.Add("CmpPayrate", row.ItemArray[6].ToString());
                        SelectedContractor.Add("CmpLogoPath", row.ItemArray[7].ToString());
                        SelectedContractor.Add("CmpInitials", row.ItemArray[8].ToString());
                        SelectedContractor.Add("CmpType", row.ItemArray[9].ToString());
                        break;
                    case "ContractorContact":
                        SelectedContractorContact.Clear();
                        SelectedContractorContact.Add("ContactId", row.ItemArray[0].ToString());
                        SelectedContractorContact.Add("ConName", row.ItemArray[1].ToString());
                        SelectedContractorContact.Add("ConPhone", row.ItemArray[2].ToString());
                        SelectedContractorContact.Add("ConEmail", row.ItemArray[3].ToString());
                        SelectedContractorContact.Add("CompanyId", row.ItemArray[4].ToString());
                        break;
                    case "Contact":
                        SelectedContact.Clear();
                        SelectedContact.Add("ContactId", row.ItemArray[0].ToString());
                        SelectedContact.Add("ConName", row.ItemArray[1].ToString());
                        SelectedContact.Add("ConPhone", row.ItemArray[2].ToString());
                        SelectedContact.Add("ConEmail", row.ItemArray[3].ToString());
                        SelectedContact.Add("CompanyId", row.ItemArray[4].ToString());
                        break;
                    case "Paydate":
                        SelectedPaydate.Clear();
                        SelectedPaydate.Add("PayDateId", row.ItemArray[0].ToString());
                        SelectedPaydate.Add("CompanyId", row.ItemArray[1].ToString());
                        SelectedPaydate.Add("WeekStart", row.ItemArray[2].ToString());
                        SelectedPaydate.Add("WeekEnd", row.ItemArray[3].ToString());
                        SelectedPaydate.Add("PayDate", row.ItemArray[4].ToString());
                        SelectedPaydate.Add("InvoiceNumber", row.ItemArray[5].ToString());
                        SelectedPaydate.Add("WeekNumber", row.ItemArray[6].ToString());
                        break;
                    case "Project":
                        SelectedProject.Clear();
                        SelectedProject.Add("ProjectId", row.ItemArray[0].ToString());
                        SelectedProject.Add("ProjectName", row.ItemArray[1].ToString());
                        SelectedProject.Add("ProjectDescription", row.ItemArray[2].ToString());
                        SelectedProject.Add("ProjectStatus", row.ItemArray[3].ToString());
                        SelectedProject.Add("ProjectGroup", row.ItemArray[4].ToString());
                        break;
                    case "TimeLog":
                        SelectedCompany.Clear();
                        SelectedTimeLog.Add("TimeLogId", row.ItemArray[0].ToString());
                        SelectedTimeLog.Add("DateWorked", row.ItemArray[1].ToString());
                        SelectedTimeLog.Add("ProjectId", row.ItemArray[2].ToString());
                        SelectedTimeLog.Add("StartTime", row.ItemArray[3].ToString());
                        SelectedTimeLog.Add("EndTime", row.ItemArray[4].ToString());
                        break;
                    case "TimeLogQuery":
                        SelectedTimeLogQuery.Clear();
                        SelectedTimeLogQuery.Add("TimeLogId", row.ItemArray[0].ToString());
                        SelectedTimeLogQuery.Add("AssignmentId", row.ItemArray[1].ToString());
                        SelectedTimeLogQuery.Add("DateWorked", row.ItemArray[2].ToString());
                        SelectedTimeLogQuery.Add("WeekDate", row.ItemArray[3].ToString());
                        SelectedTimeLogQuery.Add("WeekNumber", row.ItemArray[4].ToString());
                        SelectedTimeLogQuery.Add("Description", row.ItemArray[5].ToString());
                        SelectedTimeLogQuery.Add("StartTime", row.ItemArray[6].ToString());
                        SelectedTimeLogQuery.Add("EndTime", row.ItemArray[7].ToString());
                        SelectedTimeLogQuery.Add("Hours", row.ItemArray[8].ToString());
                        SelectedTimeLogQuery.Add("Cost", row.ItemArray[9].ToString());
                        break;
                    case "WorkDate":
                        SelectedWorkDate.Clear();
                        SelectedWorkDate.Add("WorkDateId", row.ItemArray[0].ToString());
                        SelectedWorkDate.Add("WorkDate", row.ItemArray[1].ToString());
                        SelectedWorkDate.Add("PayDateId", row.ItemArray[2].ToString());
                        break;
                }
            }
            public static class CustomCombos
            {
                public static DataTable LoadTimeDataTable(string CurrentDate, string LoadType)
                {
                    DataTable dt = new DataTable();
                    int CurInt = 0;
                    int CurHour = 0;
                    int IntLimit = 24;
                    if (LoadType == "Normal")
                    {
                        CurInt = 7;
                        CurHour = CurInt;
                        IntLimit = 18;
                    }
                    string AmPm = "AM";
                    dt.Columns.Add("Display", typeof(String));
                    dt.Columns.Add("Value", typeof(DateTime));
                    while (CurInt < IntLimit)
                    {
                        if (CurInt == 0)
                        {
                            CurHour = 12;
                            AmPm = "AM";
                        }
                        if (CurInt == 1)
                        {
                            CurHour = 1;
                            AmPm = "AM";
                        }
                        if (CurInt == 12)
                        {
                            CurHour = 12;
                            AmPm = "PM";
                        }
                        if (CurInt == 13)
                        {
                            CurHour = 1;
                            AmPm = "PM";
                        }
                        dt.Rows.Add("" + CurHour.ToString() + ":00 " + AmPm + "", Convert.ToDateTime("" + CurrentDate + " " + CurHour.ToString() + ":00 " + AmPm + ""));
                        dt.Rows.Add("" + CurHour.ToString() + ":15 " + AmPm + "", Convert.ToDateTime("" + CurrentDate + " " + CurHour.ToString() + ":15 " + AmPm + ""));
                        dt.Rows.Add("" + CurHour.ToString() + ":30 " + AmPm + "", Convert.ToDateTime("" + CurrentDate + " " + CurHour.ToString() + ":30 " + AmPm + ""));
                        dt.Rows.Add("" + CurHour.ToString() + ":45 " + AmPm + "", Convert.ToDateTime("" + CurrentDate + " " + CurHour.ToString() + ":45 " + AmPm + ""));
                        CurInt++;
                        CurHour++;
                    }
                    return dt;
                }
                public static void LoadTimeCombos(ComboBox cb1, ComboBox cb2, string CurrentDate, string LoadType)
                {
                    if (LoadType == "Normal")
                    {
                        cb1.DataSource = LoadTimeDataTable(CurrentDate, "Normal");
                        cb1.DisplayMember = "Display";
                        cb1.ValueMember = "Value";
                        cb2.DataSource = LoadTimeDataTable(CurrentDate, "Normal");
                        cb2.DisplayMember = "Display";
                        cb2.ValueMember = "Value";
                    }
                    else
                    {
                        cb1.DataSource = LoadTimeDataTable(CurrentDate, "Overtime");
                        cb1.DisplayMember = "Display";
                        cb1.ValueMember = "Value";
                        cb2.DataSource = LoadTimeDataTable(CurrentDate, "Overtime");
                        cb2.DisplayMember = "Display";
                        cb2.ValueMember = "Value";
                    }
                }
            }
        }
        public static class Joins
        {
            public static DataTable GetJoinCompanyContact()
            {
                string query = "SELECT con.ContactId, con.ConName, con.ConPhone, con.ConEmail, con.CompanyId, cmp.CmpName FROM (Contacts con INNER JOIN Companies cmp ON con.CompanyId = cmp.CompanyId)";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetJoinCompanyContactById(int CompanyId)
            {
                string query = "SELECT con.ContactId, con.ConName, con.ConPhone, con.ConEmail, con.CompanyId, cmp.CmpName " +
                                "FROM (Contacts con INNER JOIN Companies cmp ON con.CompanyId = cmp.CompanyId) " +
                                "WHERE cmp.CompanyId = " + CompanyId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
        }
        public static class Company
        {
            public static void Delete(int IdValue)
            {
                string table = "Companies";
                string IdColumn = "CompanyId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(string CmpName, string CmpAddress, string CmpCity, string CmpState, string CmpZip, string CmpPayRate, string CmpLogoPath, string Initials, string CmpType)
            {
                string Command = "INSERT INTO Companies " +
                                "(CmpName, CmpAddress, CmpCity, CmpState, CmpZip, CmpPayRate, CmpLogoPath, Initials, CmpType) " +
                                "VALUES " +
                                "('" + CmpName + "','" + CmpAddress + "','" + CmpCity + "','" + CmpState + "','" + CmpZip + "','" + CmpPayRate + "','" + CmpLogoPath + "','" + Initials + "','" + CmpType + "')";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int CompanyId, string CmpName, string CmpAddress, string CmpCity, string CmpState, string CmpZip, string CmpPayRate, string CmpLogoPath, string Initials, string CmpType)
            {
                string Command = "UPDATE Companies " +
                                "SET CmpName = '" + CmpName + "', " +
                                "CmpAddress = '" + CmpAddress + "', " +
                                "CmpCity = '" + CmpCity + "', " +
                                "CmpState = '" + CmpState + "', " +
                                "CmpZip = '" + CmpZip + "', " +
                                "CmpPayRate = '" + CmpPayRate + "', " +
                                "CmpLogoPath = '" + CmpLogoPath + "', " +
                                "Initials = '" + Initials + "', " +
                                "CmpType = '" + CmpType + "' " +
                                "WHERE CompanyId = " + CompanyId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetAllCompanies()
            {
                string query = "SELECT * FROM Companies ORDER BY CmpName";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetActiveCompanies()
            {
                string query = "SELECT * FROM Companies WHERE CmpType='Company' ORDER BY CmpName";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetActiveContractors()
            {
                string query = "SELECT * FROM Companies WHERE CmpType='Contractor' ORDER BY CmpName";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetCompanyById(int CompanyId)
            {
                string query = "SELECT * FROM Companies WHERE CompanyId = " + CompanyId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
        }
        public static class Contact
        {
            public static void Delete(int IdValue)
            {
                string table = "Contacts";
                string IdColumn = "ContactId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(string ConName, string ConPhone, string ConEmail, int CompanyId)
            {
                string Command = "INSERT INTO Contacts " +
                                "(ConName, ConPhone, ConEmail, CompanyId) " +
                                "VALUES " +
                                "('" + ConName + "','" + ConPhone + "','" + ConEmail + "'," + CompanyId.ToString() + ")";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int ContactId, string ConName, string ConPhone, string ConEmail, int CompanyId)
            {
                string Command = "UPDATE Contacts " +
                                "SET ConName = '" + ConName + "', " +
                                "ConPhone = '" + ConPhone + "', " +
                                "ConEmail = '" + ConEmail + "', " +
                                "CompanyId = " + CompanyId + " " +
                                "WHERE ContactId = " + ContactId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetActiveContacts()
            {
                string query = "SELECT * FROM Contacts";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetContactByCompany(int CompanyId)
            {
                string query = "SELECT ContactId, ConName, ConPhone, ConEmail, CompanyId FROM Contacts WHERE CompanyId = " + CompanyId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetContactById(int ContactId)
            {
                string query = "SELECT ContactId, ConName, ConPhone, ConEmail, CompanyId FROM Contacts WHERE ContactId = " + ContactId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
        }
        public static class Paydate
        {
            public static void Delete(int IdValue)
            {
                string table = "PayDates";
                string IdColumn = "PayDateId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(int CompanyId, string WeekStart, string WeekEnd, string PayDate, string InvoiceNumber, int WeekNumber)
            {
                string Command = "INSERT INTO PayDates " +
                                "(CompanyId, WeekStart, WeekEnd, PayDate, InvoiceNumber, WeekNumber) " +
                                "VALUES " +
                                "(" + CompanyId + ",'" + WeekStart + "','" + WeekEnd + "','" + PayDate + "','" + InvoiceNumber + "'," + WeekNumber + ")";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int PayDateId, int CompanyId, string WeekStart, string WeekEnd, string PayDate, string InvoiceNumber, int WeekNumber)
            {
                string Command = "UPDATE PayDates " +
                                "SET ConName = " + CompanyId + ", " +
                                "ConPhone = '" + WeekStart + "', " +
                                "ConEmail = '" + WeekEnd + "', " +
                                "CompanyId = '" + PayDate + "', " +
                                "ConEmail = '" + InvoiceNumber + "', " +
                                "CompanyId = " + WeekNumber + " " +
                                "WHERE PayDateId = " + PayDateId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetPaydates()
            {
                string query = "SELECT * FROM PayDates ORDER BY CDATE(PayDate) DESC,CDATE(WeekStart) DESC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetPaydatesByCompany(int CompanyId)
            {
                string query = "SELECT PayDateId, CompanyId, WeekStart, WeekEnd, PayDate, InvoiceNumber, WeekNumber FROM PayDates WHERE (((CDate([WeekEnd])) Between (Date()-30) And (Date()+29)) AND ((CompanyId)=" + CompanyId + "))";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetPaydateIDsByPaydate(string Paydate)
            {
                string query = "SELECT PayDateId,InvoiceNumber FROM PayDates WHERE PayDate='" + Paydate + "' ORDER BY PayDateId";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetPaydateById(int PaydateId)
            {
                string query = "SELECT * FROM PayDates WHERE PayDateId = " + PaydateId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
            public static DataRow GetLastPaydateWithCompany()
            {
                string query = "SELECT TOP 1 pd.*,cmp.CompanyId,cmp.CmpName,cmp.Initials FROM PayDates pd INNER JOIN Companies cmp on cmp.CompanyId = pd.CompanyId ORDER BY CDate(WeekStart) DESC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
            public static DataRow GetPaydateByIdWithCompany(int PaydateId)
            {
                string query = "SELECT pd.*,cmp.CompanyId,cmp.CmpName FROM PayDates pd INNER JOIN Companies cmp on cmp.CompanyId = pd.CompanyId WHERE PayDateId = " + PaydateId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }            
        }
        public static class Project
        {
            public static void Delete(int IdValue)
            {
                string table = "Projects";
                string IdColumn = "ProjectId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(string ProjectName, string ProjectDescription, string ProjectStatus, string ProjectGroup)
            {
                string Command = "INSERT INTO Projects " +
                                "(ProjectName, ProjectDescription, ProjectStatus, ProjectGroup) " +
                                "VALUES " +
                                "('" + ProjectName + "','" + ProjectDescription + "','" + ProjectStatus + "','" + ProjectGroup + "')";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int ProjectId, string ProjectName, string ProjectDescription, string ProjectStatus, string ProjectGroup)
            {
                string Command = "UPDATE Projects " +
                                "SET ProjectName = '" + ProjectName + "', " +
                                "ProjectDescription = '" + ProjectDescription + "', " +
                                "ProjectStatus = '" + ProjectStatus + "', " +
                                "ProjectGroup = '" + ProjectGroup + "' " +
                                "WHERE ProjectId = " + ProjectId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetAllProjects()
            {
                string query = "SELECT * FROM Projects";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetOpenProjects()
            {
                string query = "SELECT * FROM Projects WHERE ProjectStatus = 'Open'";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetProjectGroups()
            {
                string query = "SELECT DISTINCT ProjectGroup FROM Projects ORDER BY ProjectGroup ASC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetProjectById(int ProjectId)
            {
                string query = "SELECT * FROM Projects WHERE ProjectId = " + ProjectId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
        }
        public static class TimeLog
        {
            public static void Delete(int IdValue)
            {
                string table = "TimeLog";
                string IdColumn = "TimeLogId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(int WorkDateId, int ProjectId, string StartTime, string EndTime)
            {
                string Command = "INSERT INTO TimeLog " +
                                "(WorkDateId,ProjectId, StartTime, EndTime) " +
                                "VALUES " +
                                "(" + WorkDateId + "," + ProjectId + ",'" + StartTime + "','" + EndTime + "')";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int TimeLogId, int WorkDateId, int ProjectId, string StartTime, string EndTime)
            {
                string Command = "UPDATE TimeLog " +
                                "SET WorkDateId = " + WorkDateId + ", " +
                                "ProjectId = " + ProjectId + ", " +
                                "StartTime = '" + StartTime + "', " +
                                "EndTime = '" + EndTime + "' " +
                                "WHERE TimeLogId = " + TimeLogId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetAllTimeLog()
            {
                string query = "SELECT * FROM TimeLog order by CDATE(StartTime)";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetTimeLogByWorkdate(int WorkdateId)
            {
                //string query = "SELECT * FROM TimeLog WHERE WorkDateId = " + WorkdateId + " ORDER BY CDATE(StartTime)";
                string query = "SELECT TimeLog.TimeLogId, WorkDates.WorkDate, Projects.ProjectDescription AS Description, " +
                                "Format([StartTime],'Medium Time') AS Start, Format([EndTime],'Medium Time') AS Finish, Projects.ProjectId " +
                                "FROM (PayDates INNER JOIN (TimeLog INNER JOIN WorkDates ON TimeLog.WorkDateId = WorkDates.WorkDateId) ON " +
                                "PayDates.PayDateId = WorkDates.PayDateId) INNER JOIN Projects ON TimeLog.ProjectId = Projects.ProjectId " +
                                "WHERE (((WorkDates.WorkDateId)=" + WorkdateId + ")) GROUP BY TimeLog.TimeLogId, WorkDates.WorkDate, " +
                                "Projects.ProjectDescription, Format([StartTime],'Medium Time'), Format([EndTime],'Medium Time'), Projects.ProjectId";

                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetBundledTimeLogByWorkDate(int PaydateId, int WeekNumber, string Workdate)
            {
                string query = "SELECT TimeLog.TimeLogId, WorkDates.WorkDate, PayDates.WeekNumber, Projects.ProjectDescription, TimeLog.StartTime, TimeLog.EndTime " +
                                "FROM (TimeLog INNER JOIN Projects ON TimeLog.ProjectId = Projects.ProjectId) INNER JOIN (WorkDates INNER JOIN PayDates ON " +
                                "WorkDates.PayDateId = PayDates.PayDateId) ON TimeLog.WorkDateId = WorkDates.WorkDateId WHERE (((PayDates.PayDateId)=" + PaydateId + ") " +
                                "AND ((PayDates.WeekNumber)=" + WeekNumber + ") AND ((CDATE(WorkDates.WorkDate))=CDATE('" + Workdate + "')))";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetTimeLogById(int TimeLogId)
            {
                string query = "SELECT TimeLog.TimeLogId, WorkDates.WorkDate, PayDates.WeekNumber, Projects.ProjectDescription, TimeLog.StartTime, TimeLog.EndTime " +
                                "FROM Companies, (TimeLog INNER JOIN Projects ON TimeLog.ProjectId = Projects.ProjectId) INNER JOIN (WorkDates INNER JOIN PayDates " +
                                "ON WorkDates.PayDateId = PayDates.PayDateId) ON TimeLog.WorkDateId = WorkDates.WorkDateId WHERE (((TimeLog.TimeLogId)=" + TimeLogId + "))";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            } 
        }
        public static class ActionLog
        {
            public static void Delete(int IdValue)
            {
                string table = "ActionLog";
                string IdColumn = "ActionId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(string ActionType, string ActionExtra)
            {
                string Command = "INSERT INTO ActionLog " +
                                "(ActionDate,ActionType, ActionExtra) " +
                                "VALUES " +
                                "('" + DateTime.Now.ToString() + "','" + ActionType + "','" + ActionExtra + "')";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int ActionId, string ActionDate, string ActionType, string ActionExtra)
            {
                string Command = "UPDATE ActionLog " +
                                "SET ActionDate = '" + ActionDate + "', " +
                                "ActionType = '" + ActionType + "', " +
                                "ActionExtra = '" + ActionExtra + "' " +
                                "WHERE ActionId = " + ActionId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetAllActionLog()
            {
                string query = "SELECT ActionId,Format(ActionDate,'Short Date') AS ActionDate,Format(ActionDate,'Medium Time') As ActionTime,ActionType,ActionExtra FROM ActionLog ORDER BY CDATE(ActionDate) DESC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetTodayActionLog()
            {
                string query = "SELECT ActionId,Format(ActionDate,'Short Date') AS ActionDate,Format(ActionDate,'Medium Time') As ActionTime,ActionType,ActionExtra FROM ActionLog WHERE CDATE(ActionDate) > CDATE('" + DateTime.Now.ToShortDateString() + "') ORDER BY CDATE(ActionDate) DESC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetCountByActionType(string ActionType,string ActionExtra)
            {
                string query = "SELECT COUNT(ActionId) AS Total FROM ActionLog WHERE ActionType = '" + ActionType + "' AND ActionExtra = '" + ActionExtra + "'";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }
        }
        public static class Workdate
        {
            public static void Delete(int IdValue)
            {
                string table = "WorkDates";
                string IdColumn = "WorkDateId";
                string Command = "DELETE FROM " + table + " WHERE " + IdColumn + " = " + IdValue + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Insert(string WorkDate, int PayDateId)
            {
                string Command = "INSERT INTO WorkDates " +
                                "(WorkDate, PayDateId) " +
                                "VALUES " +
                                "('" + WorkDate + "'," + PayDateId + ")";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static void Update(int WorkDateId, string WorkDate, int PayDateId)
            {
                string Command = "UPDATE WorkDates " +
                                "SET WorkDate = '" + WorkDate + "', " +
                                "PayDateId = " + PayDateId + " " +
                                "WHERE WorkDateId = " + WorkDateId + "";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(Command);
            }
            public static DataTable GetAllWorkDates()
            {
                string query = "SELECT * FROM WorkDates ORDER BY CDATE(ActionDate) DESC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataTable GetWorkDatesByPayDate(int PaydateId)
            {
                string query = "SELECT WorkDateId, WorkDate, PayDateId FROM WorkDates WHERE (((PayDateId)=" + PaydateId + ") AND ((Weekday([WorkDate],1))>1 And (Weekday([WorkDate],1))<7))";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt;
            }
            public static DataRow GetWorkDateById(int WorkDateId)
            {
                string query = "SELECT * FROM WorkDates WHERE WorkDateId " + WorkDateId + " ORDER BY CDATE(ActionDate) ASC";
                DataTable dt = new DataTable();
                dt = Connection.getResultTable(query);
                return dt.Rows[0];
            }            
        }
        public static class Invoice
        {
            private static double Invoice1Hour = 0.00;
            private static double Invoice1Cost = 0.00;
            private static double Invoice2Hour = 0.00;
            private static double Invoice2Cost = 0.00;
            private static double FinalHour = 0.00;
            private static double FinalCost = 0.00;
            public static string Wk1Hour = string.Empty;
            public static string Wk2Hour = string.Empty;
            public static string FinHour = string.Empty;
            public static string Wk1Cost = string.Empty;
            public static string Wk2Cost = string.Empty;
            public static string FinCost = string.Empty;
            public static DataTable Wk1Data = new DataTable();
            public static DataTable Wk2Data = new DataTable();
            public static void LoadPayPeriodTables(int PaydateId1, int PaydateId2)
            {
                Invoice1Hour = 0.00;
                Invoice1Cost = 0.00;
                Invoice2Hour = 0.00;
                Invoice2Cost = 0.00;
                FinalHour = 0.00;
                FinalCost = 0.00;
                Wk1Data = BuildNewTimeLog(PaydateId1, 1);
                Wk2Data = BuildNewTimeLog(PaydateId2, 2);
            }
            public static DataTable BuildNewTimeLog(int PayDateId, int WeekNum)
            {
                DataTable FinalTimeLog = new DataTable();
                FinalTimeLog.Columns.Add("Date");
                FinalTimeLog.Columns.Add("Day");
                FinalTimeLog.Columns.Add("#");
                FinalTimeLog.Columns.Add("Description");
                FinalTimeLog.Columns.Add("Start");
                FinalTimeLog.Columns.Add("Finish");
                FinalTimeLog.Columns.Add("Hours");
                FinalTimeLog.Columns.Add("Cost");

                DataTable Dates = TimeConnector.Data.Workdate.GetWorkDatesByPayDate(PayDateId);
                foreach (DataRow DateRow in Dates.Rows)
                {
                    string DateWorked = string.Empty;
                    string DayWorked = string.Empty;
                    string WeekNumber = string.Empty;
                    string Description = string.Empty;
                    string StartTime = string.Empty;
                    string EndTime = string.Empty;
                    string Hours = string.Empty;
                    string Cost = string.Empty;
                    DateTime WorkingStartTime = new DateTime();
                    DataTable TimeLog = TimeConnector.Data.TimeLog.GetBundledTimeLogByWorkDate(PayDateId, WeekNum, DateRow.ItemArray[1].ToString());
                    foreach (DataRow TimeRow in TimeLog.Rows)
                    {
                        string rowDateWorked = TimeRow.ItemArray[1].ToString();
                        string rowWeekNumber = TimeRow.ItemArray[2].ToString();
                        string rowDescription = TimeRow.ItemArray[3].ToString();
                        string rowStartTime = TimeRow.ItemArray[4].ToString();
                        string rowEndTime = TimeRow.ItemArray[5].ToString();
                        DateWorked = Convert.ToDateTime(rowDateWorked).ToShortDateString();
                        DayWorked = Convert.ToDateTime(DateWorked).DayOfWeek.ToString().Substring(0, 3).ToUpper();
                        WeekNumber = rowWeekNumber;
                        Description = "" + Description + ", " + rowDescription + "";
                        DateTime sTime = new DateTime();
                        DateTime eTime = new DateTime();
                        if (StartTime == "")
                        {
                            sTime = Convert.ToDateTime(rowStartTime);
                            eTime = Convert.ToDateTime(rowEndTime);
                            StartTime = sTime.ToShortTimeString();
                            EndTime = eTime.ToShortTimeString();
                            Hours = (((eTime - sTime).TotalMinutes) / 60).ToString();
                        }
                        else
                        {
                            sTime = Convert.ToDateTime(WorkingStartTime);
                            eTime = Convert.ToDateTime(rowEndTime);
                            EndTime = eTime.ToShortTimeString();
                            Hours = (((eTime - sTime).TotalMinutes) / 60).ToString();
                        }
                        WorkingStartTime = sTime;
                        double dblHours = Convert.ToDouble(Hours);
                        double dblPayrate = Convert.ToDouble(TimeConnector.Data.Variables.SelectedCompany["CmpPayrate"]);
                        double dblCost = (dblHours * dblPayrate);
                        Cost = System.String.Format("{0:C}", dblCost);
                    }
                    if (DateWorked == "")
                    {
                    }
                    else
                    {
                        Description = Description.Substring(2);
                        FinalTimeLog.Rows.Add(DateWorked, DayWorked, WeekNumber, Description, StartTime, EndTime, Hours, Cost);
                    }
                }
                foreach (DataRow row in FinalTimeLog.Rows)
                {
                    if (row.ItemArray[2].ToString() == "1")
                    {
                        Invoice1Hour = Invoice1Hour + Convert.ToDouble(row.ItemArray[6].ToString());
                        Invoice1Cost = Invoice1Cost + Convert.ToDouble(row.ItemArray[7].ToString().Substring(1));
                    }
                    else
                    {
                        Invoice2Hour = Invoice2Hour + Convert.ToDouble(row.ItemArray[6].ToString());
                        Invoice2Cost = Invoice2Cost + Convert.ToDouble(row.ItemArray[7].ToString().Substring(1));
                    }
                }
                return FinalTimeLog;
            }
            public static void Calculate()
            {
                Wk1Hour = "";
                Wk2Hour = "";
                FinHour = "";
                Wk1Cost = "";
                Wk2Cost = "";
                FinCost = "";
                FinalHour = Invoice1Hour + Invoice2Hour;
                FinalCost = Invoice1Cost + Invoice2Cost;
                Wk1Hour = String.Format("{0:0.00}",Invoice1Hour);
                Wk2Hour = String.Format("{0:0.00}",Invoice2Hour);
                FinHour = String.Format("{0:0.00}",FinalHour);
                Wk1Cost = String.Format("{0:C}",Invoice1Cost);
                Wk2Cost = String.Format("{0:C}",Invoice2Cost);
                FinCost = String.Format("{0:C}",FinalCost);
                Invoice1Hour = 0.00;
                Invoice2Hour = 0.00;
                FinalHour = 0.00;
                Invoice2Hour = 0.00;
                Invoice2Cost = 0.00;
                FinalCost = 0.00;
            }
            public static void Display(Label lblInv1H, Label lblInv2H, Label lblFinH, Label lblInv1C, Label lblInv2C, Label lblFinC)
            {
                lblInv1H.Text = System.String.Format("{0:0.00}", Wk1Hour);
                lblInv2H.Text = System.String.Format("{0:0.00}", Wk2Hour);
                lblFinH.Text = System.String.Format("{0:0.00}", FinHour);
                lblInv1C.Text = System.String.Format("{0:C}", Wk1Cost);
                lblInv2C.Text = System.String.Format("{0:C}", Wk2Cost);
                lblFinC.Text = System.String.Format("{0:C}", FinCost);
            }
        }
    }
}
