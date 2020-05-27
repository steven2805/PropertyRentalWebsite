using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalWebPortal.Data.Migrations
{
    public partial class moredetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "Propertys",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Propertys",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ListedDate",
                table: "Propertys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Propertys");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Propertys");

            migrationBuilder.DropColumn(
                name: "ListedDate",
                table: "Propertys");
        }
    }
}
