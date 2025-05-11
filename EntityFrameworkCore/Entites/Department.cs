using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entites
{
    public class Department
    {
        public int DepId { get; }
        public string DepName { get; set; }
        public DateTime CreatedDate { get; set; }
        //[InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); // Navigation property
    }
}
