using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDataTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionalUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InstitutionalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionalDocument = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionalUsers", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_InstitutionalUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstitutionalUsers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
