using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Controllers
{
    public class GroupsController : Controller
    {
        private UniversityContext _db;
        private Group _group;
       
        public GroupsController(UniversityContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            List<Group> groups = _db.Groups.ToList();
            return View(groups);
        }
        
        public IActionResult Show(int id)
        {
            _group = _db.Groups.Find(id);
            return View(_group);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Group group = await _db.Groups.FirstOrDefaultAsync(p => p.GroupId == id);
                if (group != null)
                    return View(group);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Group group)
        {
            Group foundGroup = await _db.Groups.FirstOrDefaultAsync(p => p.GroupId == group.GroupId);
            foundGroup.Name = group.Name;
            _db.Groups.Update(foundGroup);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}