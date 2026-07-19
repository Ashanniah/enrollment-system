namespace EnrollmentSystem.Api.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public int? DepartmentId { get; set; }
    public Department? Department { get; set; }

    public int? DegreeId { get; set; }
    public Degree? Degree { get; set; }

    // Navigation property
    public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
