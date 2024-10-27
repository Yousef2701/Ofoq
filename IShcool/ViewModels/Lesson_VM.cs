using System.ComponentModel.DataAnnotations;

namespace IShcool.ViewModels
{
    public class Lesson_VM
    {
        [Required]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string ChapterTitle { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Academy_Year Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        public string Academy_Year { get; set; }

        [Display(Name = "Add a Vedio")]
        [DataType(DataType.Upload)]
        public IFormFile VedioFile { get; set; }
    }
}
