using Classes;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerInfoApi.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController()
        {
            _customerRepository = new CustomerRepository();
        }

        public IHttpActionResult Get()
        {
            var temp = _customerRepository.GetAll().ToList();
            return Ok(temp);
        }

        public IHttpActionResult Get(int id)
        {
            var temp = _customerRepository.GetAll().FirstOrDefault(x => x.Id == id);
            return Ok(temp);
        }

        public IHttpActionResult Post(int id, [FromBody] Customer customer)
        {
            customer.Id = id;
            var newCustomer = _customerRepository.AddOrUpdate(customer);
            return Ok(newCustomer);
        }

        public IHttpActionResult Post([FromBody] Customer customer)
        {
            var newCustomer = _customerRepository.AddOrUpdate(customer);
            return Ok(newCustomer);
        }

        public IHttpActionResult Delete(int id)
        {
            _customerRepository.Delete(id);
            return Ok();
        }
    }
}
