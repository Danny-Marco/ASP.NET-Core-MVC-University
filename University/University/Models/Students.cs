using System;
using System.Collections.Generic;

namespace University.Models
{
    public partial class Students
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }

        public virtual Groups Group { get; set; }
    }
}
