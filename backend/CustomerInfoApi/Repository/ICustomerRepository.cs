using System.Collections.Generic;
using System.Linq;
using Classes;

namespace Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer AddOrUpdate(Customer customer);
        void Delete(int id);
    }
}