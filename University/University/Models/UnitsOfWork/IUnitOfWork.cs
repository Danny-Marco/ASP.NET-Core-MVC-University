using System;
using University.Models.Repository;

namespace University.Models.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        CourseRepository Courses { get; }
        GroupRepository Groups { get; }
        StudentRepository Students { get; }
        void Save();
        void Dispose(bool disposing);
        void Dispose();
    }
}