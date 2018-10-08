using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dejaview_api.Controllers
{
    [Route("api/[controller]")]
    public class ScrapJobController : Controller
    {
        // GET api/scrapjob
        // Returns a list of scrap jobs that need to be done.
        public IEnumerable<string> Get()
        {
            return new string[]
            {
                "4f817e9d3ad82887d8cac11f1c41e198", 
                "08d7baf2c4338914f8d10a85f28c2a67"
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return new ObjectResult(
                new {
                    Id = id,
                    Name = "108 Edgeworth Parade, Coombs, ACT, 2611"
                }
            );
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
