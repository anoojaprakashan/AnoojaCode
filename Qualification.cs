using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistrationApp_Project.Models
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        public string CourseName { get; set; }
        public string University { get; set; }
        public int YearOfPassing { get; set; }
        public float Percentage { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}