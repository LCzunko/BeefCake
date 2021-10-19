using System;
using BeefCakeData.Utilities;

namespace BeefCakeData.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public Gender Gender { get; set; }
    }
}
