using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB.Migrations
{
    public partial class bot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin_bot_ens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_bot_ens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bot_ens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Admin_bot_en_id = table.Column<int>(type: "int", nullable: false),
                    Admin_bot_enId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bot_ens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bot_ens_Admin_bot_ens_Admin_bot_enId",
                        column: x => x.Admin_bot_enId,
                        principalTable: "Admin_bot_ens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bot_ens_Admin_bot_enId",
                table: "Bot_ens",
                column: "Admin_bot_enId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bot_ens");

            migrationBuilder.DropTable(
                name: "Admin_bot_ens");
        }
    }
}
