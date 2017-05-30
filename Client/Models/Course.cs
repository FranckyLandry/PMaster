using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Course
    {
        public int CourseCode { get; set; }

        public string CourseName { get; set; }

        public string CourseSubmition { get; set; }

        public decimal CoursGrade { get; set; }

        public int PcnNumber { get; set; }
    }
}