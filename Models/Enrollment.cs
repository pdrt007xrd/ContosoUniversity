namespace ContosoUniversity.Models
{

       public enum Grade
        {
            A,B,C,D,f

        }

    public class Enrollment
    {
        public int EnnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //-------------------------------\\ property navigation below
        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}
