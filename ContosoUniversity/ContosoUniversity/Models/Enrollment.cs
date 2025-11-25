using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{ // enrollment entity model
    public enum Grade
    { // grade enumeration
        A, B, C, D, F
    }

    public class Enrollment
    { // properties of the Enrollment class
        public int EnrollmentID { get; set; } // primary key
        public int CourseID { get; set; } // foreign key to Course
        public int StudentID { get; set; } // foreign key to Student
        [DisplayFormat(NullDisplayText = "No grade")] // display format for grade
        public Grade? Grade { get; set; } // nullable grade property

        public Course Course { get; set; } // navigation property to Course
        public Student Student { get; set; } // navigation property to Student
    }
}