using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedRolesToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "891c0721-f23b-49c2-bbda-3e59b0c20f36", "2fe7570c-b4dc-437b-abc7-088febc8f346", "User", "USER" },
                    { "5d61cf78-e527-43bd-92ec-35518c889ace", "e0413bc1-1a5a-4860-b0cb-79cc2e2926a8", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 984, DateTimeKind.Local).AddTicks(9385), new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3583), new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3600), new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3605), new DateTime(2021, 9, 15, 19, 19, 4, 987, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6058), new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6080), new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6085), new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6090), new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6095), new DateTime(2021, 9, 15, 19, 19, 4, 988, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(285), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(305), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(310), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(315), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(325), new DateTime(2021, 9, 15, 19, 19, 4, 989, DateTimeKind.Local).AddTicks(327) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d61cf78-e527-43bd-92ec-35518c889ace");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891c0721-f23b-49c2-bbda-3e59b0c20f36");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 658, DateTimeKind.Local).AddTicks(7770), new DateTime(2021, 9, 15, 19, 6, 33, 660, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(386), new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(402), new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(408), new DateTime(2021, 9, 15, 19, 6, 33, 661, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3286), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3320), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3325), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3330), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3336), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7610), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7630), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7636), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7641), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7646), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7651), new DateTime(2021, 9, 15, 19, 6, 33, 662, DateTimeKind.Local).AddTicks(7653) });
        }
    }
}
