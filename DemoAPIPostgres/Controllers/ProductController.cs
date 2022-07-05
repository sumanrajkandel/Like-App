using DemoAPIPostgres.Data;
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
        public IEnumerable<Movie> Get()
        {
            var movies = this.context.Movies.Include("Actors").ToList();
            return movies;
        }

        // GET api/<ProductController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
