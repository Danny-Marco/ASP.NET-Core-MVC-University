using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using TestProject1.TestsRepositories;
using University.Controllers;

namespace TestProject1
{
    public class StudentTests
    {
        private TestUnitOfWork _unitOfWork;
        private StudentsController _controller;
        
        [SetUp]
        public void Setup()
        {
            _unitOfWork = new TestUnitOfWork();
            _controller = new StudentsController(_unitOfWork);
        }
        
        [Test]
        public void ModelOfViewIndex_ShouldReturn_ListOfStudents()
        {
            var result = _controller.Index() as ViewResult;
            var expectedModel = TestsData.Students.ToList();
            var currentModel = result.Model;
            Assert.That(currentModel, Is.EqualTo(expectedModel));
        }
        
        [Test]
        public void ModelOfShowGet_ShouldReturn_Student()
        {
            var student = TestsData.Students.First();
            var studentId = student.StudentId;
            var currentFoundGroup = _unitOfWork.Students.Get(studentId);
            Assert.That(currentFoundGroup, Is.EqualTo(student));
        }
    }
}