using AspNetWebApiEntityFrameworkBackend.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetWebApiEntityFrameworkBackend.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        // GET: api/customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            using NorthwindContext context = new();
            return context.Customers.ToList();
        }

        // GET api/customers/ALFKI
        [HttpGet("{id}")]
        public ActionResult<Customer?> Get(string id)
        {
            using NorthwindContext context = new();
            Customer? cust = context.Customers.Find(id);
            if (cust is null)
            {
                return NotFound();
            }
            else
            {
                return cust;
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer newCust)
        {
            using NorthwindContext context = new();
            context.Customers.Add(newCust);
            context.SaveChanges();

            return Created();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
