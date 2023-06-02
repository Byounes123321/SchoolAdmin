using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolAdmin.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        //Primary Key
        public string Fname { get; set; }
        //Teacher First name    
        public string Lname { get; set; }
        //Teacher Last name
        public DateTime HireDate { get; set; }
        //Date teacher was hired
        public decimal Salary { get; set; }
        //Teacher Salary

        //A teacher has many courses 
        public ICollection<Course> Courses;

    }
}