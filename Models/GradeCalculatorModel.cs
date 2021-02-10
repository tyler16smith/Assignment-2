using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tyler_Assignment1.Models
{
    public class GradeCalculatorModel
    {
        // Set integer validator constraints - MinValue & MaxValue
        [Required]
        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100 and YOU ROCK!")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100 and YOU ROCK!")]
        public int Groupprojects { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100 and YOU ROCK!")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100 and YOU ROCK!")]
        public int Exams { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "You must enter a number between 0 and 100 and YOU ROCK!")]
        public int Intex { get; set; }
    }
}
