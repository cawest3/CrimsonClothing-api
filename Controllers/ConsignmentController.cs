using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrimsonClothing_api.Models;

namespace CrimsonClothing_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsignmentController : ControllerBase
    {
        // GET: api/Consignment
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Consignment/Get/5
        [HttpGet("Get/{id}")/*("{id}", Name = "Get")*/]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Consignment
        [HttpPost]
        public void Post([FromBody] Consignment newConsignment)
        {
            ISaveConsignment add = new SaveConsignment();
            add.AddConsignment(newConsignment);
        }

        // PUT: api/Consignment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Consignment editConsignment, int Id)
        {
            IEditConsignment edit = new EditConsignment();
            edit.EditConsignment(editConsignment, Id);
        }

        // DELETE: api/Consignment/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
