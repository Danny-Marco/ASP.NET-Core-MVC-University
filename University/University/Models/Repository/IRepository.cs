using System.Collections.Generic;

namespace University.Models.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}