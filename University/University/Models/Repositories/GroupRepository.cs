using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace University.Models.Repository
{
    
    public class GroupRepository : IGroupRepository
    {
        private UniversityContext _db;

        public GroupRepository(UniversityContext context)
        {
            _db = context;
        }

        // public IQueryable<Group> Groups { get; }
        public IQueryable<Group> Groups => _db.Groups;

        public IEnumerable<Group> GetAll()
        {
            return _db.Groups;
        }
        
        public Group Get(int id)
        {
            return _db.Groups.Find(id);
        }

        public void Update(Group group)
        {
            _db.Entry(group).State = EntityState.Modified;
        }
    }
}