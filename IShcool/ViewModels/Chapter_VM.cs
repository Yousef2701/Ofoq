using System.ComponentModel.DataAnnotations;

namespace IShcool.ViewModels
{
    public class Chapter_VM
    {
        [Required]
        public string TeacherId { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2, ErrorMessage = "Title Must Be More Than 2 Caracters & Less Than 125 Caracters")]
        public string Title { get; set; }
    }
}
