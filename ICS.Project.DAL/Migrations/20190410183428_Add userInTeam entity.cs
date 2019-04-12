using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class AdduserInTeamentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Teams_TeamEntityID",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Users_UserEntityID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_UserEntityID",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TeamEntityID",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserEntityID",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamEntityID",
                table: "Posts");

            migrationBuilder.AddColumn<string>(
                name: "MessageText",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserInTeam",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    TeamID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInTeam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserInTeam_Teams_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserInTeam_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInTeam_TeamID",
                table: "UserInTeam",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInTeam_UserID",
                table: "UserInTeam",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInTeam");

            migrationBuilder.DropColumn(
                name: "MessageText",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityID",
                table: "Teams",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TeamEntityID",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserEntityID",
                table: "Teams",
                column: "UserEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TeamEntityID",
                table: "Posts",
                column: "TeamEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Teams_TeamEntityID",
                table: "Posts",
                column: "TeamEntityID",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Users_UserEntityID",
                table: "Teams",
                column: "UserEntityID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
