using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class yeni1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateNull",
                schema: "public",
                table: "Ils",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoNull",
                schema: "public",
                table: "Ils",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateNull",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropColumn(
                name: "NoNull",
                schema: "public",
                table: "Ils");
        }
    }
}
