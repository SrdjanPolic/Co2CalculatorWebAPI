using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class InputUpdateNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "InputType",
                columns: new[] { "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("c904cca1-4c6c-4bd9-98a9-139ea5d05b5f"), "Soil" },
                    { new Guid("294f7163-81e9-4ef1-a13c-307e493ead41"), "Fuel" },
                    { new Guid("e2d0ce72-0ab6-459d-b727-1976d7f6e938"), "Pesticide" },
                    { new Guid("d619ad71-0ada-410a-a4b4-51d231cd2407"), "Fertilizer" }
                });

            migrationBuilder.InsertData(
                table: "Inputs",
                columns: new[] { "InputId", "Co2EqPerKgCoefficient", "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("30675453-f7be-4cdf-b53c-69673e3e2628"), 9.78m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "NitrogenFertilizer" },
                    { new Guid("87ba49a5-65c6-4633-838b-e942341250ab"), 0.73m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "Urea" },
                    { new Guid("23fbc9cd-eb1b-4eac-9f1d-dfd74cf5b71d"), 0.16m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "KaliumFertilizer" },
                    { new Guid("59e8d239-d198-4fe5-8407-325968fbef36"), 4.5m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "PhosphorusFertilizer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("294f7163-81e9-4ef1-a13c-307e493ead41"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("c904cca1-4c6c-4bd9-98a9-139ea5d05b5f"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("d619ad71-0ada-410a-a4b4-51d231cd2407"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("e2d0ce72-0ab6-459d-b727-1976d7f6e938"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("23fbc9cd-eb1b-4eac-9f1d-dfd74cf5b71d"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("30675453-f7be-4cdf-b53c-69673e3e2628"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("59e8d239-d198-4fe5-8407-325968fbef36"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("87ba49a5-65c6-4633-838b-e942341250ab"));

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
    }
}
