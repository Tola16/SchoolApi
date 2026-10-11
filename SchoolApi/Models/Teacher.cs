using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:100, MinimumLength = 3)]
        public string FullName { get; set; } 

        [Required]
        [EmailAddress]
        public string Email { get; set; } 

        [Required]
        [Phone]
        public string Phone { get; set; } 

        [Required]
        public DateTime HireDate { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
