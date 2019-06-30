using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class ChangedPostTagFKsToVirtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 20, 41, 25, 805, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 20, 41, 25, 806, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 20, 41, 25, 806, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 16, 44, 5, 38, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 16, 44, 5, 39, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 16, 44, 5, 39, DateTimeKind.Local));
        }
    }
}
