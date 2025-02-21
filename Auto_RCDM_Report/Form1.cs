using CrystalDecisions.CrystalReports.Engine;
using Auto_RCDM_Report.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Auto_RCDM_Report
{
    public partial class frmAuto_RCDM_Reports : Form
    {

		//string LTFFilePath = ConfigurationManager.AppSettings["LTFFilePath"];
		//string ReportPath = ConfigurationManager.AppSettings["ReportFilePath"];
		//string DeleteData = ConfigurationManager.AppSettings["DeleteData"];
		//string LogFilePath = ConfigurationManager.AppSettings["LogFilePath"];
		//string TemplateReportPath = ConfigurationManager.AppSettings["TemplateReportPath"];

		Loger _logSys = new Loger();
		ModuleData _moduleData = new ModuleData();

		public string strServerName;
		string strUserID = "";
		string strPassword = "";
		string strDatabase = "";
		string ReportPath = "";
		string LogPath = "";
		public SqlConnectionStringBuilder conStr = new SqlConnectionStringBuilder();
		//public SqlConnectionStringBuilder conStr = new SqlConnectionStringBuilder
		//{

		//	DataSource =  _moduleData.DataSource,// ConfigurationManager.AppSettings["IPServerName"],
		//          InitialCatalog = ConfigurationManager.AppSettings["DBName"],
		//          Password = ConfigurationManager.AppSettings["Password"],
		//          UserID = ConfigurationManager.AppSettings["UserName"]
		//      };

		//  string conStr = @"Data Source=MS30IPM66209\MSSQLSERVER04;Initial Catalog=TEST;Integrated Security=True;";

		public frmAuto_RCDM_Reports(string DataSource, string UserID, string Password, string InitialCatalog, string PathReport, string PathLog)
		{
			InitializeComponent();


			conStr.DataSource = DataSource;
			conStr.UserID = UserID;
			conStr.Password = Password;
			conStr.InitialCatalog = InitialCatalog;
			ReportPath = PathReport;
			LogPath = PathLog;
			Post();
		}



		private void Post()
		{
			this.dpRunReportDate.Text = DateTime.Now.Date.ToShortDateString();
			this.dpDisplayReportDate.Text = DateTime.Now.Date.AddDays(-1).ToShortDateString();
			this.txtReadINI_Server.Text = conStr.DataSource;
			this.txtReadINI_DB.Text = conStr.InitialCatalog;

			this.txtRunPath.Text = AppDomain.CurrentDomain.BaseDirectory;
			this.txtPathReport.Text = ReportPath;
			this.txtPathLog.Text = LogPath;
			//txtDBServer.Text = "ServerName :" + conStr.DataSource + " DBName :" + conStr.InitialCatalog;

			GetDateNowReport();

		}

		public void GetDateNowReport()
		{

			try
			{
				DateTime reportDate = (dpDisplayReportDate.Value.ToString() != "") ? DateTime.Parse(dpDisplayReportDate.Value.ToString()) : DateTime.Now.Date;

				string year = "";

				if (reportDate.Year < 2500)
				{
					year = reportDate.Year.ToString().Substring(2);
				}
				else
				{
					year = (reportDate.Year - 543).ToString().Substring(2);
				}

				string dateReport = year + reportDate.Month.ToString().PadLeft(2, '0') + reportDate.Day.ToString().PadLeft(2, '0');
				this.txtFormatReportDate.Text = dateReport;

				string pathReportFile = ReportPath + @"\" + reportDate.Year + @"\" + reportDate.Month.ToString().PadLeft(2, '0') + @"\" + reportDate.Day.ToString().PadLeft(2, '0');

				this.txtPathReport.Text = pathReportFile;
				this.txtFixPathReport.Text = @ReportPath;
			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "GetDateNowReport Format วันที่ Run Report : " + ex.Message);
			}
		}
		private void btnGen_Click(object sender, EventArgs e)
		{
			//progressBar1.Value = 0;
			//GenReport(this.txtFormatReportDate.Text);

			progressBar1.Value = 0;

			if (GenReport(this.txtFormatReportDate.Text, this.txtFixPathReport.Text))
			{
				this.Close();
			}
		}

		private bool GenReport(string prmDate, string pathRepor)
		{
			progressBar1.Value = 5;
			string date = "";
			if (prmDate == "")
			{
				date = (dpRunReportDate.Text != "") ? DateTime.Parse(dpRunReportDate.Text).AddDays(-1).ToString() : DateTime.Now.Date.AddDays(-1).ToString();
			}
			else
			{
				date = prmDate;
			}


			using (SqlConnection conn = new SqlConnection(conStr.ToString()))
			{
				conn.Open();

				//1:RCDM1001_CDM Report
				GenRCDM1001_CDM_Report(conn, date, pathRepor);
				progressBar1.Value = 30;

				////2:RCDM1002_M Report
				GenRCDM1002_M_Report(conn, date.Substring(0, 4), pathRepor);
				progressBar1.Value = 70;

				////3.RCDM1002_D Report
				GenRCDM1003_D_Report(conn, date, pathRepor);

				progressBar1.Value = 100;

				return true;
			}
		}

		private void dpRunReportDate_ValueChanged(object sender, EventArgs e)
		{
			this.dpDisplayReportDate.Text = (dpRunReportDate.Text != "") ? DateTime.Parse(dpRunReportDate.Text).AddDays(-1).ToShortDateString() : DateTime.Now.Date.AddDays(-1).ToShortDateString();
			GetDateNowReport();
		}

		private void dpDisplayReportDate_ValueChanged(object sender, EventArgs e)
		{
			GetManualRunReport();
		}

		public void GetManualRunReport()
		{
			try
			{
				DateTime reportDate = (dpDisplayReportDate.Text != "") ? DateTime.Parse(dpDisplayReportDate.Text) : DateTime.Now.Date;

				string year = "";

				if (reportDate.Year < 2500)
				{
					year = reportDate.Year.ToString().Substring(2);
				}
				else
				{
					year = (reportDate.Year - 543).ToString().Substring(2);
				}

				string dateReport = year + reportDate.Month.ToString().PadLeft(2, '0') + reportDate.Day.ToString().PadLeft(2, '0');
				this.txtFormatReportDate.Text = dateReport;

				string pathReportFile = ReportPath + @"\" + reportDate.Year + @"\" + reportDate.Month + @"\" + reportDate.Day;

				this.txtPathReport.Text = pathReportFile;
			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "GetManualRunReport วันที่ Run Report : " + ex.Message);
			}


		}

		private void GenRCDM1001_CDM_Report(SqlConnection conn, string date, string pathReport)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("SP_RPT_RCDM1001_CDM", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("T_Date", date));

				DateTime dtReport = (dpDisplayReportDate.Text != "") ? DateTime.Parse(dpDisplayReportDate.Text) : DateTime.Now;
				string pathReportFile = @pathReport + @"\" + "M" + dtReport.Month.ToString().PadLeft(2, '0') + @"\" + dtReport.Day.ToString().PadLeft(2, '0');
				ReportDocument cryRpt = new ReportDocument();


				string rcdm1001 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "rptRCDM1001_CDM.rpt"; //@TemplateReportPath + @"\" + "rptRCDM1001_CDM.rpt";
				cryRpt.Load(rcdm1001);
				cryRpt.DataSourceConnections[0].SetConnection(conStr.DataSource, conStr.InitialCatalog, conStr.UserID, conStr.Password);


				//cryRpt.Load(@"D:\D1_Project\BACC\Project\Manual_Report_RCDM\Manual_Report_RCDM\Manual_Report_RCDM\rptRCDM1001_CDM.rpt");


				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				cryRpt.SetDataSource(dt);
				cryRpt.SetParameterValue("T_Date", date);

				//crystalReportViewer1.ReportSource = cryRpt;
				//crystalReportViewer1.Refresh();


				DirectoryInfo directoryInfo = new DirectoryInfo(pathReportFile);
				if (!Directory.Exists(pathReportFile))
				{
					Directory.CreateDirectory(pathReportFile);
				}

				if (directoryInfo.Exists)
				{

					DirectoryInfo directoryInfoFile = new DirectoryInfo(pathReportFile);
					directoryInfoFile.Create();

					//string ReportFilePath = CreateForderTrue.FullName;
					string contentType = string.Empty;
					if (directoryInfoFile.Exists)
					{
						string path = pathReportFile + "\\RCDM1001_CDM_" + date + ".pdf";
						cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
					}
				}

			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "GenRCDM1001_CDM_Report : " + ex.Message);
			}

		}

		private void GenRCDM1002_M_Report(SqlConnection conn, string date, string pathReport)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("SP_RPT_RCDM1002_M", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("T_Date", date));

				DateTime dtReport = (dpDisplayReportDate.Text != "") ? DateTime.Parse(dpDisplayReportDate.Text) : DateTime.Now;
				string pathReportFile = @pathReport + @"\" + "M" + dtReport.Month.ToString().PadLeft(2, '0') + @"\" + dtReport.Day.ToString().PadLeft(2, '0');
				ReportDocument cryRpt = new ReportDocument();

				string rcdm1002 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "rptRCDM1002_M_CDM.rpt";// @TemplateReportPath + @"\" + "rptRCDM1002_M_CDM.rpt";
				cryRpt.Load(rcdm1002);
				cryRpt.DataSourceConnections[0].SetConnection(conStr.DataSource, conStr.InitialCatalog, conStr.UserID, conStr.Password);

				//cryRpt.Load(@"D:\D1_Project\BACC\RunTLFText\RunTLFText\RunTLFText\rptRCDM1002_M_CDM.rpt");

				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				cryRpt.SetDataSource(dt);
				cryRpt.SetParameterValue("T_Date", date);

				//crystalReportViewer1.ReportSource = cryRpt;
				//crystalReportViewer1.Refresh();

				DirectoryInfo directoryInfo = new DirectoryInfo(pathReportFile);
				if (!Directory.Exists(pathReportFile))
				{
					Directory.CreateDirectory(pathReportFile);
				}

				if (directoryInfo.Exists)
				{

					DirectoryInfo directoryInfoFile = new DirectoryInfo(pathReportFile);
					directoryInfoFile.Create();

					//string ReportFilePath = CreateForderTrue.FullName;
					string contentType = string.Empty;
					if (directoryInfoFile.Exists)
					{
						string path = pathReportFile + "\\RCDM1002_M_CDM_" + date + ".pdf";
						cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
					}
				}




			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "GenRCDM1002_M_Report : " + ex.Message);
			}
		}

		private void GenRCDM1003_D_Report(SqlConnection conn, string date, string pathReport)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("SP_RPT_RCDM1002_D", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add(new SqlParameter("T_Date", date));

				DateTime dtReport = (dpDisplayReportDate.Text != "") ? DateTime.Parse(dpDisplayReportDate.Text) : DateTime.Now;
				string pathReportFile = @pathReport + @"\" + "M" + dtReport.Month.ToString().PadLeft(2, '0') + @"\" + dtReport.Day.ToString().PadLeft(2, '0');
				ReportDocument cryRpt = new ReportDocument();

				string rcdm1002 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "rptRCDM1003_D_CDM.rpt";// @TemplateReportPath + @"\" + "rptRCDM1003_D_CDM.rpt";
				cryRpt.Load(rcdm1002);
				cryRpt.DataSourceConnections[0].SetConnection(conStr.DataSource, conStr.InitialCatalog, conStr.UserID, conStr.Password);

				//cryRpt.Load(@"D:\D1_Project\BACC\RunTLFText\RunTLFText\RunTLFText\rptRCDM1003_D_CDM.rpt");


				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				cryRpt.SetDataSource(dt);
				cryRpt.SetParameterValue("T_Date", date);

				//crystalReportViewer1.ReportSource = cryRpt;
				//crystalReportViewer1.Refresh();

				DirectoryInfo directoryInfo = new DirectoryInfo(pathReportFile);
				if (!Directory.Exists(pathReportFile))
				{
					Directory.CreateDirectory(pathReportFile);
				}

				if (directoryInfo.Exists)
				{

					DirectoryInfo directoryInfoFile = new DirectoryInfo(pathReportFile);
					directoryInfoFile.Create();

					//string ReportFilePath = CreateForderTrue.FullName;
					string contentType = string.Empty;
					if (directoryInfoFile.Exists)
					{
						string path = pathReportFile + "\\RCDM1002_D_CDM_" + date + ".pdf";
						cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
					}
				}


			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "GenRCDM1003_D_Report : " + ex.Message);
			}

		}

		private void btnConnecting_Click(object sender, EventArgs e)
		{

			try
			{
				using (SqlConnection conn = new SqlConnection(conStr.ToString()))
				{
					conn.Open();
					String query = "select case when exists((select * from information_schema.tables where table_name = 'TBL_BANK')) then 1 else 0 end ";
					SqlCommand cmd = new SqlCommand(query, conn);
					bool exists = (int)cmd.ExecuteScalar() == 1;
					if (exists)
					{
						MessageBox.Show("ติดต่อฐานข้อมูลสำเร็จ");
					}
					else
					{
						MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้!");
					}
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				string fullpath = LogPath + @"\" + "log.txt";
				_logSys.WriteProcessLogFile(fullpath, "btnConnecting_Click Test Connection database : " + ex.Message);
			}

		}

		private void frmAuto_RCDM_Reports_Load(object sender, EventArgs e)
		{
			btnGen.PerformClick();

           
        }
		
	}
}
