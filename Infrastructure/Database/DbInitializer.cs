using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Database
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Patients.Any()) return;

            var patients = new List<Patient>
            {
                new() { Id = 1, Name = "Tom", NHSNumber = "NHS21", DateOfBirth = new DateOnly(2000, 10, 28), GPPractice ="North Medical GP" },
                new() { Id = 2, Name = "Jerry", NHSNumber = "NHS22", DateOfBirth = new DateOnly(2002, 11, 28), GPPractice ="South Medical GP" },
                new() { Id = 3, Name = "Oscar", NHSNumber = "NHS23", DateOfBirth = new DateOnly(2001, 9, 28), GPPractice = "East Medical GP" },
                new() { Id = 4, Name = "Oasis", NHSNumber = "NHS24", DateOfBirth = new DateOnly(2007, 12, 28), GPPractice = "Hill Medical GP" },
                new() { Id = 5, Name = "Pete", NHSNumber = "NHS25", DateOfBirth = new DateOnly(2010, 11, 28), GPPractice="West Medical GP" },
            };

            context.Patients.AddRange(patients);
            context.SaveChanges();
        }
    }
}
