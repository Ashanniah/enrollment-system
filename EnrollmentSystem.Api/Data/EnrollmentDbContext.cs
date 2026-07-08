using Microsoft.EntityFrameworkCore;
using EnrollmentSystem.Api.Models;

namespace EnrollmentSystem.Api.Data;

public class EnrollmentDbContext : DbContext
{
    public EnrollmentDbContext(DbContextOptions<EnrollmentDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<YearLevel> YearLevels { get; set; } = null!;
    public DbSet<Enrollment> Enrollments { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Student -> Enrollment <- Subject many-to-many relationship
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId);

        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Subject)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.SubjectId);

        // Seed Users
        // Hash for "password-123" is hardcoded to prevent EF from generating a new hash every migration
        string hash123 = "$2a$11$16uHNH4dKW/v1z4Wrb/exujzPpsdGNo4g23aud/bC4olXKOTl8veu";
        
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Email = "registrar@mapplewood.edu", PasswordHash = hash123, Role = "Admin" },
            new User { Id = 2, Email = "john@mapplewood.edu", PasswordHash = hash123, Role = "Student" }
        );

        // Seed Courses
        modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, Name = "Bachelor of Science in Information Technology" },
            new Course { Id = 2, Name = "Bachelor of Science in Criminology" },
            new Course { Id = 3, Name = "Bachelor of Science in Psychology" },
            new Course { Id = 4, Name = "Bachelor of Science in Computer Science" },
            new Course { Id = 5, Name = "Bachelor of Science in Accountancy" },
            new Course { Id = 6, Name = "Bachelor in Secondary Education" },
            new Course { Id = 7, Name = "Bachelor in Elementary Education" },
            new Course { Id = 8, Name = "Bachelor of Science in Civil Engineering" },
            new Course { Id = 9, Name = "Bachelor of Science in Computer Engineering" },
            new Course { Id = 10, Name = "Bachelor of Science in Tourism Management" },
            new Course { Id = 11, Name = "Bachelor of Science in Hospitality Management" },
            new Course { Id = 12, Name = "Bachelor of Science in Nursing" },
            new Course { Id = 13, Name = "Bachelor of Science in Business Administration" }
        );

        // Seed Year Levels
        modelBuilder.Entity<YearLevel>().HasData(
            new YearLevel { Id = 1, Name = "1st Year" },
            new YearLevel { Id = 2, Name = "2nd Year" },
            new YearLevel { Id = 3, Name = "3rd Year" },
            new YearLevel { Id = 4, Name = "4th Year" },
            new YearLevel { Id = 5, Name = "5th Year" }
        );
        // Seed Subjects
        modelBuilder.Entity<Subject>().HasData(
            new Subject { Id = 1, CourseId = 1, EdpCode = "2001", SubjectCode = "IT101", SubjectTitle = "Intro to Computing", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "A", Room = "RM 200", Units = 3 },
            new Subject { Id = 2, CourseId = 1, EdpCode = "2002", SubjectCode = "IT102", SubjectTitle = "Programming Fundamentals", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "A", Room = "RM 201", Units = 3 },
            new Subject { Id = 3, CourseId = 1, EdpCode = "2003", SubjectCode = "IT103", SubjectTitle = "Data Structures", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "A", Room = "RM 202", Units = 3 },
            new Subject { Id = 4, CourseId = 1, EdpCode = "2004", SubjectCode = "IT104", SubjectTitle = "Database Systems", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "A", Room = "RM 203", Units = 3 },
            new Subject { Id = 5, CourseId = 1, EdpCode = "2005", SubjectCode = "IT105", SubjectTitle = "Networking Basics", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "A", Room = "RM 204", Units = 2 },
            new Subject { Id = 6, CourseId = 1, EdpCode = "2006", SubjectCode = "IT106", SubjectTitle = "Web Development", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "A", Room = "RM 205", Units = 3 },
            new Subject { Id = 7, CourseId = 2, EdpCode = "2101", SubjectCode = "CRIM101", SubjectTitle = "Intro to Criminology", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "B", Room = "RM 200", Units = 3 },
            new Subject { Id = 8, CourseId = 2, EdpCode = "2102", SubjectCode = "CRIM102", SubjectTitle = "Criminal Law I", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "B", Room = "RM 201", Units = 3 },
            new Subject { Id = 9, CourseId = 2, EdpCode = "2103", SubjectCode = "CRIM103", SubjectTitle = "Police Organization", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "B", Room = "RM 202", Units = 3 },
            new Subject { Id = 10, CourseId = 2, EdpCode = "2104", SubjectCode = "CRIM104", SubjectTitle = "Ethics in Law Enforcement", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "B", Room = "RM 203", Units = 3 },
            new Subject { Id = 11, CourseId = 2, EdpCode = "2105", SubjectCode = "CRIM105", SubjectTitle = "Forensic Science", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "B", Room = "RM 204", Units = 2 },
            new Subject { Id = 12, CourseId = 2, EdpCode = "2106", SubjectCode = "CRIM106", SubjectTitle = "Criminal Investigation", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "B", Room = "RM 205", Units = 3 },
            new Subject { Id = 13, CourseId = 3, EdpCode = "2201", SubjectCode = "PSY101", SubjectTitle = "General Psychology", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "C", Room = "RM 200", Units = 3 },
            new Subject { Id = 14, CourseId = 3, EdpCode = "2202", SubjectCode = "PSY102", SubjectTitle = "Developmental Psychology", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "C", Room = "RM 201", Units = 3 },
            new Subject { Id = 15, CourseId = 3, EdpCode = "2203", SubjectCode = "PSY103", SubjectTitle = "Psychological Statistics", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "C", Room = "RM 202", Units = 3 },
            new Subject { Id = 16, CourseId = 3, EdpCode = "2204", SubjectCode = "PSY104", SubjectTitle = "Abnormal Psychology", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "C", Room = "RM 203", Units = 3 },
            new Subject { Id = 17, CourseId = 3, EdpCode = "2205", SubjectCode = "PSY105", SubjectTitle = "Cognitive Psychology", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "C", Room = "RM 204", Units = 2 },
            new Subject { Id = 18, CourseId = 3, EdpCode = "2206", SubjectCode = "PSY106", SubjectTitle = "Experimental Psychology", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "C", Room = "RM 205", Units = 3 },
            new Subject { Id = 19, CourseId = 4, EdpCode = "2301", SubjectCode = "CS101", SubjectTitle = "Introduction to Computer Science", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "D", Room = "RM 200", Units = 3 },
            new Subject { Id = 20, CourseId = 4, EdpCode = "2302", SubjectCode = "CS102", SubjectTitle = "Advanced Computer Science", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "D", Room = "RM 201", Units = 3 },
            new Subject { Id = 21, CourseId = 4, EdpCode = "2303", SubjectCode = "CS103", SubjectTitle = "Computer Science Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "D", Room = "RM 202", Units = 3 },
            new Subject { Id = 22, CourseId = 4, EdpCode = "2304", SubjectCode = "CS104", SubjectTitle = "Applied Computer Science", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "D", Room = "RM 203", Units = 3 },
            new Subject { Id = 23, CourseId = 4, EdpCode = "2305", SubjectCode = "CS105", SubjectTitle = "Computer Science Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "D", Room = "RM 204", Units = 2 },
            new Subject { Id = 24, CourseId = 4, EdpCode = "2306", SubjectCode = "CS106", SubjectTitle = "Seminar in Computer Science", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "D", Room = "RM 205", Units = 3 },
            new Subject { Id = 25, CourseId = 5, EdpCode = "2401", SubjectCode = "ACC101", SubjectTitle = "Introduction to Accounting", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "E", Room = "RM 200", Units = 3 },
            new Subject { Id = 26, CourseId = 5, EdpCode = "2402", SubjectCode = "ACC102", SubjectTitle = "Advanced Accounting", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "E", Room = "RM 201", Units = 3 },
            new Subject { Id = 27, CourseId = 5, EdpCode = "2403", SubjectCode = "ACC103", SubjectTitle = "Accounting Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "E", Room = "RM 202", Units = 3 },
            new Subject { Id = 28, CourseId = 5, EdpCode = "2404", SubjectCode = "ACC104", SubjectTitle = "Applied Accounting", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "E", Room = "RM 203", Units = 3 },
            new Subject { Id = 29, CourseId = 5, EdpCode = "2405", SubjectCode = "ACC105", SubjectTitle = "Accounting Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "E", Room = "RM 204", Units = 2 },
            new Subject { Id = 30, CourseId = 5, EdpCode = "2406", SubjectCode = "ACC106", SubjectTitle = "Seminar in Accounting", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "E", Room = "RM 205", Units = 3 },
            new Subject { Id = 31, CourseId = 6, EdpCode = "2501", SubjectCode = "SED101", SubjectTitle = "Introduction to Secondary Education", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "F", Room = "RM 200", Units = 3 },
            new Subject { Id = 32, CourseId = 6, EdpCode = "2502", SubjectCode = "SED102", SubjectTitle = "Advanced Secondary Education", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "F", Room = "RM 201", Units = 3 },
            new Subject { Id = 33, CourseId = 6, EdpCode = "2503", SubjectCode = "SED103", SubjectTitle = "Secondary Education Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "F", Room = "RM 202", Units = 3 },
            new Subject { Id = 34, CourseId = 6, EdpCode = "2504", SubjectCode = "SED104", SubjectTitle = "Applied Secondary Education", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "F", Room = "RM 203", Units = 3 },
            new Subject { Id = 35, CourseId = 6, EdpCode = "2505", SubjectCode = "SED105", SubjectTitle = "Secondary Education Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "F", Room = "RM 204", Units = 2 },
            new Subject { Id = 36, CourseId = 6, EdpCode = "2506", SubjectCode = "SED106", SubjectTitle = "Seminar in Secondary Education", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "F", Room = "RM 205", Units = 3 },
            new Subject { Id = 37, CourseId = 7, EdpCode = "2601", SubjectCode = "EED101", SubjectTitle = "Introduction to Elementary Education", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "G", Room = "RM 200", Units = 3 },
            new Subject { Id = 38, CourseId = 7, EdpCode = "2602", SubjectCode = "EED102", SubjectTitle = "Advanced Elementary Education", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "G", Room = "RM 201", Units = 3 },
            new Subject { Id = 39, CourseId = 7, EdpCode = "2603", SubjectCode = "EED103", SubjectTitle = "Elementary Education Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "G", Room = "RM 202", Units = 3 },
            new Subject { Id = 40, CourseId = 7, EdpCode = "2604", SubjectCode = "EED104", SubjectTitle = "Applied Elementary Education", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "G", Room = "RM 203", Units = 3 },
            new Subject { Id = 41, CourseId = 7, EdpCode = "2605", SubjectCode = "EED105", SubjectTitle = "Elementary Education Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "G", Room = "RM 204", Units = 2 },
            new Subject { Id = 42, CourseId = 7, EdpCode = "2606", SubjectCode = "EED106", SubjectTitle = "Seminar in Elementary Education", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "G", Room = "RM 205", Units = 3 },
            new Subject { Id = 43, CourseId = 8, EdpCode = "2701", SubjectCode = "CE101", SubjectTitle = "Introduction to Civil Engineering", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "H", Room = "RM 200", Units = 3 },
            new Subject { Id = 44, CourseId = 8, EdpCode = "2702", SubjectCode = "CE102", SubjectTitle = "Advanced Civil Engineering", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "H", Room = "RM 201", Units = 3 },
            new Subject { Id = 45, CourseId = 8, EdpCode = "2703", SubjectCode = "CE103", SubjectTitle = "Civil Engineering Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "H", Room = "RM 202", Units = 3 },
            new Subject { Id = 46, CourseId = 8, EdpCode = "2704", SubjectCode = "CE104", SubjectTitle = "Applied Civil Engineering", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "H", Room = "RM 203", Units = 3 },
            new Subject { Id = 47, CourseId = 8, EdpCode = "2705", SubjectCode = "CE105", SubjectTitle = "Civil Engineering Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "H", Room = "RM 204", Units = 2 },
            new Subject { Id = 48, CourseId = 8, EdpCode = "2706", SubjectCode = "CE106", SubjectTitle = "Seminar in Civil Engineering", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "H", Room = "RM 205", Units = 3 },
            new Subject { Id = 49, CourseId = 9, EdpCode = "2801", SubjectCode = "CPE101", SubjectTitle = "Introduction to Computer Engineering", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "I", Room = "RM 200", Units = 3 },
            new Subject { Id = 50, CourseId = 9, EdpCode = "2802", SubjectCode = "CPE102", SubjectTitle = "Advanced Computer Engineering", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "I", Room = "RM 201", Units = 3 },
            new Subject { Id = 51, CourseId = 9, EdpCode = "2803", SubjectCode = "CPE103", SubjectTitle = "Computer Engineering Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "I", Room = "RM 202", Units = 3 },
            new Subject { Id = 52, CourseId = 9, EdpCode = "2804", SubjectCode = "CPE104", SubjectTitle = "Applied Computer Engineering", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "I", Room = "RM 203", Units = 3 },
            new Subject { Id = 53, CourseId = 9, EdpCode = "2805", SubjectCode = "CPE105", SubjectTitle = "Computer Engineering Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "I", Room = "RM 204", Units = 2 },
            new Subject { Id = 54, CourseId = 9, EdpCode = "2806", SubjectCode = "CPE106", SubjectTitle = "Seminar in Computer Engineering", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "I", Room = "RM 205", Units = 3 },
            new Subject { Id = 55, CourseId = 10, EdpCode = "2901", SubjectCode = "TM101", SubjectTitle = "Introduction to Tourism", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "J", Room = "RM 200", Units = 3 },
            new Subject { Id = 56, CourseId = 10, EdpCode = "2902", SubjectCode = "TM102", SubjectTitle = "Advanced Tourism", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "J", Room = "RM 201", Units = 3 },
            new Subject { Id = 57, CourseId = 10, EdpCode = "2903", SubjectCode = "TM103", SubjectTitle = "Tourism Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "J", Room = "RM 202", Units = 3 },
            new Subject { Id = 58, CourseId = 10, EdpCode = "2904", SubjectCode = "TM104", SubjectTitle = "Applied Tourism", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "J", Room = "RM 203", Units = 3 },
            new Subject { Id = 59, CourseId = 10, EdpCode = "2905", SubjectCode = "TM105", SubjectTitle = "Tourism Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "J", Room = "RM 204", Units = 2 },
            new Subject { Id = 60, CourseId = 10, EdpCode = "2906", SubjectCode = "TM106", SubjectTitle = "Seminar in Tourism", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "J", Room = "RM 205", Units = 3 },
            new Subject { Id = 61, CourseId = 11, EdpCode = "3001", SubjectCode = "HM101", SubjectTitle = "Introduction to Hospitality", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "K", Room = "RM 200", Units = 3 },
            new Subject { Id = 62, CourseId = 11, EdpCode = "3002", SubjectCode = "HM102", SubjectTitle = "Advanced Hospitality", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "K", Room = "RM 201", Units = 3 },
            new Subject { Id = 63, CourseId = 11, EdpCode = "3003", SubjectCode = "HM103", SubjectTitle = "Hospitality Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "K", Room = "RM 202", Units = 3 },
            new Subject { Id = 64, CourseId = 11, EdpCode = "3004", SubjectCode = "HM104", SubjectTitle = "Applied Hospitality", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "K", Room = "RM 203", Units = 3 },
            new Subject { Id = 65, CourseId = 11, EdpCode = "3005", SubjectCode = "HM105", SubjectTitle = "Hospitality Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "K", Room = "RM 204", Units = 2 },
            new Subject { Id = 66, CourseId = 11, EdpCode = "3006", SubjectCode = "HM106", SubjectTitle = "Seminar in Hospitality", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "K", Room = "RM 205", Units = 3 },
            new Subject { Id = 67, CourseId = 12, EdpCode = "3101", SubjectCode = "NUR101", SubjectTitle = "Introduction to Nursing", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "L", Room = "RM 200", Units = 3 },
            new Subject { Id = 68, CourseId = 12, EdpCode = "3102", SubjectCode = "NUR102", SubjectTitle = "Advanced Nursing", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "L", Room = "RM 201", Units = 3 },
            new Subject { Id = 69, CourseId = 12, EdpCode = "3103", SubjectCode = "NUR103", SubjectTitle = "Nursing Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "L", Room = "RM 202", Units = 3 },
            new Subject { Id = 70, CourseId = 12, EdpCode = "3104", SubjectCode = "NUR104", SubjectTitle = "Applied Nursing", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "L", Room = "RM 203", Units = 3 },
            new Subject { Id = 71, CourseId = 12, EdpCode = "3105", SubjectCode = "NUR105", SubjectTitle = "Nursing Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "L", Room = "RM 204", Units = 2 },
            new Subject { Id = 72, CourseId = 12, EdpCode = "3106", SubjectCode = "NUR106", SubjectTitle = "Seminar in Nursing", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "L", Room = "RM 205", Units = 3 },
            new Subject { Id = 73, CourseId = 13, EdpCode = "3201", SubjectCode = "BA101", SubjectTitle = "Introduction to Business", StartTime = "08:00 AM", EndTime = "09:30 AM", Days = "M/W", Section = "M", Room = "RM 200", Units = 3 },
            new Subject { Id = 74, CourseId = 13, EdpCode = "3202", SubjectCode = "BA102", SubjectTitle = "Advanced Business", StartTime = "10:00 AM", EndTime = "11:30 AM", Days = "T/Thu", Section = "M", Room = "RM 201", Units = 3 },
            new Subject { Id = 75, CourseId = 13, EdpCode = "3203", SubjectCode = "BA103", SubjectTitle = "Business Principles", StartTime = "01:00 PM", EndTime = "02:30 PM", Days = "M/W", Section = "M", Room = "RM 202", Units = 3 },
            new Subject { Id = 76, CourseId = 13, EdpCode = "3204", SubjectCode = "BA104", SubjectTitle = "Applied Business", StartTime = "02:30 PM", EndTime = "04:00 PM", Days = "T/Thu", Section = "M", Room = "RM 203", Units = 3 },
            new Subject { Id = 77, CourseId = 13, EdpCode = "3205", SubjectCode = "BA105", SubjectTitle = "Business Lab", StartTime = "09:00 AM", EndTime = "10:30 AM", Days = "Fri", Section = "M", Room = "RM 204", Units = 2 },
            new Subject { Id = 78, CourseId = 13, EdpCode = "3206", SubjectCode = "BA106", SubjectTitle = "Seminar in Business", StartTime = "03:00 PM", EndTime = "04:30 PM", Days = "M/W", Section = "M", Room = "RM 205", Units = 3 }
        );
    }
}
