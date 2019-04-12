using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.BL.Migrations
{
    public partial class addFkstoMessageandComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AutorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostEntityID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostEntityID",
                table: "Comments",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostEntityID",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "AutorId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_AutorId",
                table: "Comments",
                column: "AutorId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts",
                column: "AutorId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_AutorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "Comments",
                newName: "PostEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                newName: "IX_Comments_PostEntityID");

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
                name: "FK_Comments_Posts_PostEntityID",
                table: "Comments",
                column: "PostEntityID",
                principalTable: "Posts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AutorId",
                table: "Posts",
                column: "AutorId",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
