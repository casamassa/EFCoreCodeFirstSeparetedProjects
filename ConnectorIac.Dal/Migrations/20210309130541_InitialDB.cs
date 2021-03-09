using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConnectorIac.Dal.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ean = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductGroups_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalTable: "ProductGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2021, 3, 9, 10, 5, 41, 138, DateTimeKind.Local).AddTicks(9210), "Almoxarifado", true, new DateTime(2021, 3, 9, 10, 5, 41, 140, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.InsertData(
                table: "ProductGroups",
                columns: new[] { "Id", "CreatedAt", "Description", "Status", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2021, 3, 9, 10, 5, 41, 140, DateTimeKind.Local).AddTicks(2377), "Armazém", true, new DateTime(2021, 3, 9, 10, 5, 41, 140, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "Ean", "ExpirationDate", "Price", "ProductGroupId", "Status", "UpdatedAt", "Volume", "Weight" },
                values: new object[] { 1, "12547828", new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(3788), "Produto 1", "78554782447", new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(2781), 258m, 1, true, new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(4277), 254m, 188m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "Ean", "ExpirationDate", "Price", "ProductGroupId", "Status", "UpdatedAt", "Volume", "Weight" },
                values: new object[] { 2, "58712544", new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(5283), "Produto 2", "75547855547", new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(5261), 145m, 2, true, new DateTime(2021, 3, 9, 10, 5, 41, 142, DateTimeKind.Local).AddTicks(5292), 180m, 258m });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductGroupId",
                table: "Products",
                column: "ProductGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductGroups");
        }
    }
}
