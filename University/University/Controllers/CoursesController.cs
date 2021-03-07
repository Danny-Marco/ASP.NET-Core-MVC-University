using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class CoursesController : Controller
    {
        private UniversityContext _db;

        public CoursesController(UniversityContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Course> courses = _db.Courses.ToList();
            return View(courses);
        }
    }
}