namespace AtmTransaction.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtmTransaction.MyDbContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AtmTransaction.MyDbContex context)
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

            context.userData.AddOrUpdate(
                p => p.id,
                new Models.UserData { card_number = 1, pinNumber = 123, balance = 1200},
                new Models.UserData { card_number = 2, pinNumber = 234, balance = 1500 },
                new Models.UserData { card_number = 3, pinNumber = 345, balance = 1000 }

                );

        }
    }
}
