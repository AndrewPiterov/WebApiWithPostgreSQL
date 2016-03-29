namespace WebApiWitnPostgreSQL.DataContexts.StoreMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.books",
                c => new
                    {
                        book_id = c.Guid(nullable: false),
                        book_name = c.String(nullable: false, maxLength: 20),
                        author = c.String(nullable: false, maxLength: 20),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.book_id);
            
        }
        
        public override void Down()
        {
            DropTable("public.books");
        }
    }
}
