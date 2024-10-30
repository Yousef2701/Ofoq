using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using The_Top_App.Models;

namespace IShcool.Models
{
    public class Exam
    {
        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 18 Caracters")]
        public string Academy_Year { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Exam_Time Must Be More Than 1 Caracters & Less Than 3 Caracters")]
        public string Exam_Duration { get; set; }

        [Required]
        public DateTime StartExamDate { get; set; }

        [Required]
        public DateTime FinishExamDate { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
