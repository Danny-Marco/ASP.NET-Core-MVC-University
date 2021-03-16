using System.Collections.Generic;
using System.Linq;
using University.Models;
using University.Models.Repository;

namespace TestProject1.TestsRepositories
{
    public class TestStudentRepository : IStudentRepository
    {
        public IEnumerable<Student> Students => TestsData.Students;

        public IEnumerable<Student> GetAll()
        {
            return Students;
        }

        public Student Get(int id)
        {
            var student = Students.FirstOrDefault(g => g.GroupId == id);
            return student;
        }

        public void Update(Student student)
        {
            throw new System.NotImplementedException();
        }
    }
}