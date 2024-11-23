using System.ComponentModel.DataAnnotations;

namespace IShcool.ViewModels
{
    public class Enrollment_VM
    {
        [Display(Name = "Subjects")]
        [RegularExpression("^,[ا-ي ء أ ؤ]+$*[ؤ ء أ ا-ي]+[ؤ ء أ ا-ي]*$",
            ErrorMessage = "Name Must Contain only Letters")]
        public string Subjects { get; set; }

        [Display(Name = "Teachers Phone")]
        [RegularExpression("^01[0125][0-9],$",
            ErrorMessage = "Invalid phone numbers")]
        public string TeachersPhones { get; set; }
    }
}
