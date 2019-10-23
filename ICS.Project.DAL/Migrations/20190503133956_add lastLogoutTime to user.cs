using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class addlastLogoutTimetouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca83"));

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
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca83"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"));

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
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"));

            migrationBuilder.RenameColumn(
                name: "LastActivity",
                table: "Users",
                newName: "LastLogoutTime");

            migrationBuilder.AddColumn<bool>(
                name: "IsLoggedIn",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "The Lewd Turtles" },
                    { new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", "Black Wariors" },
                    { new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", "The Six Eagles" },
                    { new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca84"), "Mel at viris fuisset, vis diceret meliore ut.", "The Jagged Penguins" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IsLoggedIn", "IterationCount", "LastLogoutTime", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84"), "student@fit", false, 10007, new DateTime(2019, 4, 4, 14, 13, 50, 0, DateTimeKind.Unspecified), "Student", new byte[] { 19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35 }, new byte[] { 116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219, 28, 219, 147, 127, 133, 67, 116, 206, 143 }, "Roberts" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"), null, false, 0, new DateTime(2019, 4, 18, 18, 47, 24, 0, DateTimeKind.Unspecified), "Regan", null, null, "Wiggins" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), null, false, 0, new DateTime(2019, 3, 24, 14, 55, 36, 0, DateTimeKind.Unspecified), "Kimberl", null, null, "Cohen" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84"), null, false, 0, new DateTime(2019, 4, 28, 14, 24, 11, 0, DateTimeKind.Unspecified), "Kelley", null, null, "Watts" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(2019, 2, 1, 3, 31, 12, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), "Mediocrem" },
                    { new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(2019, 2, 1, 12, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), "Imperdiet" },
                    { new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 3, 1, 1, 8, 54, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), "Novum" },
                    { new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(2019, 1, 1, 8, 36, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), "Splendide" },
                    { new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(2019, 5, 14, 18, 21, 7, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), "Euismod" },
                    { new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(2019, 4, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84"), "Putent" }
                });

            migrationBuilder.InsertData(
                table: "UserInTeam",
                columns: new[] { "ID", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84") },
                    { new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84") },
                    { new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84") },
                    { new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84") },
                    { new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84") },
                    { new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84") },
                    { new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84") },
                    { new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84") },
                    { new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84") },
                    { new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "AuthorId", "MessageText", "PostId", "PublishDate" },
                values: new object[,]
                {
                    { new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"), new DateTime(2019, 2, 1, 5, 12, 4, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"), new DateTime(2019, 2, 3, 4, 17, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"), new DateTime(2019, 3, 10, 11, 19, 31, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84"), "Mel at viris fuisset, vis diceret meliore ut.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"), new DateTime(2019, 3, 10, 11, 20, 39, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), "Ad his pertinacia assueverit conclusionemque.", new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca84"), new DateTime(2019, 2, 12, 7, 13, 52, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca84"), new DateTime(2019, 3, 1, 1, 14, 2, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), "Quo clita quaeque id, ei vel invenire persecuti.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca84"), new DateTime(2019, 3, 1, 2, 4, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"), "o exerci nonumes has, sit in sumo assum dissentias.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca84"), new DateTime(2019, 1, 1, 7, 14, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca84"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca84"), new DateTime(2019, 1, 1, 7, 15, 50, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca84"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca84"));

            migrationBuilder.DropColumn(
                name: "IsLoggedIn",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "LastLogoutTime",
                table: "Users",
                newName: "LastActivity");

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
                    { new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "student@fit", 10007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Student", new byte[] { 19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35 }, new byte[] { 116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219, 28, 219, 147, 127, 133, 67, 116, 206, 143 }, "Roberts" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Regan", null, null, "Wiggins" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberl", null, null, "Cohen" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), null, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelley", null, null, "Watts" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(2019, 2, 1, 3, 31, 12, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Mediocrem" },
                    { new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(2019, 2, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Imperdiet" },
                    { new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 3, 1, 1, 8, 54, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Novum" },
                    { new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(2019, 1, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Splendide" },
                    { new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(2019, 5, 14, 18, 21, 7, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Euismod" },
                    { new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(2019, 4, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), "Putent" }
                });

            migrationBuilder.InsertData(
                table: "UserInTeam",
                columns: new[] { "ID", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("709ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("719ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("729ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("739ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83") },
                    { new Guid("749ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83") },
                    { new Guid("779ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83") },
                    { new Guid("759ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83") },
                    { new Guid("789ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83") },
                    { new Guid("769ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83") },
                    { new Guid("799ece27-ac92-4d56-a8aa-2016fa63a6eb"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "AuthorId", "MessageText", "PostId", "PublishDate" },
                values: new object[,]
                {
                    { new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new DateTime(2019, 2, 1, 5, 12, 4, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new DateTime(2019, 2, 3, 4, 17, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new DateTime(2019, 3, 10, 11, 19, 31, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new DateTime(2019, 3, 10, 11, 20, 39, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Ad his pertinacia assueverit conclusionemque.", new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca83"), new DateTime(2019, 2, 12, 7, 13, 52, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new DateTime(2019, 3, 1, 1, 14, 2, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new DateTime(2019, 3, 1, 2, 4, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "o exerci nonumes has, sit in sumo assum dissentias.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new DateTime(2019, 1, 1, 7, 14, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new DateTime(2019, 1, 1, 7, 15, 50, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
