using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class removeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "ID",
                keyValue: new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "UserInTeam",
                keyColumn: "ID",
                keyValue: new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "The Lewd Turtles" },
                    { new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", "Black Wariors" },
                    { new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", "The Six Eagles" },
                    { new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca85"), "Mel at viris fuisset, vis diceret meliore ut.", "The Jagged Penguins" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IsLoggedIn", "IterationCount", "LastLogoutTime", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"), "student@fit", false, 10007, new DateTime(2019, 4, 4, 14, 13, 50, 0, DateTimeKind.Unspecified), "Student", new byte[] { 202, 82, 20, 32, 112, 253, 84, 38, 27, 97, 23, 217, 243, 164, 66, 10 }, new byte[] { 163, 239, 2, 208, 228, 143, 175, 191, 180, 132, 51, 246, 231, 59, 71, 67, 111, 210, 241, 123, 21, 17, 125, 143, 167, 195, 204, 109, 188, 100, 47, 255 }, "Roberts" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"), null, false, 0, new DateTime(2019, 4, 18, 18, 47, 24, 0, DateTimeKind.Unspecified), "Regan", null, null, "Wiggins" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), null, false, 0, new DateTime(2019, 3, 24, 14, 55, 36, 0, DateTimeKind.Unspecified), "Kimberl", null, null, "Cohen" },
                    { new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"), null, false, 0, new DateTime(2019, 4, 28, 14, 24, 11, 0, DateTimeKind.Unspecified), "Kelley", null, null, "Watts" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(2019, 2, 1, 3, 31, 12, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), "Mediocrem" },
                    { new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(2019, 2, 1, 12, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), "Imperdiet" },
                    { new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 3, 1, 1, 8, 54, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), "Novum" },
                    { new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(2019, 1, 1, 8, 36, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), "Splendide" },
                    { new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(2019, 5, 14, 18, 21, 7, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), "Euismod" },
                    { new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(2019, 4, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"), "Putent" }
                });

            migrationBuilder.InsertData(
                table: "UserInTeam",
                columns: new[] { "ID", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85") },
                    { new Guid("1c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85") },
                    { new Guid("2c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85") },
                    { new Guid("3c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-37e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85") },
                    { new Guid("4c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85") },
                    { new Guid("7c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85") },
                    { new Guid("5c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85") },
                    { new Guid("8c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85") },
                    { new Guid("6c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85") },
                    { new Guid("9c16e27a-07e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "AuthorId", "MessageText", "PostId", "PublishDate" },
                values: new object[,]
                {
                    { new Guid("dc16e27a-07e2-0f47-b09d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"), new DateTime(2019, 2, 1, 5, 12, 4, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b19d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"), new DateTime(2019, 2, 3, 4, 17, 40, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b29d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"), new DateTime(2019, 3, 10, 11, 19, 31, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-0f47-b39d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"), "Mel at viris fuisset, vis diceret meliore ut.", new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca85"), new DateTime(2019, 3, 10, 11, 20, 39, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), "Ad his pertinacia assueverit conclusionemque.", new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca85"), new DateTime(2019, 2, 12, 7, 13, 52, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca85"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"), new DateTime(2019, 3, 1, 1, 14, 2, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), "Quo clita quaeque id, ei vel invenire persecuti.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca85"), new DateTime(2019, 3, 1, 2, 4, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca85"), "o exerci nonumes has, sit in sumo assum dissentias.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"), new DateTime(2019, 1, 1, 7, 14, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca85"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca85"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca85"), new DateTime(2019, 1, 1, 7, 15, 50, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
