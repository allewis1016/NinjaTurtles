namespace NinjaTurtlesApp.Data.Migrations
{
    using NinjaTurtlesApp.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NinjaTurtlesApp.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NinjaTurtlesApp.Data.ApplicationDbContext context)
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
            context.Turtles.AddOrUpdate(t => t.Name,
                new NinjaTurtle ( "Michaelangelo", "Purple", "He is a party dude", "http://img1.wikia.nocookie.net/__cb20140717163859/tmnt/images/thumb/e/e2/Michelangelo_2014_Textless_Poster.jpg/250px-Michelangelo_2014_Textless_Poster.jpg", "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSWKjGWqCJg_V7o8zwYwCcMlmxydF9toeVXo4ukYAG-6ErCFo5Q", "Happy-go-lucky and funny", "Nunchucks" )
                );
        }
    }
}
