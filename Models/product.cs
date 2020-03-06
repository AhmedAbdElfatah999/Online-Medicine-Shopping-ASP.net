using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Online_Medicine_Shopping.Models
{
    public class product
    {
         [Key]
        public int id { get; set; }
        
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Price")]
        public float price { get; set; }
        [Display(Name = "Quantity")]
        public int quantity { get; set; }
        [Display(Name = "Category Name")]
        public string category_name { get; set; }
        [Display(Name = "Description")]
        public string descrition { get; set; }

        [Display(Name = "Image")]
        public byte[] image { get; set; }
    }
}