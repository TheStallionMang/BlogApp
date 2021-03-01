using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApp.Data.Migrations
{
    public partial class DeletedAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_ApplicationUserId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BlogPost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "BlogPost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_ApplicationUserId",
                table: "BlogPost",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_AspNetUsers_ApplicationUserId",
                table: "BlogPost",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
