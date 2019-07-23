using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class Event_Location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "LocationName",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "TableCount",
                table: "Event");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "EventLocation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "EventLocation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "EventLocation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableCount",
                table: "EventLocation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "TableCount",
                table: "EventLocation");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Event",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TableCount",
                table: "Event",
                nullable: true);
        }
    }
}
