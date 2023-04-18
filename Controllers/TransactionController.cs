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
    public class TransactionController : ControllerBase
    {
        // GET: api/Transaction
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Transaction/Get/5
        [HttpGet("Get/{id}")/*("{id}", Name = "Get")*/]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Transaction
        [HttpPost]
        public void Post([FromBody] Transaction newTransaction)
        {
            ISaveTransaction save = new SaveTransaction();
            save.AddTransaction(newTransaction);
        }

        // PUT: api/Transaction/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Transaction editTransaction, int Id)
        {
            IEditTransaction edit = new EditTransaction();
            edit.EditTransaction(editTransaction, Id);
        }

        // DELETE: api/Transaction/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
