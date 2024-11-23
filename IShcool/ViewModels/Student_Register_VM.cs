using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace IShcool.ViewModels
{
    public class Student_Register_VM
    {
        [Required]
        [StringLength(55, MinimumLength = 3, ErrorMessage = "Name Must Be More Than 3 Caracters & Less Than 55 Caracters")]
        public string Name { get; set; }

        [Display(Name = "Student Phone")]
        [StringLength(11),
            RegularExpression(@"^01[0125][0-9]{8}$",
            ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Grade")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Grade Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        [RegularExpression("^[ا-ي ء أ ؤ]+$*[ؤ ء أ ا-ي]+[ؤ ء أ ا-ي]*$",
            ErrorMessage = "Name Must Contain only Letters")]
        public string Grade { get; set; }

        [Required]
        [Display(Name = "Department")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Department Must Be More Than 4 Caracters & Less Than 30 Caracters")]
        [RegularExpression("^[ا-ي ء أ ؤ]+$*[ؤ ء أ ا-ي]+[ؤ ء أ ا-ي]*$",
            ErrorMessage = "Name Must Contain only Letters")]
        public string Department { get; set; }

        [Required]
        [Display(Name = "SecondLang")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "SecondLang Must Be More Than 4 Caracters & Less Than 20 Caracters")]
        [RegularExpression("^[ا-ي ء أ ؤ]+$*[ؤ ء أ ا-ي]+[ؤ ء أ ا-ي]*$",
            ErrorMessage = "Name Must Contain only Letters")]
        public string SecondLang { get; set; }

        [AllowNull]
        [Display(Name = "Parent Phone")]
        [StringLength(11),
            RegularExpression(@"^01[0125][0-9]{8}$",
            ErrorMessage = "Invalid phone number")]
        public string? Par_Phone { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string ConfirmPassword { get; set; }
    }
}
