using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AdjustedOnOrderHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDueDate",
                table: "OrderHeaders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7491), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7496), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7496), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7498), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7499), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7500), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7873), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7882), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7882), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7887), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7887) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7891), new DateTime(2024, 1, 1, 13, 1, 31, 670, DateTimeKind.Utc).AddTicks(7891) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "OrderHeaders");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PaymentDueDate",
                table: "OrderHeaders",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
