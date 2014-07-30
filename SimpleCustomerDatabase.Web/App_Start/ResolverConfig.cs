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
using SimpleCustomerDatabase.Web.Models;
using System.Configuration;
using System.Data.Entity;


namespace SimpleCustomerDatabase.Web.App_Start 
{
    public class ResolverConfig
    {
        public static CustomerModel instance;

        public static void Register()
        {

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(ResolverConfig).Assembly);
            //builder.RegisterType<CustomerModel>();
            builder.Register<IRepository>(cc => new Repository(cc.Resolve<IDataContext>()));
            builder.RegisterType<MappingConfig>().AsImplementedInterfaces();
            //builder.Register<IMappingConfiguration>(cc => new MappingConfig());
            //builder.Register<IDataContext>(cc => new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, cc.Resolve<IMappingConfiguration>()));
            builder.RegisterType<DataContext>().AsImplementedInterfaces().WithParameter(new NamedParameter("connectionString", ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}