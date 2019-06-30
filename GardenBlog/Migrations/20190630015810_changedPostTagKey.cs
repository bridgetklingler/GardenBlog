using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class changedPostTagKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "PostTagID",
                table: "PostTags");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags",
                columns: new[] { "PostId", "TagId" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags");

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.AddColumn<int>(
                name: "PostTagID",
                table: "PostTags",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags",
                column: "PostTagID");

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostTagID", "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 },
                    { 3, 3, 2 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags",
                column: "PostId");
        }
    }
}
