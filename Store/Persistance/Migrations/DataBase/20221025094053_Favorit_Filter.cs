using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations.DataBase
{
    public partial class Favorit_Filter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 580, DateTimeKind.Local).AddTicks(6908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 580, DateTimeKind.Local).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 579, DateTimeKind.Local).AddTicks(2771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 83, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 579, DateTimeKind.Local).AddTicks(9413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 578, DateTimeKind.Local).AddTicks(5809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 578, DateTimeKind.Local).AddTicks(774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 576, DateTimeKind.Local).AddTicks(2728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.AddColumn<int>(
                name: "VisitCount",
                table: "CatalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 577, DateTimeKind.Local).AddTicks(6717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 577, DateTimeKind.Local).AddTicks(3108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 575, DateTimeKind.Local).AddTicks(7703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 533, DateTimeKind.Local).AddTicks(8867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 65, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 575, DateTimeKind.Local).AddTicks(3389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.CreateTable(
                name: "CatalogItemFavourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 577, DateTimeKind.Local).AddTicks(24)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItemFavourites_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemFavourites_CatalogItemId",
                table: "CatalogItemFavourites",
                column: "CatalogItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId",
                principalTable: "CatalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_CatalogItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "CatalogItemFavourites");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "VisitCount",
                table: "CatalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(9900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 580, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(6072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 580, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 83, DateTimeKind.Local).AddTicks(6000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 579, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 84, DateTimeKind.Local).AddTicks(2769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 579, DateTimeKind.Local).AddTicks(9413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(9084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 578, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 82, DateTimeKind.Local).AddTicks(3860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 578, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(9477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 576, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(9822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 577, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 81, DateTimeKind.Local).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 577, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(4588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 575, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 65, DateTimeKind.Local).AddTicks(914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 533, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 25, 9, 47, 44, 80, DateTimeKind.Local).AddTicks(414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 25, 13, 10, 51, 575, DateTimeKind.Local).AddTicks(3389));
        }
    }
}
