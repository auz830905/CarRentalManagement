using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class CreateUserDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FistName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "748b708f-69a3-45b5-b520-a95fe1417017", 0, "bc4492b4-bbe2-4b22-af4e-b74788b10828", "adael@gmail.com", false, "System", "User", true, null, "ADAEL@GMAIL.COM", "ADAEL@GMAIL.COM", "AQAAAAEAACcQAAAAEBkPa0ekrofVny7r5tjFj9jVkuwamBrJb+uMpoC7e9euIEq8+2MqXrWjaRMSXfGz8g==", null, false, "a3dc5dfb-8a25-4a3a-a1e9-8b6db1689dfe", false, "adael@gmail.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417017");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d61cf78-e527-43bd-92ec-35518c889ac9",
                column: "ConcurrencyStamp",
                value: "48331909-705f-46e7-9d90-a6842b2a4d78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891c0721-f23b-49c2-bbda-3e59b0c20f38",
                column: "ConcurrencyStamp",
                value: "3ffef39c-22d8-4d3c-b445-4f543a1755d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748b708f-69a3-45b5-b520-a95fe1417016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "586ad32c-7c47-4546-b54a-fb100f748ae1", "AQAAAAEAACcQAAAAEBGIGuWqf64WKUYJnyBwt16hndQNyjZY3KmEOx0TpNzkNjiiUl9wQ/NBelx+AU5AtA==", "e2ac60fa-844e-4123-ad0a-0615d2e4c10f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FistName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "b190470a-9fad-4021-a335-6673d47d9b64", "adael@gmail.com", false, "System", "User", true, null, "ADAEL@GMAIL.COM", "ADAEL@GMAIL.COM", "AQAAAAEAACcQAAAAELYOadgy2tiJHoo/5+QrAejF2OTX+YJf3Yz5IdSxdKYEB4L9jEy/h1FbeL6S4ub+5g==", null, false, "d0196e4d-be1f-4559-9462-6827088775c0", false, "adael@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 981, DateTimeKind.Local).AddTicks(657), new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4134), new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4150), new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4155), new DateTime(2021, 9, 15, 22, 49, 33, 983, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7870), new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7904), new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7910), new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7915), new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7919), new DateTime(2021, 9, 15, 22, 49, 33, 984, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2058), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2079), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2085), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2090), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2095), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2100), new DateTime(2021, 9, 15, 22, 49, 33, 985, DateTimeKind.Local).AddTicks(2102) });
        }
    }
}
