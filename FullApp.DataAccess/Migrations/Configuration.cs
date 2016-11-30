namespace FullApp.DataAccess.Migrations
{
    using DomainModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FullApp.DataAccess.FullContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FullApp.DataAccess.FullContext";
        }

        protected override void Seed(FullApp.DataAccess.FullContext context)
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


            context.Products.AddOrUpdate(
                new Product() { Name = "Product 02" },
                new Product() { Name = "Product 03" },
                new Product() { Id = 1, Name = "Product 001" });
        }
    }
}
