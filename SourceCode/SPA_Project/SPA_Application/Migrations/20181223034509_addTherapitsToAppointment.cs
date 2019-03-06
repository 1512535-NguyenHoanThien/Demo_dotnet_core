using Microsoft.EntityFrameworkCore.Migrations;

namespace SPA_Application.Migrations
{
    public partial class addTherapitsToAppointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TherapistId",
                table: "Appointments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TherapistId",
                table: "Appointments");
        }
    }
}
