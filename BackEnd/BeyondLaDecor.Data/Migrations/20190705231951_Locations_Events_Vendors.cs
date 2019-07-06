using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class Locations_Events_Vendors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ServiceType",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ServiceTypeId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Service",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    VendorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_Vendor",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventLocation",
                columns: table => new
                {
                    EventLocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLocation", x => x.EventLocationId);
                    table.ForeignKey(
                        name: "FK_EventLocation_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventLocation_Location",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventLocation_EventId",
                table: "EventLocation",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLocation_LocationId",
                table: "EventLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Name",
                table: "Location",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Location_VendorId",
                table: "Location",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventLocation");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Service");

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ServiceTypeId",
                table: "Product",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ServiceType",
                table: "Product",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "ServiceTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
