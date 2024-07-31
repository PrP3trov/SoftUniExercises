using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicRecordsApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Exams",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Exams", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Students",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Students", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Grades",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Value = table.Column<decimal>(type: "decimal(3,2)", nullable: false),
            //        ExamId = table.Column<int>(type: "int", nullable: false),
            //        StudentId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Grades", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Grades_Exams",
            //            column: x => x.ExamId,
            //            principalTable: "Exams",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Grades_Students",
            //            column: x => x.StudentId,
            //            principalTable: "Students",
            //            principalColumn: "Id");
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_StudentsId",
                table: "StudentsCourses",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_ExamId",
                table: "Grades",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCourses");

            //migrationBuilder.DropTable(
            //    name: "Grades");

            migrationBuilder.DropTable(
                name: "Courses");

            //migrationBuilder.DropTable(
            //    name: "Exams");

            //migrationBuilder.DropTable(
            //    name: "Students");
        }
    }
}
