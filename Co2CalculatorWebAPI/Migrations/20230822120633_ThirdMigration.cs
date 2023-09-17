using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Co2CalculatorWebAPI.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InputTypeId",
                table: "Inputs",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "InputType",
                columns: table => new
                {
                    InputTypeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputType", x => x.InputTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Inputs_InputTypeId",
                table: "Inputs",
                column: "InputTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inputs_InputType_InputTypeId",
                table: "Inputs",
                column: "InputTypeId",
                principalTable: "InputType",
                principalColumn: "InputTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inputs_InputType_InputTypeId",
                table: "Inputs");

            migrationBuilder.DropTable(
                name: "InputType");

            migrationBuilder.DropIndex(
                name: "IX_Inputs_InputTypeId",
                table: "Inputs");

            migrationBuilder.DropColumn(
                name: "InputTypeId",
                table: "Inputs");
        }
    }
}
