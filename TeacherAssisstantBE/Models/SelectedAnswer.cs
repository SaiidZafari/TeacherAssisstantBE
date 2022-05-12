namespace TeacherAssisstantBE.Models
{
    public class SelectedAnswer
    {
        public int SelectedAnswerId { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public int QuestionId { get; set; }

        public int SeleAnswerId { get; set; }

        public int CorrAnswerId { get; set; }

        public string QuizDate { get; set; }

        public int WeekNumber { get; set; }

        public string DayName { get; set; }        
    }
}
