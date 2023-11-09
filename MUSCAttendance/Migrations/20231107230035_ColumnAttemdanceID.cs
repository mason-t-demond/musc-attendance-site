using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MUSCAttendance.Migrations
{
    /// <inheritdoc />
    public partial class ColumnAttemdanceID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "Attendances",
                newName: "AttendanceID");

            migrationBuilder.AlterColumn<int>(
                name: "GraduationYear",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AttendanceID",
                table: "Attendances",
                newName: "EnrollmentID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "GraduationYear",
                table: "Student",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
