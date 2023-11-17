namespace LabCodeFirst.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime Date { get; set; }

        //Foreing keys
        public int StudentID { get; set; }
        public Student? Student { get; set; }

        public int CourseID { get; set; }
        public Course? Course { get; set; }

        public bool IsDeleted {get; set; }
    }
}
