using System;
using System.Web.UI;

namespace WebFormsStarterKit.Dashboard
{
    public partial class DashboardViewer : Page
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(DashboardViewer));

        public string DashboardId { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            DashboardId = (Page.RouteData.Values["id"] + string.Empty);
            Logger.DebugFormat("Render Dashboard ID={0}", DashboardId);
        }
    }
}