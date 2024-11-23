using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IShcool.ViewModels
{
    public class Teacher_Register_VM
    {
        [Required]
        [StringLength(55, MinimumLength = 3, ErrorMessage = "Name Must Be More Than 3 Caracters & Less Than 55 Caracters")]
        public string Name { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "Subject Must Be More Than 3 Caracters & Less Than 45 Caracters")]
        public string Subject { get; set; }

        [Display(Name = "Teacher Phone")]
        [StringLength(11),
            RegularExpression(@"^01[0125][0-9]{8}$",
            ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        public bool? First { get; set; } = true;

        public bool? Second { get; set; } = true;

        public bool? Third { get; set; } = true;

        [Required]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Add an Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }
    }
}
