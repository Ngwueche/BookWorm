using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5676), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5679), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5680), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5682), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5682), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5684), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5684), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5686), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5686), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5848), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5859), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5867), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5870), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "ImageUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5873), "", new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5872) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5606), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5609), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5611), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5612), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5613), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5614), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5615), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5615), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5616), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5617), new DateTime(2023, 12, 23, 16, 20, 35, 430, DateTimeKind.Utc).AddTicks(5616) });
        }
    }
}
