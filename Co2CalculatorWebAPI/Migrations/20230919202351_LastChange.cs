using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class LastChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastChange",
                table: "Inputs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "CultureId", "Name" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Corn" });

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "CultureId", "Name" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Wheat" });

            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "CultureId", "Name" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Ray" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Cultures",
                keyColumn: "CultureId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DropColumn(
                name: "LastChange",
                table: "Inputs");
        }
    }
}
