import json

courses = [
    {"Id": 1, "CodePrefix": "IT", "StartId": 2001},
    {"Id": 2, "CodePrefix": "CRIM", "StartId": 2101},
    {"Id": 3, "CodePrefix": "PSY", "StartId": 2201},
    {"Id": 4, "CodePrefix": "CS", "StartId": 2301},
    {"Id": 5, "CodePrefix": "ACC", "StartId": 2401},
    {"Id": 6, "CodePrefix": "SED", "StartId": 2501},
    {"Id": 7, "CodePrefix": "EED", "StartId": 2601},
    {"Id": 8, "CodePrefix": "CE", "StartId": 2701},
    {"Id": 9, "CodePrefix": "CPE", "StartId": 2801},
    {"Id": 10, "CodePrefix": "TM", "StartId": 2901},
    {"Id": 11, "CodePrefix": "HM", "StartId": 3001},
    {"Id": 12, "CodePrefix": "NUR", "StartId": 3101},
    {"Id": 13, "CodePrefix": "BA", "StartId": 3201}
]

subjects = []
id_counter = 1

# Base subjects as requested
base_subjects = {
    1: [
        {"SubTitle": "Intro to Computing", "Units": 3},
        {"SubTitle": "Programming Fundamentals", "Units": 3},
        {"SubTitle": "Data Structures", "Units": 3},
        {"SubTitle": "Database Systems", "Units": 3},
        {"SubTitle": "Networking Basics", "Units": 2},
        {"SubTitle": "Web Development", "Units": 3}
    ],
    2: [
        {"SubTitle": "Intro to Criminology", "Units": 3},
        {"SubTitle": "Criminal Law I", "Units": 3},
        {"SubTitle": "Police Organization", "Units": 3},
        {"SubTitle": "Ethics in Law Enforcement", "Units": 3},
        {"SubTitle": "Forensic Science", "Units": 2},
        {"SubTitle": "Criminal Investigation", "Units": 3}
    ],
    3: [
        {"SubTitle": "General Psychology", "Units": 3},
        {"SubTitle": "Developmental Psychology", "Units": 3},
        {"SubTitle": "Psychological Statistics", "Units": 3},
        {"SubTitle": "Abnormal Psychology", "Units": 3},
        {"SubTitle": "Cognitive Psychology", "Units": 2},
        {"SubTitle": "Experimental Psychology", "Units": 3}
    ]
}

generic_titles = [
    "Introduction to {}", "Advanced {}", "{} Principles", "Applied {}", "{} Lab", "Seminar in {}"
]

times = [
    ("08:00 AM", "09:30 AM", "M/W"),
    ("10:00 AM", "11:30 AM", "T/Th"),
    ("01:00 PM", "02:30 PM", "M/W"),
    ("02:30 PM", "04:00 PM", "T/Th"),
    ("09:00 AM", "10:30 AM", "F"),
    ("03:00 PM", "04:30 PM", "M/W")
]

for course in courses:
    cid = course["Id"]
    cprefix = course["CodePrefix"]
    sid = course["StartId"]
    section = chr(64 + cid) + "1"
    
    course_titles = []
    if cid in base_subjects:
        course_titles = base_subjects[cid]
    else:
        name = "Course " + str(cid)
        if cid == 4: name = "Computer Science"
        if cid == 5: name = "Accounting"
        if cid == 6: name = "Secondary Education"
        if cid == 7: name = "Elementary Education"
        if cid == 8: name = "Civil Engineering"
        if cid == 9: name = "Computer Engineering"
        if cid == 10: name = "Tourism"
        if cid == 11: name = "Hospitality"
        if cid == 12: name = "Nursing"
        if cid == 13: name = "Business"
        
        course_titles = [
            {"SubTitle": generic_titles[0].format(name), "Units": 3},
            {"SubTitle": generic_titles[1].format(name), "Units": 3},
            {"SubTitle": generic_titles[2].format(name), "Units": 3},
            {"SubTitle": generic_titles[3].format(name), "Units": 3},
            {"SubTitle": generic_titles[4].format(name), "Units": 2},
            {"SubTitle": generic_titles[5].format(name), "Units": 3}
        ]
        
    for i in range(6):
        t = course_titles[i]
        time_info = times[i]
        
        sub = f'new Subject {{ Id = {id_counter}, CourseId = {cid}, EdpCode = "{sid + i}", SubjectCode = "{cprefix}10{i+1}", SubjectTitle = "{t["SubTitle"]}", StartTime = "{time_info[0]}", EndTime = "{time_info[1]}", Days = "{time_info[2]}", Section = "{section}", Room = "Rm {200 + i}", Units = {t["Units"]} }}'
        subjects.append(sub)
        id_counter += 1

code = "        modelBuilder.Entity<Subject>().HasData(\n            " + ",\n            ".join(subjects) + "\n        );"
with open('seed.txt', 'w') as f:
    f.write(code)
