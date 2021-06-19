using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsDevs.Migrations
{
    public partial class TeamMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    CareerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerDatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CareerYearsExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.CareerId);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMemberPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamMemberImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.TeamMemberId);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamMemberId", "TeamMemberImageUrl", "TeamMemberName", "TeamMemberPosition" },
                values: new object[,]
                {
                    { 1, "https://images.unsplash.com/photo-1586083702768-190ae093d34d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80", "PLEASURE NDHLOVU", "FOUNDER" },
                    { 2, "https://images.unsplash.com/photo-1560241804-02b7b1bc9d55?ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8bWFufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80", "SURPRISE MDLULI", "CO-FOUNDER" },
                    { 3, "https://i.pinimg.com/originals/b5/d3/54/b5d354063dae4723a18195174019fc73.jpg", "SAM JONE", "ARCHITECTURE" },
                    { 4, "https://images.unsplash.com/photo-1544005313-94ddf0286df2?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8cGVyc29ufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80", "ABIGAIL MNISI", "SENIOR DEVELOPER" },
                    { 5, "https://images.unsplash.com/photo-1570158268183-d296b2892211?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTd8fGJsYWNrJTIwbWFsZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&w=1000&q=80", "PRINCE THWALA", "SENIOR DEVELOPER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
