using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;


namespace Online_Medicine_Shopping.Data 
{
    public class Online_Medicine_Shopping_DBContext: DbContext
    {
        public DbSet<Models.users> users { get; set; }
        public DbSet<Models.product> product { get; set; }







    }
}