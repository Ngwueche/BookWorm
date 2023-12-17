using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeededDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DisplayOrder", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1026), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1028), 1, "Fiction", new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1027) },
                    { 2, new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1032), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1033), 2, "SciFic", new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1033) },
                    { 3, new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1035), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1036), 3, "History", new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1036) },
                    { 4, new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1122), 4, "Horror", new DateTime(2023, 12, 10, 4, 27, 56, 500, DateTimeKind.Utc).AddTicks(1121) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
