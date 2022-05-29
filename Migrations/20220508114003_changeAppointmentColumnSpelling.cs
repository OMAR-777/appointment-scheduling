using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentScheduling.Migrations
{
    public partial class changeAppointmentColumnSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDoctorAprroved",
                table: "Appointments",
                newName: "IsDoctorApproved");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDoctorApproved",
                table: "Appointments",
                newName: "IsDoctorAprroved");
        }
    }
}
