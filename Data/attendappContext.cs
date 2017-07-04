using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using attendapp.DataModels;

namespace attendapp.DataModels
{
    public class attendappContext : DbContext
    {
        public attendappContext (DbContextOptions<attendappContext> options)
            : base(options)
        {
        }

        //public DbSet<attendapp.DataModels.Course> Course { get; set; }
		public DbSet<Course> Courses { get; set; }

		public DbSet<Student> Students { get; set; }
    }
}
