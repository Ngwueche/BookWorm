﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookWorm.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5847), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5867), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5870), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 12, 23, 20, 16, 23, 870, DateTimeKind.Utc).AddTicks(5872) });
        }
    }
}
