using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Author", "Body", "CategoryId", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 1, "Blair", "This was so scary, it's scary", null, new DateTime(2019, 6, 28, 16, 45, 38, 209, DateTimeKind.Local), "Horror" },
                    { 2, "Bridget", "Soooo funny", null, new DateTime(2019, 6, 28, 16, 45, 38, 210, DateTimeKind.Local), "Comedy" },
                    { 3, "Travis", "Kinda Creepy", null, new DateTime(2019, 6, 28, 16, 45, 38, 210, DateTimeKind.Local), "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "funny" },
                    { 2, "scary" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostTagID", "PostId", "TagId" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostTagID", "PostId", "TagId" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostTagID", "PostId", "TagId" },
                values: new object[] { 3, 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumn: "PostTagID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumn: "PostTagID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumn: "PostTagID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);
        }
    }
}
