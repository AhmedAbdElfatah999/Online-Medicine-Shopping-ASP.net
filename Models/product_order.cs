using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Medicine_Shopping.Models
{
    public class product_order
    {
        [Key]
        public int id { get; set; }
        public int product_id { get; set; }
        public int order_id { get; set; }

        [ForeignKey(nameof(product_id))]
        public product subject { get; set; }

        [ForeignKey(nameof(order_id))]
        public order order { get; set; }
    }
}