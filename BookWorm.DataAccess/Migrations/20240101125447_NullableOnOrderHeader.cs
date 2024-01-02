using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class NullableOnOrderHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(598), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(803), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(804), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(809), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(810), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(813), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(817), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(818), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 1, 1, 12, 54, 46, 394, DateTimeKind.Utc).AddTicks(820) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
