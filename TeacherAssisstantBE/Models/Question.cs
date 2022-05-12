namespace TeacherAssisstantBE.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string QuestionText { get; set; }

        public DateTime QuizDate { get; set; }

        public int WeekNumber { get; set; }

        public string DayName { get; set; }

        public IEnumerable<Answer> Answers { get; set; }
    }
}
