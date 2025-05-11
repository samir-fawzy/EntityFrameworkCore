using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Migration04_EmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view EmployeeDepartmentView
                                with Encryption
                                as 
	                                select 
		                                E.EmpId as EmployeeId ,
		                                E.Name as EmployeeName , 
		                                D.DepId as DepartmentId , 
		                                D.DepName as DepartmentName
	                                from Employees E 
	                                join Departments as D on E.DepartmentId = D.DepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view EmployeeDepartmentView");
        }
    }
}
