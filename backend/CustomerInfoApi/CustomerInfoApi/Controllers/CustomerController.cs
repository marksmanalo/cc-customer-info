using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerInfoApi.Controllers
{
    public class CustomerController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
