using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class StudentsController : Controller
    {
        readonly UnitOfWork unitOfWork;

        public StudentsController()
        {
            unitOfWork = new UnitOfWork();
        }
        
        public IActionResult Index()
        {
            var students = unitOfWork.Students.GetAll().ToList();
            return View(students);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            Student student = unitOfWork.Students.Get(id);
            return View(student);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
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