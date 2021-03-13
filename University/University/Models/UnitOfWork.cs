using System;
using University.Models.Repository;

namespace University.Models
{
    public class UnitOfWork : IDisposable
    {
        private UniversityContext _db = new UniversityContext();
        private CourseRepository _courseRepository;
        private GroupRepository _groupRepository;
        private StudentRepository _studentRepository;
        private bool disposed = false;

        public CourseRepository Courses
        {
            get
            {
                if (_courseRepository != null) return _courseRepository;
                _courseRepository = new CourseRepository(_db);
                return _courseRepository;
            }
        }

        public GroupRepository Groups
        {
            get
            {
                if (_groupRepository != null) return _groupRepository;
                _groupRepository = new GroupRepository(_db);
                return _groupRepository;
            }
        }

        public StudentRepository Students
        {
            get
            {
                if (_studentRepository != null) return _studentRepository;
                _studentRepository = new StudentRepository(_db);
                return _studentRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}