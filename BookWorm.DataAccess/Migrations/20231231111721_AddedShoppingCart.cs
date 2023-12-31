using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedShoppingCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1337), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1347), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1351), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1354), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1356), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1357), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1681), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1682), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1690), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1695), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1697), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 12, 31, 11, 17, 19, 772, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShoppingCarts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarts");

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
        }
    }
}
