using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ZController : ApiController
    {
        // GET api/z
        public IEnumerable<string> Get()
        {
            return new string[] { "15" };
        }

        // GET api/z/5
        public IEnumerable<int> Get(int id)
        {
            if (id > 0)
                return Enumerable.Range(1, id).Where(x => x % 15 == 0);
            return new int[] { 15 };
        }
    }
}
