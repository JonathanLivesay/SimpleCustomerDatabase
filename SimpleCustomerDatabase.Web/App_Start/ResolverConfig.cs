﻿using System;
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


namespace SimpleCustomerDatabase.Web.App_Start 
{
    public class ResolverConfig
    {
        public static Customer instance;

        public static void Register()
        {

            CreateDummyCustomer1();

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(ResolverConfig).Assembly);
            builder.Register<SimpleCustomerDatabase.Domain.Customer>(c => instance);
            builder.Register<IRepository>(cc => new Repository(cc.Resolve<IDataContext>()));
            builder.Register<IMappingConfiguration>(cc => new MappingConfig());
            builder.Register<IDataContext>(cc => new DataContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, cc.Resolve<IMappingConfiguration>()));
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        private static void CreateDummyCustomer1()
        {

            instance = new Customer()
                {
                    FirstName = "James",
                    LastName = "Bond",
                    Email = "James.Bond@customer.com",
                    PhoneNumber = "214.555.1212",
                    CompanyName = "Company Work",
                    CompanyStreet1 = "2525 Alta Vista Dr.",
                    CompanyStreet2 =  "Suite 400",
                    CompanyCity = "Addison",
                    CompanyState = "TX",
                    CompanyPostalCode = "75087",
                };
        }

        private static void CreateDummyCustomer2()
        {

            instance = new Customer()
            {
                FirstName = "Bad",
                LastName = "Guy",
                Email = "Bad.Guy@customer.com",
                PhoneNumber = "214.555.1212",
                CompanyName = "Company Work",
                CompanyStreet1 = "1233 Victory Way",
                CompanyStreet2 = "Suite 400",
                CompanyCity = "Addison",
                CompanyState = "TX",
                CompanyPostalCode = "75001",
            };
        }

    }
}