using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain
{
    public class A
    {
         public static List<Customer> CreateDummyCustomerModel()
        {

             var customers = new List<Customer>();

            var customer1 = new Customer()
            {
                FirstName = "Jim",
                LastName = "Bob", 
                Email = "jim@bob.com",
                CompanyName = "Jim Bob's Granite Emporium",
                PhoneNumber = "222.333.3322",
                CompanyStreet1 = "Jim Bob Street",
                CompanyStreet2 = "Suite 2001",
                CompanyCity = "Addison", 
                CompanyState = "TX", 
                CompanyPostalCode = "77443"

            };

            var customer2 = new Customer()
            {
                FirstName = "Phone",
                LastName = "Booth",
                Email = "someone@phonebooth.com",
                CompanyName = "Jim Bob's Granite Emporium",
                PhoneNumber = "222.333.3322",
                CompanyStreet1 = "Jim Bob Street",
                CompanyStreet2 = "Suite 2001",
                CompanyCity = "Addison",
                CompanyState = "TX",
                CompanyPostalCode = "77443"

            };

            var customer3 = new Customer()
            {
                FirstName = "Radar",
                LastName = "Jenkins",
                Email = "radar@jenkins.com",
                CompanyName = "Jim Bob's Granite Emporium",
                PhoneNumber = "222.333.3322",
            };

            var customer4 = new Customer()
            {
                FirstName = "Timothy",
                LastName = "Jenkins",
                Email = "timothy@jenkins.com",
                CompanyName = "Jim Bob's Granite Emporium",
                PhoneNumber = "222.333.3322",
                CompanyStreet1 = "ABC Way",
                CompanyStreet2 = "Suite 2001",
                CompanyCity = "Addison",
                CompanyState = "TX",
                CompanyPostalCode = "77443"

            };

            var customer5 = new Customer()
            {
                FirstName = "Handy",
                LastName = "Sands",
                Email = "jim@bob.com",
                CompanyName = "Jim Bob's Granite Emporium",
                PhoneNumber = "222.333.3322",
                CompanyStreet1 = "Jim Bob Street",
                CompanyStreet2 = "Suite 2001",
                CompanyCity = "Addison",
                CompanyState = "TX",
                CompanyPostalCode = "77443"

            };

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);
            customers.Add(customer5);

            return customers;

        }
    
    }

    public class An
    {
        
    }

    public class The
    {
        
    }
}
