using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class up2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudySubject_AcademicProgram_AcademicProgramId",
                table: "StudySubject");

            migrationBuilder.DropIndex(
                name: "IX_StudySubject_AcademicProgramId",
                table: "StudySubject");

            migrationBuilder.DropColumn(
                name: "AcademicProgramId",
                table: "StudySubject");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicProgramStudySubject");

            migrationBuilder.AddColumn<int>(
                name: "AcademicProgramId",
                table: "StudySubject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudySubject_AcademicProgramId",
                table: "StudySubject",
                column: "AcademicProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudySubject_AcademicProgram_AcademicProgramId",
                table: "StudySubject",
                column: "AcademicProgramId",
                principalTable: "AcademicProgram",
                principalColumn: "Id");
        }
    }
}
