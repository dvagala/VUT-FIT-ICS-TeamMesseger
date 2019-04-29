using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class addmoreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55404"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca83"));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "The Lewd Turtles" },
                    { new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", "Black Wariors" },
                    { new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", "The Six Eagles" },
                    { new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", "The Jagged Penguins" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IterationCount", "LastActivity", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "student@fit.cz", 10007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", new byte[] { 19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35 }, new byte[] { 116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219, 28, 219, 147, 127, 133, 67, 116, 206, 143 }, "Roberts" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regan", null, null, "Wiggins" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberl", null, null, "Cohen" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelley", null, null, "Watts" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "AuthorId", "MessageText", "PostId", "PublishDate" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-0f47-b29d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-4f47-b59d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b19d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-1f47-b69d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "o exerci nonumes has, sit in sumo assum dissentias.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b09d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-1f47-b79d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-4f47-b49d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b39d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-2f47-b89d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Ad his pertinacia assueverit conclusionemque.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Putent" },
                    { new Guid("ec16e27a-17e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Novum" },
                    { new Guid("ec16e27a-07e2-1f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Splendide" },
                    { new Guid("ec16e27a-27e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Euismod" },
                    { new Guid("ec16e27a-17e2-2f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Imperdiet" },
                    { new Guid("ec16e27a-07e2-0f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mediocrem" }
                });

            migrationBuilder.InsertData(
                table: "UserInTeam",
                columns: new[] { "ID", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("789ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83") },
                    { new Guid("759ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83") },
                    { new Guid("779ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83") },
                    { new Guid("749ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83") },
                    { new Guid("739ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("729ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("719ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("709ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("769ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83") },
                    { new Guid("799ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-0f47-b09d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-0f47-b19d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-0f47-b29d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-0f47-b39d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-1f47-b69d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-1f47-b79d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-2f47-b89d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b49d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b59d-0f362003ca83"));

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

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("709ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("719ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("729ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("739ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("749ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("759ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("769ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("779ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("789ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("799ece27-ac92-4d56-a8aa-2016fa63a6eb"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"));

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55404"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "Black Wariors" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IterationCount", "LastActivity", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[] { new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca83"), "student@fit.cz", 10007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asher", new byte[] { 19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35 }, new byte[] { 116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219, 28, 219, 147, 127, 133, 67, 116, 206, 143 }, "Roberts" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "Title" },
                values: new object[] { new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6eb"), new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });
        }
    }
}
