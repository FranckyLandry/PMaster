using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Student
    {

        [Display(Name ="PcNumber")]
        public int PcnNumber { get; set; }

        //[Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }


    }
}