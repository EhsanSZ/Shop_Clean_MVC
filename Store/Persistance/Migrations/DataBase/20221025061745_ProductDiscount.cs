using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations.DataBase
{
    public partial class ProductDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 527, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 527, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 83, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 524, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(2769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 526, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(9084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 523, DateTimeKind.Local).AddTicks(4661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(3860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 522, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 516, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.AddColumn<int>(
                name: "OldPrice",
                table: "CatalogItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentDiscount",
                table: "CatalogItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(9822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 518, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 517, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(4588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 515, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 65, DateTimeKind.Local).AddTicks(914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 455, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 515, DateTimeKind.Local).AddTicks(3661));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PercentDiscount",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 527, DateTimeKind.Local).AddTicks(6524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 527, DateTimeKind.Local).AddTicks(246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 524, DateTimeKind.Local).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 83, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 526, DateTimeKind.Local).AddTicks(157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 523, DateTimeKind.Local).AddTicks(4661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 522, DateTimeKind.Local).AddTicks(7367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 516, DateTimeKind.Local).AddTicks(5426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 518, DateTimeKind.Local).AddTicks(5953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 517, DateTimeKind.Local).AddTicks(5078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 515, DateTimeKind.Local).AddTicks(9859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 455, DateTimeKind.Local).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 65, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 18, 21, 46, 515, DateTimeKind.Local).AddTicks(3661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(414));
        }
    }
}
