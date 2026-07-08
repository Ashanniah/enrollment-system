using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSubjectFormats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "A" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "B" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "C" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "D" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "E" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "F" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "G" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "H" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "I" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "J" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "K" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "L" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 200", "M" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 201", "M" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 202", "M" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Thu", "RM 203", "M" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "Fri", "RM 204", "M" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Room", "Section" },
                values: new object[] { "RM 205", "M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "A1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "B1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "C1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "D1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "E1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "F1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "G1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "H1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "I1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "J1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "K1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "L1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 200", "M1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 201", "M1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 202", "M1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "T/Th", "Rm 203", "M1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Days", "Room", "Section" },
                values: new object[] { "F", "Rm 204", "M1" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Room", "Section" },
                values: new object[] { "Rm 205", "M1" });
        }
    }
}
