using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace WebAPI.Controllers
{
    using WebAPI.Math;

    public class FibonacciController : ApiController
    {
        // GET api/fibonacci
        public IEnumerable<string> Get()
        {
            return new string[] { "1" };
        }

        // GET api/fibonacci/5
        public string Get(int id)
        {
            return Fibonacci.Get(id).ToString();
        }
    }
}
