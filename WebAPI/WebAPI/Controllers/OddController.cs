using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class OddController : ApiController
    {
        // GET api/odd
        public IEnumerable<string> Get()
        {
            return new string[] { "0" };
        }

        // GET api/odd/5
        public IEnumerable<int> Get(int id)
        {
            return Enumerable.Range(1, id).Where(x => x % 2 == 1).ToList();
        }
    }
}
