using Microsoft.EntityFrameworkCore.Migrations;

namespace SPA_Application.Migrations
{
    public partial class addOrderProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "AppointmentDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails",
                columns: new[] { "AppointmentId", "ServiceId", "Order" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "AppointmentDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppointmentDetails",
                table: "AppointmentDetails",
                columns: new[] { "AppointmentId", "ServiceId" });
        }
    }
}
