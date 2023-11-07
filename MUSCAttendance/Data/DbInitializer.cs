using MUSCAttendance.Models;
using System;
using System.Collections.Generic;
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

            var alexander = new Student
            {
                FirstMidName = "Carson",
                LastName = "Alexander",
                GraduationYear = 2026
            };

            var alonso = new Student
            {
                FirstMidName = "Meredith",
                LastName = "Alonso",
                GraduationYear = 2026
            };

            var anand = new Student
            {
                FirstMidName = "Arturo",
                LastName = "Anand",
                GraduationYear = 2026
            };

            var barzdukas = new Student
            {
                FirstMidName = "Gytis",
                LastName = "Barzdukas",
                GraduationYear = 2026
            };

            var li = new Student
            {
                FirstMidName = "Yan",
                LastName = "Li",
                GraduationYear = 2026
            };

            var justice = new Student
            {
                FirstMidName = "Peggy",
                LastName = "Justice",
                GraduationYear = 2026
            };

            var norman = new Student
            {
                FirstMidName = "Laura",
                LastName = "Norman",
                GraduationYear = 2026
            };

            var olivetto = new Student
            {
                FirstMidName = "Nino",
                LastName = "Olivetto",
                GraduationYear = 2026
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
                CourseID = 1050,
                Title = "Chemistry",
                Credits = 3,
                Department = engineering,
                Instructors = new List<Instructor> { kapoor, harui }
            };

            var microeconomics = new Course
            {
                CourseID = 4022,
                Title = "Microeconomics",
                Credits = 3,
                Department = economics,
                Instructors = new List<Instructor> { zheng }
            };

            var macroeconmics = new Course
            {
                CourseID = 4041,
                Title = "Macroeconomics",
                Credits = 3,
                Department = economics,
                Instructors = new List<Instructor> { zheng }
            };

            var calculus = new Course
            {
                CourseID = 1045,
                Title = "Calculus",
                Credits = 4,
                Department = mathematics,
                Instructors = new List<Instructor> { fakhouri }
            };

            var trigonometry = new Course
            {
                CourseID = 3141,
                Title = "Trigonometry",
                Credits = 4,
                Department = mathematics,
                Instructors = new List<Instructor> { harui }
            };

            var composition = new Course
            {
                CourseID = 2021,
                Title = "Composition",
                Credits = 3,
                Department = english,
                Instructors = new List<Instructor> { abercrombie }
            };

            var literature = new Course
            {
                CourseID = 2042,
                Title = "Literature",
                Credits = 4,
                Department = english,
                Instructors = new List<Instructor> { abercrombie }
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

            var Attendances = new Attendance[]
            {
                new Attendance {
                    Student = alexander,
                    Course = chemistry,
                    EventType = EventType.A
                },
                new Attendance {
                    Student = alexander,
                    Course = microeconomics,
                    EventType = EventType.C
                },
                new Attendance {
                    Student = alexander,
                    Course = macroeconmics,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = alonso,
                    Course = calculus,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = alonso,
                    Course = trigonometry,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = alonso,
                    Course = composition,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = anand,
                    Course = chemistry
                },
                new Attendance {
                    Student = anand,
                    Course = microeconomics,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = barzdukas,
                    Course = chemistry,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = li,
                    Course = composition,
                    EventType = EventType.B
                },
                new Attendance {
                    Student = justice,
                    Course = literature,
                    EventType = EventType.B
                }
            };

            context.AddRange(Attendances);
            context.SaveChanges();
        }
    }
}