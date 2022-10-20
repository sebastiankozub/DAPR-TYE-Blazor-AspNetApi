using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Category", "Model", "Name", "ProductionYear" },
                values: new object[,]
                {
                    { new Guid("2bb26f6e-bc21-471c-b4fc-9dfbe359ead1"), "heavy lifter", "Ford", "John", 1955 },
                    { new Guid("3032144a-8aa1-4884-a4bc-c44919e40370"), "heavy lifter", "Opel", "John", 1939 },
                    { new Guid("3924250f-0c42-48af-9520-c78e230c599f"), "personal", "Ford", "Doe", 2021 },
                    { new Guid("6ee99129-bba5-459a-9d01-81625209e055"), "personal", "Hyundai", "Doe", 2025 },
                    { new Guid("9f6da19c-68ca-4550-980b-aa21c7bfddc4"), "personal", "Opel", "Doe", 2022 },
                    { new Guid("dd0070bd-d465-4dc8-9b60-4482ef53ad39"), "heavy lifter", "Hyundai", "John", 1933 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2bb26f6e-bc21-471c-b4fc-9dfbe359ead1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3032144a-8aa1-4884-a4bc-c44919e40370"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3924250f-0c42-48af-9520-c78e230c599f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6ee99129-bba5-459a-9d01-81625209e055"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("9f6da19c-68ca-4550-980b-aa21c7bfddc4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("dd0070bd-d465-4dc8-9b60-4482ef53ad39"));
        }
    }
}
