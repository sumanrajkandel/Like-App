using DemoAPIPostgres.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPIPostgres.Controllers
{

    //[Route("api/[controller]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ProductDataContext context;
        public HomeController(ProductDataContext context)
        {
            this.context = context;
        }

        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var movies = this.context.Movies.Include("Actors").ToList();
            return movies;
        }

        // GET api/<HomeController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
