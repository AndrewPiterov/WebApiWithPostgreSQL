namespace WebApiWitnPostgreSQL.DataContexts.StoreMigrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddIdAutoGenerationToBook : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("public.books");
            AlterColumn("public.books", "book_id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("public.books", "book_id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("public.books");
            AlterColumn("public.books", "book_id", c => c.Guid(nullable: false));
            AddPrimaryKey("public.books", "book_id");
        }
    }
}
