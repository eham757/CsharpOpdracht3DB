using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace COpdrachtDatabase
{
    public class Student
    {
        [Required]
        [StringLength(100, ErrorMessage = "Description Max Length is 100")]
        public string StudentName { get; set; }

        [Key]
        public int StudentNumber{ get; set; }
        public decimal? StudentHeight { get; set; }
        public float? StudentWeight { get; set; }

        [Required]
        public short StudentDivision { get; set; }
    }
}
