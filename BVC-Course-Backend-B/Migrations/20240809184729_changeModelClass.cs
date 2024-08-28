using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BVC_Course_Backend_B.Migrations
{
    /// <inheritdoc />
    public partial class changeModelClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseName",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeacherName",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseName",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TeacherName",
                table: "Classes");
        }
    }
}
