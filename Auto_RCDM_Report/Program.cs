using Auto_RCDM_Report.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_RCDM_Report
{
    static class Program
    {

        static string strPathApp = AppDomain.CurrentDomain.BaseDirectory;
        static string iniFile = strPathApp + "Conf.INI";
        static string strDateRun = "";
        static string strPathDateRun = "";
        static string conStr = "";

        static string Server = "";
        static string User = "";
        static string Password = "";
        static string Database = "";
        static string ReportPath = "";
        static string LogPath = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Server = ModConf.ReadIni(iniFile, "DB", "Server");
            User = ModConf.ReadIni(iniFile, "DB", "User");
            Password = ModConf.ReadIni(iniFile, "DB", "Password");
            Database = ModConf.ReadIni(iniFile, "DB", "Database");
            ReportPath = ModConf.ReadIni(iniFile, "PathFile", "PathReport");
            LogPath = ModConf.ReadIni(iniFile, "PathFile", "PathLogFile");

            Application.Run(new frmAuto_RCDM_Reports(Server, User, Password, Database, ReportPath, LogPath));
            strPathDateRun = ModConf.ReadIni(iniFile, "PathFile", "PathTextDateRun");







            //  _moduleData.conStr = conStr;
        }
    }
}
