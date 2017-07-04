using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace attendapp.DataModels
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            attendappContext context = app.ApplicationServices
                .GetRequiredService<attendappContext>();
            if (!context.Students.Any())
            {
                context.Students.AddRange(
                     new Student
                     {
                         // StudentId = 1,
                         FirstName = "John",
                         LastName = "Smith",
                         AlphaOrder = "N-S",
                         Email = "jsmith@yahoo.com",
                         HomePhone = "(865) 272-5017",
                         CellPhone = "(865) 771-4171",
                         StreetAddress1 = "117 Whippoorwll Dr.",
                         StreetAddress2 = "",
                         CityAddress = "Elgin",
                         StateAddress = "IL",
                         ZipCode = "66901",
                         // CreationDate = DateTime.Now
                     },

                        new Student
                        {
                            // StudentId = 2,
                            FirstName = "Jane",
                            LastName = "Doe",
                            AlphaOrder = "A-F",
                            Email = "jdoe@yahoo.com",
                            HomePhone = "(865) 272-5017",
                            CellPhone = "(865) 771-4171",
                            StreetAddress1 = "117 Whippoorwll Dr.",
                            StreetAddress2 = "",
                            CityAddress = "Elgin",
                            StateAddress = "IL",
                            ZipCode = "66901",
                            // CreationDate = DateTime.Now
                        },

                        new Student
                        {
                            // StudentId = 3,
                            FirstName = "Harvey",
                            LastName = "Mudd",
                            AlphaOrder = "G-M",
                            Email = "hmudd@yahoo.com",
                            HomePhone = "(865) 272-5017",
                            CellPhone = "(865) 771-4171",
                            StreetAddress1 = "117 Whippoorwll Dr.",
                            StreetAddress2 = "",
                            CityAddress = "Elgin",
                            StateAddress = "IL",
                            ZipCode = "66901",
                            // CreationDate = DateTime.Now
                        },
                            new Student
                            {
                                // StudentId = 1,
                                FirstName = "Bob",
                                LastName = "Worthy",
                                AlphaOrder = "T-Z",
                                Email = "bworthy@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
                            },

                            new Student
                            {
                                // StudentId = 2,
                                FirstName = "Alice",
                                LastName = "Averill",
                                AlphaOrder = "A-F",
                                Email = "aaverill@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
                            },

                            new Student
                            {
                                // StudentId = 3,
                                FirstName = "Mike",
                                LastName = "Olson",
                                AlphaOrder = "N-S",
                                Email = "molson@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
                            },
                            new Student
                            {
                                // StudentId = 1,
                                FirstName = "Benda",
                                LastName = "Goodley",
                                AlphaOrder = "G-M",
                                Email = "bgoodley@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
                },

                            new Student
                            {
                                // StudentId = 2,
                                FirstName = "Sue",
                                LastName = "Jones",
                                AlphaOrder = "G-M",
                                Email = "sjones@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
                            },

                            new Student
                            {
                                // StudentId = 3,
                                FirstName = "Thomas",
                                LastName = "Zander",
                                AlphaOrder = "T-Z",
                                Email = "hmudd@yahoo.com",
                                HomePhone = "(865) 272-5017",
                                CellPhone = "(865) 771-4171",
                                StreetAddress1 = "117 Whippoorwll Dr.",
                                StreetAddress2 = "",
                                CityAddress = "Elgin",
                                StateAddress = "IL",
                                ZipCode = "66901",
                                // CreationDate = DateTime.Now
            });
            context.SaveChanges();
            }
        }
    }
}
