using System;
using System.Collections.Generic;

namespace University.Models.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityContext _db;

        public CourseRepository(UniversityContext context)
        {
            _db = context;
        }

        public IEnumerable<Course> Courses => _db.Courses;

        public IEnumerable<Course> GetAll()
        {
            return _db.Courses;
        }

        public Course Get(int id)
        {
            return _db.Courses.Find(id);
        }
    }
}