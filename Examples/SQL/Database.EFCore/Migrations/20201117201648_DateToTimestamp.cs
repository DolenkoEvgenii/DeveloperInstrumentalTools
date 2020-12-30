using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.EFCore.Migrations
{
    public partial class DateToTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineType",
                table: "CarModel",
                newName: "TypeEngine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeEngine",
                table: "CarModel",
                newName: "EngineType");
        }
    }
}
