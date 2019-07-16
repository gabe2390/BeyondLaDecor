using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class DecorIdRemoval_AdministratorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_User",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_UserId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_InventoryId_UserId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "Setting");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ServiceVendor");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "ServiceVendor");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "ServiceVendor");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "ServiceType");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ProductServiceType");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "ProductServiceType");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "ProductServiceType");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "PackageService");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PackageProduct");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "PackageProduct");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "PackageProduct");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "EventType");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "DecorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AdminstratorId",
                table: "AspNetUsers",
                newName: "AdministratorId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AdminstratorId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AdministratorId");

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Vendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "ServiceType",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Service",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "ProductType",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "PackageService",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Package",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Inventory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Inventory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "Inventory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "EventType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_AdministratorId",
                table: "Vendor",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AdministratorId",
                table: "Task",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_AdministratorId",
                table: "ServiceType",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_AdministratorId",
                table: "Service",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_AdministratorId",
                table: "ProductType",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_AdministratorId",
                table: "Product",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageService_AdministratorId",
                table: "PackageService",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_AdministratorId",
                table: "Package",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_AdministratorId",
                table: "Inventory",
                column: "AdministratorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_InventoryId_AdministratorId",
                table: "Inventory",
                columns: new[] { "InventoryId", "AdministratorId" });

            migrationBuilder.CreateIndex(
                name: "IX_EventType_AdministratorId",
                table: "EventType",
                column: "AdministratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_EventType",
                table: "EventType",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_User",
                table: "Inventory",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Administrator",
                table: "Package",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageService_AspNetUsers_AdministratorId",
                table: "PackageService",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Administrator",
                table: "Product",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_ProductType",
                table: "ProductType",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_Service",
                table: "Service",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_ServiceType ",
                table: "ServiceType",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_AspNetUsers_AdministratorId",
                table: "Task",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_Vendor",
                table: "Vendor",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_EventType",
                table: "EventType");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_User",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Administrator",
                table: "Package");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageService_AspNetUsers_AdministratorId",
                table: "PackageService");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Administrator",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_ProductType",
                table: "ProductType");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_Service",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_ServiceType ",
                table: "ServiceType");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_AspNetUsers_AdministratorId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_Vendor",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Vendor_AdministratorId",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Task_AdministratorId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_ServiceType_AdministratorId",
                table: "ServiceType");

            migrationBuilder.DropIndex(
                name: "IX_Service_AdministratorId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_ProductType_AdministratorId",
                table: "ProductType");

            migrationBuilder.DropIndex(
                name: "IX_Product_AdministratorId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_PackageService_AdministratorId",
                table: "PackageService");

            migrationBuilder.DropIndex(
                name: "IX_Package_AdministratorId",
                table: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_AdministratorId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_InventoryId_AdministratorId",
                table: "Inventory");

            migrationBuilder.DropIndex(
                name: "IX_EventType_AdministratorId",
                table: "EventType");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "ServiceType");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "ProductType");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "PackageService");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "LastUpdatedOn",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "EventType");

            migrationBuilder.RenameColumn(
                name: "AdministratorId",
                table: "AspNetUsers",
                newName: "AdminstratorId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_AdministratorId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_AdminstratorId");

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Vendor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Setting",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Setting",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "Setting",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ServiceVendor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "ServiceVendor",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "ServiceVendor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "ServiceType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Service",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "ProductType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductServiceType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "ProductServiceType",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "ProductServiceType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "PackageService",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "PackageProduct",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "PackageProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedOn",
                table: "PackageProduct",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Package",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Inventory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "EventType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "Event",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DecorId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserId",
                table: "Inventory",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_InventoryId_UserId",
                table: "Inventory",
                columns: new[] { "InventoryId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_User",
                table: "Inventory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
