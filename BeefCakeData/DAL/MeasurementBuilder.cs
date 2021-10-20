using BeefCakeData.Model;
using System;

namespace BeefCakeData.DAL
{
    public static class MeasurementBuilder
    {
        public static Measurement BuildMeasurement(DateTime date, string weight, string calories, int currentUserId)
        {
            var newMeasurement = new Measurement()
            {
                Date = date,
                Weight = decimal.Parse(weight),
                Calories = int.Parse(calories),
                UserId = currentUserId,
            };
            return newMeasurement;
        }
    }
}