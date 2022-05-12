namespace TeacherAssisstantBE.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string ImageUrl { get; set; }

        public string ContentText { get; set; }

        public DateTime Date { get; set; }

        public string Link { get; set; }

        public string LinkPdf { get; set; }

        public string LinkVideo { get; set; }
    }
}
