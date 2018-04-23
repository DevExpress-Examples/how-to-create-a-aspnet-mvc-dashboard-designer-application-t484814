using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCxDashboard_SimpleDesigner
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DashboardConfig.RegisterService(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
        }
    }
}