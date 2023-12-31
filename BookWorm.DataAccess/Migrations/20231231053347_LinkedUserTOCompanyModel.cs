using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LinkedUserTOCompanyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5397), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5399), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5399), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5400), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5861), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5879), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 12, 31, 5, 33, 46, 176, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Companies_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AspNetUsers");

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
    }
}
