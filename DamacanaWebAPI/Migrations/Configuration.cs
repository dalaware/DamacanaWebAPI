namespace DamacanaWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DamacanaWebAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DamacanaWebAPI.Models.DamacanaWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DamacanaWebAPI.Models.DamacanaWebAPIContext context)
        {

            context.Products.AddOrUpdate(p => p.Id,
            new Product() { Id = 1, Name = "Potion of Invisibility", Price = 410 },
            new Product() { Id = 2, Name = "Potion of SelfDestruction", Price = 130 },
            new Product() { Id = 3, Name = "Potion of FakePotion", Price = 53 }
            ); 

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
        }
    }
}
