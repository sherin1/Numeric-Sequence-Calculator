using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class FullSeriesController : ApiController
    {
        // GET api/fullseries
        public IEnumerable<string> Get()
        {
            return new string[] { "1" };
        }

        // GET api/fullseries/5
        public IEnumerable<int> Get(int id)
        {
            if (id <= 0) return Enumerable.Range(1, 1);
            return Enumerable.Range(1, id);
        }
    }
}
