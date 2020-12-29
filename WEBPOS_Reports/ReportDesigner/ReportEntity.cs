using DevExpress.Xpo;

namespace DXWebApplication_ReportDesigner.DAL
{
    [DeferredDeletion(false)]
    public class ReportEntity : XPCustomObject
    {
        string url;
        byte[] layout;
        string reportName;
        int id;

        public ReportEntity(Session session)
            : base(session)
        {
        }

        
        //public int Id
        //{
        //    get { return id; }
        //    set { SetPropertyValue("Id", ref id, value); }
        //}

        [Key]
        public string Url
        {
            get { return url; }
            set { SetPropertyValue("Url", ref url, value); }
        }

        public byte[] Layout
        {
            get { return layout; }
            set { SetPropertyValue("Layout", ref layout, value); }
        }

        public string ReportName
        {
            get { return reportName; }
            set { SetPropertyValue("ReportName", ref reportName, value); }
        }
    }
}
