using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeededDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "061f9022-a4b7-40fb-bb42-28062c22b87d", 0, "Devils City", "c84590e2-d603-4071-b491-d7ecd8383f2b", "CompanyUser", "SDX@fh.com", false, false, null, "SDX", null, null, null, "76546e5763", false, "265768728", "75cdd11e-f07e-4d79-b86d-f8c98bbc23c2", "Lagos", "23 Ddevi ayca Lagos", false, null },
                    { "95d0f856-cfc2-435c-92f2-aea0d58de6fb", 0, "Mech City", "a2480e72-1d42-4f6a-a539-90887fad4146", "CompanyUser", "Mech@fh.com", false, false, null, "MechWeldX", null, null, null, "76546e5763", false, "265768728", "850c8ab3-7f15-4c61-be8b-8bb5c5b8f2c0", "Enugu", "23 yefv ayca Lagos", false, null },
                    { "a1c21176-1390-4488-8e02-310361e80838", 0, "Agric City", "b7ee6d40-c025-4e0f-a19f-e51517263d07", "CompanyUser", "Agridiv@fh.com", false, false, null, "AgridivX", null, null, null, "76546e5763", false, "265768728", "a4563978-9915-40de-a444-ee48a1003b7f", "Enugu", "23 rds ayca Lagos", false, null },
                    { "c21ddc51-1dd4-4fe2-8567-e8ce9952fed4", 0, "Tech City", "6c20db97-01a7-4858-abce-6f1260aa0833", "CompanyUser", "Fusin@fh.com", false, false, null, "FuxionX", null, null, null, "76546e5763", false, "265768728", "fac9dd4c-c414-4b66-923c-7c250927e39e", "Lagos", "23 ajug ayca Lagos", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(12), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(27), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(376), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(378), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(390), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(391), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(396), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(398), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(398), new DateTime(2023, 12, 31, 5, 10, 42, 231, DateTimeKind.Utc).AddTicks(398) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "061f9022-a4b7-40fb-bb42-28062c22b87d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95d0f856-cfc2-435c-92f2-aea0d58de6fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1c21176-1390-4488-8e02-310361e80838");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c21ddc51-1dd4-4fe2-8567-e8ce9952fed4");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9555), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9563), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9567), new DateTime(2023, 12, 31, 4, 29, 43, 654, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(59), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(60), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(66), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(67), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(70), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(71), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(74), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(75), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(78), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(79), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(82), new DateTime(2023, 12, 31, 4, 29, 43, 655, DateTimeKind.Utc).AddTicks(81) });
        }
    }
}
