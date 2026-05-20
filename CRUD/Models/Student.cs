using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="Student ID")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        public string Department { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }


    }
}
