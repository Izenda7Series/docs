using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebFormsStarterKit
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // This route is used for exporting image from html content
            routes.MapPageRoute("ReportPart", "viewer/reportpart/{id}", "~/Report/ReportPart.aspx");

            // This route is used for exporting subscription report
            routes.MapPageRoute("ReportViewer", "report/view/{id}", "~/Report/ReportViewer.aspx");

            // This route is used for exporting subscription dashboard
            routes.MapPageRoute("DashboardViewer", "dashboard/view/{id}", "~/Dashboard/DashboardViewer.aspx");

            routes.Ignore("izapi/{*pathInfo}");

            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
