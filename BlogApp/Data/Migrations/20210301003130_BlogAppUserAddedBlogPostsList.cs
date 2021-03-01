using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Data.Migrations
{
    public partial class BlogAppUserAddedBlogPostsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogAppUserId",
                table: "BlogPost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_BlogAppUserId",
                table: "BlogPost",
                column: "BlogAppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_BlogAppUser_BlogAppUserId",
                table: "BlogPost",
                column: "BlogAppUserId",
                principalTable: "BlogAppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_BlogAppUser_BlogAppUserId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_BlogAppUserId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "BlogAppUserId",
                table: "BlogPost");
        }
    }
}
