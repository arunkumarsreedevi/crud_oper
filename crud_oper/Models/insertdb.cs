using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crud_oper.Models
{
    public class insertdb
    {
    
        public int id { get; set; }
        [Required(ErrorMessage = "enter name")]
        public string name { get; set; }
        [Range(18, 50, ErrorMessage = "enter age between 18 and 50")]
        public int age { get; set; }
        [Required(ErrorMessage = "about employee")]
        public string des { get; set; }
        public string msg { get; set; }
    }
}