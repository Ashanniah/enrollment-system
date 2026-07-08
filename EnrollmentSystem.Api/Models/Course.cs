namespace EnrollmentSystem.Api.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    // Navigation property
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
