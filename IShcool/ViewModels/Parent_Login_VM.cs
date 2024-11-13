using System.ComponentModel.DataAnnotations;

namespace IShcool.ViewModels
{
    public class Parent_Login_VM
    {
        [Display(Name = "Student Phone")]
        [StringLength(11),
            RegularExpression(@"^01[0125][0-9]{8}$",
            ErrorMessage ="Invalid phone number")]
        public string StudentPhone { get; set; }

        [Display(Name = "Parent Phone")]
        [StringLength(11),
           RegularExpression(@"^01[0125][0-9]{8}$",
           ErrorMessage = "Invalid phone number")]
        public string ParentPhone { get; set; }
    }
}
