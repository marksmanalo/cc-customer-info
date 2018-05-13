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
        public List<Customer> GetAll()
        {
            var customers = new List<Customer>();
            using (var context = new CustomerInfoContext())
            {
                customers = context.Customers.ToList();
            }

            return customers;
        }
    }
}
