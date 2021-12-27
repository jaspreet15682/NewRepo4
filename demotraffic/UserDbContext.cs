using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace demotraffic
{
    public class UserDbContext: DbContext
    {
        public UserDbContext() : base("name=MyDbConnection")
        {
        }
        

        public System.Data.Entity.DbSet<User> User { get; set; }
    }

}