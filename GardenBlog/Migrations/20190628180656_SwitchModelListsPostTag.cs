using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenBlog.Migrations
{
    public partial class SwitchModelListsPostTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagId",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags");

            migrationBuilder.DropIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "PostTags");

            migrationBuilder.AddColumn<int>(
                name: "PostTagId",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostTagId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_PostTagId",
                table: "Tags",
                column: "PostTagId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostTagId",
                table: "Posts",
                column: "PostTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostTags_PostTagId",
                table: "Posts",
                column: "PostTagId",
                principalTable: "PostTags",
                principalColumn: "PostTagID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_PostTags_PostTagId",
                table: "Tags",
                column: "PostTagId",
                principalTable: "PostTags",
                principalColumn: "PostTagID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostTags_PostTagId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_PostTags_PostTagId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_PostTagId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostTagId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostTagId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "PostTagId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "PostTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "PostTags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagId",
                table: "PostTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
