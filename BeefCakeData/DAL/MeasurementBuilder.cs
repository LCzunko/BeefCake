using BeefCakeData.Model;
using System;

namespace BeefCakeData.DAL
{
    public static class MeasurementBuilder
    {
        public static Measurement BuildMeasurement(DateTime date, decimal weight, int calories, decimal bmi, int currentUserId)
        {
            var newMeasurement = new Measurement()
            {
                Date = date,
                Weight = weight,
                Calories = calories,
                Bmi = bmi,
                UserId = currentUserId,
            };
            return newMeasurement;
        }
    }
}