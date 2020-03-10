using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Online_Medicine_Shopping.Models
{
    public class order
    {    [Key]
        public int id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        System.DateTime date { get; set; }
        [Display(Name = "Recipient Address")]
        public string address { get; set; }

        public int user_id { get; set; }

        [ForeignKey(nameof(user_id))]
        public virtual users user { get; set; }
    }
}