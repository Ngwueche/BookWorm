using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddressToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3802), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4102), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4111), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4114), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4115), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4117), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4120), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4121), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4124), new DateTime(2024, 1, 1, 9, 38, 55, 651, DateTimeKind.Utc).AddTicks(4124) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8877), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8896), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9716), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9718), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9727), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9732), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9733), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9738), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9741), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9742), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9745), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9746), new DateTime(2024, 1, 1, 0, 55, 59, 767, DateTimeKind.Utc).AddTicks(9746) });
        }
    }
}
