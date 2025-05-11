using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entites
{
    internal class StudentCourse
    {

        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double? Grade { get; set; } 
        public virtual Student Student { get; set; } // Navigation property
        public virtual Course Course { get; set; } // Navigation property
    }
}
