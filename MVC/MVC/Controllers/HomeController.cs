using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCourses()
        {
            Courses coursesRaw = new Courses();
            var temp = coursesRaw.getCourses();

            CoursesDto courses = (CoursesDto)temp;

            return View(courses.Courses as IEnumerable<Courses>);
        }
    }
}