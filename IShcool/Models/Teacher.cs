using IShcool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;

namespace The_Top_App.Models
{
    public class Teacher
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(55, MinimumLength = 3, ErrorMessage = "Name Must Be More Than 3 Caracters & Less Than 55 Caracters")]
        public string Name { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "Subject Must Be More Than 3 Caracters & Less Than 45 Caracters")]
        public string Subject { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Must Be 11 Caracters")]
        public string Phone { get; set; }

        [AllowNull]
        public bool First { get; set; } = true;

        [AllowNull]
        public bool Second { get; set; } = true;

        [AllowNull]
        public bool Third { get; set; } = true;

        [AllowNull]
        public string? Image_Url { get; set; } = null;

        public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();

        public virtual ICollection<Chapter> Chapters { get; } = new List<Chapter>();

        public virtual ICollection<Exam> Exams { get; } = new List<Exam>();

        public virtual ICollection<ExamResult> ExamResults { get; } = new List<ExamResult>();

        public virtual ICollection<Book> Books { get; } = new List<Book>();

    }
}
