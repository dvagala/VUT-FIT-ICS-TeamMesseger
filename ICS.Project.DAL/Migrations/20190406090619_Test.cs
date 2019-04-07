using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Users_Emails_EmailID",
                "Users");

            migrationBuilder.DropTable(
                "Emails");

            migrationBuilder.DropIndex(
                "IX_Users_EmailID",
                "Users");

            migrationBuilder.DropColumn(
                "EmailID",
                "Users");

            migrationBuilder.RenameColumn(
                "UserName",
                "Users",
                "Surname");

            migrationBuilder.AlterColumn<DateTime>(
                "LastActivity",
                "Users",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<string>(
                "Email",
                "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                "Name",
                "Users",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                "PublishDate",
                "Posts",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AlterColumn<DateTime>(
                "PublishDate",
                "Comments",
                nullable: false,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<Guid>(
                "PostEntityID",
                "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                "IX_Comments_PostEntityID",
                "Comments",
                "PostEntityID");

            migrationBuilder.AddForeignKey(
                "FK_Comments_Posts_PostEntityID",
                "Comments",
                "PostEntityID",
                "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                "FK_Comments_Posts_PostEntityID",
                "Comments");

            migrationBuilder.DropIndex(
                "IX_Comments_PostEntityID",
                "Comments");

            migrationBuilder.DropColumn(
                "Email",
                "Users");

            migrationBuilder.DropColumn(
                "Name",
                "Users");

            migrationBuilder.DropColumn(
                "PostEntityID",
                "Comments");

            migrationBuilder.RenameColumn(
                "Surname",
                "Users",
                "UserName");

            migrationBuilder.AlterColumn<TimeSpan>(
                "LastActivity",
                "Users",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<Guid>(
                "EmailID",
                "Users",
                nullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                "PublishDate",
                "Posts",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<TimeSpan>(
                "PublishDate",
                "Comments",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateTable(
                "Emails",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Emails", x => x.ID); });

            migrationBuilder.CreateIndex(
                "IX_Users_EmailID",
                "Users",
                "EmailID");

            migrationBuilder.AddForeignKey(
                "FK_Users_Emails_EmailID",
                "Users",
                "EmailID",
                "Emails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}