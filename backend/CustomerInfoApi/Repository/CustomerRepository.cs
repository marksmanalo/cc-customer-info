using Classes;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer AddOrUpdate(Customer customer)
        {
            using (var context = new CustomerInfoContext())
            {
                var existingCustomer = context.Customers.Include("Contacts").FirstOrDefault(x => x.Id == customer.Id);
                if (existingCustomer == null)
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                else
                {
                    var existingContactIds = existingCustomer.Contacts.Select(x => x.Id).ToList();
                    foreach(var id in existingContactIds)
                    {
                        var contact = context.Contacts.FirstOrDefault(x => x.Id == id);
                        if (contact != null) context.Contacts.Remove(contact);
                    }

                    existingCustomer.CompanyName = customer.CompanyName;
                    existingCustomer.WebsiteUrl = customer.WebsiteUrl;
                    existingCustomer.Industry = customer.Industry;
                    existingCustomer.EnterpriseClient = customer.EnterpriseClient;
                    existingCustomer.PrimaryContactId = customer.PrimaryContactId;

                    foreach (var contact in customer.Contacts)
                    {
                        contact.CustomerId = existingCustomer.Id;
                        context.Contacts.Add(contact);
                    }

                    context.SaveChanges();
                }
            }

            return customer;
        }

        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();
            using (var context = new CustomerInfoContext())
            {
                customers = context.Customers.Include("Contacts").ToList();
            }

            return customers;
        }

        public void Delete(int id)
        {
            using (var context = new CustomerInfoContext())
            {
                var existingCustomer = context.Customers.FirstOrDefault(x => x.Id == id);

                if (existingCustomer != null)
                {
                    context.Customers.Remove(existingCustomer);
                    context.SaveChanges();
                }
            }
        }
    }
}
