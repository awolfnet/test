using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using test.App_Code;

namespace test.Controllers
{
    public class ValueController : ApiController
    {
        // GET: api/Value
        public IEnumerable<string> Get()
        {
            new Prerouting().Route(HTTP.METHOD.POST, null);

            return new string[] { "value1", "value2" };
        }

        // GET: api/Value/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Value
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Value/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Value/5
        public void Delete(int id)
        {
        }
    }
}
