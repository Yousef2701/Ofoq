﻿namespace ISchool.Data.Models
{
    public class ExamQuestion
    {
        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string ExamTitle { get; set; }

        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 18 Caracters")]
        public string Academy_Year { get; set; }

        [Required]
        [StringLength(185, MinimumLength = 2, ErrorMessage = "Quest Must Be More Than 2 Caracters & Less Than 185 Caracters")]
        public string Quest { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 4, ErrorMessage = "Quest_Type Must Be More Than 4 Caracters & Less Than 5 Caracters")]
        public string Quest_Type { get; set; }

        [Required]
        public string? Frist_Answer { get; set; } = null;

        [Required]
        public string? Second_Answer { get; set; } = null;

        [Required]
        public string? Third_Answer { get; set; } = null;

        [Required]
        public string? Forth_Answer { get; set; } = null;

        [Required]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Correct_Answer Must Be More Than 1 Caracters & Less Than 6 Caracters")]
        public string Correct_Answer { get; set; }

    }
}
