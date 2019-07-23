using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class IsCustom_Other : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCustom",
                table: "Package",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Location",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Location",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "Location",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "EventLocation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "EventLocation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "EventLocation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Location_AdministratorId",
                table: "Location",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLocation_AdministratorId",
                table: "EventLocation",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventLocation_AspNetUsers_AdministratorId",
                table: "EventLocation",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_AspNetUsers_AdministratorId",
                table: "Location",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventLocation_AspNetUsers_AdministratorId",
                table: "EventLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_AspNetUsers_AdministratorId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_AdministratorId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_EventLocation_AdministratorId",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "IsCustom",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "EventLocation");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "EventLocation");
        }
    }
}
