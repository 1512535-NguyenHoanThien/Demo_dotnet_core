using Microsoft.EntityFrameworkCore.Migrations;

namespace SPA_Application.Migrations
{
    public partial class commentBedProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentDetails_Beds_BedId",
                table: "AppointmentDetails");

            migrationBuilder.AlterColumn<long>(
                name: "BedId",
                table: "AppointmentDetails",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentDetails_Beds_BedId",
                table: "AppointmentDetails",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppointmentDetails_Beds_BedId",
                table: "AppointmentDetails");

            migrationBuilder.AlterColumn<long>(
                name: "BedId",
                table: "AppointmentDetails",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppointmentDetails_Beds_BedId",
                table: "AppointmentDetails",
                column: "BedId",
                principalTable: "Beds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
