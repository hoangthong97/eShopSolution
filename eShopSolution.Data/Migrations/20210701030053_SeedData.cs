using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 10, 0, 52, 642, DateTimeKind.Local).AddTicks(2539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 1, 9, 53, 41, 616, DateTimeKind.Local).AddTicks(229));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 9, 53, 41, 616, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 1, 10, 0, 52, 642, DateTimeKind.Local).AddTicks(2539));
        }
    }
}
