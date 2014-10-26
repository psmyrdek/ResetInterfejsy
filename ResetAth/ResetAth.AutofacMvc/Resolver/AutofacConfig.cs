using Autofac;
using Autofac.Integration.Mvc;
using ResetAth.AutofacMvc.DAL.Contract;
using ResetAth.AutofacMvc.DAL.Implementations.MySql;
using ResetAth.AutofacMvc.DAL.Implementations.SqlServer;
using System.Web.Mvc;

namespace ResetAth.AutofacMvc.Resolver
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<MySqlPostRepository>().As<IPostRepository>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}