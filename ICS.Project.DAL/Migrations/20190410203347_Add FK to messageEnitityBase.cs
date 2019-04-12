using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class AddFKtomessageEnitityBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserEntity",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntity",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserEntity",
                table: "Posts",
                column: "UserEntity");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserEntity",
                table: "Comments",
                column: "UserEntity");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserEntity",
                table: "Comments",
                column: "UserEntity",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserEntity",
                table: "Posts",
                column: "UserEntity",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEntity",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserEntity",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserEntity",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserEntity",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserEntity",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserEntity",
                table: "Comments");
        }
    }
}
