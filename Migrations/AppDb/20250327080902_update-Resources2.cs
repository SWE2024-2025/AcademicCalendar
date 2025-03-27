using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademicYearCalendar.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class updateResources2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Resources_GroupId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "IsGroup",
                table: "Resources");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Resources",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_GroupId",
                table: "Resources",
                newName: "IX_Resources_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Resources_ParentId",
                table: "Resources",
                column: "ParentId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Resources_ParentId",
                table: "Resources");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Resources",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Resources_ParentId",
                table: "Resources",
                newName: "IX_Resources_GroupId");

            migrationBuilder.AddColumn<bool>(
                name: "IsGroup",
                table: "Resources",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Resources_GroupId",
                table: "Resources",
                column: "GroupId",
                principalTable: "Resources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
