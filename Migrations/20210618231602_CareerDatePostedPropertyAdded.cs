using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsDevs.Migrations
{
    public partial class CareerDatePostedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CareerDatePosted",
                table: "Careers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareerDatePosted",
                table: "Careers");
        }
    }
}
