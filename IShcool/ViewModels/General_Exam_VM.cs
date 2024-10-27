using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IShcool.ViewModels
{
    public class General_Exam_VM
    {
        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        [Required]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(18, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 18 Caracters")]
        public string Academy_Year { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Exam_Time Must Be More Than 1 Caracters & Less Than 3 Caracters")]
        public string Exam_Duration { get; set; }

        [Required]
        public string StartExamDate { get; set; }

        [Required]
        public string StartExamTime { get; set; }

        [Required]
        public string FinishExamDate { get; set; }

        [Required]
        public string FinishExamTime { get; set; }
    }
}
