using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistrationApp_Project.Models
{
    public class StudentViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Qualification> Qualifications { get; set; }
    }
}