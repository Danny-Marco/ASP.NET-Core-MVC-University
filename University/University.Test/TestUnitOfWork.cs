using System;
using TestProject1.TestsRepositories;
using University.Models.Repository;
using University.Models.UnitsOfWork;

namespace TestProject1
{
    public class TestUnitOfWork : IUnitOfWork
    {
        private TestCourseRepository _courseRepository;
        private TestGroupRepository _groupRepository;
        private TestStudentRepository _studentRepository;

        public ICourseRepository Courses
        {
            get
            {
                if (_courseRepository != null) return _courseRepository;
                _courseRepository = new TestCourseRepository();
                return _courseRepository;
            }
        }

        public IGroupRepository Groups
        {
            get
            {
                if (_groupRepository != null) return _groupRepository;
                _groupRepository = new TestGroupRepository();
                return _groupRepository;
            }
        }

        public IStudentRepository Students
        {
            get
            {
                if (_studentRepository != null) return _studentRepository;
                _studentRepository = new TestStudentRepository();
                return _studentRepository;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}