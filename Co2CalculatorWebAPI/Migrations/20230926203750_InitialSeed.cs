using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cultures",
                columns: new[] { "CultureId", "Name" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Corn" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Wheat" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Ray" }
                });

            migrationBuilder.InsertData(
                table: "InputType",
                columns: new[] { "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("72574ea7-47c4-4248-9a49-dde040ac47c1"), "Soil" },
                    { new Guid("b9dc67b4-df69-41fe-b06b-3294a939a0e0"), "Fuel" },
                    { new Guid("9b572fc7-4e71-400b-b66e-528b5dc90106"), "Pesticide" },
                    { new Guid("242e5514-ce39-4647-ad4d-a81516be7def"), "Fertilizer" }
                });

            migrationBuilder.InsertData(
                table: "Inputs",
                columns: new[] { "InputId", "Co2EqPerKgCoefficient", "Co2KgPerHa", "InputTypeId", "Name" },
                values: new object[,]
                {
                    { new Guid("1b7252ec-fe35-42df-9a6e-395ba4e6d7f0"), 0m, 4000m, new Guid("72574ea7-47c4-4248-9a49-dde040ac47c1"), "Soil1" },
                    { new Guid("47f0b104-dd1c-4775-be36-5503ce49794b"), 9.78m, 0m, new Guid("242e5514-ce39-4647-ad4d-a81516be7def"), "NitrogenFertilizer" },
                    { new Guid("2499f832-0843-4e0c-8beb-1ef53adecb00"), 0.73m, 0m, new Guid("242e5514-ce39-4647-ad4d-a81516be7def"), "Urea" },
                    { new Guid("3b32f09f-9ae3-4045-9f95-75300fe179b0"), 0.16m, 0m, new Guid("242e5514-ce39-4647-ad4d-a81516be7def"), "KaliumFertilizer" },
                    { new Guid("9540bca3-a5db-4729-abb5-9d5593ad7568"), 4.5m, 0m, new Guid("242e5514-ce39-4647-ad4d-a81516be7def"), "PhosphorusFertilizer" }
                });
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

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("9b572fc7-4e71-400b-b66e-528b5dc90106"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("b9dc67b4-df69-41fe-b06b-3294a939a0e0"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("1b7252ec-fe35-42df-9a6e-395ba4e6d7f0"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("2499f832-0843-4e0c-8beb-1ef53adecb00"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("3b32f09f-9ae3-4045-9f95-75300fe179b0"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("47f0b104-dd1c-4775-be36-5503ce49794b"));

            migrationBuilder.DeleteData(
                table: "Inputs",
                keyColumn: "InputId",
                keyValue: new Guid("9540bca3-a5db-4729-abb5-9d5593ad7568"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("242e5514-ce39-4647-ad4d-a81516be7def"));

            migrationBuilder.DeleteData(
                table: "InputType",
                keyColumn: "InputTypeId",
                keyValue: new Guid("72574ea7-47c4-4248-9a49-dde040ac47c1"));
        }
    }
}
