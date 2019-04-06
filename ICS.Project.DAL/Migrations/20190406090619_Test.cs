using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Emails_EmailID",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropIndex(
                name: "IX_Users_EmailID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Surname");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastActivity",
                table: "Users",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<Guid>(
                name: "PostEntityID",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostEntityID",
                table: "Comments",
                column: "PostEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostEntityID",
                table: "Comments",
                column: "PostEntityID",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostEntityID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostEntityID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostEntityID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "UserName");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "LastActivity",
                table: "Users",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<Guid>(
                name: "EmailID",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "PublishDate",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "PublishDate",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailID",
                table: "Users",
                column: "EmailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Emails_EmailID",
                table: "Users",
                column: "EmailID",
                principalTable: "Emails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
