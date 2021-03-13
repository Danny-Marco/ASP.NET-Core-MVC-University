using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace University.Models.Repository
{
    public class StudentRepository : IRepository<Student>
    {
        private UniversityContext _db;

        public StudentRepository(UniversityContext context)
        {
            _db = context;
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.Students;
        }
        
        public Student Get(int id)
        {
            return _db.Students.Find(id);
        }

        public void Update(Student student)
        {
            _db.Entry(student).State = EntityState.Modified;
        }
    }
}