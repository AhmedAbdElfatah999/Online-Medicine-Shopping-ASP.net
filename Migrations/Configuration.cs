namespace Online_Medicine_Shopping.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Online_Medicine_Shopping.Data.Online_Medicine_Shopping_DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Online_Medicine_Shopping.Data.Online_Medicine_Shopping_DBContext";
        }

        protected override void Seed(Online_Medicine_Shopping.Data.Online_Medicine_Shopping_DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
