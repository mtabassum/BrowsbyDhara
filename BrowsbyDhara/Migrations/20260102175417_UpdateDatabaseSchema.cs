using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrowsbyDhara.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSales_Customers_CustomerId",
                table: "ProductSales");

            migrationBuilder.DropTable(
                name: "AppointmentServices");

            migrationBuilder.DropIndex(
                name: "IX_ProductSales_CustomerId",
                table: "ProductSales");

            migrationBuilder.DropIndex(
                name: "IX_Payments_AppointmentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ProductSales");

            migrationBuilder.DropColumn(
                name: "CanceledDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ConfirmedDate",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TipAmount",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Appointments",
                newName: "ServiceType");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Appointments",
                newName: "RequestedDate");

            migrationBuilder.RenameColumn(
                name: "CancellationReason",
                table: "Appointments",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointments",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Appointments",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AppointmentId",
                table: "Payments",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_AppointmentId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "ServiceType",
                table: "Appointments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "RequestedDate",
                table: "Appointments",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Appointments",
                newName: "CancellationReason");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Appointments",
                newName: "AppointmentId");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ProductSales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CanceledDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ConfirmedDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "Appointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartTime",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<decimal>(
                name: "TipAmount",
                table: "Appointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Appointments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "AppointmentServices",
                columns: table => new
                {
                    AppointmentServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentServices", x => x.AppointmentServiceId);
                    table.ForeignKey(
                        name: "FK_AppointmentServices_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSales_CustomerId",
                table: "ProductSales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_AppointmentId",
                table: "Payments",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServices_AppointmentId",
                table: "AppointmentServices",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentServices_ServiceId",
                table: "AppointmentServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSales_Customers_CustomerId",
                table: "ProductSales",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
