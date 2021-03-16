using System.Collections.Generic;
using System.Linq;

namespace University.Models.Repository
{
    public interface IGroupRepository
    {
        IEnumerable<Group> Groups { get; }
        IEnumerable<Group> GetAll();
        Group Get(int id);
        void Update(Group group);
    }
}