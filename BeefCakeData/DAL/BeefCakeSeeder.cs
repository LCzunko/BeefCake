using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BeefCakeData.DAL
{
    public static class BeefCakeSeeder
    {
        public static void SeedBeefCake(this ModelBuilder builder)
        {
            List<User> Users = new();
            Users.Add(new User()
            {
                ID = 1,
                Name = "Mark",
                DateOfBirth = DateTime.Parse("1988-05-12"),
                Height: 180,
                Gender: Gender.Male
            });
            Users.Add(new User()
            {
                ID = 2,
                Name = "Susan",
                DateOfBirth = DateTime.Parse("1991-10-01"),
                Height: 165,
                Gender: Gender.Female
            });

            List<Measurement> Measurements = new();
            Measurements.Add(new Measurement()
            {
                ID = 1,
                UserId = 1,
                Calories =,
                Date =,
                Weight =
            });
            Measurements.Add(new Measurement()
            {
                ID = 1,
                UserId = 2,
                Calories =,
                Date = ,
                Weight =
            });


            builder.Entity<User>().HasData(Users);
            builder.Entity<Measurement>().HasData(Measurements);
        }
    }
}
