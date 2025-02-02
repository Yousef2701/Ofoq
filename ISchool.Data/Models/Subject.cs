namespace ISchool.Data.Models
{
    public class Subject
    {
        [Key]
        public int Numbre { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Grade Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        public string Grade { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Department Must Be More Than 4 Caracters & Less Than 30 Caracters")]
        public string Department { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 4, ErrorMessage = "Department Must Be More Than 4 Caracters & Less Than 70 Caracters")]
        public string Name { get; set; }

        [AllowNull]
        public string? ImageUrl { get; set; } = null;
    }
}
