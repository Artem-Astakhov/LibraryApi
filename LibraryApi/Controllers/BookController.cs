using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace LibraryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private ILibraryRepository context;
        public BookController(ILibraryRepository context)
        {
            this.context = context;
        }
        
        
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return context.GetBooks();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = context.GetBookId(id);
            if (book != null)
            {
                return new ObjectResult(book);
            }
            return NotFound();
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            context.CreateBook(book);
            return Ok(book);
            
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            var currentBook = context.GetBookId(book.Id);

            if (currentBook == null)
            {
                return NotFound();
            }

            context.UpdateBook(currentBook);
            return Ok(book);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var currentBook = context.GetBookId(id);

            if (currentBook == null)
            {
                return NotFound();
            }

            context.DeleteBook(currentBook.Id);
            return Ok(currentBook);
        }
    }
}
