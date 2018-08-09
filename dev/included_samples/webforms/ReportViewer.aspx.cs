using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebFormsStarterKit.Report
{
    public partial class ReportViewer : Page
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(ReportViewer));

        public string ReportId { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ReportId = (Page.RouteData.Values["id"] + string.Empty);
            Logger.DebugFormat("Render Report ID={0}", ReportId);
        }
    }
}