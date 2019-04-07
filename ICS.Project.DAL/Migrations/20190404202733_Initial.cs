using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Emails",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Emails", x => x.ID); });

            migrationBuilder.CreateTable(
                "Users",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    LastActivity = table.Column<TimeSpan>(nullable: false),
                    EmailID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        "FK_Users_Emails_EmailID",
                        x => x.EmailID,
                        "Emails",
                        "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Comments",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AutorID = table.Column<Guid>(nullable: true),
                    MessageText = table.Column<string>(nullable: true),
                    PublishDate = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        "FK_Comments_Users_AutorID",
                        x => x.AutorID,
                        "Users",
                        "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Teams",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserEntityID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                    table.ForeignKey(
                        "FK_Teams_Users_UserEntityID",
                        x => x.UserEntityID,
                        "Users",
                        "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "Posts",
                table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AutorID = table.Column<Guid>(nullable: true),
                    PublishDate = table.Column<TimeSpan>(nullable: false),
                    MessageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    TeamEntityID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        "FK_Posts_Users_AutorID",
                        x => x.AutorID,
                        "Users",
                        "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Posts_Teams_TeamEntityID",
                        x => x.TeamEntityID,
                        "Teams",
                        "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Comments_AutorID",
                "Comments",
                "AutorID");

            migrationBuilder.CreateIndex(
                "IX_Posts_AutorID",
                "Posts",
                "AutorID");

            migrationBuilder.CreateIndex(
                "IX_Posts_TeamEntityID",
                "Posts",
                "TeamEntityID");

            migrationBuilder.CreateIndex(
                "IX_Teams_UserEntityID",
                "Teams",
                "UserEntityID");

            migrationBuilder.CreateIndex(
                "IX_Users_EmailID",
                "Users",
                "EmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Comments");

            migrationBuilder.DropTable(
                "Posts");

            migrationBuilder.DropTable(
                "Teams");

            migrationBuilder.DropTable(
                "Users");

            migrationBuilder.DropTable(
                "Emails");
        }
    }
}