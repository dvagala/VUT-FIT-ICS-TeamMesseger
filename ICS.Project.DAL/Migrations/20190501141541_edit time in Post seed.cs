using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class edittimeinPostseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 2, 1, 3, 31, 12, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 3, 1, 1, 8, 54, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 5, 14, 18, 21, 7, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca83"),
                column: "PublishDate",
                value: new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
