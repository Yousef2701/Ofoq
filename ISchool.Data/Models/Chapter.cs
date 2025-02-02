namespace ISchool.Data.Models
{
    public class Chapter
    {
        [Required]
        [ForeignKey("Teacher")]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        public virtual Teacher Teacher { get; set; } = null!;
    }
}
