using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class editauthorid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AutorID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserEntity",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AutorID",
                table: "Posts");

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

            migrationBuilder.RenameColumn(
                name: "AutorID",
                table: "Posts",
                newName: "AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AutorID",
                table: "Posts",
                newName: "IX_Posts_AutorId");

            migrationBuilder.RenameColumn(
                name: "AutorID",
                table: "Comments",
                newName: "AutorId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AutorID",
                table: "Comments",
                newName: "IX_Comments_AutorId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AutorId",
                table: "Comments",
                column: "AutorId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts",
                column: "AutorId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AutorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Posts",
                newName: "AutorID");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AutorId",
                table: "Posts",
                newName: "IX_Posts_AutorID");

            migrationBuilder.RenameColumn(
                name: "AutorId",
                table: "Comments",
                newName: "AutorID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AutorId",
                table: "Comments",
                newName: "IX_Comments_AutorID");

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorID",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntity",
                table: "Posts",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorID",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(Guid));

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
                name: "FK_Comments_Users_AutorID",
                table: "Comments",
                column: "AutorID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserEntity",
                table: "Comments",
                column: "UserEntity",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AutorID",
                table: "Posts",
                column: "AutorID",
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
    }
}
