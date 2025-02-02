namespace ISchool.Data.Models
{
    public class LTestResult
    {
        [Required]
        public string Vedio_Url { get; set; }

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

        public virtual Student Student { get; set; } = null!;
    }
}
