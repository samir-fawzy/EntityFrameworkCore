using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entites
{
    internal class Course
    {
        public int Id { get;  }
        public string Title { get; set; }

        public virtual ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>(); // Navigation property
    }
}
