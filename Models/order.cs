using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
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
    }
}