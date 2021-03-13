using System.Collections.Generic;
using System.Linq;

namespace University.Models.Repository
{
    public interface ICourseRepository : IRepository<Course>
    {
        IQueryable Courses { get; }
        IEnumerable<Course> GetAll();
        Course Get(int id);
    }
}