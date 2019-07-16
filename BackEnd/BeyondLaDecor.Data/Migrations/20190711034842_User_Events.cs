using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class User_Events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Event",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_PackageId_EventTypeId_UserId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Event",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_UserId",
                table: "Event",
                newName: "IX_Event_ClientId");

            migrationBuilder.AddColumn<bool>(
                name: "Negotiable",
                table: "Service",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Negotiable",
                table: "Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Negotiable",
                table: "Package",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorId",
                table: "Event",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Event_AdministratorId",
                table: "Event",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_PackageId_EventTypeId_AdministratorId_ClientId",
                table: "Event",
                columns: new[] { "PackageId", "EventTypeId", "AdministratorId", "ClientId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_Event",
                table: "Event",
                column: "AdministratorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Event",
                table: "Event",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_Event",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Event",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_AdministratorId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_PackageId_EventTypeId_AdministratorId_ClientId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Negotiable",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "Negotiable",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Negotiable",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "AdministratorId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Event",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_ClientId",
                table: "Event",
                newName: "IX_Event_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_PackageId_EventTypeId_UserId",
                table: "Event",
                columns: new[] { "PackageId", "EventTypeId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_User_Event",
                table: "Event",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
