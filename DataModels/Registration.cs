using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations.Schema;

namespace attendapp.DataModels
{
    public class Registration
    {     
        public int RegistrationId { get; set; }
        public virtual int CourseId { get; set; }
        public Student Student { get; set; }
    }
}
