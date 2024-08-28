namespace BVC_Course_Backend_B.Models
{
    public class Enrollment
    {
       
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public Student? Student { get; set; }
        public Class? Class { get; set; }


    }
}
