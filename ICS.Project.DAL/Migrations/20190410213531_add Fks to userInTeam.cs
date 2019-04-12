using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class addFkstouserInTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInTeam_Teams_TeamID",
                table: "UserInTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInTeam_Users_UserID",
                table: "UserInTeam");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserInTeam",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "UserInTeam",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInTeam_UserID",
                table: "UserInTeam",
                newName: "IX_UserInTeam_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserInTeam_TeamID",
                table: "UserInTeam",
                newName: "IX_UserInTeam_TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInTeam_Teams_TeamId",
                table: "UserInTeam",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInTeam_Users_UserId",
                table: "UserInTeam",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInTeam_Teams_TeamId",
                table: "UserInTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInTeam_Users_UserId",
                table: "UserInTeam");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserInTeam",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "UserInTeam",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_UserInTeam_UserId",
                table: "UserInTeam",
                newName: "IX_UserInTeam_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserInTeam_TeamId",
                table: "UserInTeam",
                newName: "IX_UserInTeam_TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInTeam_Teams_TeamID",
                table: "UserInTeam",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInTeam_Users_UserID",
                table: "UserInTeam",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
