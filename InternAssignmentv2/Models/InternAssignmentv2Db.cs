using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternAssignmentv2.Models
{
    public class InternAssignmentv2Db : DbContext 
    {
        public InternAssignmentv2Db():
            base("name=DefaultConnection")
        {
            this.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }


        public DbSet<User> Users { get; set; }
    }
}