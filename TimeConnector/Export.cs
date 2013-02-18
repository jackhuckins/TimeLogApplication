using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace TimeConnector
{
    public static class Export
    {
        #region "Variables"
        public static string ApplicationPath;
        public static string ReportPath;
        public static bool Updating = false;
        public static string PdfFont = "Calibri";
        public static string PdfFontMyInfo = "Tempus Sans ITC";
        public static string SelectedInvoiceNumber = "";
        public static string SelectedCompanyName = "";
        #endregion

        #region "Actions"
        public static void SetReportPath()
        {
            ApplicationPath = Application.StartupPath;
            string NewFileName = "" + SelectedInvoiceNumber + ".pdf";
            ReportPath = "" + ApplicationPath + "\\Invoices\\" + SelectedCompanyName + "\\" + NewFileName + "";
        }
        public static bool PDFCheck()
        {
            bool PDFExists = false;
            string SearchDirectory = "" + Application.StartupPath + "\\Invoices\\" + SelectedCompanyName + "";
            if ((System.IO.Directory.Exists(SearchDirectory)))
            {
            }
            else
            {
                System.IO.Directory.CreateDirectory(SearchDirectory);
            }
            List<string> FilterList = new List<string>();
            FilterList.Add("" + SelectedInvoiceNumber + ".pdf");
            List<System.IO.FileInfo> files = GetFiles(SearchDirectory, FilterList);
            if (files.Count == 0)
            {
                PDFExists = false;
            }
            else
            {
                PDFExists = true;
            }
            return PDFExists;
        }
        private static List<System.IO.FileInfo> GetFiles(string Path, List<string> FilterList)
        {
            System.IO.DirectoryInfo d = new System.IO.DirectoryInfo(Path);
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();

            //Iterate through the FilterList

            foreach (string Filter in FilterList)
            {
                //the files are appended to the file array
                files.AddRange(d.GetFiles(Filter));
            }

            return files;
        }
        public static void UpdatePDFLabel(string Type, Label label)
        {
            if (Type == "Load")
            {
                if (PDFCheck() == false)
                {
                    label.Text = "" + SelectedInvoiceNumber + " Does Not Exist";
                }
                else
                {
                    label.Text = "" + SelectedInvoiceNumber + " Exists";
                }
            }
            else
            {
                int counter = 0;
                int counterEnd = 30;
                byte Done = 0;
                counter = 0;
                while (counter <= counterEnd)
                {
                    if (PDFCheck() == false)
                    {
                        label.Text = "" + SelectedInvoiceNumber + " Does Not Exist";
                        Done = 0;
                    }
                    else
                    {
                        label.Text = "" + SelectedInvoiceNumber + " Exists";
                        if (Updating == true)
                        {
                            label.Text = "" + SelectedInvoiceNumber + " Updated";
                        }
                        Done = 1;
                    }
                    if (Done == 0)
                    {
                        counter = counter + 1;
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        counter = 31;
                    }
                }
            }
        }
        public static void SendMail(bool TestStatus)
        {
            int TestRun = 0;
            if (TestStatus == true)
            {
                TestRun = 1;
            }
            else
            {
                TestRun = 0;
            }
            string MyName = TimeConnector.Data.Variables.SelectedContractorContact["ConName"];
            string MyPhone = TimeConnector.Data.Variables.SelectedContractorContact["ConPhone"];
            string MyEmail = TimeConnector.Data.Variables.SelectedContractorContact["ConEmail"];
            string ContactName = TimeConnector.Data.Variables.SelectedContact["ConName"];
            string ContactPhone = TimeConnector.Data.Variables.SelectedContact["ConPhone"];
            string ContactEmail = TimeConnector.Data.Variables.SelectedContact["ConEmail"];
            string WeekEnding = TimeConnector.Data.Variables.SelectedPaydate["WeekEnd"];
            string PayDate = TimeConnector.Data.Variables.SelectedPaydate["PayDate"];
            string InvoiceNumber = TimeConnector.Data.Variables.SelectedPaydate["InvoiceNumber"];

            NetworkCredential loginInfo = new NetworkCredential(MyEmail, "Huck1977!");
            string EmailFrom = MyEmail;
            string EmailTo = null;
            string EmailSubject = "Invoice # " + SelectedInvoiceNumber + "";
            string EmailBody = "";
            string ToAddress = "";
            string BccAddress = "";
            if (TestRun == 1)
            {
                ToAddress = MyEmail;
                //Should be Administrator
                BccAddress = MyEmail;
                //Should be Test Administrator
            }
            else
            {
                ToAddress = ContactEmail;
                //Should be ContactEmail
                BccAddress = MyEmail;
                //Should be Administrator
            }
            EmailTo = ToAddress;

            string eStart = "<html><head></head><body><font face=trebuchet size=3>";
            string eBody = null;
            string eSignature = null;
            string eEnd = "</font></body></html>";
            string eFinal = null;
            object NameArray = Strings.Split(ContactName, " ");

            string DisplayName = null;
            DisplayName = ((string[])(NameArray))[0];

            //************************************************ BODY OF EMAIL ********************************************
            eBody = "<table border=0 cellpadding=0 cellspacing=0>";
            eBody += "<tr>";
            eBody += "<td colspan=4>" + DisplayName + ",</td>";
            eBody += "</tr>";
            eBody += "<tr>";
            eBody += "<td colspan=4>&nbsp;</td>";
            eBody += "</tr>";
            if (DateTime.Now > Convert.ToDateTime(WeekEnding))
            {
                eBody += "<tr>";
                eBody += "<td colspan=4>I have attached an Invoice for time worked last week. Below I have outlined the details:</td>";
                eBody += "</tr>";
            }
            else
            {
                eBody += "<tr>";
                eBody += "<td colspan=4>I have attached an Invoice for time worked this week. Below I have outlined the details:</td>";
                eBody += "</tr>";
            }
            eBody += "<tr>";
            eBody += "<td colspan=4>&nbsp;</td>";
            eBody += "</tr>";
            eBody += "<tr>";
            eBody += "<td>Invoice #:</td>";
            eBody += "<td>Week Ending:</td>";
            eBody += "<td>Pay Date:</td>";
            eBody += "<td>&nbsp;</td>";
            eBody += "</tr>";
            eBody += "<tr>";
            eBody += "<td><font color=#9E0508><b>" + InvoiceNumber + "</b></font></td>";
            eBody += "<td><font color=#9E0508><b>" + WeekEnding + "</b></font></td>";
            eBody += "<td><font color=#9E0508><b>" + PayDate + "</b></font></td>";
            eBody += "<td width=100>&nbsp;</td>";
            eBody += "</tr>";
            eBody += "</table>";
            eBody += "<br>";
            //***********************************************************************************************************
            //******************************************* SIGNATURE OF EMAIL ********************************************
            eSignature = "<br>";
            eSignature += "<table>";
            eSignature += "<tr>";
            eSignature += "<td colspan=2>&nbsp;</td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td><font size=2>Thanks,</font></td>";
            eSignature += "<td>&nbsp;</td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td colspan=2>&nbsp;</td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td colspan=2 align=center><b><font size=5 color=#26466D><u><i>Stephen Jack Huckins</i></u></font></b></td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td colspan=2 align=center>-----&nbsp;<font color=#9E0508><i>C# & VB Programmer</i></font>&nbsp;-----</td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td colspan=2>&nbsp;</td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td><font size=2>Work:</font></td>";
            eSignature += "<td><font size=2><b>(219) 513-6735</b></font></td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td><font size=2>Mobile:</font></td>";
            eSignature += "<td><font size=2><b>(219) 789-9514</b></font></td>";
            eSignature += "</tr>";
            eSignature += "<tr>";
            eSignature += "<td><font size=2>Email:</font></td>";
            eSignature += "<td><font size=2><b><a href=mailto:campaigndirectorpro@gmail.com target=_blank>CampaignDirectorPro@Gmail.com</a></b></font></td>";
            eSignature += "</tr>";
            eSignature += "</table>";
            eSignature += "<br>";
            //***********************************************************************************************************

            eFinal = eStart + eBody + eSignature + eEnd;
            EmailBody = eFinal;
            MailMessage msg = new MailMessage(EmailFrom, EmailTo, EmailSubject, EmailBody);
            msg.Bcc.Add(BccAddress);
            string PDFName = ReportPath.Substring((ReportPath.Length - 11), 11);
            string TempReportFolder = "" + ReportPath.Substring(0, (ReportPath.Length - 11)) + "Temp\\";
            string TempReportPath = "" + TempReportFolder + "" + PDFName + "";
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(TempReportFolder);
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}.", e.ToString());
            }
            if (System.IO.File.Exists(ReportPath) == true)
            {
                System.IO.File.Copy(ReportPath, TempReportPath);
            }
            msg.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = loginInfo;
                msg.Attachments.Add(new Attachment(TempReportPath));
                client.Send(msg);
                msg.Dispose();
                TimeConnector.Data.ActionLog.Insert("Send Email", "" + InvoiceNumber + "");
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                msg.Dispose();
                if (System.IO.File.Exists(TempReportPath) == true)
                {
                    System.IO.File.Delete(TempReportPath);
                }
            }
        }
        public static void PDFExport(string Paydate)
        {
            string InvoiceNumber = "" + SelectedInvoiceNumber + "";

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Invoice";
            document.Info.Author = "Jack Huckins";
            document.Info.Subject = "Service Invoice";

            PdfPage page = new PdfPage();
            page = document.AddPage();
            page.Width = XUnit.FromInch(8.5);
            page.Height = XUnit.FromInch(11);

            XGraphics gfx = default(XGraphics);
            gfx = XGraphics.FromPdfPage(page);

            XForm form = new XForm(document, XUnit.FromMillimeter(300), XUnit.FromMillimeter(300));

            XGraphics formGfx = default(XGraphics);
            formGfx = XGraphics.FromForm(form);

            XGraphicsState state = default(XGraphicsState);
            state = formGfx.Save();
            //..... Invoice Results
            GetInvResults(Paydate);
            PrepareInvoiceTop(formGfx, state, InvoiceNumber);
            PrepareInvoiceData(6, 217, formGfx);
            PrepareFooter(formGfx);

            state = formGfx.Save();
            formGfx.Dispose();
            gfx.DrawImage(form, 0, 0);
            //document.Save("c:\\Invoices\\Inv " + InvoiceNumber + ".pdf")
            SetReportPath();
            document.Save(ReportPath);
            TimeConnector.Data.ActionLog.Insert("PDF Export", "" + InvoiceNumber + "");
            //UpdatePDFLabel("30 second Check", Form1.lblPDFStatus);
            //var _with1 = ViewPDF;
            //_with1.PdfName = Export.ReportPath;
            //_with1.Show();
        }
        #endregion
        #region "InvoicePreparation"
        private static void GetInvResults(string Paydate)
        {
            DataTable dt = TimeConnector.Data.Paydate.GetPaydateIDsByPaydate(Paydate);
            int PaydateId1 = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
            int PaydateId2 = Convert.ToInt32(dt.Rows[1].ItemArray[0].ToString());
            TimeConnector.Data.Invoice.LoadPayPeriodTables(PaydateId1, PaydateId2);
            TimeConnector.Data.Invoice.Calculate();
        }
        private static void PrepareInvoiceTop(XGraphics formGfx, XGraphicsState state, string InvoiceNumber)
        {
            string Headline = "Service Invoice " + InvoiceNumber + "";
            string MyName = TimeConnector.Data.Variables.SelectedContractor["CmpName"];
            string Phone = TimeConnector.Data.Variables.SelectedContractorContact["ConPhone"];
            string MyPhone = "Phone (" + Phone.Substring(0, 3) + ") " + Phone.Substring(4, 3) + "-" + Phone.Substring(7, 4) + "";
            string MyEmail = "Email: " + TimeConnector.Data.Variables.SelectedContractorContact["ConEmail"] + "";
            string MyAddress = TimeConnector.Data.Variables.SelectedContractor["CmpAddress"];
            string MyCityStateZip = "" + TimeConnector.Data.Variables.SelectedContractor["CmpCity"] + ", " + TimeConnector.Data.Variables.SelectedContractor["CmpState"] + "  " + TimeConnector.Data.Variables.SelectedContractor["CmpZip"] + "";
            string WeekEnding = TimeConnector.Data.Variables.SelectedPaydate["WeekEnd"];
            string PayDate = TimeConnector.Data.Variables.SelectedPaydate["PayDate"];
            string CompanyName = TimeConnector.Data.Variables.SelectedCompany["CmpName"];
            string CompanyContact = "c/o " + TimeConnector.Data.Variables.SelectedContact["ConName"] + "";
            string CompanyContactPhone = "" + TimeConnector.Data.Variables.SelectedContact["ConPhone"] + "";
            string CompanyContactEmail = "" + TimeConnector.Data.Variables.SelectedContact["ConEmail"] + "";
            string CompanyAddress = TimeConnector.Data.Variables.SelectedCompany["CmpAddress"];
            string CompanyCityStateZip = "" + TimeConnector.Data.Variables.SelectedCompany["CmpCity"] + ", " + TimeConnector.Data.Variables.SelectedCompany["CmpState"] + "  " + TimeConnector.Data.Variables.SelectedCompany["CmpZip"] + "";

            //----- Invoice Header
            XFont HeaderFont = new XFont("Imprint MT Shadow", 30, XFontStyle.Bold);
            string HeaderText = "I N V O I C E";
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Near;
            format.LineAlignment = XLineAlignment.Near;
            XColor color = default(XColor);
            color = XColor.FromName("SteelBlue");
            color.A = 0.5;
            XBrush brush = default(XBrush);
            brush = new XSolidBrush(color);
            XPoint point = new XPoint(410, 20);
            formGfx.DrawString(HeaderText, HeaderFont, brush, point, format);

            //..... My Company Icon
            state = formGfx.Save();
            formGfx.DrawImage(XImage.FromFile("Images\\logo.png"), 20, 20, 65, 65);
            formGfx.Restore(state);

            //..... My Company Information
            DrawText(MyName, formGfx, new XFont(PdfFontMyInfo, 15, XFontStyle.Bold), XBrushes.SteelBlue, 95, 20);
            DrawText(MyAddress, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 45);
            DrawText(MyCityStateZip, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 55);
            DrawText(MyPhone, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 65);
            DrawText(MyEmail, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 75);

            XPen pen1 = new XPen(XColors.Maroon);
            pen1.Width = 1;
            //Dim pen2 As New XPen(XColors.Maroon)
            XPen pen2 = new XPen(XColors.SteelBlue);
            pen2.Width = 2;
            //Dim pen3 As New XPen(XColors.SteelBlue)
            XPen pen3 = new XPen(XColors.Maroon);
            pen3.Width = 1;
            formGfx.DrawBeziers(pen1, XPoint.ParsePoints("20,95 80,140 190,70 250,110"));

            DrawSignature(formGfx, 531, 696, "LightGray", 1);
            DrawSignature(formGfx, 530, 695, "Black", 1.5);
            DrawSignature(formGfx, 530, 695, "SteelBlue", 1);

            //formGfx.DrawBeziers(pen2, XPoint.ParsePoints("300,100 310,110 340,90 350,100"))  'Top
            //formGfx.DrawBeziers(pen2, XPoint.ParsePoints("312,108 322,118 332,99 342,110")) 'Top Center
            //formGfx.DrawBeziers(pen2, XPoint.ParsePoints("314,118 324,128 334,109 344,120")) 'Bottom Center
            //formGfx.DrawBeziers(pen2, XPoint.ParsePoints("310,130 315,140 330,120 335,130")) 'Bottom
            //formGfx.DrawBeziers(pen2, XPoint.ParsePoints("325,100 335,110 325,120 335,130")) 'Center

            //formGfx.DrawBeziers(pen3, XPoint.ParsePoints("300,100 310,110 340,90 350,100"))  'Top
            //formGfx.DrawBeziers(pen3, XPoint.ParsePoints("312,108 322,118 332,99 342,110")) 'Top Center
            //formGfx.DrawBeziers(pen3, XPoint.ParsePoints("314,118 324,128 334,109 344,120")) 'Bottom Center
            //formGfx.DrawBeziers(pen3, XPoint.ParsePoints("310,130 315,140 330,120 335,130")) 'Bottom
            //formGfx.DrawBeziers(pen3, XPoint.ParsePoints("325,100 335,110 325,120 335,130")) 'Center

            //..... ACS Company Icon
            DrawText("B I L L   T O :", formGfx, new XFont(PdfFont, 9, XFontStyle.Bold), XBrushes.Black, 60, 95);
            state = formGfx.Save();
            formGfx.DrawImage(XImage.FromFile("Images\\ACSIcon.jpg"), 20, 115, 65, 65);
            formGfx.Restore(state);

            //..... ACS Company Information
            DrawText(CompanyName, formGfx, new XFont(PdfFontMyInfo, 15, XFontStyle.Bold), XBrushes.Green, 95, 115);
            DrawText(CompanyContact, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 135);
            DrawText(CompanyAddress, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 145);
            DrawText(CompanyCityStateZip, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 155);
            DrawText(CompanyContactPhone, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 165);
            DrawText(CompanyContactEmail, formGfx, new XFont(PdfFontMyInfo, 7, XFontStyle.Regular), XBrushes.Black, 95, 175);

            //..... Invoice Information
            DrawLine(formGfx, 450, 590, 80, "SteelBlue", 0.5);
            DrawText("Invoice #:", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 452, 71);
            DrawText(InvoiceNumber, formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Maroon, 530, 71);
            DrawLine(formGfx, 450, 590, 90, "SteelBlue", 0.5);
            DrawText("Week Ending:", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 452, 81);
            DrawText(WeekEnding, formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 530, 81);
            DrawLine(formGfx, 450, 590, 100, "SteelBlue", 0.5);
            DrawText("Pay Date:", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 452, 91);
            DrawText(PayDate, formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 530, 91);
            DrawLine(formGfx, 450, 590, 110, "SteelBlue", 0.5);
            DrawText("Hours Worked:", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 452, 101);
            DrawText(TimeConnector.Data.Invoice.FinHour, formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 530, 101);
            DrawLine(formGfx, 450, 590, 120, "SteelBlue", 0.5);
            DrawText("Balance Due:", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 452, 111);
            DrawText(TimeConnector.Data.Invoice.FinCost, formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 530, 111);
        }
        private static void PrepareInvoiceData(Int32 ResultFontSize, Int32 ResultRowLocation, XGraphics formGfx)
        {
            Int32 HeaderFontSize = 7;
            double GridThickness = 0.5;
            DrawRectangle(formGfx, GridThickness, 570, 15, 20, ResultRowLocation);
            DrawFill(formGfx, "Maroon", 570, 15, 20, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            DrawText("WEEK 1", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 300, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 12;
            DrawFill(formGfx, "SteelBlue", 570, 15, 20, ResultRowLocation);

            DrawRectangle(formGfx, GridThickness, 45, 15, 20, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 25, 15, 65, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 15, 15, 90, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 330, 15, 105, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 15, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 15, 475, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 15, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 15, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            //..... Result Headers
            DrawText("Date", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 30, ResultRowLocation);
            DrawText("Day", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 71, ResultRowLocation);
            DrawText("#", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 95, ResultRowLocation);
            DrawText("Description", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 110, ResultRowLocation);
            DrawText("Start", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 444, ResultRowLocation);
            DrawText("Finish", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 483, ResultRowLocation);
            DrawText("Hours", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 520, ResultRowLocation);
            DrawText("Cost", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 560, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 12;

            int StartRow = ResultRowLocation + 150;
            //DrawText(ResultRowLocation, formGfx, New XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 30, ResultRowLocation)
            DrawRectangle(formGfx, GridThickness, 45, 150, 20, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 25, 150, 65, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 15, 150, 90, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 330, 150, 105, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 150, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 150, 475, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 150, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 150, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;


            foreach (DataRow row in TimeConnector.Data.Invoice.Wk1Data.Rows)
            {
                DrawText(row.ItemArray[0].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 22, ResultRowLocation);
                DrawText(row.ItemArray[1].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 70, ResultRowLocation);
                DrawText(row.ItemArray[2].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 95, ResultRowLocation);
                DrawText(row.ItemArray[3].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 110, ResultRowLocation);
                DrawText(row.ItemArray[4].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 442, ResultRowLocation);
                DrawText(row.ItemArray[5].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 482, ResultRowLocation);
                DrawText(row.ItemArray[6].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 522, ResultRowLocation);
                DrawText(row.ItemArray[7].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 555, ResultRowLocation);
                ResultRowLocation = ResultRowLocation + 15;
            }

            //DrawText(ResultRowLocation, formGfx, New XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 30, ResultRowLocation)
            ResultRowLocation = StartRow;
            ResultRowLocation = ResultRowLocation + 15;

            DrawRectangle(formGfx, GridThickness, 570, 15, 20, ResultRowLocation);
            DrawFill(formGfx, "Maroon", 570, 15, 20, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            DrawText("WEEK 2", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 300, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 12;
            DrawFill(formGfx, "SteelBlue", 570, 15, 20, ResultRowLocation);

            DrawRectangle(formGfx, GridThickness, 45, 15, 20, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 25, 15, 65, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 15, 15, 90, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 330, 15, 105, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 15, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 15, 475, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 15, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 15, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            //..... Result Headers
            DrawText("Date", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 30, ResultRowLocation);
            DrawText("Day", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 71, ResultRowLocation);
            DrawText("#", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 95, ResultRowLocation);
            DrawText("Description", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 110, ResultRowLocation);
            DrawText("Start", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 444, ResultRowLocation);
            DrawText("Finish", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 483, ResultRowLocation);
            DrawText("Hours", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 520, ResultRowLocation);
            DrawText("Cost", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 560, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 12;

            //DrawText(ResultRowLocation, formGfx, New XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 30, ResultRowLocation)
            StartRow = ResultRowLocation + 150;
            DrawRectangle(formGfx, GridThickness, 45, 150, 20, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 25, 150, 65, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 15, 150, 90, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 330, 150, 105, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 150, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 40, 150, 475, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 150, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 150, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;


            foreach (DataRow row in TimeConnector.Data.Invoice.Wk2Data.Rows)
            {
                DrawText(row.ItemArray[0].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 22, ResultRowLocation);
                DrawText(row.ItemArray[1].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 70, ResultRowLocation);
                DrawText(row.ItemArray[2].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 95, ResultRowLocation);
                DrawText(row.ItemArray[3].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 110, ResultRowLocation);
                DrawText(row.ItemArray[4].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 442, ResultRowLocation);
                DrawText(row.ItemArray[5].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 482, ResultRowLocation);
                DrawText(row.ItemArray[6].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 522, ResultRowLocation);
                DrawText(row.ItemArray[7].ToString(), formGfx, new XFont(PdfFont, ResultFontSize, XFontStyle.Regular), XBrushes.Black, 555, ResultRowLocation);
                ResultRowLocation = ResultRowLocation + 15;
            }
            //-------------------------------------------------------------------------------------------------

            ResultRowLocation = StartRow;
            ResultRowLocation = ResultRowLocation + 15;

            DrawText("Hours", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 520, ResultRowLocation);
            DrawText("Cost", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Bold), XBrushes.Black, 560, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 12;

            DrawRectangle(formGfx, GridThickness, 80, 15, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 15, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 15, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            //..... SubTotal Week 1 Information
            DrawText("Week 1 SubTotal", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 440, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.Wk1Hour, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 520, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.Wk1Cost, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.BoldItalic), XBrushes.Maroon, 555, ResultRowLocation);


            ResultRowLocation = ResultRowLocation + 15;

            DrawRectangle(formGfx, GridThickness, 80, 15, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 15, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 15, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            //..... SubTotal Week 2 Information
            DrawText("Week 2 SubTotal", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 440, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.Wk2Hour, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 520, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.Wk2Cost, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.BoldItalic), XBrushes.Maroon, 555, ResultRowLocation);


            ResultRowLocation = ResultRowLocation + 15;

            DrawRectangle(formGfx, GridThickness, 80, 15, 435, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 30, 15, 515, ResultRowLocation);
            DrawRectangle(formGfx, GridThickness, 45, 15, 545, ResultRowLocation);

            ResultRowLocation = ResultRowLocation + 3;

            //..... Total Information
            DrawText("Total", formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 440, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.FinHour, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.Regular), XBrushes.Black, 520, ResultRowLocation);
            DrawText(TimeConnector.Data.Invoice.FinCost, formGfx, new XFont(PdfFont, HeaderFontSize, XFontStyle.BoldItalic), XBrushes.Maroon, 555, ResultRowLocation);

        }
        private static void PrepareFooter(XGraphics formGfx)
        {
            DrawRectangle(formGfx, 0.5, 200, 15, 20, 609);
            DrawText("Notes", formGfx, new XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 25, 612);
            DrawRectangle(formGfx, 0.5, 200, 80, 20, 624);
            //DrawText("Notes", formGfx, New XFont(PdfFont, 7, XFontStyle.Bold), XBrushes.Black, 25, 637)
            DrawText("Thank you for your business!!", formGfx, new XFont(PdfFont, 12, XFontStyle.Bold), XBrushes.SteelBlue, 350, 750);
            //DrawLine(formGfx, 20, 590, 756, "Black", 0.5)
            //DrawLine(formGfx, 20, 590, 757, "SteelBlue", 0.5)
            //DrawLine(formGfx, 20, 590, 758, "Maroon", 0.5)
            XPen pen1 = new XPen(XColors.Black);
            XPen pen2 = new XPen(XColors.SteelBlue);
            XPen pen3 = new XPen(XColors.Maroon);
            formGfx.DrawBeziers(pen1, XPoint.ParsePoints("20,715 134,810 476,635 590,775"));
            formGfx.DrawBeziers(pen2, XPoint.ParsePoints("20,730 134,815 476,640 590,775"));
            formGfx.DrawBeziers(pen3, XPoint.ParsePoints("20,745 134,820 476,645 590,775"));
        }
        #endregion
        #region "Draws"
        private static void DrawText(string text, XGraphics formGfx, XFont font, XSolidBrush color, double x, double y)
        {
            formGfx.DrawString(text, font, color, x, y, XStringFormats.TopLeft);
        }
        private static void DrawPNG(XGraphics gfx, int number, string filename)
        {
            XImage image = default(XImage);
            image = XImage.FromFile(filename);

            const double dx = 250;
            const double dy = 140;
            double width = image.PixelWidth * 72 / image.HorizontalResolution;
            double height = image.PixelHeight * 72 / image.HorizontalResolution;

            gfx.DrawImage(image, (dx - width) / 2, (dy - height) / 2, width, height);
        }
        private static void DrawFill(XGraphics formGfx, string Color, int Width, int Height, int Left, int Top)
        {
            XColor back = default(XColor);
            back = XColor.FromName(Color);
            back.A = 0.2;
            XSolidBrush brush = new XSolidBrush(back);
            formGfx.DrawRectangle(brush, Left, Top, Width, Height);
        }
        private static void DrawLine(XGraphics gfx, int Left, int Right, int Top, string Color, double Thickness)
        {
            XPen pen = new XPen(XColor.FromName(Color));
            pen.Width = Thickness;
            gfx.DrawLine(pen, new Point(Left, Top), new Point(Right, Top));
        }
        private static void DrawRectangle(XGraphics gfx, double PenWidth, int RectWidth, int RectHeight, int StartLeft, int StartTop)
        {
            XPen pen = default(XPen);
            pen = XPens.SteelBlue.Clone();
            pen.Width = PenWidth;
            int Width = RectWidth;
            int Height = RectHeight;
            int Left = StartLeft;
            int Right = (Left + Width);
            int Top = StartTop;
            int Bottom = (Top + Height);
            gfx.DrawLine(pen, new Point(Left, Top), new Point(Right, Top));
            gfx.DrawLine(pen, new Point(Right, Top), new Point(Right, Bottom));
            gfx.DrawLine(pen, new Point(Right, Bottom), new Point(Left, Bottom));
            gfx.DrawLine(pen, new Point(Left, Bottom), new Point(Left, Top));
        }
        private static void DrawSignature(XGraphics gfx, int StartLeft, int StartTop, string Color, double Thickness)
        {
            XPen Main = new XPen(XColor.FromName(Color));
            Main.Width = Thickness;

            string LinePoints = null;
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int val4 = 0;
            int val5 = 0;
            int val6 = 0;
            int val7 = 0;
            int val8 = 0;

            //----- Top Line
            val1 = StartLeft;
            val2 = StartTop;
            val3 = val1 + 10;
            val4 = val2 + 10;
            val5 = val1 + 40;
            val6 = val2 - 10;
            val7 = val1 + 50;
            val8 = val2;
            LinePoints = "" + val1.ToString() + "," + val2.ToString() + " " + val3.ToString() + "," + val4.ToString() + " " + val5.ToString() + "," + val6.ToString() + " " + val7.ToString() + "," + val8.ToString() + "";
            gfx.DrawBeziers(Main, XPoint.ParsePoints(LinePoints));
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("300,100 310,110 340,90 350,100"))

            //----- Top Center Line
            val1 = val1 + 12;
            val2 = val2 + 8;
            val3 = val1 + 10;
            val4 = val2 + 10;
            val5 = val1 + 20;
            val6 = val2 - 9;
            val7 = val1 + 30;
            val8 = val2 + 2;
            LinePoints = "" + val1.ToString() + "," + val2.ToString() + " " + val3.ToString() + "," + val4.ToString() + " " + val5.ToString() + "," + val6.ToString() + " " + val7.ToString() + "," + val8.ToString() + "";
            gfx.DrawBeziers(Main, XPoint.ParsePoints(LinePoints));
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("312,108 322,118 332,99 342,110"))

            //----- Bottom Center Line
            val1 = val1 + 2;
            val2 = val2 + 10;
            val3 = val1 + 10;
            val4 = val2 + 10;
            val5 = val1 + 20;
            val6 = val2 - 9;
            val7 = val1 + 30;
            val8 = val2 + 2;
            LinePoints = "" + val1.ToString() + "," + val2.ToString() + " " + val3.ToString() + "," + val4.ToString() + " " + val5.ToString() + "," + val6.ToString() + " " + val7.ToString() + "," + val8.ToString() + "";
            gfx.DrawBeziers(Main, XPoint.ParsePoints(LinePoints));
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("314,118 324,128 334,109 344,120")) 'Bottom Center

            //----- Bottom Line
            val1 = val1 - 4;
            //310
            val2 = val2 + 12;
            //130
            val3 = val1 + 10;
            //320
            val4 = val2 + 10;
            //140
            val5 = val1 + 15;
            //325
            val6 = val2 - 10;
            //120
            val7 = val1 + 25;
            //335
            val8 = val2;
            //130
            LinePoints = "" + val1.ToString() + "," + val2.ToString() + " " + val3.ToString() + "," + val4.ToString() + " " + val5.ToString() + "," + val6.ToString() + " " + val7.ToString() + "," + val8.ToString() + "";
            gfx.DrawBeziers(Main, XPoint.ParsePoints(LinePoints));
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("310,130 315,140 330,120 335,130")) 'Bottom

            //----- Center Line
            val1 = val1 + 15;
            //325
            val2 = val2 - 30;
            //100
            val3 = val1 + 10;
            //335 
            val4 = val2 + 10;
            //110
            val5 = val1;
            //325 
            val6 = val2 + 20;
            //120
            val7 = val1 + 10;
            //335
            val8 = val2 + 30;
            //110
            LinePoints = "" + val1.ToString() + "," + val2.ToString() + " " + val3.ToString() + "," + val4.ToString() + " " + val5.ToString() + "," + val6.ToString() + " " + val7.ToString() + "," + val8.ToString() + "";
            gfx.DrawBeziers(Main, XPoint.ParsePoints(LinePoints));
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("325,100 335,110 325,120 335,130")) 'Center

            //gfx.DrawBeziers(Main, XPoint.ParsePoints("300,100 310,110 340,90 350,100"))  'Top
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("312,108 322,118 332,99 342,110")) 'Top Center
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("314,118 324,128 334,109 344,120")) 'Bottom Center
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("310,130 320,140 325,120 335,130")) 'Bottom
            //gfx.DrawBeziers(Main, XPoint.ParsePoints("325,100 335,110 325,120 335,130")) 'Center

        }
        #endregion
    }
}
