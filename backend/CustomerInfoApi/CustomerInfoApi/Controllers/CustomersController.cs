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
    }
}
