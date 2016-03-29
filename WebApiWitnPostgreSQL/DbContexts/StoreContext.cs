using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using WebApiWitnPostgreSQL.Models;

namespace WebApiWitnPostgreSQL.DbContexts
{
    public class StoreContext:DbContext
    {
        public DbSet<Book> Books { get; set; }

        public StoreContext():base("books")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BookConfig());
        }
    }

    public class BookConfig : EntityTypeConfiguration<Book>
    {
        public BookConfig()
        {
            ToTable("books", "public");

            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("book_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("book_name").IsRequired().HasMaxLength(20);
            Property(x => x.Author).HasColumnName("author").IsRequired().HasMaxLength(20);
            Property(x => x.Price).HasColumnName("price");
        }
    }
}