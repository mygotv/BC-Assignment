using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weather.Models;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Test()
        {
            return View();
        }

        public ActionResult CoursesOrNot()
        {
            return View();
        }

        public ActionResult GetCourses()
        {
            Courses coursesRaw = new Courses();
            var temp = coursesRaw.getCourses();



            CourseDto courses = (CourseDto)temp;


            return View(courses.Courses as IEnumerable<Course>);
        }
    }
}