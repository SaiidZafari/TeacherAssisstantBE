namespace TeacherAssisstantBE.Models
{
    public class Lecture
    {
        public int LectureId { get; set; }

        public string LectureTitle { get; set; }

        public string LectureCategory { get; set; }

        public DateTime LactureDate { get; set; }

        public string LactureImageUrl { get; set; }

        public string LectureText { get; set; }

        public string LectureLink { get; set; }

        public string LecturePdf { get; set; }

        public string LectureVideo { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}
