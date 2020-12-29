using System.Collections.Generic;

namespace WEBPOS_Reports.Models
{
    public class IndexModel
    {
        public List<NewReportModel> Reports { get; set; }
        public string SelectedReportUrl { get; set; }
    }
}

