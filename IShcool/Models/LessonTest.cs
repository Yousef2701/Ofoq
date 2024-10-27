using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IShcool.Models
{
    public class LessonTest
    {
        [Required]
        public string Vedio_Url { get; set; }

        [Required]
        [StringLength(185, MinimumLength = 2, ErrorMessage = "Quest Must Be More Than 2 Caracters & Less Than 185 Caracters")]
        public string Quest { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 4, ErrorMessage = "Quest_Type Must Be More Than 4 Caracters & Less Than 5 Caracters")]
        public string Quest_Type { get; set; }

        [AllowNull]
        [StringLength(130, MinimumLength = 2, ErrorMessage = "Answer Must Be More Than 2 Caracters & Less Than 130 Caracters")]
        public string? Frist_Answer { get; set; } = null;

        [AllowNull]
        [StringLength(130, MinimumLength = 2, ErrorMessage = "Answer Must Be More Than 2 Caracters & Less Than 130 Caracters")]
        public string? Second_Answer { get; set; } = null;

        [AllowNull]
        [StringLength(130, MinimumLength = 2, ErrorMessage = "Answer Must Be More Than 2 Caracters & Less Than 130 Caracters")]
        public string? Third_Answer { get; set; } = null;

        [AllowNull]
        public string? Frist_Answer_Url { get; set; } = null;

        [AllowNull]
        public string? Second_Answer_Url { get; set; } = null;

        [AllowNull]
        public string? Third_Answer_Url { get; set; } = null;

        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Correct_Answer Must Be More Than 1 Caracters & Less Than 6 Caracters")]
        public string Correct_Answer { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Date Must Be 10 Caracters")]
        public string Date { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Time Must Be More Than 5 Caracters & Less Than 12 Caracters")]
        public string Time { get; set; }
    }
}
