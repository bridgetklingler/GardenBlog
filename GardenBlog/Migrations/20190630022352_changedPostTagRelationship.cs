using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class changedPostTagRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Posts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 22, 23, 51, 587, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 22, 23, 51, 588, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 22, 23, 51, 588, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Tags_TagId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 21, 58, 10, 95, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 21, 58, 10, 96, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2019, 6, 29, 21, 58, 10, 96, DateTimeKind.Local));
        }
    }
}
