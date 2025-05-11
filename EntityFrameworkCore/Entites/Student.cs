using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entites
{
    internal class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>(); // Navigation property
    }
}
