namespace ISchool.Data.Models
{
    public class ExamResult
    {
        [Required]
        [StringLength(185, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 185 Caracters")]
        public string ExamTitle { get; set; }

        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [ForeignKey("Student")]
        public string StudentId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Date Must Be 10 Caracters")]
        public string Date { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Time Must Be More Than 5 Caracters & Less Than 12 Caracters")]
        public string Time { get; set; }

        [Required]
        public int Correct_Answers_No { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;

        public virtual Student Student { get; set; } = null!;
    }
}
