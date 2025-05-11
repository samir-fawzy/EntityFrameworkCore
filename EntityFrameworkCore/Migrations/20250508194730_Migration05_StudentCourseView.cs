using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Migration05_StudentCourseView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view StudentCourseView
                                    with Encryption
                                    as
	                                    select 
		                                    S.Id as StudentId,
		                                    S.Name as StudentName,
		                                    C.Id as CourseId,
		                                    C.Title as Title
	                                    from 
		                                    StudentCourses SC
		                                    join Students as S on SC.StudentId = S.Id
		                                    join Courses as C on SC.CourseId = C.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view StudentCourseView");
        }
    }
}
