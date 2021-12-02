using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filters_Filters_FilterLogic",
                schema: "public",
                table: "Filters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filters",
                schema: "public",
                table: "Filters");

            migrationBuilder.DropIndex(
                name: "IX_Filters_FilterLogic",
                schema: "public",
                table: "Filters");

            migrationBuilder.DropColumn(
                name: "Logic",
                schema: "public",
                table: "Filters");

            migrationBuilder.DropColumn(
                name: "FilterLogic",
                schema: "public",
                table: "Filters");

            migrationBuilder.DropColumn(
                name: "Value",
                schema: "public",
                table: "Filters");

            migrationBuilder.AlterColumn<string>(
                name: "Field",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filters",
                schema: "public",
                table: "Filters",
                column: "Field");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Filters",
                schema: "public",
                table: "Filters");

            migrationBuilder.AlterColumn<string>(
                name: "Field",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Logic",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FilterLogic",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filters",
                schema: "public",
                table: "Filters",
                column: "Logic");

            migrationBuilder.CreateIndex(
                name: "IX_Filters_FilterLogic",
                schema: "public",
                table: "Filters",
                column: "FilterLogic");

            migrationBuilder.AddForeignKey(
                name: "FK_Filters_Filters_FilterLogic",
                schema: "public",
                table: "Filters",
                column: "FilterLogic",
                principalSchema: "public",
                principalTable: "Filters",
                principalColumn: "Logic",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
