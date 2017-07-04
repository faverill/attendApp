using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace attendapp.DataModels
{
    public class Student
    {
        [Required]
        public virtual int StudentId { get; set; }
   
        [Required]
        [StringLength(100, MinimumLength =2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage ="First name must begin with an upper-case letter and be between 2 and 100 characters long.")]
        public virtual string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "Last name must begin with an upper-case letter and be between 2 and 100 characters long.")]
        public virtual string LastName { get; set; }

        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+ "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$",
            ErrorMessage ="Please enter a valid email address.")]
        public virtual string Email { get; set; }

        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx")]
        public virtual string HomePhone { get; set; }

        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx")]
        public virtual string CellPhone { get; set; }

        [StringLength(200, MinimumLength = 2, ErrorMessage = "Street address must begin with an letter and be between 2 and 200 characters long.")]
        public virtual string StreetAddress1 { get; set; }

        [StringLength(200, MinimumLength = 2, ErrorMessage = "Street address must begin with an letter and be between 2 and 200 characters long.")]
        public virtual string StreetAddress2 { get; set; }

        [StringLength(200, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z].*$", ErrorMessage = "City name must begin with an upper-case letter and be between 2 and 200 characters long.")]
        public virtual string CityAddress { get; set; }

        [RegularExpression(@"[A-Z][A-Z]", ErrorMessage = "Please enter a valid 2 upper-case letter state abbreviation.")]
        public virtual string StateAddress { get; set; }

        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Please enter a valid zip code.")]
        public virtual string ZipCode { get; set; }

        public virtual string AlphaOrder { get; set; }

        public virtual DateTime CreationDate { get; set; }

        public Student()
        {
            CreationDate = DateTime.Now;
        }

    }
}