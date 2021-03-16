using System;
using University.Models.Repository;

namespace University.Models.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IGroupRepository Groups { get; }
        IStudentRepository Students { get; }
        void Save();
    }
}