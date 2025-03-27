using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class updateResources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Resources_GroupId",
                table: "Resources",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Resources_GroupId",
                table: "Resources",
                column: "GroupId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Resources_GroupId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_GroupId",
                table: "Resources");
        }
    }
}
