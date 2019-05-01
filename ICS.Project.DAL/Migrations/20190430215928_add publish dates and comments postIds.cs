using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ICS.Project.DAL.Migrations
{
    public partial class addpublishdatesandcommentspostIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorId", "MessageText", "PublishDate", "TeamId", "Title" },
                values: new object[,]
                {
                    { new Guid("ec16e28b-07e2-0f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Mediocrem" },
                    { new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Novum" },
                    { new Guid("ec16e28b-27e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-07e2-4f47-b19d-0a362003ca83"), "Euismod" },
                    { new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", new DateTime(2019, 1, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Splendide" },
                    { new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", new DateTime(2019, 2, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-17e2-4f47-b19d-0a362003ca83"), "Imperdiet" },
                    { new Guid("ec16e28b-07e2-4f47-b19d-0b362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new DateTime(2019, 4, 1, 7, 13, 50, 0, DateTimeKind.Unspecified), new Guid("ec16e27a-27e2-4f47-b19d-0a362003ca83"), "Putent" }
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
                    { new Guid("dc16e27a-07e2-4f47-b49d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new DateTime(2019, 3, 1, 1, 14, 2, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-4f47-b59d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", new Guid("ec16e28b-17e2-4f47-b19d-0b362003ca83"), new DateTime(2019, 3, 1, 2, 4, 20, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b69d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "o exerci nonumes has, sit in sumo assum dissentias.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new DateTime(2019, 1, 1, 7, 14, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-1f47-b79d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", new Guid("ec16e28b-07e2-1f47-b19d-0b362003ca83"), new DateTime(2019, 1, 1, 7, 15, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc16e27a-07e2-2f47-b89d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Ad his pertinacia assueverit conclusionemque.", new Guid("ec16e28b-17e2-2f47-b19d-0b362003ca83"), new DateTime(2019, 2, 12, 7, 13, 52, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "AuthorId", "MessageText", "PostId", "PublishDate" },
                values: new object[,]
                {
                    { new Guid("ec16e27a-07e2-0f47-b09d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Pro eu tation saperet, et sea brute similique theophrastus. Nec ex verear facilisi conceptam, novum postulant definitiones mei at.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b19d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b29d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83"), "Partem scripta laoreet ei cum. Ea vel dico vocibus omittam, pro mollis tamquam efficiendi an.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-0f47-b39d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Mel at viris fuisset, vis diceret meliore ut.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-4f47-b49d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-3a362003ca83"), "Nec iudico soluta vocent id, qui ferri perfecto te. Quo id tota dicam volumus.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-4f47-b59d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Quo clita quaeque id, ei vel invenire persecuti.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-1f47-b69d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "o exerci nonumes has, sit in sumo assum dissentias.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-1f47-b79d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-1a362003ca83"), "Altera abhorreant referrentur eam ut, ne pro purto meis dolor.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec16e27a-07e2-2f47-b89d-0f362003ca83"), new Guid("ec16e27a-47e2-4f47-b19d-2a362003ca83"), "Ad his pertinacia assueverit conclusionemque.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
        }
    }
}
