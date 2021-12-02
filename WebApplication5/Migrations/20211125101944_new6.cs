using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class new6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operation",
                schema: "public",
                table: "Filters");

            migrationBuilder.RenameColumn(
                name: "PropertyName",
                schema: "public",
                table: "Filters",
                newName: "Field");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                schema: "public",
                table: "Ils",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "No",
                schema: "public",
                table: "Ils",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                schema: "public",
                table: "Filters",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropColumn(
                name: "No",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropColumn(
                name: "Operator",
                schema: "public",
                table: "Filters");

            migrationBuilder.RenameColumn(
                name: "Field",
                schema: "public",
                table: "Filters",
                newName: "PropertyName");

            migrationBuilder.AddColumn<int>(
                name: "Operation",
                schema: "public",
                table: "Filters",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
