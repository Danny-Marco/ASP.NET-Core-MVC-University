using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Models.UnitsOfWork;

namespace University.Controllers
{
    public class StudentsController : Controller
    {
        readonly IUnitOfWork unitOfWork;

        public StudentsController(IUnitOfWork unit)
        {
            unitOfWork = unit;
        }
        
        public IActionResult Index()
        {
            var students = unitOfWork.Students.GetAll().ToList();
            return View(students);
        }
        
        public IActionResult Edit(int id)
        {
            Student student = unitOfWork.Students.Get(id);
            return View(student);
        }
        
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var parameter = student.GroupId;
            Student foundStudent = unitOfWork.Students.Get(student.StudentId);
            foundStudent.FirstName = student.FirstName;
            foundStudent.LastName = student.LastName;
            unitOfWork.Students.Update(foundStudent);
            unitOfWork.Save();
            return RedirectToAction("Show", "Groups", new {@id = parameter});
        }
    }
}