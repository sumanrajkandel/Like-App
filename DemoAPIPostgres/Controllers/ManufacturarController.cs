using DemoAPIPostgres.Data;
using DemoAPIPostgres.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPIPostgres.Controllers
{

    //[Route("api/[controller]")]
    //[ApiController]
    public class ManufacturarController : ControllerBase
    {
        private readonly ProductDataContext context;
        public ManufacturarController(ProductDataContext context)
        {
            this.context = context;
        }


        // GET: api/<ManufacturarController>
        [HttpGet]
        public IEnumerable<ManufacturarMaster> Get()
        {
            var manufacturarMasterList = this.context.ManufacturarMasters.ToList();
            return manufacturarMasterList;
        }


        // GET api/<ManufacturarController>/5
        [HttpGet("{id}")]
        public ManufacturarMaster Get(int id)
        {
            var manufacturarMaster = context.ManufacturarMasters.FirstOrDefault(p => p.ManufacturarId == id);
            return manufacturarMaster;
        }


        // POST api/<ManufacturarController>
        [HttpPost]
        public void Post([FromBody] ManufacturarMaster manufacturarMaster)
        {
            if (!ModelState.IsValid)
                return;

            context.ManufacturarMasters.Add(manufacturarMaster);
            context.SaveChanges();



        }


        // PUT api/<ManufacturarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ManufacturarMaster manufacturarMaster)
        {
            if (id == 0) return;
            if (!ModelState.IsValid) return;
            context.ManufacturarMasters.Update(manufacturarMaster);
            context.SaveChanges();
        }


        // DELETE api/<ManufacturarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id == 0) return;

            var rowDelete = context.ManufacturarMasters.First(r => r.ManufacturarId == id);

            if (rowDelete != null)
            {
                context.ManufacturarMasters.Remove(rowDelete);
                context.SaveChanges(true);
            }


        }

    }
}
