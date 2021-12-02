using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ils_Users_User_ID",
                schema: "public",
                table: "Ils");

            migrationBuilder.RenameColumn(
                name: "User_ID",
                schema: "public",
                table: "Ils",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ils_User_ID",
                schema: "public",
                table: "Ils",
                newName: "IX_Ils_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ils_Users_UserId",
                schema: "public",
                table: "Ils",
                column: "UserId",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ils_Users_UserId",
                schema: "public",
                table: "Ils");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "public",
                table: "Ils",
                newName: "User_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Ils_UserId",
                schema: "public",
                table: "Ils",
                newName: "IX_Ils_User_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ils_Users_User_ID",
                schema: "public",
                table: "Ils",
                column: "User_ID",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
