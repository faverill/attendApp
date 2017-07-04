using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using attendapp.DataModels;

namespace attendapp.Migrations
{
    [DbContext(typeof(attendappContext))]
    partial class attendappContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("attendapp.DataModels.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Teacher")
                        .HasMaxLength(100);

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("attendapp.DataModels.Registration", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int?>("StudentId");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("attendapp.DataModels.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlphaOrder");

                    b.Property<string>("CellPhone");

                    b.Property<string>("CityAddress")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("HomePhone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("StateAddress");

                    b.Property<string>("StreetAddress1")
                        .HasMaxLength(200);

                    b.Property<string>("StreetAddress2")
                        .HasMaxLength(200);

                    b.Property<string>("ZipCode");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("attendapp.DataModels.Registration", b =>
                {
                    b.HasOne("attendapp.DataModels.Course")
                        .WithMany("Registrations")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("attendapp.DataModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });
        }
    }
}
