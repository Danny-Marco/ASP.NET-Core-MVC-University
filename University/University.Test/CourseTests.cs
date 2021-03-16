using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using TestProject1.TestsRepositories;
using University.Controllers;
using University.Models;

namespace TestProject1
{
    public class CourseTests
    {
        private TestUnitOfWork _unitOfWork;
        private CoursesController _controller;
        private Course _course;

        [SetUp]
        public void Setup()
        {
            _unitOfWork = new TestUnitOfWork();
            _controller = new CoursesController(_unitOfWork);
            _course = TestsData.Courses.First();
        }
        
        [Test]
        public void ModelOfViewIndex_ShouldReturn_ListOfCourse()
        {
            var result = _controller.Index() as ViewResult;
            var expectedModel = TestsData.Courses.ToList();
            var currentModel = result.Model;
            Assert.That(currentModel, Is.EqualTo(expectedModel));
        }
        
        [Test]
        public void ModelOfShowGroupsGet_ShouldReturn_Course()
        {
            var courseId = _course.CourseId;
            var currentFoundCourse = _unitOfWork.Courses.Get(courseId);
            Assert.That(currentFoundCourse, Is.EqualTo(_course));
        }

        [Test]
        public void ShowGroups_ShouldReturn_ListOfCourseGroups()
        {
            var groups = _course.Groups;
            var result = _controller.ShowGroups(1) as ViewResult;
            var currentModel = result.Model;
            Assert.That(groups, Is.EquivalentTo((IEnumerable) currentModel));
        }
    }
}