namespace MvcBookStore.Web.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorToBook : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("Books", "AuthorId", "Authors", "AuthorId", cascadeDelete: true);
            CreateIndex("Books", "AuthorId");
        }
        
        public override void Down()
        {
            DropIndex("Books", new[] { "AuthorId" });
            DropForeignKey("Books", "AuthorId", "Authors");
        }
    }
}
