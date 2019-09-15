using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;


namespace Weather.Models
{
    public class Courses
    {
        
        public Object getCourses()
        {
            string url = "https://www2.bellevuecollege.edu/data/api/v1/courses/engl";
            //synchronous client
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<CourseDto>(content);
            return jsonContent;
        }
    }

    public class CourseDto
    {
       public List<Course> Courses { get; set; }
    }
}