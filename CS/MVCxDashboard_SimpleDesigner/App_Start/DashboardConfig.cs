using System.Web.Routing;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;

public class DashboardConfig
{
    public static void RegisterService(RouteCollection routes)
    {
        routes.MapDashboardRoute();
        DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/Dashboards"));
    }
}