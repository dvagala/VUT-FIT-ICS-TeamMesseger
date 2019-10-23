using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ea"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55403"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca82"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55403"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "Black Wariors" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IterationCount", "LastActivity", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[] { new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca82"), "student@fit.cz", 10007, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asher", new byte[] { 63, 198, 247, 214, 110, 87, 223, 52, 73, 5, 178, 106, 122, 125, 141, 94 }, new byte[] { 98, 151, 12, 49, 37, 149, 252, 182, 99, 49, 232, 101, 229, 191, 139, 237, 52, 142, 77, 36, 0, 54, 120, 18, 56, 93, 167, 245, 12, 223, 128, 196 }, "Roberts" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "Title" },
                values: new object[] { new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ea"), new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca82"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });
        }
    }
}
