using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiWitnPostgreSQL.DbContexts;
using WebApiWitnPostgreSQL.Models;

namespace WebApiWitnPostgreSQL.Controllers
{
    public class BooksController : ApiController
    {
        public async Task<IHttpActionResult> Get()
        {
            List<Book> books;

            using (var c = new StoreContext())
            {
                books = await c.Books.Select(x=> new Book
                {
                    Id = x.Id,
                    Name = x.Name,
                    Author = x.Author,
                    Price = x.Price
                }).ToListAsync();
            }

            return Ok(books);
        }
    }
}
