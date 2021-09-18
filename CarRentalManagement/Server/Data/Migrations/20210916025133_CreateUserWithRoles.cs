using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class CreateUserWithRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d61cf78-e527-43bd-92ec-35518c889ac9",
                column: "ConcurrencyStamp",
                value: "38013ef7-c2bd-4081-873c-fa8c0cb42350");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891c0721-f23b-49c2-bbda-3e59b0c20f38",
                column: "ConcurrencyStamp",
                value: "071049ef-2a0b-440d-bd2f-f185d988fb94");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d61cf78-e527-43bd-92ec-35518c889ac9", "748b708f-69a3-45b5-b520-a95fe1417016" },
                    { "891c0721-f23b-49c2-bbda-3e59b0c20f38", "748b708f-69a3-45b5-b520-a95fe1417017" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3353d5d2-aaab-4ce5-ac6d-5ec4b6e8974c", "AQAAAAEAACcQAAAAEBhdxYljL46CVNTarxju/7uo8sPmm2ZGpenclyYMMAfw40lW5PyGu0vYQOPoaf12xg==", "8c44a430-97e3-42d7-a885-a8640b6c16fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4d6afa6-5ee5-4136-9f94-33442455534a", "AQAAAAEAACcQAAAAECzt2pZhrvSH3RO6jlik1UW40CtlrNAixJrGMALX2IytpCQ7kROwkDvqD6rsrp/SmA==", "80ea3889-b35c-464b-a756-d4f68eb1692c" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 794, DateTimeKind.Local).AddTicks(7369), new DateTime(2021, 9, 15, 22, 51, 32, 796, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(252), new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(268), new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(273), new DateTime(2021, 9, 15, 22, 51, 32, 797, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2658), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2680), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2685), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2690), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2695), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6812), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6831), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6836), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6841), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6846), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6851), new DateTime(2021, 9, 15, 22, 51, 32, 798, DateTimeKind.Local).AddTicks(6853) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d61cf78-e527-43bd-92ec-35518c889ac9", "748b708f-69a3-45b5-b520-a95fe1417016" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "891c0721-f23b-49c2-bbda-3e59b0c20f38", "748b708f-69a3-45b5-b520-a95fe1417017" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d61cf78-e527-43bd-92ec-35518c889ac9",
                column: "ConcurrencyStamp",
                value: "9d152a5b-32de-4a5c-a0c1-a7a973323d91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891c0721-f23b-49c2-bbda-3e59b0c20f38",
                column: "ConcurrencyStamp",
                value: "dfcb8561-4e6b-4799-b2e7-924bbe6ff403");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cc2eb1d-5763-4a46-a5f8-b2e8afdb2994", "AQAAAAEAACcQAAAAEFDzgCvx1ckXwBLnOiH+BkSiXrnDDnc4Zx3SXx+kC/4hTAF8lEPt4Xk/1/u5UtIgnA==", "afb7de8a-945d-4547-a659-f5d48a8e75cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc4492b4-bbe2-4b22-af4e-b74788b10828", "AQAAAAEAACcQAAAAEBkPa0ekrofVny7r5tjFj9jVkuwamBrJb+uMpoC7e9euIEq8+2MqXrWjaRMSXfGz8g==", "a3dc5dfb-8a25-4a3a-a1e9-8b6db1689dfe" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 970, DateTimeKind.Local).AddTicks(5367), new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8766), new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8784), new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8789), new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1912), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1941), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1946), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1952), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1956), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6804), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6833), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6839), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6844), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6849), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6854), new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6856) });
        }
    }
}
