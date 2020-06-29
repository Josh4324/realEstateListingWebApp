using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstateApp.Data.Migrations.ApplicationDb
{
    public partial class InitialApplicationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    DeleteAt = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    LocalGovernmentArea = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    DeleteAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Properties");
        }
    }
}
