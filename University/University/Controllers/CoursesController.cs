using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Models.UnitsOfWork;

namespace University.Controllers
{
    public class CoursesController : Controller
    {
        readonly IUnitOfWork _unitOfWork;

        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var courses = _unitOfWork.Courses.GetAll().ToList();
            return View(courses);
        }
        
        public IActionResult ShowGroups(int id)
        {
            Course course = _unitOfWork.Courses.Get(id);
            return View(course.Groups.ToList());
        } 
    }
}