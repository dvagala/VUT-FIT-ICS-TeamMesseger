using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class changeseedstudenthash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 202, 82, 20, 32, 112, 253, 84, 38, 27, 97, 23, 217, 243, 164, 66, 10 }, new byte[] { 163, 239, 2, 208, 228, 143, 175, 191, 180, 132, 51, 246, 231, 59, 71, 67, 111, 210, 241, 123, 21, 17, 125, 143, 167, 195, 204, 109, 188, 100, 47, 255 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca85"),
                columns: new[] { "PasswordHash", "Salt" },
                values: new object[] { new byte[] { 19, 36, 234, 204, 83, 41, 69, 76, 27, 40, 176, 157, 35, 181, 37, 35 }, new byte[] { 116, 214, 110, 237, 125, 7, 30, 5, 219, 149, 182, 93, 62, 91, 71, 69, 105, 152, 66, 44, 114, 122, 219, 28, 219, 147, 127, 133, 67, 116, 206, 143 } });
        }
    }
}
