using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedDatav1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 9, 50, 57, 239, DateTimeKind.Local).AddTicks(5752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 1, 9, 32, 45, 576, DateTimeKind.Local).AddTicks(4059));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 9, 32, 45, 576, DateTimeKind.Local).AddTicks(4059),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 1, 9, 50, 57, 239, DateTimeKind.Local).AddTicks(5752));
        }
    }
}
