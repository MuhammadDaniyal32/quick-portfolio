using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bootstrap_model_data_inserttion.Models
{
    public class Class2
    {
        [Key]
        public int Emp_id { get; set; }
        [Required(ErrorMessage = "Enter name")]

        public string Emp_name { get; set; }
        [Required(ErrorMessage = "Enter dep_id")]

        public Nullable<int> Dep_id { get; set; }
        [Required(ErrorMessage = "Enter address")]

        public string Address { get; set; }

        public string Dep_name { get; set; }

        public string site_name { get; set; }




    }
}