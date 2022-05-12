namespace TeacherAssisstantBE.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        
        public int studentId { get; set; }
        
        public string StudentName { get; set; }
        
        public string SubjectName { get; set; }
        
        public int TotalQestion { get; set; }
        
        public int NumOfCorrAnswer { get; set; }
       
        public string ResultDate { get; set; }
        
        public int WeekNumber { get; set; }
        
        public string DayName { get; set; }
    }
}
