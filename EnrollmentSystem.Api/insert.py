with open('seed.txt', 'r') as f:
    seed = f.read()

with open('Data/EnrollmentDbContext.cs', 'r') as f:
    content = f.read()

content = content.replace("    }\n}", "        // Seed Subjects\n" + seed + "\n    }\n}")

with open('Data/EnrollmentDbContext.cs', 'w') as f:
    f.write(content)
