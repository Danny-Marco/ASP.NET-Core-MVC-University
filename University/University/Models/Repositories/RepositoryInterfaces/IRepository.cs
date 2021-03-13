using System.Collections.Generic;
using System.Linq;

namespace University.Models.Repository
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
    }
}