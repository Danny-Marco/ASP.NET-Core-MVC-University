using System.Collections.Generic;
using System.Linq;
using University.Models;
using University.Models.Repository;

namespace TestProject1.TestsRepositories
{
    public class TestGroupRepository : IGroupRepository
    {
        public IEnumerable<Group> Groups => TestsData.Groups;
        
        public IEnumerable<Group> GetAll()
        {
            return Groups;
        }

        public Group Get(int id)
        {
            var group = Groups.FirstOrDefault(g => g.GroupId == id);
            return group;
        }

        public void Update(Group group)
        {
            throw new System.NotImplementedException();
        }
    }
}