using MUSCAttendance.Models;

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

            var elliot = new Student{ID=576981,FirstMidName="Elliot",LastName="Allen",GradYear=2025, Forms={}};
            var mason = new Student{ID=576982,FirstMidName="Mason",LastName="Mason",GradYear=2023, Forms={}};
            var ryan = new Student{ID=576985,FirstMidName="Ryan",LastName="Fuller",GradYear=2024, Forms={}};
            var arturo = new Student{ID=576983,FirstMidName="Arturo",LastName="Anand",GradYear=2024, Forms={}};
            var gytis = new Student{ID=576984,FirstMidName="Gytis",LastName="Barzdukas",GradYear=2025, Forms={}};
            var peggy = new Student{ID=576986,FirstMidName="Peggy",LastName="Justice",GradYear=2023, Forms={}};
            var laura = new Student{ID=576987,FirstMidName="Laura",LastName="Norman",GradYear=2025, Forms={}};
            var nino = new Student{ID=576988,FirstMidName="Nino",LastName="Olivetto",GradYear=2026, Forms={}};

            var students = new Student[]
            {
                elliot,
                mason,
                ryan,
                arturo,
                gytis,
                peggy,
                laura,
                nino
            };

            context.Students.AddRange(students);

            var elliot1 = new Form{
                    Student=elliot,
                    EventDate=DateTime.Parse("2023-10-04"),
                    Type=EventType.Hendrix,
                    Performed=false,
                    HasProgram=true,
                    Approved=true
                };
            var mason1 = new Form{
                    Student=mason,
                    EventDate=DateTime.Parse("2023-11-03"),
                    Type=EventType.Other,
                    Performed=false,
                    HasProgram=false,
                    OtherDescription="It was a concert I played in.",
                    ProgramDescription="It was me and a couple other performers.",
                    Approved=false
                };
            var ryan1 = new Form{
                    Student=ryan,
                    EventDate=DateTime.Parse("2023-08-10"),
                    Type=EventType.Hendrix,
                    Performed=false,
                    HasProgram=true,
                    Approved=true
                };

            var arturo1 = new Form{
                    Student=arturo,
                    EventDate=DateTime.Parse("2023-07-17"),
                    Type=EventType.Other,
                    Performed=false,
                    HasProgram=true,
                    OtherDescription="It was a musical I played a minor role in.",
                    Approved=false
                    
                };
            var gytis1 = new Form{
                    Student=gytis,
                    EventDate=DateTime.Parse("2023-09-27"),
                    Type=EventType.Other,
                    Performed=false,
                    HasProgram=false,
                    OtherDescription="It was a play I performed in.",
                    ProgramDescription="It was me and a few other performers.",
                    Approved=false
                    
                };
            var laura1 = new Form{
                    Student=laura,
                    EventDate=DateTime.Parse("2023-08-08"),
                    Type=EventType.UCA,
                    Performed=false,
                    HasProgram=true,
                    Approved=true
                    
                };
            var laura2 = new Form{
                    Student=laura,
                    EventDate=DateTime.Parse("2023-08-08"),
                    Type=EventType.Hendrix,
                    Performed=false,
                    HasProgram=true,
                    Approved=true
                };

            var forms = new Form[]
            {
                elliot1,
                mason1,
                ryan1,
                arturo1,
                gytis1,
                laura1,
                laura2,
                
            };

            context.Forms.AddRange(forms);
            context.SaveChanges();
        }
    }
}

    




