using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class NukedandAddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    TagId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Indoor" },
                    { 2, "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "mulch" },
                    { 2, "ivy" },
                    { 3, "orange" },
                    { 4, "colorful" },
                    { 5, "high-maintenance" },
                    { 6, "easy-watering" },
                    { 7, "direct-sun" },
                    { 8, "low-maintenance" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Author", "Body", "CategoryId", "TagId", "TimeStamp", "Title" },
                values: new object[,]
                {
                    { 1, "Blair", "I've found that the spider plant is the most effective at cleaning the air in my home. As someone with asthma, I can attest that this plant has done wonders for my breathing!", 1, null, new DateTime(2019, 7, 1, 3, 0, 48, 382, DateTimeKind.Local), "Spider Plant" },
                    { 2, "Bridget", "I know this plant is easy to care for inside, but does anyone else have an issue with the ivy climbing on every other plant within a 5 mile radius? Asking for a friend...", 1, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "English Ivy" },
                    { 3, "Kyle", "I just planted a burning bush off my back porch and the leaves all fell off within the week. Is it dead or just didn't take the transplant well?", 1, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "Burning Bush" },
                    { 6, "Miranda", "I just came across this entire acre field that plants sunflowers every year outside of Avon. It's so gorgeous, you have to check it out! It's so bright and yellow, and such a fun walk thorugh the field, it's a must do in the 2 weeks they're in full bloom!", 1, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "Sunflowers" },
                    { 4, "Elise", "Last year I planted 4 asiatic lily plants and after my dog dug them up on multiple occassions, I just assumed they were dead. But this year, I have 9 plants growing! I'm so excited!", 2, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "Asiatic Lilies" },
                    { 5, "Peter", "I have a little bird bath fountain that I just put lily pads in. Now I have a couple peepers and the birds seem to not be using it anymore. Do you think the frogs scared them away? Or are birds scared of lily pads and I just didn't know about it?", 2, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "Lily Pads" },
                    { 7, "Travis", "Black mulch beware!! I've found that the black mulch actually has overheated my softer plants. Just make sure to keep a good eye out on your plants after laying mulch. The black mulch tends to fade rather quickly, so the first 2 weeks are key.", 2, null, new DateTime(2019, 7, 1, 3, 0, 48, 383, DateTimeKind.Local), "Mulch" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 3, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TagId",
                table: "Posts",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
