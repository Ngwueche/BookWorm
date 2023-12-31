using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCompanyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6956), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6959), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6961), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6962), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6963), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6963), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6964), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6965), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6966), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6966), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7095), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7096), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7102), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7103), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7105), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7108), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 12, 29, 4, 26, 3, 569, DateTimeKind.Utc).AddTicks(7113) });
        }
    }
}
