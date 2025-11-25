using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{ // course entity model
    public class Course
    { // properties of the Course class
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // disable identity column
        public int CourseID { get; set; } // primary key
        public string Title { get; set; } // title of the course
        public int Credits { get; set; } // number of credits for the course

        public ICollection<Enrollment> Enrollments { get; set; } // navigation property for enrollments, contains multiple Enrollment objects (Course & Student relationship)
    }
}