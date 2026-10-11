using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos
{
    public class CreateTeacherDto
    {
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public DateTime HireDate { get; set; }
    }
}
