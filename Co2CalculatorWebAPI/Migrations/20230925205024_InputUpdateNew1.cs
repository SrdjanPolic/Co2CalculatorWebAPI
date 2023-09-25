using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class InputUpdateNew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("2c0f49a0-e74b-4542-bf93-c82bb9a2b8ff"), "Soil" },
                    { new Guid("854c37b3-8ea1-4080-b569-904410bd313f"), "Fuel" },
                    { new Guid("d1d73d63-c4be-4ce6-ad84-770bf620be47"), "Pesticide" },
                    { new Guid("3314fe3b-6af1-43d9-a417-e4af1b221038"), "Fertilizer" }
                });

            migrationBuilder.InsertData(
                table: "Inputs",
                columns: new[] { "InputId", "Co2EqPerKgCoefficient", "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("01906959-9e63-423a-8add-f6e3198ac9fa"), 9.78m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "NitrogenFertilizer" },
                    { new Guid("ff6ac44d-5539-4a8d-add5-aa71354aca81"), 0.73m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "Urea" },
                    { new Guid("8ab62401-e837-4bda-8c36-1b9aaf49300a"), 0.16m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "KaliumFertilizer" },
                    { new Guid("74e865a8-1fc6-4f18-8a6f-77778ff51fb7"), 4.5m, new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec"), "PhosphorusFertilizer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("2c0f49a0-e74b-4542-bf93-c82bb9a2b8ff"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("3314fe3b-6af1-43d9-a417-e4af1b221038"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("854c37b3-8ea1-4080-b569-904410bd313f"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("d1d73d63-c4be-4ce6-ad84-770bf620be47"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("01906959-9e63-423a-8add-f6e3198ac9fa"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("74e865a8-1fc6-4f18-8a6f-77778ff51fb7"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("8ab62401-e837-4bda-8c36-1b9aaf49300a"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("ff6ac44d-5539-4a8d-add5-aa71354aca81"));

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
    }
}
