using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class up1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
