namespace BVC_Course_Backend_B.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String? TeacherName{ get; set; }
        public String? CourseName { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
