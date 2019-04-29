using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class adduserpasswordseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ee"),
                column: "MessageText",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca81"),
                columns: new[] { "Email", "IterationCount", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[] { "student@fit.cz", 10007, "Asher", new byte[] { 63, 198, 247, 214, 110, 87, 223, 52, 73, 5, 178, 106, 122, 125, 141, 94 }, new byte[] { 98, 151, 12, 49, 37, 149, 252, 182, 99, 49, 232, 101, 229, 191, 139, 237, 52, 142, 77, 36, 0, 54, 120, 18, 56, 93, 167, 245, 12, 223, 128, 196 }, "Roberts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("7a9ece27-ac92-4d56-a8aa-2015fa63a6ee"),
                column: "MessageText",
                value: "MessageText");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed16e27a-47e2-4f47-b19d-4a362003ca81"),
                columns: new[] { "Email", "IterationCount", "Name", "PasswordHash", "Salt", "Surname" },
                values: new object[] { "ali@gmail.com", 0, "Alfonz", null, null, "Mike" });
        }
    }
}
