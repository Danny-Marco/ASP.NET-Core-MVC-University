using System.Collections.Generic;

namespace University.Models.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> Courses { get; }
        IEnumerable<Course> GetAll();
        Course Get(int id);
    }
}