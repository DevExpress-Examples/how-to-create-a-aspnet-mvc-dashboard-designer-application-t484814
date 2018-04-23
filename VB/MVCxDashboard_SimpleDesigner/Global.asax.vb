Imports System
Imports System.Web.Http
Imports System.Web.Routing
Imports System.Web.Mvc

Namespace MVCxDashboard_SimpleDesigner
    Public Class MvcApplication
        Inherits System.Web.HttpApplication

        Protected Sub Application_Start()
            DashboardConfig.RegisterService(RouteTable.Routes)
            AreaRegistration.RegisterAllAreas()

            GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
            RouteConfig.RegisterRoutes(RouteTable.Routes)

            ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()

            AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
        End Sub

        Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
        End Sub
    End Class
End Namespace