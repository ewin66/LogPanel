﻿namespace LogDashboard.Route
{
    public static class LogDashboardRoutes
    {
        public static RouteCollection Routes { get; }

        static LogDashboardRoutes()
        {
            Routes = new RouteCollection();

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/Home", "Views.Dashboard.Home.cshtml"));

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/SearchLog", "Views.Dashboard.LogList.cshtml"));

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/BasicLog", "Views.Dashboard.BasicLog.cshtml"));

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/ErrorLog", "Views.Dashboard.LogList.cshtml"));

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/LogInfo", "Views.Dashboard.LogInfo.cshtml"));

            Routes.AddRoute(new LogDashboardRoute("/Dashboard/Tip", "Views.Dashboard.ApolloTip.cshtml"));

            Routes.AddRoute(new LogDashboardRoute
            {
                Key = "/Dashboard/GetException",
                HtmlView = false
            });

            Routes.AddRoute(new LogDashboardRoute
            {
                Key = "/Dashboard/RequestTrace",
                HtmlView = false
            });

            Routes.AddRoute(new LogDashboardRoute
            {
                Key = "/Dashboard/GetLogChart",
                HtmlView = false
            });
        }
    }
}
