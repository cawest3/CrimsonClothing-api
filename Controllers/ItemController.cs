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
    public class ItemController : ControllerBase
    {
        // GET: api/Item
        [HttpGet]
        public List<Item> Get()
        {
            List<Item> items = new List<Item>();
            IReadItem readin = new ReadItem();
            items = readin.GetItems();
            
            return items;
        }

        // GET: api/Item/Get/5
        [HttpGet("Get/{id}")/*("{id}", Name = "Get")*/]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Item
        [HttpPost]
        public void Post([FromBody] Item addItem)
        {
            System.Console.WriteLine("In Item Post");
            ISaveItem newItem = new SaveItem();
            newItem.AddItem(addItem);

        }

        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item editItem, int Id)
        {
            System.Console.WriteLine("In Item Put");
            IEditItem edit = new EditItem();
            edit.EditItem(editItem, Id);
        }

        // DELETE: api/Item/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
