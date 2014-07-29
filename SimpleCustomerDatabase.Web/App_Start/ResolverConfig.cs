using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Linq;
using SimpleCustomerDatabase.Web.Controllers;
using SimpleCustomerDatabase.Domain;
using Highway.Data;
using SimpleCustomerDatabase.Web.Persistence;
using System.Configuration;
using System.Data.Entity;


namespace SimpleCustomerDatabase.Web.App_Start 
{
    public class ResolverConfig
    {
        public static Customer instance;

        public static void Register()
        {

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(ResolverConfig).Assembly);
            builder.Register<SimpleCustomerDatabase.Domain.Customer>(c => instance);
            builder.Register<IRepository>(cc => new Repository(cc.Resolve<IDataContext>()));
            builder.Register<IMappingConfiguration>(cc => new MappingConfig());
            builder.Register<IDataContext>(cc => new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, cc.Resolve<IMappingConfiguration>()));
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}