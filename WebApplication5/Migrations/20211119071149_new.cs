using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication5.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                schema: "public",
                table: "Ils",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customer name",
                schema: "public",
                table: "Customers",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateTable(
                name: "Filters",
                schema: "public",
                columns: table => new
                {
                    Logic = table.Column<string>(type: "text", nullable: false),
                    Field = table.Column<string>(type: "text", nullable: true),
                    Operator = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    FilterLogic = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Logic);
                    table.ForeignKey(
                        name: "FK_Filters_Filters_FilterLogic",
                        column: x => x.FilterLogic,
                        principalSchema: "public",
                        principalTable: "Filters",
                        principalColumn: "Logic",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filters_FilterLogic",
                schema: "public",
                table: "Filters",
                column: "FilterLogic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filters",
                schema: "public");

            migrationBuilder.DropColumn(
                name: "Ad",
                schema: "public",
                table: "Ils");

            migrationBuilder.AlterColumn<int>(
                name: "Customer name",
                schema: "public",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
