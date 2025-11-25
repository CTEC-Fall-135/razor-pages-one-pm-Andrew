namespace ContosoUniversity.Models
{
    public class Student
    { // student entity model
        public int ID { get; set; } // primary key
        public string LastName { get; set; } // last name of the student
        public string FirstMidName { get; set; } // first and middle name of the student
        public DateTime EnrollmentDate { get; set; } // date of enrollment

        public ICollection<Enrollment> Enrollments { get; set; } // navigation property for enrollments, contains multiple Enrollment objects (Student & Course relationship)
    }
}