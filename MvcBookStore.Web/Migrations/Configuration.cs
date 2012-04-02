using MvcBookStore.Web.Domain;

namespace MvcBookStore.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcBookStore.Web.Database.MvcBookStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcBookStore.Web.Database.MvcBookStoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Author a1 = new Author()
                            {
                                AuthorId = 1,
                                FirstName = "Stephen",
                                LastName = "King"
                            };

            Author a2 = new Author()
                            {
                                AuthorId = 2,
                                FirstName = "Michael",
                                LastName = "Crichton"
                            };

            Book b1 = new Book()
                          {
                              BookId = 1,
                              AuthorId = 1,
                              Title = "The Thing"
                          };

            Book b2 = new Book()
                          {
                              BookId = 2,
                              AuthorId = 2,
                              Title = "Jurassic Park"
                          };

            context.Authors.AddOrUpdate(a1);
            context.Authors.AddOrUpdate(a2);
            context.Books.AddOrUpdate(b1);
            context.Books.AddOrUpdate(b2);
            
            context.SaveChanges();
        }
    }
}
