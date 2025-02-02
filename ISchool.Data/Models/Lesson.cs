namespace ISchool.Data.Models
{
    public class Lesson
    {
        [Required]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string ChapterTitle { get; set; }

        [Required]
        public string Vedio_Url { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Date Must Be 10 Caracters")]
        public string Date { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 5, ErrorMessage = "Time Must Be More Than 5 Caracters & Less Than 12 Caracters")]
        public string Time { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 2, ErrorMessage = "Am_Pm Must Be More Than 2 Caracters & Less Than 6 Caracters")]
        public string Am_Pm { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        public string Academy_Year { get; set; }

    }
}
