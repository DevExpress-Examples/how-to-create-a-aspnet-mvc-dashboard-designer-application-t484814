Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports System.Web.Routing

Public Class DashboardConfig
    Public Shared Sub RegisterService(ByVal routes As RouteCollection)
        routes.MapDashboardRoute()
        DashboardConfigurator.Default.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
    End Sub
End Class