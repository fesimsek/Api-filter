using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication5.Migrations
{
    public partial class yeni5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ils_Users_UserId",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_Customer_ID",
                schema: "public",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tanimlars_Birim",
                schema: "public",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_Userid",
                schema: "public",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Customers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Filters",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Group_Permissions",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Group_Users",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Ilces",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Log_Olc_Cihazlars",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Loggers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Mail_Ayars",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Mail_Havuzus",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Cihaz_User_Pers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Cihazlar_Auds",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Dogrulamas",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Iskartas",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Paramaters",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Rapors",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Taleps",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Progs",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Groups",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Revins",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Kal_Olcum_Sebeps",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Cihazlars",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Imalatcis",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Olc_Cihaz_Grups",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Tanimlars",
                schema: "public");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "public",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Birim",
                schema: "public",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_Customer_ID",
                schema: "public",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "public",
                newName: "User",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Userid",
                schema: "public",
                table: "User",
                newName: "IX_User_Userid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "public",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ils_User_UserId",
                schema: "public",
                table: "Ils",
                column: "UserId",
                principalSchema: "public",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_Userid",
                schema: "public",
                table: "User",
                column: "Userid",
                principalSchema: "public",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ils_User_UserId",
                schema: "public",
                table: "Ils");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_Userid",
                schema: "public",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "public",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "public",
                newName: "Users",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_User_Userid",
                schema: "public",
                table: "Users",
                newName: "IX_Users_Userid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "public",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customername = table.Column<string>(name: "Customer name", type: "text", nullable: true),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Filters",
                schema: "public",
                columns: table => new
                {
                    Field = table.Column<string>(type: "text", nullable: false),
                    Operator = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Field);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Il_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Ils_Il_ID",
                        column: x => x.Il_ID,
                        principalSchema: "public",
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilces_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imalatcis",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imalatcis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imalatcis_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kal_Olcum_Sebeps",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kal_Olcum_Sebeps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kal_Olcum_Sebeps_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loggers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loggers_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mail_Ayars",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail_Ayars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mail_Ayars_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mail_Havuzus",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail_Havuzus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mail_Havuzus_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Cihaz_Grups",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Cihaz_Grups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olc_Cihaz_Grups_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paramaters",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paramaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paramaters_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Progs",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progs_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rapors",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rapors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rapors_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Revins",
                schema: "public",
                columns: table => new
                {
                    Rev = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revins", x => x.Rev);
                });

            migrationBuilder.CreateTable(
                name: "Tanimlars",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tanimlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tanimlars_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Group_Users",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Group_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Users_Groups_Group_ID",
                        column: x => x.Group_ID,
                        principalSchema: "public",
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Users_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Group_Permissions",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Group_ID = table.Column<int>(type: "integer", nullable: false),
                    Permission_ID = table.Column<int>(type: "integer", nullable: false),
                    Program_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Permissions_Groups_Group_ID",
                        column: x => x.Group_ID,
                        principalSchema: "public",
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Permissions_Permissions_Permission_ID",
                        column: x => x.Permission_ID,
                        principalSchema: "public",
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Permissions_Progs_Program_ID",
                        column: x => x.Program_ID,
                        principalSchema: "public",
                        principalTable: "Progs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_Permissions_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Cihazlar_Auds",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rev = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Cihazlar_Auds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olc_Cihazlar_Auds_Revins_Rev",
                        column: x => x.Rev,
                        principalSchema: "public",
                        principalTable: "Revins",
                        principalColumn: "Rev",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Log_Olc_Cihazlars",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_Grup_ID = table.Column<int>(type: "integer", nullable: false),
                    Imalatci_ID = table.Column<int>(type: "integer", nullable: false),
                    Kont_Tip_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log_Olc_Cihazlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Log_Olc_Cihazlars_Imalatcis_Imalatci_ID",
                        column: x => x.Imalatci_ID,
                        principalSchema: "public",
                        principalTable: "Imalatcis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Log_Olc_Cihazlars_Olc_Cihaz_Grups_Cihaz_Grup_ID",
                        column: x => x.Cihaz_Grup_ID,
                        principalSchema: "public",
                        principalTable: "Olc_Cihaz_Grups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Log_Olc_Cihazlars_Tanimlars_Kont_Tip_ID",
                        column: x => x.Kont_Tip_ID,
                        principalSchema: "public",
                        principalTable: "Tanimlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Log_Olc_Cihazlars_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Cihazlars",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_Grup_ID = table.Column<int>(type: "integer", nullable: false),
                    Imalatci_ID = table.Column<int>(type: "integer", nullable: false),
                    Kont_Tip_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Cihazlars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olc_Cihazlars_Imalatcis_Imalatci_ID",
                        column: x => x.Imalatci_ID,
                        principalSchema: "public",
                        principalTable: "Imalatcis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Cihazlars_Olc_Cihaz_Grups_Cihaz_Grup_ID",
                        column: x => x.Cihaz_Grup_ID,
                        principalSchema: "public",
                        principalTable: "Olc_Cihaz_Grups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Cihazlars_Tanimlars_Kont_Tip_ID",
                        column: x => x.Kont_Tip_ID,
                        principalSchema: "public",
                        principalTable: "Tanimlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Cihazlars_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Cihaz_User_Pers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_ID = table.Column<int>(type: "integer", nullable: false),
                    CihazUserID = table.Column<int>(name: "Cihaz User ID", type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Cihaz_User_Pers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olc_Cihaz_User_Pers_Olc_Cihazlars_Cihaz_ID",
                        column: x => x.Cihaz_ID,
                        principalSchema: "public",
                        principalTable: "Olc_Cihazlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Cihaz_User_Pers_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Dogrulamas",
                schema: "public",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Dogrulamas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Olc_Dogrulamas_Olc_Cihazlars_Cihaz_ID",
                        column: x => x.Cihaz_ID,
                        principalSchema: "public",
                        principalTable: "Olc_Cihazlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Dogrulamas_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Olc_Iskartas",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_Id = table.Column<int>(type: "integer", nullable: false),
                    OnayRedEden = table.Column<int>(name: "Onay Red Eden", type: "integer", nullable: false),
                    TalepEden = table.Column<int>(name: "Talep Eden", type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Olc_Iskartas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Olc_Iskartas_Olc_Cihazlars_Cihaz_Id",
                        column: x => x.Cihaz_Id,
                        principalSchema: "public",
                        principalTable: "Olc_Cihazlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Olc_Iskartas_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Taleps",
                schema: "public",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cihaz_ID = table.Column<int>(type: "integer", nullable: false),
                    Kalibrasyon_Sebep = table.Column<int>(type: "integer", nullable: false),
                    TalepEden = table.Column<int>(name: "Talep Eden", type: "integer", nullable: false),
                    User_ID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taleps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Taleps_Kal_Olcum_Sebeps_Kalibrasyon_Sebep",
                        column: x => x.Kalibrasyon_Sebep,
                        principalSchema: "public",
                        principalTable: "Kal_Olcum_Sebeps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Taleps_Olc_Cihazlars_Cihaz_ID",
                        column: x => x.Cihaz_ID,
                        principalSchema: "public",
                        principalTable: "Olc_Cihazlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Taleps_Users_User_ID",
                        column: x => x.User_ID,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Birim",
                schema: "public",
                table: "Users",
                column: "Birim");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Customer_ID",
                schema: "public",
                table: "Users",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_User_ID",
                schema: "public",
                table: "Customers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Permissions_Group_ID",
                schema: "public",
                table: "Group_Permissions",
                column: "Group_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Permissions_Permission_ID",
                schema: "public",
                table: "Group_Permissions",
                column: "Permission_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Permissions_Program_ID",
                schema: "public",
                table: "Group_Permissions",
                column: "Program_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Permissions_User_ID",
                schema: "public",
                table: "Group_Permissions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Users_Group_ID",
                schema: "public",
                table: "Group_Users",
                column: "Group_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Group_Users_User_ID",
                schema: "public",
                table: "Group_Users",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_User_ID",
                schema: "public",
                table: "Groups",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_Il_ID",
                schema: "public",
                table: "Ilces",
                column: "Il_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_User_ID",
                schema: "public",
                table: "Ilces",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Imalatcis_User_ID",
                schema: "public",
                table: "Imalatcis",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Kal_Olcum_Sebeps_User_ID",
                schema: "public",
                table: "Kal_Olcum_Sebeps",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_Olc_Cihazlars_Cihaz_Grup_ID",
                schema: "public",
                table: "Log_Olc_Cihazlars",
                column: "Cihaz_Grup_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_Olc_Cihazlars_Imalatci_ID",
                schema: "public",
                table: "Log_Olc_Cihazlars",
                column: "Imalatci_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_Olc_Cihazlars_Kont_Tip_ID",
                schema: "public",
                table: "Log_Olc_Cihazlars",
                column: "Kont_Tip_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Log_Olc_Cihazlars_User_ID",
                schema: "public",
                table: "Log_Olc_Cihazlars",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Loggers_User_ID",
                schema: "public",
                table: "Loggers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Mail_Ayars_User_ID",
                schema: "public",
                table: "Mail_Ayars",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Mail_Havuzus_User_ID",
                schema: "public",
                table: "Mail_Havuzus",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihaz_Grups_User_ID",
                schema: "public",
                table: "Olc_Cihaz_Grups",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihaz_User_Pers_Cihaz_ID",
                schema: "public",
                table: "Olc_Cihaz_User_Pers",
                column: "Cihaz_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihaz_User_Pers_User_ID",
                schema: "public",
                table: "Olc_Cihaz_User_Pers",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihazlar_Auds_Rev",
                schema: "public",
                table: "Olc_Cihazlar_Auds",
                column: "Rev");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihazlars_Cihaz_Grup_ID",
                schema: "public",
                table: "Olc_Cihazlars",
                column: "Cihaz_Grup_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihazlars_Imalatci_ID",
                schema: "public",
                table: "Olc_Cihazlars",
                column: "Imalatci_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihazlars_Kont_Tip_ID",
                schema: "public",
                table: "Olc_Cihazlars",
                column: "Kont_Tip_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Cihazlars_User_ID",
                schema: "public",
                table: "Olc_Cihazlars",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Dogrulamas_Cihaz_ID",
                schema: "public",
                table: "Olc_Dogrulamas",
                column: "Cihaz_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Dogrulamas_User_ID",
                schema: "public",
                table: "Olc_Dogrulamas",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Iskartas_Cihaz_Id",
                schema: "public",
                table: "Olc_Iskartas",
                column: "Cihaz_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Olc_Iskartas_User_ID",
                schema: "public",
                table: "Olc_Iskartas",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Paramaters_User_ID",
                schema: "public",
                table: "Paramaters",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_User_ID",
                schema: "public",
                table: "Permissions",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Progs_User_ID",
                schema: "public",
                table: "Progs",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Rapors_User_ID",
                schema: "public",
                table: "Rapors",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Taleps_Cihaz_ID",
                schema: "public",
                table: "Taleps",
                column: "Cihaz_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Taleps_Kalibrasyon_Sebep",
                schema: "public",
                table: "Taleps",
                column: "Kalibrasyon_Sebep");

            migrationBuilder.CreateIndex(
                name: "IX_Taleps_User_ID",
                schema: "public",
                table: "Taleps",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tanimlars_User_ID",
                schema: "public",
                table: "Tanimlars",
                column: "User_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ils_Users_UserId",
                schema: "public",
                table: "Ils",
                column: "UserId",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_Customer_ID",
                schema: "public",
                table: "Users",
                column: "Customer_ID",
                principalSchema: "public",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tanimlars_Birim",
                schema: "public",
                table: "Users",
                column: "Birim",
                principalSchema: "public",
                principalTable: "Tanimlars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_Userid",
                schema: "public",
                table: "Users",
                column: "Userid",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
