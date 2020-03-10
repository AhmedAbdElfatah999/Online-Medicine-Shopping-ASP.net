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
        public Online_Medicine_Shopping_DBContext() : base()
        {

        }

        public DbSet<Models.users> users { get; set; }
        public DbSet<Models.product> product { get; set; }
        public DbSet<Models.product_order> product_order { get; set; }
        public DbSet<Models.product_supplier> product_supplier { get; set; }
        public DbSet<Models.supplier> supplier { get; set; }
        public DbSet<Models.user_order> user_order { get; set; }
        public DbSet<Models.user_type> user_type { get; set; }
        public DbSet<Models.order> order { get; set; }









    }
}