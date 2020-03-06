using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Medicine_Shopping.Models
{
    public class user_order
    {

        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public int order_id { get; set; }
        public double total_Bill { get; set; }


        [ForeignKey(nameof(user_id))]
        public users users { get; set; }

        [ForeignKey(nameof(order_id))]
        public order order { get; set; }

    }
}