using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Medicine_Shopping.Models
{
    public class payment
    {
        [Key]
        public int id { get; set; }

        public int user_id { get; set; }
        public int card_number { get; set; }
        System.DateTime expiration_date { get; set; }
        public int security_code { get; set; }
        public string owner_name { get; set; }

        [ForeignKey(nameof(user_id))]
        public virtual users user { get; set; }
    }
}