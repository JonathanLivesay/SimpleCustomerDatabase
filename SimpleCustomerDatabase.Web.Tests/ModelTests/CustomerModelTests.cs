using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCustomerDatabase.Web.Models;
using SimpleCustomerDatabase.Domain;
using System.Web;

namespace SimpleCustomerDatabase.Web.Tests.ModelTests
{
    [TestFixture]
    class CustomerModelTests
    {

        private CustomerModel customerModel;
        private List<Customer> customers;
        private Customer customer;


    //    private void Setup()
    //    {
    //        customerModel = new CustomerModels()
    //            {
    //                customers = new List<Customer>(),
    //            };
    //    }

    //    private void Testing_Model()
    //    {
    //        Controllers.Create(customerModel);

    //        Assert.IsTrue(true);
    //    }
    }
}
