using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace attendapp.DataModels
{
    public class Course
    {
        [Required]
        public virtual int CourseId { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }


        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Class name is required and must begin with an upper-case letter and be between 2 and 100 characters long.")]
        public virtual string CourseName { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Teacher name must begin with an upper-case letter and be between 2 and 100 characters long.")]
        public virtual string Teacher { get; set; }

        [StringLength(500, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Class description must begin with an upper-case letter and be between 2 and 500 characters long.")]
        public virtual string Description { get; set; }


        public virtual DateTime CreationDate { get; set; }

        public Course()
        {
            CreationDate = DateTime.Now;
        }


    }
}
