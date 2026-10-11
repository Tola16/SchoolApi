using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos
{
    public class CreateStudentDto
    {
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
