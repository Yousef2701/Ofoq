namespace ISchool.Data.Models
{
    public class Book
    {
        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 18 Caracters")]
        public string Academy_Year { get; set; }

        [Required]
        public string FileUrl { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
