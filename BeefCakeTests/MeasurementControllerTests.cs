using System;
using BeefCakeData.Model;
using BeefCakeLogic;
using NUnit.Framework;

namespace BeefCakeTests
{
    public class MeasurementControllerTests
    {
        [TestCase(10, 100)]
        [TestCase(10, 200)]
        [TestCase(100, 200)]
        public void Given_ValidUserAndMeasurement_CalculateBmi_ReturnsExpectedAnswer(decimal weight, decimal height)
        {
            var user = new User { Height = height };
            var measurement = new Measurement { Weight = weight };
            var expectedBmi = weight / ((height/100) * (height/100));

            Assert.AreEqual(expectedBmi, MeasurementController.CalculateBmi(height, weight));
        }

    }
}