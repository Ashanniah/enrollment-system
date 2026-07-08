namespace EnrollmentSystem.Api.Models;

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    
    public int SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;
    
    public DateTime EnrollmentDate { get; set; }
    public string Grade { get; set; } = string.Empty;
}
