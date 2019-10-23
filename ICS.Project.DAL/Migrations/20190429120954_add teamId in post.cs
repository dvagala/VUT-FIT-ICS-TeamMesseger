using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class addteamIdinpost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-0f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-1f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-2f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-27e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e27b-07e2-0f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Mediocrem" },
                    { new Guid("ec16e27b-17e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Novum" },
                    { new Guid("ec16e27b-27e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Euismod" },
                    { new Guid("ec16e27b-07e2-1f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Splendide" },
                    { new Guid("ec16e27b-17e2-2f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Imperdiet" },
                    { new Guid("ec16e27b-07e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), "Putent" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"),
                column: "Email",
                value: "student@fit");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TeamId",
                table: "Posts",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Teams_TeamId",
                table: "Posts",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Teams_TeamId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TeamId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-07e2-0f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-07e2-1f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-07e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-17e2-2f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-17e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27b-27e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-0f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mediocrem" },
                    { new Guid("ec16e27a-17e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Novum" },
                    { new Guid("ec16e27a-27e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Euismod" },
                    { new Guid("ec16e27a-07e2-1f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Splendide" },
                    { new Guid("ec16e27a-17e2-2f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Imperdiet" },
                    { new Guid("ec16e27a-07e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Putent" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"),
                column: "Email",
                value: "student@fit.cz");
        }
    }
}
