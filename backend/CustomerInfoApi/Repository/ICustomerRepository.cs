using System.Collections.Generic;
using System.Linq;
using Classes;

namespace Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
    }
}