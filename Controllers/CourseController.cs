using DataTableJquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTableJquery.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoadData()
        {
            IEnumerable<Course> courses = GetCourses();
            var json = Json(new { data = courses, recordsFiltered = courses.Count(), recordsTotal = courses.Count() });
            return json;
        }

        private IEnumerable<Course> GetCourses()
        {
            List<Course> courses = new List<Course>()
            {

                new Course(){CourseID="1", CourseName= "c Programing", Duration = "2 moths"},
                 new Course(){CourseID="2", CourseName= "java Programing", Duration = "4 moths"},
                  new Course(){CourseID="3", CourseName= "c++ Programing", Duration = "2 moths"},
                   new Course(){CourseID="4", CourseName= "c# Programing", Duration = "1 moths"},
                    new Course(){CourseID="5", CourseName= "Vb .net", Duration = "2 moths"},
                     new Course(){CourseID="6", CourseName= "A Programing", Duration = "2 moths"},
                      new Course(){CourseID="7", CourseName= "F# Programing", Duration = "1 moths"},
                       new Course(){CourseID="8", CourseName= "core java", Duration = "3 moths"},
                        new Course(){CourseID="9", CourseName= "jquery", Duration = "4 moths"},
                        new Course(){CourseID="10", CourseName= "oracle", Duration = "3 moths"},
                        new Course(){CourseID="11", CourseName= "PHP", Duration = "2 moths"},
                        new Course(){CourseID="12", CourseName= "asp .net", Duration = "5 moths"},
                        new Course(){CourseID="", CourseName= "data scructure", Duration = "2 moths"},
            };

            return courses;
        }
    }
}