namespace InternAssignmentv2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InternAssignmentv2.Models.InternAssignmentv2Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InternAssignmentv2.Models.InternAssignmentv2Db";
        }

        protected override void Seed(InternAssignmentv2.Models.InternAssignmentv2Db context)
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
        }
    }
}
