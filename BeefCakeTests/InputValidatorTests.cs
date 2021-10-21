using System;
using System.Collections.Generic;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using BeefCakeLogic;
using NSubstitute;
using NUnit.Framework;

namespace BeefCakeTests
{
    public class InputValidatorTests
    {
        InputValidator inputValidator;
        IUserDao userDaoSubstitute;
        [SetUp]
        public void SetUp()
        {
            userDaoSubstitute = Substitute.For<IUserDao>();
            userDaoSubstitute.ReadAll().Returns(new List<User>());
            inputValidator = new InputValidator(userDaoSubstitute);
        }

        [Test]
        public void TestIsDateOfBirthInThePast()
        {
            string message = "";
            DateTime date = new DateTime(2020, 12, 12);
            DateTime isDateInThePast = DateTime.Today;
            Assert.IsTrue(inputValidator.IsDateOfBirthInThePast(date, out message));
        }

        [Test]
        public void TestIsUserNameAvailable()
        {
            string message = "";
            string name = "Jozef";
            Assert.IsTrue(inputValidator.IsUserNameAvailable(name, out message));
        }

        [Test]
        public void TestIsHeightInRange()
        {
            string message = "";
            decimal height = 200m;
            Assert.IsTrue(inputValidator.IsHeightValid(Convert.ToString(height), out message));
        }

        [Test]
        public void TestIsWeightInRange()
        {
            string message = "";
            decimal weight = 200m;
            Assert.IsTrue(inputValidator.IsWeightValid(Convert.ToString(weight), out message));
        }

        [Test]
        public void TestIsCaloriesInRange()
        {
            string message = "";
            int calories = 1200;
            Assert.IsTrue(inputValidator.IsCaloriesValid(Convert.ToString(calories), out message));
        }
    }
}
