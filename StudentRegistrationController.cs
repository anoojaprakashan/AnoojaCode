using StudentRegistrationApp_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistrationApp_Project.Controllers
{
    public class StudentRegistrationController : Controller
    {
        private StudentApplicationDbContext db = new StudentApplicationDbContext();

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student student, List<Qualification> Qualifications)
        {
            if (ModelState.IsValid)
            {
                student.Qualifications = Qualifications;
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(student);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var student = db.Students.FirstOrDefault(x => x.Username == Username && x.Password == Password);
            if (student != null)
            {
                return RedirectToAction("List");
            }

            ViewBag.Error = "Invalid login.";
            return View();
        }

        public ActionResult List()
        {
            var students = db.Students.Include("Qualifications").ToList();
            return View(students);
        }
    }
}