using System;
using System.Linq;
using NUnit.Framework;
using Moq;
using Highway.Data;
using System.Collections;
using SimpleCustomerDatabase.Web.Controllers;
using SimpleCustomerDatabase.Web.Models;
using System.Web.Mvc;
using Highway.Data.Contexts;
using SimpleCustomerDatabase.Domain;
using SimpleCustomerDatabase.Web.App_Start;

namespace SimpleCustomerDatabase.Web.Tests
{
    [TestFixture]
    public class When_A_Customer_Is_Created
    {

        private InMemoryDataContext context;
        private IRepository repo;
        private CustomerController customerController;

        private CustomerModel model;

        [SetUp]
        public void SetUp()
        {


            model = new CustomerModel()
            {
                Customers = A.CreateDummyCustomerModel(),
            };

            context = new InMemoryDataContext();
            repo = new Repository(context);
            customerController = new CustomerController(repo);


            //mockRepo = Mock.Of<IRepository>();
            //Mock.Get(mockRepo)
            //    .Setup(r => r.Context)
            //    .Returns(mockContext);
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void When_A_Customer_Is_Created_They_Should_Be_Added_To_the_Customers_Model_List()
        {
            var result = customerController.First() as ViewResult;

            Assert.IsNotNull(result);
        }

        [Test]
        public void When_A_Customer_Is_Created_The_Index_Of_The_Customer_Controller_Should_Come_Up()
        {
            
            
            var customerController = new CustomerController(repo);
            
            foreach (var customer in model.Customers)
                repo.Context.Add(customer);

            repo.Context.Commit();

            model.Customers = repo.Find(new FindAll<Customer>()).ToList();

            var result = customerController.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
