using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedCompanyID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6991), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6994), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6997), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6997), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6998), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6999), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7000), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7000), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7001), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7002), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Email", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Tech City", "Fusin@fh.com", "FuxionX", "76546e5763", "265768728", "Lagos", "23 ajug ayca Lagos" },
                    { 2, "Devils City", "SDX@fh.com", "SDX", "76546e5763", "265768728", "Lagos", "23 Ddevi ayca Lagos" },
                    { 3, "Agric City", "Agridiv@fh.com", "AgridivX", "76546e5763", "265768728", "Enugu", "23 rds ayca Lagos" },
                    { 4, "Mech City", "Mech@fh.com", "MechWeldX", "76546e5763", "265768728", "Enugu", "23 yefv ayca Lagos" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7276), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7284), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7286), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7287), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7290), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7292), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7292), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7295), new DateTime(2023, 12, 31, 5, 23, 17, 778, DateTimeKind.Utc).AddTicks(7295) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
