using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ex_webApi.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> Datalist = new List<string>()
        {
            "value0","value1","value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return Datalist;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return Datalist[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Datalist.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            Datalist[id]= value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            Datalist.RemoveAt(id);
        }
    }
}
