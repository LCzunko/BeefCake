using System;
using System.Collections.Generic;
using BeefCakeData.Model;
using BeefCakeData.Utilities;
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
                Id = 1,
                Name = "Grzesiek",
                DateOfBirth = DateTime.Parse("1992-07-09"),
                Height = 175,
                Gender = Gender.M
            });
            Users.Add(new User()
            {
                Id = 2,
                Name = "Piotr",
                DateOfBirth = DateTime.Parse("1982-07-04"),
                Height = 185,
                Gender = Gender.M
            });
            Users.Add(new User()
            {
                Id = 3,
                Name = "Łukasz",
                DateOfBirth = DateTime.Parse("1994-06-05"),
                Height = 185,
                Gender = Gender.M
            });
            Users.Add(new User()
            {
                Id = 4,
                Name = "Sylwia",
                DateOfBirth = DateTime.Parse("1992-11-14"),
                Height = 170,
                Gender = Gender.F
            });

            List<Measurement> Measurements = new();
            Measurements.Add(new Measurement()
            {
                Id = 1,
                UserId = 1,
                Calories = 3000,
                Date = DateTime.Now,
                Weight = 68.5m,
                Bmi = 22.2m
            });
            Measurements.Add(new Measurement()
            {
                Id = 1,
                UserId = 2,
                Calories = 3500,
                Date = DateTime.Now,
                Weight = 80,
                Bmi = 23.3m
            });
            Measurements.Add(new Measurement()
            {
                Id = 1,
                UserId = 3,
                Calories = 2000,
                Date = DateTime.Now,
                Weight = 78,
                Bmi = 22.7m
            });
            Measurements.Add(new Measurement()
            {
                Id = 1,
                UserId = 4,
                Calories = 1900,
                Date = DateTime.Now,
                Weight = 54.0m,
                Bmi = 18.6m
            });


            builder.Entity<User>().HasData(Users);
            builder.Entity<Measurement>().HasData(Measurements);
        }
    }
}
