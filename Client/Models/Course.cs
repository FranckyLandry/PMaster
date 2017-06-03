using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Client.Models
{
    public class Course
    {
        

       

        public int CourseCode { get; set; }

        [Display(Name ="Course Name")]
        public string CourseName { get; set; }

        [Display(Name = "Course File Path")]
        public string CourseFilePath { get; set; }


        public int PcnNumber { get; set; }
    }
}