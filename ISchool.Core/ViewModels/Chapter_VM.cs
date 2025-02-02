namespace ISchool.Core.ViewModels
{
    public class Chapter_VM
    {
        [Required]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        [RegularExpression("^[ا-ي ء أ ؤ]+$*[ؤ ء أ ا-ي]+[ؤ ء أ ا-ي]*$",
            ErrorMessage = "Name Must Contain only Letters")]
        public string Title { get; set; }
    }
}
