using System;
using University.Models.Repository;
using University.Models.UnitsOfWork;

namespace University.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private UniversityContext _db = new UniversityContext();
        private ICourseRepository _courseRepository;
        private IGroupRepository _groupRepository;
        private IStudentRepository _studentRepository;
        private bool disposed = false;

        public ICourseRepository Courses
        {
            get
            {
                if (_courseRepository != null) return (CourseRepository) _courseRepository;
                _courseRepository = new CourseRepository(_db);
                return (CourseRepository) _courseRepository;
            }
        }

        public IGroupRepository Groups
        {
            get
            {
                if (_groupRepository != null) return (GroupRepository) _groupRepository;
                _groupRepository = new GroupRepository(_db);
                return (GroupRepository) _groupRepository;
            }
        }

        public IStudentRepository Students
        {
            get
            {
                if (_studentRepository != null) return (StudentRepository) _studentRepository;
                _studentRepository = new StudentRepository(_db);
                return (StudentRepository) _studentRepository;
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