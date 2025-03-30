using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class adduserfullname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicProgramStudySubject");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AcademicProgram");

            migrationBuilder.DropTable(
                name: "StudySubject");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AcademicProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudySubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudySubject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcademicProgramStudySubject",
                columns: table => new
                {
                    AcademicProgramsId = table.Column<int>(type: "int", nullable: false),
                    StudySubjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicProgramStudySubject", x => new { x.AcademicProgramsId, x.StudySubjectsId });
                    table.ForeignKey(
                        name: "FK_AcademicProgramStudySubject_AcademicProgram_AcademicProgramsId",
                        column: x => x.AcademicProgramsId,
                        principalTable: "AcademicProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicProgramStudySubject_StudySubject_StudySubjectsId",
                        column: x => x.StudySubjectsId,
                        principalTable: "StudySubject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicProgramStudySubject_StudySubjectsId",
                table: "AcademicProgramStudySubject",
                column: "StudySubjectsId");
        }
    }
}
