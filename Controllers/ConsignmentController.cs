using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrimsonClothing_api.Models;
using CrimsonClothing_api.Databases;

namespace CrimsonClothing_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsignmentController : ControllerBase
    {
        // GET: api/Consignment
        [HttpGet]
        public List<Consignment> Get()
        {
            List<Consignment> consignments = new List<Consignment>();
            IReadConsignment readin = new ReadConsignment();
            consignments = readin.GetConsignments();

            return consignments;
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
            System.Console.WriteLine("In Consignment Post");
            ISaveConsignment add = new SaveConsignment();
            add.AddConsignment(newConsignment);
        }

        // PUT: api/Consignment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Consignment editConsignment, int Id)
        {
            System.Console.WriteLine("In Consignment Put");
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
