using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EnrollmentSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSubjectsAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Subjects",
                newName: "SubjectTitle");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Subjects",
                newName: "SubjectCode");

            migrationBuilder.RenameColumn(
                name: "Credits",
                table: "Subjects",
                newName: "Units");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Subjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EdpCode",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "Subjects",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CourseId", "Days", "EdpCode", "EndTime", "Room", "Section", "StartTime", "SubjectCode", "SubjectTitle", "Units" },
                values: new object[,]
                {
                    { 1, 1, "M/W", "2001", "09:30 AM", "Rm 200", "A1", "08:00 AM", "IT101", "Intro to Computing", 3 },
                    { 2, 1, "T/Th", "2002", "11:30 AM", "Rm 201", "A1", "10:00 AM", "IT102", "Programming Fundamentals", 3 },
                    { 3, 1, "M/W", "2003", "02:30 PM", "Rm 202", "A1", "01:00 PM", "IT103", "Data Structures", 3 },
                    { 4, 1, "T/Th", "2004", "04:00 PM", "Rm 203", "A1", "02:30 PM", "IT104", "Database Systems", 3 },
                    { 5, 1, "F", "2005", "10:30 AM", "Rm 204", "A1", "09:00 AM", "IT105", "Networking Basics", 2 },
                    { 6, 1, "M/W", "2006", "04:30 PM", "Rm 205", "A1", "03:00 PM", "IT106", "Web Development", 3 },
                    { 7, 2, "M/W", "2101", "09:30 AM", "Rm 200", "B1", "08:00 AM", "CRIM101", "Intro to Criminology", 3 },
                    { 8, 2, "T/Th", "2102", "11:30 AM", "Rm 201", "B1", "10:00 AM", "CRIM102", "Criminal Law I", 3 },
                    { 9, 2, "M/W", "2103", "02:30 PM", "Rm 202", "B1", "01:00 PM", "CRIM103", "Police Organization", 3 },
                    { 10, 2, "T/Th", "2104", "04:00 PM", "Rm 203", "B1", "02:30 PM", "CRIM104", "Ethics in Law Enforcement", 3 },
                    { 11, 2, "F", "2105", "10:30 AM", "Rm 204", "B1", "09:00 AM", "CRIM105", "Forensic Science", 2 },
                    { 12, 2, "M/W", "2106", "04:30 PM", "Rm 205", "B1", "03:00 PM", "CRIM106", "Criminal Investigation", 3 },
                    { 13, 3, "M/W", "2201", "09:30 AM", "Rm 200", "C1", "08:00 AM", "PSY101", "General Psychology", 3 },
                    { 14, 3, "T/Th", "2202", "11:30 AM", "Rm 201", "C1", "10:00 AM", "PSY102", "Developmental Psychology", 3 },
                    { 15, 3, "M/W", "2203", "02:30 PM", "Rm 202", "C1", "01:00 PM", "PSY103", "Psychological Statistics", 3 },
                    { 16, 3, "T/Th", "2204", "04:00 PM", "Rm 203", "C1", "02:30 PM", "PSY104", "Abnormal Psychology", 3 },
                    { 17, 3, "F", "2205", "10:30 AM", "Rm 204", "C1", "09:00 AM", "PSY105", "Cognitive Psychology", 2 },
                    { 18, 3, "M/W", "2206", "04:30 PM", "Rm 205", "C1", "03:00 PM", "PSY106", "Experimental Psychology", 3 },
                    { 19, 4, "M/W", "2301", "09:30 AM", "Rm 200", "D1", "08:00 AM", "CS101", "Introduction to Computer Science", 3 },
                    { 20, 4, "T/Th", "2302", "11:30 AM", "Rm 201", "D1", "10:00 AM", "CS102", "Advanced Computer Science", 3 },
                    { 21, 4, "M/W", "2303", "02:30 PM", "Rm 202", "D1", "01:00 PM", "CS103", "Computer Science Principles", 3 },
                    { 22, 4, "T/Th", "2304", "04:00 PM", "Rm 203", "D1", "02:30 PM", "CS104", "Applied Computer Science", 3 },
                    { 23, 4, "F", "2305", "10:30 AM", "Rm 204", "D1", "09:00 AM", "CS105", "Computer Science Lab", 2 },
                    { 24, 4, "M/W", "2306", "04:30 PM", "Rm 205", "D1", "03:00 PM", "CS106", "Seminar in Computer Science", 3 },
                    { 25, 5, "M/W", "2401", "09:30 AM", "Rm 200", "E1", "08:00 AM", "ACC101", "Introduction to Accounting", 3 },
                    { 26, 5, "T/Th", "2402", "11:30 AM", "Rm 201", "E1", "10:00 AM", "ACC102", "Advanced Accounting", 3 },
                    { 27, 5, "M/W", "2403", "02:30 PM", "Rm 202", "E1", "01:00 PM", "ACC103", "Accounting Principles", 3 },
                    { 28, 5, "T/Th", "2404", "04:00 PM", "Rm 203", "E1", "02:30 PM", "ACC104", "Applied Accounting", 3 },
                    { 29, 5, "F", "2405", "10:30 AM", "Rm 204", "E1", "09:00 AM", "ACC105", "Accounting Lab", 2 },
                    { 30, 5, "M/W", "2406", "04:30 PM", "Rm 205", "E1", "03:00 PM", "ACC106", "Seminar in Accounting", 3 },
                    { 31, 6, "M/W", "2501", "09:30 AM", "Rm 200", "F1", "08:00 AM", "SED101", "Introduction to Secondary Education", 3 },
                    { 32, 6, "T/Th", "2502", "11:30 AM", "Rm 201", "F1", "10:00 AM", "SED102", "Advanced Secondary Education", 3 },
                    { 33, 6, "M/W", "2503", "02:30 PM", "Rm 202", "F1", "01:00 PM", "SED103", "Secondary Education Principles", 3 },
                    { 34, 6, "T/Th", "2504", "04:00 PM", "Rm 203", "F1", "02:30 PM", "SED104", "Applied Secondary Education", 3 },
                    { 35, 6, "F", "2505", "10:30 AM", "Rm 204", "F1", "09:00 AM", "SED105", "Secondary Education Lab", 2 },
                    { 36, 6, "M/W", "2506", "04:30 PM", "Rm 205", "F1", "03:00 PM", "SED106", "Seminar in Secondary Education", 3 },
                    { 37, 7, "M/W", "2601", "09:30 AM", "Rm 200", "G1", "08:00 AM", "EED101", "Introduction to Elementary Education", 3 },
                    { 38, 7, "T/Th", "2602", "11:30 AM", "Rm 201", "G1", "10:00 AM", "EED102", "Advanced Elementary Education", 3 },
                    { 39, 7, "M/W", "2603", "02:30 PM", "Rm 202", "G1", "01:00 PM", "EED103", "Elementary Education Principles", 3 },
                    { 40, 7, "T/Th", "2604", "04:00 PM", "Rm 203", "G1", "02:30 PM", "EED104", "Applied Elementary Education", 3 },
                    { 41, 7, "F", "2605", "10:30 AM", "Rm 204", "G1", "09:00 AM", "EED105", "Elementary Education Lab", 2 },
                    { 42, 7, "M/W", "2606", "04:30 PM", "Rm 205", "G1", "03:00 PM", "EED106", "Seminar in Elementary Education", 3 },
                    { 43, 8, "M/W", "2701", "09:30 AM", "Rm 200", "H1", "08:00 AM", "CE101", "Introduction to Civil Engineering", 3 },
                    { 44, 8, "T/Th", "2702", "11:30 AM", "Rm 201", "H1", "10:00 AM", "CE102", "Advanced Civil Engineering", 3 },
                    { 45, 8, "M/W", "2703", "02:30 PM", "Rm 202", "H1", "01:00 PM", "CE103", "Civil Engineering Principles", 3 },
                    { 46, 8, "T/Th", "2704", "04:00 PM", "Rm 203", "H1", "02:30 PM", "CE104", "Applied Civil Engineering", 3 },
                    { 47, 8, "F", "2705", "10:30 AM", "Rm 204", "H1", "09:00 AM", "CE105", "Civil Engineering Lab", 2 },
                    { 48, 8, "M/W", "2706", "04:30 PM", "Rm 205", "H1", "03:00 PM", "CE106", "Seminar in Civil Engineering", 3 },
                    { 49, 9, "M/W", "2801", "09:30 AM", "Rm 200", "I1", "08:00 AM", "CPE101", "Introduction to Computer Engineering", 3 },
                    { 50, 9, "T/Th", "2802", "11:30 AM", "Rm 201", "I1", "10:00 AM", "CPE102", "Advanced Computer Engineering", 3 },
                    { 51, 9, "M/W", "2803", "02:30 PM", "Rm 202", "I1", "01:00 PM", "CPE103", "Computer Engineering Principles", 3 },
                    { 52, 9, "T/Th", "2804", "04:00 PM", "Rm 203", "I1", "02:30 PM", "CPE104", "Applied Computer Engineering", 3 },
                    { 53, 9, "F", "2805", "10:30 AM", "Rm 204", "I1", "09:00 AM", "CPE105", "Computer Engineering Lab", 2 },
                    { 54, 9, "M/W", "2806", "04:30 PM", "Rm 205", "I1", "03:00 PM", "CPE106", "Seminar in Computer Engineering", 3 },
                    { 55, 10, "M/W", "2901", "09:30 AM", "Rm 200", "J1", "08:00 AM", "TM101", "Introduction to Tourism", 3 },
                    { 56, 10, "T/Th", "2902", "11:30 AM", "Rm 201", "J1", "10:00 AM", "TM102", "Advanced Tourism", 3 },
                    { 57, 10, "M/W", "2903", "02:30 PM", "Rm 202", "J1", "01:00 PM", "TM103", "Tourism Principles", 3 },
                    { 58, 10, "T/Th", "2904", "04:00 PM", "Rm 203", "J1", "02:30 PM", "TM104", "Applied Tourism", 3 },
                    { 59, 10, "F", "2905", "10:30 AM", "Rm 204", "J1", "09:00 AM", "TM105", "Tourism Lab", 2 },
                    { 60, 10, "M/W", "2906", "04:30 PM", "Rm 205", "J1", "03:00 PM", "TM106", "Seminar in Tourism", 3 },
                    { 61, 11, "M/W", "3001", "09:30 AM", "Rm 200", "K1", "08:00 AM", "HM101", "Introduction to Hospitality", 3 },
                    { 62, 11, "T/Th", "3002", "11:30 AM", "Rm 201", "K1", "10:00 AM", "HM102", "Advanced Hospitality", 3 },
                    { 63, 11, "M/W", "3003", "02:30 PM", "Rm 202", "K1", "01:00 PM", "HM103", "Hospitality Principles", 3 },
                    { 64, 11, "T/Th", "3004", "04:00 PM", "Rm 203", "K1", "02:30 PM", "HM104", "Applied Hospitality", 3 },
                    { 65, 11, "F", "3005", "10:30 AM", "Rm 204", "K1", "09:00 AM", "HM105", "Hospitality Lab", 2 },
                    { 66, 11, "M/W", "3006", "04:30 PM", "Rm 205", "K1", "03:00 PM", "HM106", "Seminar in Hospitality", 3 },
                    { 67, 12, "M/W", "3101", "09:30 AM", "Rm 200", "L1", "08:00 AM", "NUR101", "Introduction to Nursing", 3 },
                    { 68, 12, "T/Th", "3102", "11:30 AM", "Rm 201", "L1", "10:00 AM", "NUR102", "Advanced Nursing", 3 },
                    { 69, 12, "M/W", "3103", "02:30 PM", "Rm 202", "L1", "01:00 PM", "NUR103", "Nursing Principles", 3 },
                    { 70, 12, "T/Th", "3104", "04:00 PM", "Rm 203", "L1", "02:30 PM", "NUR104", "Applied Nursing", 3 },
                    { 71, 12, "F", "3105", "10:30 AM", "Rm 204", "L1", "09:00 AM", "NUR105", "Nursing Lab", 2 },
                    { 72, 12, "M/W", "3106", "04:30 PM", "Rm 205", "L1", "03:00 PM", "NUR106", "Seminar in Nursing", 3 },
                    { 73, 13, "M/W", "3201", "09:30 AM", "Rm 200", "M1", "08:00 AM", "BA101", "Introduction to Business", 3 },
                    { 74, 13, "T/Th", "3202", "11:30 AM", "Rm 201", "M1", "10:00 AM", "BA102", "Advanced Business", 3 },
                    { 75, 13, "M/W", "3203", "02:30 PM", "Rm 202", "M1", "01:00 PM", "BA103", "Business Principles", 3 },
                    { 76, 13, "T/Th", "3204", "04:00 PM", "Rm 203", "M1", "02:30 PM", "BA104", "Applied Business", 3 },
                    { 77, 13, "F", "3205", "10:30 AM", "Rm 204", "M1", "09:00 AM", "BA105", "Business Lab", 2 },
                    { 78, 13, "M/W", "3206", "04:30 PM", "Rm 205", "M1", "03:00 PM", "BA106", "Seminar in Business", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CourseId",
                table: "Subjects");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "EdpCode",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "Units",
                table: "Subjects",
                newName: "Credits");

            migrationBuilder.RenameColumn(
                name: "SubjectTitle",
                table: "Subjects",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "SubjectCode",
                table: "Subjects",
                newName: "Description");
        }
    }
}
