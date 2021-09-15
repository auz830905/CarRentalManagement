using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedInitDataForConfigurationVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 15, 19, 6, 33, 658, DateTimeKind.Local).AddTicks(7770), "RED", "System", new DateTime(2021, 9, 15, 19, 6, 33, 660, DateTimeKind.Local).AddTicks(9784) },
                    { 2, "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(386), "BLACK", "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(399) },
                    { 3, "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(402), "BLUE", "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(405) },
                    { 4, "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(408), "WHITE", "System", new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(410) }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3286), "Toyota", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3315) },
                    { 2, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3320), "BMW", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3322) },
                    { 3, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3325), "Ferrari", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3328) },
                    { 4, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3330), "AUDI", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3333) },
                    { 5, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3336), "Lada", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3338) }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreateBy", "CreateDate", "Name", "UpdateBy", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7610), "Auris", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7625) },
                    { 2, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7630), "Avensis", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7633) },
                    { 3, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7636), "Enso", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7638) },
                    { 4, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7641), "A1", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7643) },
                    { 5, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7646), "A8", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7648) },
                    { 6, "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7651), "2107", "System", new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7653) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
