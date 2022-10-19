﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations.DataBase
{
    public partial class UserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 725, DateTimeKind.Local).AddTicks(1813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 102, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 723, DateTimeKind.Local).AddTicks(7533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 101, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 724, DateTimeKind.Local).AddTicks(7532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 102, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 724, DateTimeKind.Local).AddTicks(3623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 101, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 723, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 100, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 670, DateTimeKind.Local).AddTicks(8585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 66, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 722, DateTimeKind.Local).AddTicks(7103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 99, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.CreateTable(
                name: "userAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 725, DateTimeKind.Local).AddTicks(6110)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userAddresses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userAddresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 102, DateTimeKind.Local).AddTicks(4690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 725, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 101, DateTimeKind.Local).AddTicks(678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 723, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 102, DateTimeKind.Local).AddTicks(492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 724, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 101, DateTimeKind.Local).AddTicks(6691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 724, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 100, DateTimeKind.Local).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 723, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 66, DateTimeKind.Local).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 670, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 16, 22, 43, 45, 99, DateTimeKind.Local).AddTicks(6677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 19, 20, 22, 46, 722, DateTimeKind.Local).AddTicks(7103));
        }
    }
}
