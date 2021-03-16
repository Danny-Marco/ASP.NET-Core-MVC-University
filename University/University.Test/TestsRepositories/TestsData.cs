using System.Collections.Generic;
using System.Linq;
using University.Models;

namespace TestProject1.TestsRepositories
{
    public static class TestsData
    {
        static Course course1 = new Course
        {
            CourseId = 1,
            Name = "Java",
            Description = "Course studying java",
            Groups = new List<Group>()
        };

        static Course course2 = new Course
        {
            CourseId = 2,
            Name = "Java Script",
            Description = "Course studying java script",
            Groups = new List<Group>()
        };

        static Course course3 = new Course
        {
            CourseId = 3,
            Name = "C#",
            Description = "Course studying C#",
            Groups = new List<Group>()
        };

        static Group group1 = new Group
        {
            GroupId = 1,
            Name = "J-01",
            Course = course1,
            CourseId = 1,
            Students = new List<Student>()
        };

        static Group group2 = new Group
        {
            GroupId = 2,
            Name = "J-02",
            Course = course1,
            CourseId = 1,
            Students = new List<Student>
            {
                // student3, student4
            }
        };

        static Group group3 = new Group
        {
            GroupId = 3,
            Name = "JS-01",
            Course = course2,
            CourseId = 2,
            Students = new List<Student>
            {
                // student5, student6
            }
        };

        static Group group4 = new Group
        {
            GroupId = 4,
            Name = "JS-02",
            Course = course2,
            CourseId = 2,
            Students = new List<Student>
            {
                // student7, student8
            }
        };

        static Group group5 = new Group
        {
            GroupId = 5,
            Name = "SR-01",
            Course = course3,
            CourseId = 3,
            Students = new List<Student>
            {
                // student9, student10
            }
        };

        static Group group6 = new Group
        {
            GroupId = 6,
            Name = "SR-02",
            Course = course3,
            CourseId = 3,
            Students = new List<Student>
            {
                // student11, student12
            }
        };

        static Student student1 = new Student
        {
            StudentId = 1,
            FirstName = "Kitti",
            Group = group1,
            GroupId = 1,
            LastName = "Ruit"
        };

        static Student student2 = new Student
        {
            StudentId = 2,
            FirstName = "Alfredo",
            Group = group1,
            GroupId = 1,
            LastName = "Ornelas"
        };

        static Student student3 = new Student
        {
            StudentId = 3,
            FirstName = "Peterus",
            Group = group2,
            GroupId = 2,
            LastName = "Tibbetts"
        };

        static Student student4 = new Student
        {
            StudentId = 4,
            FirstName = "Christiana",
            Group = group2,
            GroupId = 2,
            LastName = "Collison"
        };

        static Student student5 = new Student
        {
            StudentId = 5,
            FirstName = "Bellini",
            Group = group3,
            GroupId = 3,
            LastName = "Ive"
        };

        static Student student6 = new Student
        {
            StudentId = 6,
            FirstName = "Ronalda",
            Group = group3,
            GroupId = 3,
            LastName = "Kliesl"
        };

        static Student student7 = new Student
        {
            StudentId = 7,
            FirstName = "Thornton",
            Group = group4,
            GroupId = 4,
            LastName = "Zima"
        };

        static Student student8 = new Student
        {
            StudentId = 8,
            FirstName = "Hakim",
            Group = group4,
            GroupId = 4,
            LastName = "Firks"
        };

        static Student student9 = new Student
        {
            StudentId = 9,
            FirstName = "Lucian",
            Group = group5,
            GroupId = 5,
            LastName = "Dowzell"
        };

        static Student student10 = new Student
        {
            StudentId = 10,
            FirstName = "Annabelle",
            Group = group5,
            GroupId = 5,
            LastName = "Andreopolos"
        };

        static Student student11 = new Student
        {
            StudentId = 11,
            FirstName = "Esta",
            Group = group6,
            GroupId = 6,
            LastName = "Allison"
        };

        static Student student12 = new Student
        {
            StudentId = 12,
            FirstName = "Doloritas",
            Group = group6,
            GroupId = 6,
            LastName = "Batterbee"
        };

        public static IEnumerable<Course> Courses { get; } = CreateCourses();

        public static IEnumerable<Group> Groups { get; } = CreateGroups();

        public static IEnumerable<Student> Students { get; } = CreateStudents();

        private static List<Course> CreateCourses()
        {
            FeelInStudentsGroups();
            var courses = new List<Course>
            {
                course1, course2, course3
            };
            return courses;
        }

        private static List<Group> CreateGroups()
        {
            FeelInGroupsStudents();
            var groups = new List<Group>
            {
                group1, group2, group3, group4, group5, group6
            };
            return groups;
        }

        private static List<Student> CreateStudents()
        {
            var students = new List<Student>
            {
                student1, student2, student3, student4, student5, student6, student7, student8, student9, student10,
                student11, student12,
            };
            return students;
        }

        private static void FeelInStudentsGroups()
        {
            course1.Groups.Add(group1);
            course1.Groups.Add(group2);
            course2.Groups.Add(group3);
            course2.Groups.Add(group4);
            course3.Groups.Add(group5);
            course3.Groups.Add(group6);
        }

        private static void FeelInGroupsStudents()
        {
            group1.Students.Add(student1);
            group1.Students.Add(student2);
            group2.Students.Add(student3);
            group2.Students.Add(student4);
            group3.Students.Add(student5);
            group3.Students.Add(student6);
            group4.Students.Add(student7);
            group4.Students.Add(student8);
            group5.Students.Add(student9);
            group5.Students.Add(student10);
            group6.Students.Add(student11);
            group6.Students.Add(student12); 
        }
    }
}