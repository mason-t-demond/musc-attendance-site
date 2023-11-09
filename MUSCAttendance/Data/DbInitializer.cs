using MUSCAttendance.Models;
using MUSCAttendance.Pages.Courses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MUSCAttendance.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var abercrombie = new Instructor
            {
                FirstMidName = "Kim",
                LastName = "Abercrombie",
                HireDate = DateTime.Parse("1995-03-11")
            };

            var fakhouri = new Instructor
            {
                FirstMidName = "Fadi",
                LastName = "Fakhouri",
                HireDate = DateTime.Parse("2002-07-06")
            };

            var harui = new Instructor
            {
                FirstMidName = "Roger",
                LastName = "Harui",
                HireDate = DateTime.Parse("1998-07-01")
            };

            var kapoor = new Instructor
            {
                FirstMidName = "Candace",
                LastName = "Kapoor",
                HireDate = DateTime.Parse("2001-01-15")
            };

            var zheng = new Instructor
            {
                FirstMidName = "Roger",
                LastName = "Zheng",
                HireDate = DateTime.Parse("2004-02-12")
            };

            var instructors = new Instructor[]
            {
                abercrombie,
                fakhouri,
                harui,
                kapoor,
                zheng
            };

            context.AddRange(instructors);

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    Instructor = fakhouri,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    Instructor = harui,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    Instructor = kapoor,
                    Location = "Thompson 304" }
            };

            context.AddRange(officeAssignments);

            var english = new Department
            {
                Name = "English",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = abercrombie
            };

            var mathematics = new Department
            {
                Name = "Mathematics",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = fakhouri
            };

            var engineering = new Department
            {
                Name = "Engineering",
                Budget = 350000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = harui
            };

            var economics = new Department
            {
                Name = "Economics",
                Budget = 100000,
                StartDate = DateTime.Parse("2007-09-01"),
                Administrator = kapoor
            };

            var departments = new Department[]
            {
                english,
                mathematics,
                engineering,
                economics
            };

            context.AddRange(departments);

            var chemistry = new Course
            {
                CourseID = 1,
                Title = "Musical",
                EventDate = DateTime.Parse("2023-4-15"),
                Type = EventType.UCA,
                Description = "A musical event at UCA.",
                Performed = "no",
                Department = engineering,
            };

            var microeconomics = new Course
            {
                CourseID = 2,
                Title = "Play",
                EventDate = DateTime.Parse("2023-6-21"),
                Type = EventType.Hendrix,
                Description = "Saw a play at Hendrix.",
                Performed = "yes",
                Department = engineering,
            };

            var macroeconmics = new Course
            {
                CourseID = 3,
                Title = "Concert",
                EventDate = DateTime.Parse("2023-11-2"),
                Type = EventType.Other,
                Description = "Performed in a concert.",
                Performed = "yes",
                Department = engineering,
            };

            var calculus = new Course
            {
                CourseID = 4,
                Title = "Play",
                EventDate = DateTime.Parse("2023-9-16"),
                Type = EventType.UCA,
                Description = "Saw a play at UCA.",
                Performed = "no",
                Department = engineering,
            };

            var trigonometry = new Course
            {
                CourseID = 5,
                Title = "Musical",
                EventDate = DateTime.Parse("2023-11-15"),
                Type = EventType.Hendrix,
                Description = "Performed in a musical at Hendrix.",
                Performed = "yes",
                Department = engineering,
            };

            var composition = new Course
            {
                CourseID = 6,
                Title = "Play",
                EventDate = DateTime.Parse("2023-3-24"),
                Type = EventType.Other,
                Description = "Saw a play at the theatre in Little Rock",
                Performed = "no",
                Department = engineering,
            };

            var literature = new Course
            {
                CourseID = 7,
                Title = "Musical",
                EventDate = DateTime.Parse("2023-5-2"),
                Type = EventType.Hendrix,
                Description = "Saw a musical at Hendrix!",
                Performed = "no",
                Department = engineering,
            };

            var courses = new Course[]
            {
                chemistry,
                microeconomics,
                macroeconmics,
                calculus,
                trigonometry,
                composition,
                literature
            };

            context.AddRange(courses);

            var alexander = new Student
            {
                FirstMidName = "Carson",
                LastName = "Alexander",
                GraduationYear = 2026,
                TotalAttendances = 3
            };

            var alonso = new Student
            {
                FirstMidName = "Meredith",
                LastName = "Alonso",
                GraduationYear = 2026,
                TotalAttendances = 3
            };

            var anand = new Student
            {
                FirstMidName = "Arturo",
                LastName = "Anand",
                GraduationYear = 2026,
                TotalAttendances = 2
            };

            var barzdukas = new Student
            {
                FirstMidName = "Gytis",
                LastName = "Barzdukas",
                GraduationYear = 2026,
                TotalAttendances = 1
            };

            var li = new Student
            {
                FirstMidName = "Yan",
                LastName = "Li",
                GraduationYear = 2026,
                TotalAttendances = 1
            };

            var justice = new Student
            {
                FirstMidName = "Peggy",
                LastName = "Justice",
                GraduationYear = 2026,
                TotalAttendances = 1
            };

            var norman = new Student
            {
                FirstMidName = "Laura",
                LastName = "Norman",
                GraduationYear = 2026,
                TotalAttendances = 0
            };

            var olivetto = new Student
            {
                FirstMidName = "Nino",
                LastName = "Olivetto",
                GraduationYear = 2026,
                TotalAttendances = 0
            };

            var students = new Student[]
            {
                alexander,
                alonso,
                anand,
                barzdukas,
                li,
                justice,
                norman,
                olivetto
            };

            context.AddRange(students);

            var Attendances = new Attendance[]
            {
                new Attendance {
                    Student = alexander,
                    Course = chemistry,
                    EventType = EventType.UCA
                },
                new Attendance {
                    Student = alexander,
                    Course = microeconomics,
                    EventType = EventType.Hendrix
                },
                new Attendance {
                    Student = alexander,
                    Course = macroeconmics,
                    EventType = EventType.Other
                },
                new Attendance {
                    Student = alonso,
                    Course = calculus,
                    EventType = EventType.UCA
                },
                new Attendance {
                    Student = alonso,
                    Course = trigonometry,
                    EventType = EventType.Hendrix
                },
                new Attendance {
                    Student = alonso,
                    Course = composition,
                    EventType = EventType.Other
                },
                new Attendance {
                    Student = anand,
                    Course = chemistry,
                    EventType = EventType.UCA
                },
                new Attendance {
                    Student = anand,
                    Course = microeconomics,
                    EventType = EventType.Hendrix
                },
                new Attendance {
                    Student = barzdukas,
                    Course = chemistry,
                    EventType = EventType.UCA
                },
                new Attendance {
                    Student = li,
                    Course = composition,
                    EventType = EventType.Other
                },
                new Attendance {
                    Student = justice,
                    Course = literature,
                    EventType = EventType.Hendrix
                }
            };

            context.AddRange(Attendances);
            context.SaveChanges();
        }
    }
}