﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAdmin.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        //Course ID
        public string Subject { get; set; }
        //Course Subject (Math, English, Science)
        public DateTime Time { get; set; }
        //Time of the course
        public int RoomNum { get; set; }
        //The room number for the course


        //Forign key Teachers
        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        //Teachers can have many courses 
    }
}