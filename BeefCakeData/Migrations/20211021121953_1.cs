using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeefCakeData.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bmi = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "Id", "Bmi", "Calories", "Date", "UserId", "Weight" },
                values: new object[,]
                {
                    { 1, 22.2m, 3000, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1, 68.5m },
                    { 2, 23.3m, 3500, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, 80m },
                    { 3, 22.7m, 2000, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, 78m },
                    { 4, 18.6m, 1900, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 4, 54.0m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "Gender", "Height", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 175m, "Grzesiek" },
                    { 2, new DateTime(1982, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 185m, "Piotr" },
                    { 3, new DateTime(1994, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 185m, "Łukasz" },
                    { 4, new DateTime(1992, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 170m, "Sylwia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
