using EntityFrameworkCore.Contexts;
using EntityFrameworkCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using EnterpriceDB dbContext = new EnterpriceDB();

            #region Departments Data
            //Department D01 = new Department() { DepName = "HR", CreatedDate = DateTime.Now };
            //Department D02 = new Department() { DepName = "IT", CreatedDate = DateTime.Now };
            //Department D03 = new Department { DepName = "Finance", CreatedDate = DateTime.Now };
            //Department D04 = new Department{ DepName = "Marketing",CreatedDate = DateTime.Now};
            //Department D05 = new Department{ DepName = "Logistics",CreatedDate = DateTime.Now};
            #endregion
            #region Employees Data
            //Employee E01 = new Employee { Name = "Samir", Salary = 1000, Email = "samir1@gmail.com", DateOfBirth = new DateTime(2004, 2, 8), DepartmentId = 1 };
            //Employee E02 = new Employee { Name = "Ali", Salary = 1100, Email = "ali2@gmail.com", DateOfBirth = new DateTime(2001, 5, 12), DepartmentId = 1 };
            //Employee E03 = new Employee { Name = "Sara", Salary = 1200, Email = "sara3@gmail.com", DateOfBirth = new DateTime(2000, 3, 21), DepartmentId = 1 };
            //Employee E04 = new Employee { Name = "Mona", Salary = 1300, Email = "mona4@gmail.com", DateOfBirth = new DateTime(1999, 7, 15), DepartmentId = 1 };
            //Employee E05 = new Employee { Name = "Omar", Salary = 1400, Email = "omar5@gmail.com", DateOfBirth = new DateTime(2002, 8, 9), DepartmentId = 1 };
            //Employee E06 = new Employee { Name = "Laila", Salary = 1500, Email = "laila6@gmail.com", DateOfBirth = new DateTime(1998, 12, 1), DepartmentId = 1 };
            //Employee E07 = new Employee { Name = "Youssef", Salary = 1600, Email = "youssef7@gmail.com", DateOfBirth = new DateTime(2001, 10, 25), DepartmentId = 1 };
            //Employee E08 = new Employee { Name = "Rana", Salary = 1700, Email = "rana8@gmail.com", DateOfBirth = new DateTime(1997, 4, 18), DepartmentId = 1 };

            //Employee E09 = new Employee { Name = "Ahmed", Salary = 1050, Email = "ahmed9@gmail.com", DateOfBirth = new DateTime(2003, 6, 10), DepartmentId = 2 };
            //Employee E10 = new Employee { Name = "Nour", Salary = 1150, Email = "nour10@gmail.com", DateOfBirth = new DateTime(2000, 11, 30), DepartmentId = 2 };
            //Employee E11 = new Employee { Name = "Khaled", Salary = 1250, Email = "khaled11@gmail.com", DateOfBirth = new DateTime(1999, 2, 22), DepartmentId = 2 };
            //Employee E12 = new Employee { Name = "Dina", Salary = 1350, Email = "dina12@gmail.com", DateOfBirth = new DateTime(2002, 9, 14), DepartmentId = 2 };
            //Employee E13 = new Employee { Name = "Tamer", Salary = 1450, Email = "tamer13@gmail.com", DateOfBirth = new DateTime(1998, 8, 3), DepartmentId = 2 };
            //Employee E14 = new Employee { Name = "Rania", Salary = 1550, Email = "rania14@gmail.com", DateOfBirth = new DateTime(2001, 7, 5), DepartmentId = 2 };
            //Employee E15 = new Employee { Name = "Hossam", Salary = 1650, Email = "hossam15@gmail.com", DateOfBirth = new DateTime(1997, 1, 1), DepartmentId = 2 };
            //Employee E16 = new Employee { Name = "Mariam", Salary = 1750, Email = "mariam16@gmail.com", DateOfBirth = new DateTime(2000, 3, 30), DepartmentId = 2 };

            //Employee E17 = new Employee { Name = "Mahmoud", Salary = 1080, Email = "mahmoud17@gmail.com", DateOfBirth = new DateTime(2003, 1, 15), DepartmentId = 3 };
            //Employee E18 = new Employee { Name = "Aya", Salary = 1180, Email = "aya18@gmail.com", DateOfBirth = new DateTime(1999, 12, 6), DepartmentId = 3 };
            //Employee E19 = new Employee { Name = "Sherif", Salary = 1280, Email = "sherif19@gmail.com", DateOfBirth = new DateTime(2002, 4, 4), DepartmentId = 3 };
            //Employee E20 = new Employee { Name = "Eman", Salary = 1380, Email = "eman20@gmail.com", DateOfBirth = new DateTime(2001, 6, 26), DepartmentId = 3 };
            //Employee E21 = new Employee { Name = "Adel", Salary = 1480, Email = "adel21@gmail.com", DateOfBirth = new DateTime(1998, 10, 12), DepartmentId = 3 };
            //Employee E22 = new Employee { Name = "Farah", Salary = 1580, Email = "farah22@gmail.com", DateOfBirth = new DateTime(1997, 9, 19), DepartmentId = 3 };
            //Employee E23 = new Employee { Name = "Mostafa", Salary = 1680, Email = "mostafa23@gmail.com", DateOfBirth = new DateTime(2000, 2, 17), DepartmentId = 3 };
            //Employee E24 = new Employee { Name = "Nadine", Salary = 1780, Email = "nadine24@gmail.com", DateOfBirth = new DateTime(2001, 5, 25), DepartmentId = 3 };

            //Employee E25 = new Employee { Name = "Fady", Salary = 1020, Email = "fady25@gmail.com", DateOfBirth = new DateTime(2003, 3, 3), DepartmentId = 4 };
            //Employee E26 = new Employee { Name = "Jana", Salary = 1120, Email = "jana26@gmail.com", DateOfBirth = new DateTime(1999, 1, 9), DepartmentId = 4 };
            //Employee E27 = new Employee { Name = "Tarek", Salary = 1220, Email = "tarek27@gmail.com", DateOfBirth = new DateTime(2002, 10, 30), DepartmentId = 4 };
            //Employee E28 = new Employee { Name = "Lina", Salary = 1320, Email = "lina28@gmail.com", DateOfBirth = new DateTime(2001, 9, 11), DepartmentId = 4 };
            //Employee E29 = new Employee { Name = "Ziad", Salary = 1420, Email = "ziad29@gmail.com", DateOfBirth = new DateTime(1998, 7, 7), DepartmentId = 4 };
            //Employee E30 = new Employee { Name = "Hana", Salary = 1520, Email = "hana30@gmail.com", DateOfBirth = new DateTime(1997, 8, 28), DepartmentId = 4 };
            //Employee E31 = new Employee { Name = "Ibrahim", Salary = 1620, Email = "ibrahim31@gmail.com", DateOfBirth = new DateTime(2000, 6, 6), DepartmentId = 4 };
            //Employee E32 = new Employee { Name = "Maha", Salary = 1720, Email = "maha32@gmail.com", DateOfBirth = new DateTime(2001, 12, 16), DepartmentId = 4 };

            //Employee E33 = new Employee { Name = "Amr", Salary = 1060, Email = "amr33@gmail.com", DateOfBirth = new DateTime(2003, 2, 2), DepartmentId = 5 };
            //Employee E34 = new Employee { Name = "Salma", Salary = 1160, Email = "salma34@gmail.com", DateOfBirth = new DateTime(1999, 6, 23), DepartmentId = 5 };
            //Employee E35 = new Employee { Name = "Bassel", Salary = 1260, Email = "bassel35@gmail.com", DateOfBirth = new DateTime(2002, 1, 5), DepartmentId = 5 };
            //Employee E36 = new Employee { Name = "Heba", Salary = 1360, Email = "heba36@gmail.com", DateOfBirth = new DateTime(2001, 4, 4), DepartmentId = 5 };
            //Employee E37 = new Employee { Name = "Anas", Salary = 1460, Email = "anas37@gmail.com", DateOfBirth = new DateTime(1998, 5, 14), DepartmentId = 5 };
            //Employee E38 = new Employee { Name = "Nesma", Salary = 1560, Email = "nesma38@gmail.com", DateOfBirth = new DateTime(1997, 3, 13), DepartmentId = 5 };
            //Employee E39 = new Employee { Name = "Hady", Salary = 1660, Email = "hady39@gmail.com", DateOfBirth = new DateTime(2000, 7, 7), DepartmentId = 5 };
            //Employee E40 = new Employee { Name = "Yasmin", Salary = 1760, Email = "yasmin40@gmail.com", DateOfBirth = new DateTime(2001, 8, 18), DepartmentId = 5 };
            #endregion
            #region Students Data
            //Student S01 = new Student()
            //{
            //    Name = "Samir",
            //};
            //Student S02 = new Student()
            //{
            //    Name = "Nada",
            //}; Student S03 = new Student()
            //{
            //    Name = "Noha",
            //}; 
            //Student S04 = new Student()
            //{
            //    Name = "Ahmed",
            //};
            //Student S06 = new Student()
            //{
            //    Name = "Omar",
            //};
            //Student S07 = new Student()
            //{
            //    Name = "Yasmine",
            //};
            //Student S08 = new Student()
            //{
            //    Name = "Khaled",
            //};
            //Student S09 = new Student()
            //{
            //    Name = "Mona",
            //};
            //Student S10 = new Student()
            //{
            //    Name = "Tamer",
            //};
            //Student S11 = new Student()
            //{
            //    Name = "Salma",
            //};
            //Student S12 = new Student()
            //{
            //    Name = "Mostafa",
            //};
            //Student S13 = new Student()
            //{
            //    Name = "Sara",
            //};
            //Student S14 = new Student()
            //{
            //    Name = "Hassan",
            //};
            //Student S15 = new Student()
            //{
            //    Name = "Dina",
            //};
            //Student S16 = new Student()
            //{
            //    Name = "Ali",
            //};
            //Student S17 = new Student()
            //{
            //    Name = "Marwa",
            //};
            //Student S18 = new Student()
            //{
            //    Name = "Youssef",
            //};
            //Student S19 = new Student()
            //{
            //    Name = "Farah",
            //};
            //Student S20 = new Student()
            //{
            //    Name = "Ziad",
            //};
            #endregion
            #region Courses Data
            //Course C01 = new Course()
            //{
            //    Title = "C#",
            //};
            //Course C02 = new Course()
            //{
            //    Title = "OOP",
            //};
            //Course C03 = new Course()
            //{
            //    Title = "DataStructure",
            //};
            //Course C04 = new Course()
            //{
            //    Title = "Algorithem",
            //};
            #endregion
            #region student data
            //dbContext.Students.Add(S01);
            //dbContext.Students.Add(S02);
            //dbContext.Students.Add(S03);
            //dbContext.Students.Add(S04);
            #endregion
            #region course data
            //dbContext.Courses.Add(C01);
            //dbContext.Courses.Add(C02);
            //dbContext.Courses.Add(C03);
            //dbContext.Courses.Add(C04); 
            #endregion
            #region student course data
            //StudentCourse SC01 = new StudentCourse() { StudentId = 1, CourseId = 1 };
            //StudentCourse SC02 = new StudentCourse() { StudentId = 1, CourseId = 2 };

            //StudentCourse SC03 = new StudentCourse() { StudentId = 2, CourseId = 1 };
            //StudentCourse SC04 = new StudentCourse() { StudentId = 2, CourseId = 3 };

            //StudentCourse SC05 = new StudentCourse() { StudentId = 3, CourseId = 2 };
            //StudentCourse SC06 = new StudentCourse() { StudentId = 3, CourseId = 4 };

            //StudentCourse SC07 = new StudentCourse() { StudentId = 4, CourseId = 1 };
            //StudentCourse SC08 = new StudentCourse() { StudentId = 4, CourseId = 4 };

            //StudentCourse SC09 = new StudentCourse() { StudentId = 1002, CourseId = 2 };
            //StudentCourse SC10 = new StudentCourse() { StudentId = 1002, CourseId = 3 };

            //StudentCourse SC11 = new StudentCourse() { StudentId = 1003, CourseId = 1 };
            //StudentCourse SC12 = new StudentCourse() { StudentId = 1003, CourseId = 3 };

            //StudentCourse SC13 = new StudentCourse() { StudentId = 1004, CourseId = 1 };
            //StudentCourse SC14 = new StudentCourse() { StudentId = 1004, CourseId = 2 };
            //StudentCourse SC15 = new StudentCourse() { StudentId = 1004, CourseId = 4 };

            //StudentCourse SC16 = new StudentCourse() { StudentId = 1005, CourseId = 2 };
            //StudentCourse SC17 = new StudentCourse() { StudentId = 1005, CourseId = 4 };

            //StudentCourse SC18 = new StudentCourse() { StudentId = 1006, CourseId = 3 };
            //StudentCourse SC19 = new StudentCourse() { StudentId = 1006, CourseId = 4 };

            //StudentCourse SC20 = new StudentCourse() { StudentId = 1007, CourseId = 1 };
            //StudentCourse SC21 = new StudentCourse() { StudentId = 1007, CourseId = 3 };

            //StudentCourse SC22 = new StudentCourse() { StudentId = 1008, CourseId = 1 };
            //StudentCourse SC23 = new StudentCourse() { StudentId = 1008, CourseId = 2 };

            //StudentCourse SC24 = new StudentCourse() { StudentId = 1009, CourseId = 3 };
            //StudentCourse SC25 = new StudentCourse() { StudentId = 1009, CourseId = 4 };

            //StudentCourse SC26 = new StudentCourse() { StudentId = 1010, CourseId = 1 };
            //StudentCourse SC27 = new StudentCourse() { StudentId = 1010, CourseId = 4 };

            //StudentCourse SC28 = new StudentCourse() { StudentId = 1011, CourseId = 2 };
            //StudentCourse SC29 = new StudentCourse() { StudentId = 1011, CourseId = 3 };

            //StudentCourse SC30 = new StudentCourse() { StudentId = 1012, CourseId = 1 };
            //StudentCourse SC31 = new StudentCourse() { StudentId = 1012, CourseId = 3 };

            //StudentCourse SC32 = new StudentCourse() { StudentId = 1013, CourseId = 2 };
            //StudentCourse SC33 = new StudentCourse() { StudentId = 1013, CourseId = 4 };

            //StudentCourse SC34 = new StudentCourse() { StudentId = 1014, CourseId = 1 };
            //StudentCourse SC35 = new StudentCourse() { StudentId = 1014, CourseId = 2 };
            //StudentCourse SC36 = new StudentCourse() { StudentId = 1014, CourseId = 3 };

            //StudentCourse SC37 = new StudentCourse() { StudentId = 1015, CourseId = 3 };
            //StudentCourse SC38 = new StudentCourse() { StudentId = 1015, CourseId = 4 };

            //StudentCourse SC39 = new StudentCourse() { StudentId = 1016, CourseId = 2 };
            //StudentCourse SC40 = new StudentCourse() { StudentId = 1016, CourseId = 3 };
            #region Remove Data
            //var r = (from sc in dbContext.StudentCourses
            //         select sc);
            //foreach (var item in r)
            //{
            //    dbContext.StudentCourses.Remove(item);
            //} 
            //dbContext.SaveChanges();
            #endregion
            #endregion
            #region Retrieve Student data [Quires]
            //var students = (from sc in dbContext.StudentCourses
            //                join s in dbContext.Students on sc.StudentId equals s.Id
            //                join c in dbContext.Courses on sc.CourseId equals c.Id
            //                select new
            //                {
            //                    s.Name,
            //                    c.Title,
            //                });

            //var student01 = (from sc in dbContext.StudentCourses
            //                 join s in dbContext.Students on sc.StudentId equals s.Id
            //                 join c in dbContext.Courses on sc.CourseId equals c.Id
            //                 where sc.CourseId == 2
            //                 select new
            //                 {
            //                     s.Name,
            //                     c.Title
            //                 });

            //var course01 = (from sc in dbContext.StudentCourses
            //                 join s in dbContext.Students on sc.StudentId equals s.Id
            //                 join c in dbContext.Courses on sc.CourseId equals c.Id
            //                 where sc.CourseId == 2
            //                 select new
            //                 {           
            //                     c.Title
            //                 }).FirstOrDefault();

            //var student01 = (from sc in dbContext.StudentCourses
            //                 where sc.StudentId == 2 && sc.CourseId == 1
            //                 select  sc).FirstOrDefault();
            #endregion
            #region Join
            //var employees = (from e in dbContext.Employees
            //                 where e.DepartmentId == null
            //                 select e);
            //foreach (var employee in employees)
            //{
            //    employee.DepartmentId = 2;
            //}
            //dbContext.SaveChanges();

            //var employeesinDepartmentId = (from e in dbContext.Employees
            //                               join d in dbContext.Departments on e.DepartmentId equals d.DepId
            //                               where e.DepartmentId == 2
            //                               select new
            //                               {
            //                                   EmployeeName = e.Name,
            //                                   DepartmentName = d.DepName,
            //                               });

            //employeesinDepartmentId = dbContext.Employees.Join(dbContext.Departments,
            //    E => E.DepartmentId,
            //    D => D.DepId,
            //    (E, D) => new
            //    {
            //        EmployeeName = E.Name,
            //        DepartmentName = D.DepName,
            //    });
            // groub students that have the same course
            //var Result = dbContext.StudentCourses.Where(SC => SC.CourseId == 2).Join(dbContext.Students,
            //                        SC => SC.StudentId,
            //                        S => S.Id,
            //                        (SC, S) => new
            //                        {
            //                            SC.CourseId,
            //                            S.Name
            //                        }).Join(dbContext.Courses,
            //                        SC=>SC.CourseId,
            //                        C=>C.Id,
            //                        (SC,C) => new
            //                        {
            //                            SC.Name,
            //                            C.Title
            //                        });

            //Result = (from sc in dbContext.StudentCourses
            //          where sc.CourseId == 2
            //          join s in dbContext.Students on sc.StudentId equals s.Id
            //          join c in dbContext.Courses on sc.CourseId equals c.Id
            //          select new
            //          {
            //              s.Name,
            //              c.Title
            //          });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Name: {item.Name} | Title: {item.Title}"); 
            //}

            //var numStudents = dbContext.StudentCourses
            //    .GroupBy(sc => sc.CourseId)
            //    .Select(g => new
            //    {
            //        Id = g.Key,
            //        Count = g.Count()
            //    })
            //    .Join(dbContext.Courses,
            //    sc => sc.Id, c => c.Id,
            //    (sc, c) =>
            //    new
            //    {
            //        CourseID = c.Id,
            //        Count = sc.Count,
            //        Title = c.Title                    
            //    });

            //var numStudents = dbContext.Courses
            //     .GroupJoin(dbContext.StudentCourses
            //     , C => C.Id
            //     , SC => SC.CourseId
            //     , (C, SC) => new
            //     {
            //         Title = C.Title,
            //         count = SC.Count()
            //     });

            //var result = (from sc in dbContext.StudentCourses
            //             join s in dbContext.Students on sc.StudentId equals s.Id
            //             join c in dbContext.Courses on sc.CourseId equals c.Id
            //             select new
            //             {
            //                 s.Name,
            //                 c.Title
            //             }).OrderBy(s=>s.Name);
            #endregion
            #region View
            // view 
            // 1. create empty migration
            // 2. add view to migration
            // 3. ubdate database

            // retrieve data on view
            //name of atributes should be the same as the name of the columns in the view
            //identify the view in the context class 
            //at ModelCreating method  Identify Class as View and has no key 

            #endregion
            #region Tracking & No Tracking
            //dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var e = (from E in dbContext.Employees
            //         where E.EmpId == 21
            //         select E).FirstOrDefault();

            //Console.WriteLine(dbContext.Entry(e).State);
            //e.Name = "MO";
            //Console.WriteLine(dbContext.Entry(e).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(e).State);

            #endregion

            #region Explecit Loading & Eager Loading & Lazy Loading
            // Explecit Loading
            //var employee = (from E in dbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();
            //dbContext.Entry(employee).Reference(E => E.Department).Load();
            //Console.WriteLine($"{employee.Department.DepName}");

            //var dept = (from D in dbContext.Departments
            //            where D.DepId == 1
            //            select D).FirstOrDefault();
            //dbContext.Entry(dept).Collection(D => D.Employees).Load();
            //foreach (var emp in dept.Employees)
            //{
            //    Console.WriteLine($"{emp.Name}");
            //}

            // Eager Loading
            //var dept = (from D in dbContext.Departments.Include(D => D.Employees)
            //            where D.DepId == 1
            //            select D).FirstOrDefault();
            //foreach(var emp in dept.Employees)
            //{
            //    Console.WriteLine($"{emp.Name}");
            //}

            // Lazy Loading
            // classes should be public 
            // navigation properties should be virtual
            var dept = (from D in dbContext.Departments
                        where D.DepId == 1
                        select D).FirstOrDefault();
            foreach (var emp in dept.Employees)
            {
                Console.WriteLine($"{emp.Name}");
            }

            //var employees = (from E in dbContext.Employees
            //                 join D in dbContext.Departments on E.DepartmentId equals D.DepId
            //                 where D.DepId == 2
            //                 select new
            //                 {
            //                     EmployeeId = E.EmpId,
            //                     EmployeeName = E.Name,
            //                     DepartmentId = D.DepId,
            //                     DepartmentName = D.DepName,
            //                 });
            //foreach (var e in employees)
            //    Console.WriteLine($"EmpId = {e.EmployeeId} , EmpName = {e.EmployeeName} , " +
            //        $"DepartmentId = {e.DepartmentId} , DepartmentName = {e.DepartmentName}");

            #endregion
        }

    }

}   