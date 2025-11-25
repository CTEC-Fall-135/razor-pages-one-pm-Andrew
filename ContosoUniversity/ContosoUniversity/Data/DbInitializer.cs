using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{ // class to initialize the database with seed data
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        { // method to initialize the database

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }
            var students = new Student[]
            { // array of students to add
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2010-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2013-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2011-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2013-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students) // iterate through each student
            {
                context.Students.Add(s); // add each student to the context
            }
            context.SaveChanges(); // save changes to the database
        }
    }
}
