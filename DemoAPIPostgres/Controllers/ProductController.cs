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
    public class ProductController : ControllerBase
    {
        private readonly ProductDataContext context;
        public ProductController(ProductDataContext context)
        {
            this.context = context;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var product = this.context.Products.ToList();
            return product;
        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }


        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return;

            context.Products.Add(product);
            context.SaveChanges();



        }


        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            if (id == 0) return;
            if (!ModelState.IsValid) return;
            context.Products.Update(product);
            context.SaveChanges();
        }


        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id == 0) return;
            context.Remove(id);
            context.SaveChanges(true);
        }

    }
}
