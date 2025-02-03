using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_RCDM_Report.DataAccess
{
    public class ModuleData
    {
        public string conStr { get; set; }
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string Password { get; set; }
        public string UserID { get; set; }

        public ModuleData()
        {

        }

        public string GetConnString(string strCon)
        {

            return strCon;
        }
    }
}
