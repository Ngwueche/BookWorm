using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirstnameToOrderHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "OrderHeaders",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8434), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8437), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8439), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8439), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8443), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9465), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9466), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9469), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9469), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9472), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9474), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9474), new DateTime(2024, 1, 2, 19, 1, 43, 921, DateTimeKind.Utc).AddTicks(9474) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "OrderHeaders",
                newName: "Name");

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
    }
}
