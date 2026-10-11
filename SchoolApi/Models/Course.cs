using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolApi.Models
{
  

    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:100, MinimumLength = 3)]

        public string Title { get; set; } 

        [Required]
        [Range(1, 6)]
        public int CreditHours { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public Teacher Teacher { get; set; }
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
    }
}
