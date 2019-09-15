using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace MVC.Models
{
    public class Courses
    {
        public string title { get; set; }
        public string description { get; set; }
        public int credits { get; set; }

        public Object getCourses()
        {
            string url = "https://www2.bellevuecollege.edu/data/api/v1/courses/engl";
            //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<CoursesDto>(content);
            return jsonContent;
        }
    }

    public class CoursesDto
    {
        public List<Courses> Courses { get; set; }
    }
}