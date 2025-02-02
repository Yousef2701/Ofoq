namespace ISchool.Data.Models
{
    public class Student
    {
        [Key]
        public string Id { get; set; }

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

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Must Be 11 Caracters")]
        public string? Par_Phone { get; set; } = null;

        public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();

        public virtual ICollection<LTestResult> LTestResults { get; } = new List<LTestResult>();

        public virtual ICollection<ExamResult> ExamResults { get; } = new List<ExamResult>();
    }
}
