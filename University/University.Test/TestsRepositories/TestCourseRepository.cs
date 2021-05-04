using System.Collections.Generic;
using System.Linq;
using University.Models;
using University.Models.Repository;

namespace TestProject1.TestsRepositories
{
    public class TestCourseRepository : ICourseRepository
    {
        public IEnumerable<Course> Courses => TestsData.Courses;

        public IEnumerable<Course> GetAll()
        {
            return Courses;
        }

        public Course Get(int id)
        {
            var course = Courses.FirstOrDefault(c => c.CourseId == id);
            return course;
        }
    }
}