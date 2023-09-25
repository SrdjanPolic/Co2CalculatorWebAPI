using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class InputChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Co2EqPerKgAppliance",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "Co2EqPerKgProduction",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "LastChange",
                table: "Inputs");

            migrationBuilder.RenameColumn(
                name: "Co2EqPerUnit",
                table: "Inputs",
                newName: "Co2EqPerKgCoefficient");

            migrationBuilder.InsertData(
                table: "InputType",
                columns: new[] { "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("b95ffc1c-bca5-4d58-ba07-811a92def7dc"), "Soil" },
                    { new Guid("85801c86-c678-45f1-843a-f615ff5b6a43"), "Fuel" },
                    { new Guid("a9df09d9-8325-4018-9516-a0ac0c8e3467"), "Pesticide" },
                    { new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "Fertilizer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("85801c86-c678-45f1-843a-f615ff5b6a43"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("a9df09d9-8325-4018-9516-a0ac0c8e3467"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("b95ffc1c-bca5-4d58-ba07-811a92def7dc"));

            migrationBuilder.RenameColumn(
                name: "Co2EqPerKgCoefficient",
                table: "Inputs",
                newName: "Co2EqPerUnit");

            migrationBuilder.AddColumn<decimal>(
                name: "Co2EqPerKgAppliance",
                table: "Inputs",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Co2EqPerKgProduction",
                table: "Inputs",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChange",
                table: "Inputs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
