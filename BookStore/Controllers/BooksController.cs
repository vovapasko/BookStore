using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Book
            {
                ISBN = "ISBN " + index,
                Title = "Book " + index,
                Author = "Author " + index
            })
            .ToArray(); ;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
