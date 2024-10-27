using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IShcool.ViewModels
{
    public class Student_Register_VM
    {
        [Required]
        [StringLength(55, MinimumLength = 3, ErrorMessage = "Name Must Be More Than 3 Caracters & Less Than 55 Caracters")]
        public string Name { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Must Be 11 Caracters")]
        public string Phone { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Grade Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        public string Grade { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Department Must Be More Than 4 Caracters & Less Than 30 Caracters")]
        public string Department { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "SecondLang Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        public string SecondLang { get; set; }

        [AllowNull]
        public string? Par_Phone { get; set; } = null;

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string Password { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string ConfirmPassword { get; set; }
    }
}
