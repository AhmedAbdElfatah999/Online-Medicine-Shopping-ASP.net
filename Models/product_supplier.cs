using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Medicine_Shopping.Models
{
    public class product_supplier
    {
        [Key]
        public int id { get; set; }
        public int supplier_id { get; set; }
        public int product_id { get; set; }



        [ForeignKey(nameof(supplier_id))]
        public supplier supplier { get; set; }

        [ForeignKey(nameof(product_id))]
        public product product { get; set; }
    }
}