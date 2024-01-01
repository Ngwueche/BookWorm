using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderHearderAndOrderDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingCarts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    OrderTotal = table.Column<double>(type: "float", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PaymentIntentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderHeaderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
