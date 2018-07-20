namespace InternAssignmentv2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InternAssignmentv2.Models.InternAssignmentv2Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "InternAssignmentv2.Models.InternAssignmentv2Db";
        }

        protected override void Seed(InternAssignmentv2.Models.InternAssignmentv2Db context)
        {
            context.Users.AddOrUpdate(r => r.Email,
                new User { Name = "Andrew", Email = "trudgedy@gmail.com", Password = "YouCantKnow" });
        }
    }
}
