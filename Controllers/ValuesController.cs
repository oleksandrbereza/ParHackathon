using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace azure.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
        int num;
        if (int.TryParse(id, out num))
        {
         return ProcessGetAsInt(num);
        }
        return ProcessGetAsString((string)id);
        }

        private string ProcessGetAsInt(int id)
        {
            return string.Format("This page returns value you have put in URL:\nValue={0}",id.ToString());
        }
        
        private string ProcessGetAsString(string id)
        {
            return string.Format("This page returns text value you have put in URL:\nValue={0}",id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
