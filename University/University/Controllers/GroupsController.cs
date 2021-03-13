using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Models.UnitsOfWork;

namespace University.Controllers
{
    public class GroupsController : Controller
    {
        private Group _group;
        readonly IUnitOfWork _unitOfWork;

        public GroupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            var groups = _unitOfWork.Groups.GetAll().ToList();
            return View(groups);
        }
        
        public IActionResult Show(int id)
        {
            _group = _unitOfWork.Groups.Get(id);
            return View(_group);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            _group = _unitOfWork.Groups.Get(id);
            return View(_group);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Group group)
        {
            var id = group.GroupId;
            Group foundGroup = _unitOfWork.Groups.Get(id);
            foundGroup.Name = group.Name;
            _unitOfWork.Groups.Update(foundGroup);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}