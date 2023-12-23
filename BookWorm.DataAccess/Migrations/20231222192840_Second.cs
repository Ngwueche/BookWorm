using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8814), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8819), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8825), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8826), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8827), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8828), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8829), new DateTime(2023, 12, 22, 19, 28, 37, 301, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Hoover", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "CAW777777701", 40.0, 30.0, 20.0, 25.0, "Dark Skies" },
                    { 3, "Julian Button", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" },
                    { 4, "Abby Muscles", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" },
                    { 5, "Ron Parker", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "SOTJ1111111101", 30.0, 27.0, 20.0, 25.0, "Rock in the Ocean" },
                    { 6, "Laura Phantom", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1026), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1028), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1033), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1121) });
        }
    }
}
