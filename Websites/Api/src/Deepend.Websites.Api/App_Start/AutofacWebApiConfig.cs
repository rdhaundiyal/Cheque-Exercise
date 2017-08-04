using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Deepend.Core.Logging;
using Deepend.Core.Repository.Interface;
using Deepend.Service.Provider.Provider;
using Deepend.Service.Provider.Repository;
using Deepend.Services.Model;


namespace Deepend.Website.Api.App_Start
{
    public static class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //right now for brevity I am not using parameter based dependency injection but IServiceProvider can be assigned any class based on parameter name
            builder.RegisterType<XmlChequeServiceProvider>()
                .As<IServiceProvider>().InstancePerApiRequest();
            builder.RegisterType<ChequeRepository>().As<IRepository<Cheque>>().InstancePerDependency();
            builder.RegisterInstance(AutomapperConfig.GetMapper()).As<IMapper>();
            builder.RegisterType<Log4NetLogger>().As<ILogger>();
           Container = builder.Build();

            return Container;
        }  
    }

    
}