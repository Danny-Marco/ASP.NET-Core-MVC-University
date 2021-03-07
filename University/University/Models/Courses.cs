using System;
using System.Collections.Generic;

namespace University.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Groups = new HashSet<Groups>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Groups> Groups { get; set; }
    }
}
