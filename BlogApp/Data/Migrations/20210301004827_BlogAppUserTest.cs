using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Data.Migrations
{
    public partial class BlogAppUserTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "BlogPosts",
                table: "BlogAppUser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogPosts",
                table: "BlogAppUser");

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
    }
}
