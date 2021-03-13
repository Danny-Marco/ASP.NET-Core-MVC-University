using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class CoursesController : Controller
    {
        readonly UnitOfWork unitOfWork;

        public CoursesController()
        {
            unitOfWork = new UnitOfWork();
        }

        public IActionResult Index()
        {
            var courses = unitOfWork.Courses.GetAll().ToList();
            return View(courses);
        }
        
        public IActionResult ShowGroups(int id)
        {
            Course course = unitOfWork.Courses.Get(id);
            return View(course.Groups.ToList());
        } 
    }
}