using System.ComponentModel.DataAnnotations;

namespace TeacherAssisstantBE.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email
        {
            get { return FirstName.ToLower() + "." + LastName.ToLower() + "@xmail.xx"; }
        }

        [Display(Name = "Password")]
        public string Password
        {
            get { return FirstName.Substring(0, 1).ToLower() + LastName.Substring(0, 1).ToLower() + "123"; }
        }

        public IEnumerable<Subject> Subjects { get; set; }
    }
}

