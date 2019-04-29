using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[] { new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55402"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "Black Wariors" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "IterationCount", "LastActivity", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[] { new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca81"), "ali@gmail.com", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfonz", null, null, "Mike" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "Title" },
                values: new object[] { new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ee"), new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca81"), "MessageText", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Title1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ee"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "ID",
                keyValue: new Guid("0924f8d4-18f1-43f6-b6f7-0be8a4f55402"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca81"));
        }
    }
}
