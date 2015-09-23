using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiMessageApp.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserContext : DbContext {

        public UserContext() : base()
        {
        }
        public DbSet<User> Users { get; set; }

    }
}