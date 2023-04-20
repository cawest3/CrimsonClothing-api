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
    public class CustomerController : ControllerBase
    {
        // GET: api/Customer
        [HttpGet]
        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            IReadCustomer readin = new ReadCustomer();
            customers = readin.GetCustomers();

            return customers;

            //return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/Get/5
        [HttpGet("Get/{id}")/*("{id}", Name = "Get")*/]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer newCustomer)
        {
            System.Console.WriteLine("In Customer Post");
            ISaveCustomer save = new SaveCustomer();
            save.AddCustomer(newCustomer);
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer editCustomer, int Id)
        {
            System.Console.WriteLine("In Customer Put");
            IEditCustomer edit = new EditCustomer();
            edit.EditCustomer(editCustomer, Id);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
