﻿using System.ComponentModel.DataAnnotations;
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

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Phone Must Be 11 Caracters")]
        public string Phone { get; set; }

        [AllowNull]
        public bool First { get; set; } = true;

        [AllowNull]
        public bool Second { get; set; } = true;

        [AllowNull]
        public bool Third { get; set; } = true;

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string Password { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password Must Be More Than 8 Caracters & Less Than 16 Caracters")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Add an Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }
    }
}
