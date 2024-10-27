using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using The_Top_App.Models;

namespace Test.Models
{
    public class Enrollment
    {
        [Required]
        [ForeignKey("Student")]
        public string StudentId { get; set; }

        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "Subject Must Be More Than 3 Caracters & Less Than 45 Caracters")]
        public string Subject { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;

        public virtual Student Student { get; set; } = null!;
    }
}
