using System;
using System.Collections.Generic;

namespace University.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Students = new HashSet<Students>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
