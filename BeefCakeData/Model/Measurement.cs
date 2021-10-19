using System;

namespace BeefCakeData.Model
{
    public class Measurement
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Weight { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public decimal Bmi { get; set; }
    }
}
