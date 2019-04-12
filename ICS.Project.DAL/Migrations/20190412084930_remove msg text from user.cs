using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class removemsgtextfromuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageText",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageText",
                table: "Users",
                nullable: true);
        }
    }
}
