using Microsoft.EntityFrameworkCore;
using EnrollmentSystem.Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using EnrollmentSystem.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EnrollmentDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Enable CORS so the frontend can communicate with the API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Apply DB Migrations automatically
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<EnrollmentDbContext>();
        context.Database.Migrate();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating the database.");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseStaticFiles();
app.UseCors("AllowAll");

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapPost("/api/auth/login", async (LoginRequest request, EnrollmentDbContext db) =>
{
    var user = await db.Users.SingleOrDefaultAsync(u => u.Email == request.Email);
    if (user == null)
    {
        return Results.Unauthorized();
    }

    if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
    {
        return Results.Unauthorized();
    }

    return Results.Ok(new { user.Email, user.Role });
})
.WithName("Login");

app.MapGet("/api/courses", async (EnrollmentDbContext db) =>
{
    return await db.Courses.OrderBy(c => c.Id).ToListAsync();
})
.WithName("GetCourses");

app.MapGet("/api/yearlevels", async (EnrollmentDbContext db) =>
{
    return await db.YearLevels.OrderBy(y => y.Id).ToListAsync();
})
.WithName("GetYearLevels");

app.MapGet("/api/departments", async (EnrollmentDbContext db) =>
{
    return await db.Departments.OrderBy(d => d.Id).ToListAsync();
})
.WithName("GetDepartments");

app.MapGet("/api/degrees", async (EnrollmentDbContext db) =>
{
    return await db.Degrees.OrderBy(d => d.Id).ToListAsync();
})
.WithName("GetDegrees");

app.MapGet("/api/courses/{courseId}/subjects", async (int courseId, EnrollmentDbContext db) =>
{
    return await db.Subjects.Where(s => s.CourseId == courseId).OrderBy(s => s.Id).ToListAsync();
})
.WithName("GetCourseSubjects");

app.MapPost("/api/enrollments/apply", async (
    [FromForm] string firstName,
    [FromForm] string? middleName,
    [FromForm] string lastName,
    [FromForm] string email,
    [FromForm] int courseId,
    [FromForm] int yearLevelId,
    [FromForm] string phoneNumber,
    [FromForm] string? guardianName,
    [FromForm] string selectedSubjects,
    IFormFile? form137,
    IFormFile? goodMoral,
    IFormFile? idPhoto,
    EnrollmentDbContext db,
    IWebHostEnvironment env) =>
{
    var existingStudent = await db.Students.FirstOrDefaultAsync(s => s.Email == email);
    if (existingStudent != null)
    {
        return Results.BadRequest("An application with this email has already been submitted.");
    }

    var uploadsFolder = env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
    uploadsFolder = Path.Combine(uploadsFolder, "uploads");
    Directory.CreateDirectory(uploadsFolder);

    async Task<string> SaveFile(IFormFile? file)
    {
        if (file == null) return string.Empty;
        var fileName = $"{Guid.NewGuid()}_{file.FileName}";
        var filePath = Path.Combine(uploadsFolder, fileName);
        using var fs = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(fs);
        return $"/uploads/{fileName}";
    }

    var student = new Student
    {
        FirstName = firstName,
        MiddleName = middleName ?? string.Empty,
        LastName = lastName,
        Email = email,
        PhoneNumber = phoneNumber,
        GuardianName = guardianName ?? string.Empty,
        CourseId = courseId,
        YearLevelId = yearLevelId,
        DateOfBirth = DateTime.UtcNow, // Mocking since it's not in the form
        Form137Path = await SaveFile(form137),
        GoodMoralPath = await SaveFile(goodMoral),
        IdPhotoPath = await SaveFile(idPhoto),
        ApplicationStatus = "Submitted"
    };

    db.Students.Add(student);
    await db.SaveChangesAsync();

    if (!string.IsNullOrEmpty(selectedSubjects))
    {
        var subjectIds = JsonSerializer.Deserialize<List<int>>(selectedSubjects);
        if (subjectIds != null)
        {
            foreach (var subjId in subjectIds)
            {
                db.Enrollments.Add(new Enrollment 
                { 
                    StudentId = student.Id, 
                    SubjectId = subjId, 
                    EnrollmentDate = DateTime.UtcNow 
                });
            }
            await db.SaveChangesAsync();
        }
    }

    return Results.Ok(new { message = "Application submitted successfully", studentId = student.Id });
})
.WithName("ApplyEnrollment")
.DisableAntiforgery();

app.MapPost("/api/payments/{studentId}/pay", async (int studentId, EnrollmentDbContext db) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    
    student.PaymentStatus = "Paid";
    await db.SaveChangesAsync();
    return Results.Ok(new { message = "Payment successful", status = student.PaymentStatus });
})
.WithName("PayStudent");

app.MapPost("/api/payments/{studentId}/upload-proof", async (int studentId, IFormFile receipt, EnrollmentDbContext db, IWebHostEnvironment env) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    
    if (receipt != null)
    {
        var uploadsFolder = env.WebRootPath ?? Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        uploadsFolder = Path.Combine(uploadsFolder, "uploads");
        Directory.CreateDirectory(uploadsFolder);
        
        var fileName = $"{Guid.NewGuid()}_{receipt.FileName}";
        var filePath = Path.Combine(uploadsFolder, fileName);
        using var fs = new FileStream(filePath, FileMode.Create);
        await receipt.CopyToAsync(fs);
        
        student.ProofOfPaymentPath = $"/uploads/{fileName}";
        student.PaymentStatus = "For Verification";
        await db.SaveChangesAsync();
    }
    return Results.Ok(new { message = "Proof uploaded successfully", status = student.PaymentStatus });
})
.WithName("UploadProof")
.DisableAntiforgery();

app.MapPost("/api/payments/{studentId}/verify", async (int studentId, [FromBody] JsonElement body, EnrollmentDbContext db) =>
{
    var action = body.GetProperty("action").GetString();
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();

    if (action == "verify") student.PaymentStatus = "Verified";
    else if (action == "reject") student.PaymentStatus = "Rejected";

    await db.SaveChangesAsync();
    return Results.Ok(new { message = $"Payment {action}ed", status = student.PaymentStatus });
})
.WithName("VerifyPayment");

app.MapPost("/api/enrollments/{studentId}/review", async (int studentId, EnrollmentDbContext db) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    if (student.ApplicationStatus == "Submitted" || student.ApplicationStatus == "Draft") {
        student.ApplicationStatus = "Under Review";
        await db.SaveChangesAsync();
    }
    return Results.Ok(new { message = "Application is under review", status = student.ApplicationStatus });
})
.WithName("ReviewApplication");

app.MapPost("/api/enrollments/{studentId}/approve", async (int studentId, EnrollmentDbContext db) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    
    student.ApplicationStatus = "Approved";
    await db.SaveChangesAsync();
    return Results.Ok(new { message = "Application approved", status = student.ApplicationStatus });
})
.WithName("ApproveApplication");

app.MapPost("/api/enrollments/{studentId}/enroll", async (int studentId, EnrollmentDbContext db) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    
    student.ApplicationStatus = "Enrolled";
    await db.SaveChangesAsync();
    return Results.Ok(new { message = "Student officially enrolled", status = student.ApplicationStatus });
})
.WithName("EnrollStudent");

app.MapGet("/api/enrollments/{studentId}/status", async (int studentId, EnrollmentDbContext db) =>
{
    var student = await db.Students.FindAsync(studentId);
    if (student == null) return Results.NotFound();
    return Results.Ok(new { status = student.ApplicationStatus });
})
.WithName("GetApplicationStatus");

app.Run();

public record LoginRequest(string Email, string Password);

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
