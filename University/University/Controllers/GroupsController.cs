using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
    public class GroupsController : Controller
    {
        private Group _group;
        readonly UnitOfWork unitOfWork;

        public GroupsController()
        {
            unitOfWork = new UnitOfWork();
        }
        
        public IActionResult Index()
        {
            var groups = unitOfWork.Groups.GetAll().ToList();
            return View(groups);
        }
        
        public IActionResult Show(int id)
        {
            _group = unitOfWork.Groups.Get(id);
            return View(_group);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            _group = unitOfWork.Groups.Get(id);
            return View(_group);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Group group)
        {
            var id = group.GroupId;
            Group foundGroup = unitOfWork.Groups.Get(id);
            foundGroup.Name = group.Name;
            unitOfWork.Groups.Update(foundGroup);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}