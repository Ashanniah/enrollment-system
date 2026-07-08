namespace EnrollmentSystem.Api.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    
    public string PhoneNumber { get; set; } = string.Empty;
    public string GuardianName { get; set; } = string.Empty;

    public int? CourseId { get; set; }
    public Course? Course { get; set; }

    public int? YearLevelId { get; set; }
    public YearLevel? YearLevel { get; set; }
    
    // Navigation property
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    // Uploaded Requirements
    public string Form137Path { get; set; } = string.Empty;
    public string GoodMoralPath { get; set; } = string.Empty;
    public string IdPhotoPath { get; set; } = string.Empty;

    // Payment Tracking
    public string PaymentStatus { get; set; } = "Pending"; // Pending, Paid, For Verification, Verified, Rejected
    public string ProofOfPaymentPath { get; set; } = string.Empty;

    // Application Stage Tracking
    public string ApplicationStatus { get; set; } = "Draft"; // Draft, Submitted, Under Review, Approved, Enrolled
}
