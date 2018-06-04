using ProjetoModeloDDD.Application.Interface;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LightInject;
using GameClassification.Application;

namespace GameClassification.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        
        protected void Application_Start()
        {

            var container = new ServiceContainer();
            container.RegisterApiControllers();
            container.Register<IPublisherAppService, PublisherAppService>();
            container.Register<ILeaderBoardAppService, LeaderBoardAppService>();

            //container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);

            AreaRegistration.RegisterAllAreas(container);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SubscriberAppService.SubcribeGamePoint();

        }
    }
}

