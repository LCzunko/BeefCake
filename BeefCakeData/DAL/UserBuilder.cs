using BeefCakeData.Model;
using BeefCakeData.Utilities;
using System;

namespace BeefCakeData.DAL
{
    public static class UserBuilder
    {
        public static User BuildUser(string userName, DateTime dateOfBirth, Gender gender, string height)
        {
            var newUser = new User()
            {
                Name = userName,
                DateOfBirth = dateOfBirth,
                Gender = gender,
                Height = Decimal.Parse(height)
            };
            return newUser;
        }
    }
}
