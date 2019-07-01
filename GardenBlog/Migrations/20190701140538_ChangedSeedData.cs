using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class ChangedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 7, new DateTime(2019, 7, 1, 10, 5, 37, 599, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 2, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 5, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 3, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 6, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 4, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { 1, new DateTime(2019, 7, 1, 10, 5, 37, 601, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 382, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 4,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 5,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 6,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 7,
                columns: new[] { "TagId", "TimeStamp" },
                values: new object[] { null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
