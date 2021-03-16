using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using TestProject1.TestsRepositories;
using University.Controllers;

namespace TestProject1
{
    public class GroupTests
    {
        private TestUnitOfWork _unitOfWork;
        private GroupsController _controller;
        
        [SetUp]
        public void Setup()
        {
            _unitOfWork = new TestUnitOfWork();
            _controller = new GroupsController(_unitOfWork);
        }
        
        [Test]
        public void ModelOfViewIndex_ShouldReturn_ListOfGroups()
        {
            var result = _controller.Index() as ViewResult;
            var expectedModel = TestsData.Groups.ToList();
            var currentModel = result.Model;
            Assert.AreEqual(currentModel, expectedModel);
        }
        
        [Test]
        public void ModelOfShowGet_ShouldReturn_Group()
        {
            var group = TestsData.Groups.First();
            var groupId = group.GroupId;
            var currentFoundGroup = _unitOfWork.Groups.Get(groupId);
            Assert.AreEqual(currentFoundGroup, group);
        }
    }
}