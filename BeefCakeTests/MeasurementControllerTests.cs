using System;
using BeefCakeData.Model;
using BeefCakeLogic;
using NUnit.Framework;

namespace BeefCakeTests
{
    public class MeasurementControllerTests
    {
        [Test]
        public void Given_NullUser_CalculateBmi_ThrowsArgumentNullException()
        {
            var measurement = new Measurement();

            Assert.Throws<ArgumentNullException>(() => MeasurementController.CalculateBmi(null, measurement));
        }

        [Test]
        public void Given_NullMeasurement_CalculateBmi_ThrowsArgumentNullException()
        {
            var user = new User();

            Assert.Throws<ArgumentNullException>(() => MeasurementController.CalculateBmi(user, null));
        }

        [TestCase(10, 100)]
        [TestCase(10, 200)]
        [TestCase(100, 200)]
        public void Given_ValidUserAndMeasurement_CalculateBmi_ReturnsExpectedAnswer(decimal weight, decimal height)
        {
            var user = new User { Height = height };
            var measurement = new Measurement { Weight = weight };
            var expectedBmi = weight / ((height/100) * (height/100));

            Assert.AreEqual(expectedBmi, MeasurementController.CalculateBmi(user, measurement));
        }

    }
}