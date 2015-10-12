using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class EController : ApiController
    {
        // GET api/e
        public IEnumerable<string> Get()
        {
            return new string[] { "5" };
        }

        // GET api/e/5
        public IEnumerable<int> Get(int id)
        {
            if (id > 0)
                return Enumerable.Range(1, id).Where(x => x % 5 == 0);
            return new int[] { 5 };
        }
    }
}
