using InheritanceMapping.Contexts;
using InheritanceMapping.Entities;

namespace InheritanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBContext dbContext = new CompanyDBContext();

            #region FullTimeEmployees Data
            FullTimeEmployee E01 = new FullTimeEmployee()
            {
                Name = "Ahmed",
                Age = 30,
                Address = "cairo",
                Salary = 20000,
                StartDate = DateTime.Now,
            };

            dbContext.Employees.Add(E01);
            #endregion
            #region PartTimeEmployees Data
            PartTimeEmployee E02 = new PartTimeEmployee()
            {
                Name = "Noha",
                Age = 20,
                Address = "cairo",
                HourRate = 100,
                CountOfHours = 120
            };

            dbContext.Employees.Add(E02);
            #endregion

            //dbContext.SaveChanges();
        }
    }
}
