namespace EnrollmentSystem.Api.Models;

public class Subject
{
    public int Id { get; set; }
    public string EdpCode { get; set; } = string.Empty;
    public string SubjectCode { get; set; } = string.Empty;
    public string SubjectTitle { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string EndTime { get; set; } = string.Empty;
    public string Days { get; set; } = string.Empty;
    public string Section { get; set; } = string.Empty;
    public string Room { get; set; } = string.Empty;
    public int Units { get; set; }
    
    // Foreign Key to Course
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    
    // Navigation property
    public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
