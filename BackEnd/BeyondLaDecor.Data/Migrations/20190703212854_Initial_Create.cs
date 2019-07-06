using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyondLaDecor.Data.Migrations
{
    public partial class Initial_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    IsAdministrator = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    AdminstratorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Admin",
                        column: x => x.AdminstratorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    PackageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.PackageId);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ProductTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    ServiceTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ParentServiceTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.ServiceTypeId);
                    table.ForeignKey(
                        name: "FK_Parent_ServiceType",
                        column: x => x.ParentServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    SettingType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    EventTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LocationName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    PackageId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    TableCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_EventType",
                        column: x => x.EventTypeId,
                        principalTable: "EventType",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Package_Event",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Event",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ThirdParty = table.Column<bool>(nullable: false),
                    ServiceTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_ProductType",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "ProductTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ServiceType",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Cost = table.Column<decimal>(nullable: true),
                    ServiceTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_ServiceType",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ServiceTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.VendorId);
                    table.ForeignKey(
                        name: "FK_Vendor_ServiceType",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSetting",
                columns: table => new
                {
                    UserSettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    SettingId = table.Column<int>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    ClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSetting", x => x.UserSettingId);
                    table.ForeignKey(
                        name: "FK_Client_UserSetting",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSetting_Setting",
                        column: x => x.SettingId,
                        principalTable: "Setting",
                        principalColumn: "SettingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSetting_User",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackageProduct",
                columns: table => new
                {
                    PackageProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    PackageId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageProduct", x => x.PackageProductId);
                    table.ForeignKey(
                        name: "FK_Package_PackageProduct",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_PackageProduct",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductServiceType",
                columns: table => new
                {
                    ProductServiceTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ServiceTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductServiceType", x => x.ProductServiceTypeId);
                    table.ForeignKey(
                        name: "FK_Product_ProductServiceTypeId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceType_ProductServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "ServiceTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackageService",
                columns: table => new
                {
                    PackageServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    PackageId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageService", x => x.PackageServiceId);
                    table.ForeignKey(
                        name: "FK_Package_PackageService",
                        column: x => x.PackageId,
                        principalTable: "Package",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_PackageService",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    EventId = table.Column<int>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Event_Task",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Task",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceVendor",
                columns: table => new
                {
                    ServiceVendorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    DecorId = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceVendor", x => x.ServiceVendorId);
                    table.ForeignKey(
                        name: "FK_ServiceVendor_Service",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceVendor_Vendor",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdminstratorId",
                table: "AspNetUsers",
                column: "AdminstratorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Email",
                table: "AspNetUsers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventTypeId",
                table: "Event",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_PackageId_EventTypeId_UserId",
                table: "Event",
                columns: new[] { "PackageId", "EventTypeId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_EventType_EventTypeId_Name",
                table: "EventType",
                columns: new[] { "EventTypeId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_Package_Name",
                table: "Package",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_PackageProduct_ProductId",
                table: "PackageProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageProduct_PackageId_ProductId",
                table: "PackageProduct",
                columns: new[] { "PackageId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_PackageService_ServiceId",
                table: "PackageService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageService_PackageId_ServiceId",
                table: "PackageService",
                columns: new[] { "PackageId", "ServiceId" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ServiceTypeId",
                table: "Product",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Name_ProductTypeId",
                table: "Product",
                columns: new[] { "Name", "ProductTypeId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceType_ProductId",
                table: "ProductServiceType",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductServiceType_ServiceTypeId_ProductId",
                table: "ProductServiceType",
                columns: new[] { "ServiceTypeId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductType_Name",
                table: "ProductType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceTypeId_Name",
                table: "Service",
                columns: new[] { "ServiceTypeId", "Name" });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_Name",
                table: "ServiceType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_ParentServiceTypeId",
                table: "ServiceType",
                column: "ParentServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceVendor_VendorId",
                table: "ServiceVendor",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceVendor_ServiceId_VendorId",
                table: "ServiceVendor",
                columns: new[] { "ServiceId", "VendorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Setting_Name",
                table: "Setting",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Task_EventId",
                table: "Task",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ServiceId",
                table: "Task",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_Name_ServiceId_EventId",
                table: "Task",
                columns: new[] { "Name", "ServiceId", "EventId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserSetting_ClientId",
                table: "UserSetting",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSetting_SettingId",
                table: "UserSetting",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSetting_UserId_SettingId",
                table: "UserSetting",
                columns: new[] { "UserId", "SettingId" });

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_Name",
                table: "Vendor",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_ServiceTypeId",
                table: "Vendor",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PackageProduct");

            migrationBuilder.DropTable(
                name: "PackageService");

            migrationBuilder.DropTable(
                name: "ProductServiceType");

            migrationBuilder.DropTable(
                name: "ServiceVendor");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "UserSetting");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ServiceType");
        }
    }
}
