using DataTableJquery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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
            //System.Threading.Thread.Sleep(2000);
            string searchString = Request.Form.GetValues("search[value]").FirstOrDefault();
            //sorting parameters
           
            string sortColumn, sortDirection;
            sortColumn = Request.Form.GetValues("columns[" + 
                Request.Form.GetValues("order[0][column]").FirstOrDefault()
                + "][name]").FirstOrDefault();
            sortDirection = Request.Form.GetValues("order[0][dir]").FirstOrDefault();

            //pagination parameters
            string legth = Request.Form.GetValues("length").FirstOrDefault();
            string start = Request.Form.GetValues("start").FirstOrDefault();

            int pagesize = legth != null ? Convert.ToInt32(legth) : 0;
            int skiprecords = start != null ? Convert.ToInt32(start) : 0;
            int totalRec;

            IEnumerable<Course> courses = GetCourses(searchString, sortColumn,sortDirection, pagesize,
                skiprecords, out totalRec);
            var json = Json(new { data = courses, recordsFiltered = totalRec, recordsTotal = totalRec });
            return json;
        }



        private IEnumerable<Course> GetCourses(string searchString, string sortcol,string sortDir, int pageSize, int skipRecords, out int totalRec)
        {
          

            List<Course> courses = new List<Course>()
            {

                new Course(){CourseID=1, CourseName= "c Programing", Duration = "2 moths"},
                 new Course(){CourseID=2, CourseName= "java Programing", Duration = "4 moths"},
                  new Course(){CourseID=3, CourseName= "c++ Programing", Duration = "2 moths"},
                   new Course(){CourseID=4, CourseName= "c# Programing", Duration = "1 moths"},
                    new Course(){CourseID=5, CourseName= "Vb .net", Duration = "2 moths"},
                     new Course(){CourseID=6, CourseName= "A Programing", Duration = "2 moths"},
                      new Course(){CourseID=7, CourseName= "F# Programing", Duration = "1 moths"},
                       new Course(){CourseID=8, CourseName= "core java", Duration = "3 moths"},
                        new Course(){CourseID=9, CourseName= "jquery", Duration = "4 moths"},
                        new Course(){CourseID=10, CourseName= "oracle", Duration = "3 moths"},
                        new Course(){CourseID=11, CourseName= "PHP", Duration = "2 moths"},
                        new Course(){CourseID=12, CourseName= "asp .net", Duration = "5 moths"},
                        new Course(){CourseID=13, CourseName= "data scructure", Duration = "2 moths"},

                            new Course(){CourseID=14, CourseName= "c Programing", Duration = "2 moths"},
                 new Course(){CourseID=22, CourseName= "gava Programing", Duration = "4 moths"},
                  new Course(){CourseID=23, CourseName= "c++ Programing", Duration = "2 moths"},
                   new Course(){CourseID=24, CourseName= "c# x Programing", Duration = "1 moths"},
                    new Course(){CourseID=25, CourseName= "Vx .net", Duration = "2 moths"},
                     new Course(){CourseID=26, CourseName= "Aff Programing", Duration = "2 moths"},
                      new Course(){CourseID=27, CourseName= "Fu$ Programing", Duration = "1 moths"},
                       new Course(){CourseID=28, CourseName= "coreel java", Duration = "3 moths"},
                        new Course(){CourseID=29, CourseName= "jquery", Duration = "4 moths"},
                        new Course(){CourseID=30, CourseName= "oracle", Duration = "3 moths"},
                        new Course(){CourseID=31, CourseName= "PHP", Duration = "2 moths"},
                        new Course(){CourseID=32, CourseName= "asp .net", Duration = "5 moths"},
                        new Course(){CourseID=33, CourseName= "data scructure", Duration = "2 moths"},

            };
        
            courses = courses.Where(x => x.CourseName.ToUpper().Contains(searchString.ToUpper()) ||
            x.Duration.Contains(searchString)).ToList();

            totalRec = courses.Count();

            switch (sortcol)
            {
                case "CID":
                    courses = (List<Course>)(sortcol.ToLower() == "asc" ? courses.OrderBy(x => x.CourseID) :
                    courses.OrderByDescending(x => x.CourseID)).ToList();
                break;
                case "CName":
                    courses = (List<Course>)(sortcol.ToLower() == "asc" ? courses.OrderBy(x => x.CourseName) :
                    courses.OrderByDescending(x => x.CourseName)).ToList();
                    break;
                case "CDuration":
                    courses = (List<Course>)(sortcol.ToLower() == "asc" ? courses.OrderBy(x => x.Duration) :
                    courses.OrderByDescending(x => x.Duration)).ToList();
                    break;
            }
            courses = courses.Skip(skipRecords).Take(pageSize).ToList();



            return courses;
        }
    }
}