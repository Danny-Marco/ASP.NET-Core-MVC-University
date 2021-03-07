using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Controllers
{
    public class StudentsController : Controller
    {
        private UniversityContext _db;

        public StudentsController(UniversityContext db)
        {
            _db = db;
        } 
        
        public IActionResult Index()
        {
            List<Student> students = _db.Students.ToList();
            return View(students);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Student student = await _db.Students.FirstOrDefaultAsync(p => p.StudentId == id);
                if (student != null)
                    return View(student);
            }

            return NotFound();
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            Student foundStudent = await _db.Students.FirstOrDefaultAsync(p => p.StudentId == student.StudentId);
            foundStudent.FirstName = student.FirstName;
            foundStudent.LastName = student.LastName;
            _db.Students.Update(foundStudent);
            await _db.SaveChangesAsync();
            int parameter = foundStudent.GroupId;
            return RedirectToAction("Show","Groups", new {@id=parameter});
        }
    }
}