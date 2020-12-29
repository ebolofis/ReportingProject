using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBPOS_Reports.Models
{
    public enum REPORT_TYPE : int { OLD_REPORT, NEW_CUSTOM_REPORT };

    [Serializable]
    public class ReportModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public REPORT_TYPE ReportType { get; set; }

        public override string ToString()
        {
            return "{\"Key\":\"" + Key + "\",\"Name\":\"" + Name + "\",\"ClassName\":\"" + ClassName + "\"}";
        }
    }
}