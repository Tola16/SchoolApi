using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace SchoolApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100 ,MinimumLength =3)]
        public string FullName { get; set; }

        [Required,EmailAddress]
        public string Email{ get; set; }
        [Required,Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }

        public StudentProfile? StudentProfile { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }


}

//Property Data Type Validation Rules
//Id int Primary key; auto - generated
//FullName string Required; length 3–100
//Email string Required; valid email; unique
//Phone string Required; valid phone number
//BirthDate DateTime Required
//Gender string Required