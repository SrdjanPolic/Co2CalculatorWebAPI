using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class LastChangeInputType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InputType",
                columns: new[] { "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("bcfc373e-9153-42f9-9722-ee5026e92146"), "Soil" },
                    { new Guid("7598708d-e196-4380-9d95-ba139a6f12c6"), "Fuel" },
                    { new Guid("d8c2cc2d-4c39-4295-a95c-7ba18175c0b2"), "Pesticide" },
                    { new Guid("7a5d6cf9-705d-463b-901e-fd1e30284154"), "Fertilizer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("7598708d-e196-4380-9d95-ba139a6f12c6"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("7a5d6cf9-705d-463b-901e-fd1e30284154"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("bcfc373e-9153-42f9-9722-ee5026e92146"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("d8c2cc2d-4c39-4295-a95c-7ba18175c0b2"));
        }
    }
}
