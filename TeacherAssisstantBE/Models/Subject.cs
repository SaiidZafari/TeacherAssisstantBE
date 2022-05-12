namespace TeacherAssisstantBE.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string ImageTitle { get; set; }

        public string SubjectName { get; set; }

        public IEnumerable<Question> Questions { get; set; }
    }
}
