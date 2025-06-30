using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LimeHub.Migrations
{
    /// <inheritdoc />
    public partial class InforMoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EngineDisplacement",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FuelTransmission",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureYear",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViewsCount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearsUsed",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Condition", "EngineDisplacement", "FuelTransmission", "Location", "ManufactureYear", "Mileage", "PostedDate", "VehicleType", "ViewsCount", "YearsUsed" },
                values: new object[] { null, null, null, null, null, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "EngineDisplacement",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FuelTransmission",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ManufactureYear",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PostedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ViewsCount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "YearsUsed",
                table: "Products");
        }
    }
}
