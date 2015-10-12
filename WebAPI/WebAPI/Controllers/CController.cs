using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class CController : ApiController
    {
        // GET api/c
        public IEnumerable<string> Get()
        {
            return new string[] { "3" };
        }

        // GET api/c/5
        public IEnumerable<int> Get(int id)
        {
            if (id > 0) 
                return Enumerable.Range(1, id).Where(x => x % 3 == 0);
            return new int[] {3};
        }
    }
}
