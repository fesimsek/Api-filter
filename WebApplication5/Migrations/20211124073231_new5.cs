using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operator",
                schema: "public",
                table: "Filters");

            migrationBuilder.RenameColumn(
                name: "Field",
                schema: "public",
                table: "Filters",
                newName: "PropertyName");

            migrationBuilder.AddColumn<string>(
                name: "Bolge",
                schema: "public",
                table: "Ils",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Operation",
                schema: "public",
                table: "Filters",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bolge",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropColumn(
                name: "Operation",
                schema: "public",
                table: "Filters");

            migrationBuilder.RenameColumn(
                name: "PropertyName",
                schema: "public",
                table: "Filters",
                newName: "Field");

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: true);
        }
    }
}
