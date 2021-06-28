using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsDevs.Migrations
{
    public partial class CareerModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CareerClosingDate",
                table: "Careers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CareerLocation",
                table: "Careers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareerClosingDate",
                table: "Careers");

            migrationBuilder.DropColumn(
                name: "CareerLocation",
                table: "Careers");
        }
    }
}
