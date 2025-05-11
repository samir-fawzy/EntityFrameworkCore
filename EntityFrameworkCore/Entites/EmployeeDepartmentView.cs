using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entites
{
    internal class EmployeeDepartmentView
    {
        ///////////////// name of attributes should be same as in the database
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
