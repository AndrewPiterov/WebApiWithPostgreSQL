using System.Web.Http;

namespace WebApiWitnPostgreSQL.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            //List<Book> books;

            //using (var context = new ApplicationDbContext())
            //{
            //    books = context.Books.ToList();
            //}

            //return books.Select(x=>x.Name);
            return Ok(true);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            //using (var context = new ApplicationDbContext())
            //{
            //   context.Books.Add(new Book
            //   {
            //       Id = Guid.NewGuid(),
            //       Author = value,
            //       Price = 100m,
            //       Name = value
            //   });

            //    context.SaveChanges();
            //}
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
