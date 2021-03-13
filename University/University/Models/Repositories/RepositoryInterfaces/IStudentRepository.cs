using System.Collections.Generic;

namespace University.Models.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Update(Student student);
    }
}