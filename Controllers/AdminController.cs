using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CrimsonClothing_api.Models;
using CrimsonClothing_api.Databases.Admin;

namespace CrimsonClothing_api.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET: api/Admin
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Admin/Get/5
        [HttpGet("Get/{id}")/*("{id}", Name = "Get")*/]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Admin
        [HttpPost]
        public void Post([FromBody] Admin newAdmin)
        {   
            System.Console.WriteLine("In Admin Post");
            ISaveAdmin add = new SaveAdmin();
            add.AddAdmin(newAdmin);
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Admin editAdmin, int Id)
        {
            System.Console.WriteLine("In Admin Put");
            IEditAdmin edit = new EditAdmin();
            edit.EditAdmin(editAdmin, Id);
        }

        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
