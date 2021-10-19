using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BeefCakeLogic
{
    /// <summary>
    /// Validates input
    /// </summary>
    public class InputValidator
    {
        readonly IUserDao _userDao;

        const decimal minValidHeight = 10m;
        const decimal maxValidHeight = 300m;

        /// <summary>
        /// Initializes an <see cref="InputValidator"/>
        /// </summary>
        /// <param name="userDao">UserDao to use</param>
        public InputValidator(IUserDao userDao)
        {
            _userDao = userDao;
        }

        /// <summary>
        /// Checks if user with a given name doesn't exist in the database
        /// </summary>
        /// <param name="input">Name to check for</param>
        /// <param name="message">Returned error message</param>
        /// <returns>True if given name is not taken</returns>
        public bool IsUserNameAvailable(string input, out string message)
        {
            IList<User> allUsers = _userDao.ReadAll();
            bool isNameAvailable = !allUsers.Any(user => user.Name == input);
            message = isNameAvailable ? string.Empty : MessageResource.msgUserNameTaken;
            return isNameAvailable;
        }

        /// <summary>
        /// Checks if given date of birth is in the past
        /// </summary>
        /// <param name="input">Date to check</param>
        /// <param name="message">Returned error message</param>
        /// <returns>True if given date is in the past</returns>
        public bool IsDateOfBirthInThePast(DateTime input, out string message)
        {
            bool isDateInThePast = input.Date < DateTime.Today;
            message = isDateInThePast ? string.Empty : MessageResource.msgDateOfBirthNotInThePast;
            return isDateInThePast;
        }

        /// <summary>
        /// Checks if given height value is valid
        /// </summary>
        /// <param name="input">Height in centimeters</param>
        /// <param name="message">Returned error message</param>
        /// <returns>True if given height is a decimal within valid range</returns>
        public bool IsHeightValid(string input, out string message)
        {
            if (!decimal.TryParse(input, out decimal parsedInput))
            {
                message = MessageResource.msgHightIsNotANumber;
                return false;
            }

            if (!IsDecimalInRange(parsedInput, minValidHeight, maxValidHeight))
            {
                message = string.Format(MessageResource.msgHeightOutsideValidRange, minValidHeight, maxValidHeight);
                return false;
            }

            message = string.Empty;
            return true;
        }
        public bool IsWeightValid(string input, out string message)
        {
            throw new NotImplementedException();
        }
        public bool IsCaloriesValid(string input, out string message)
        {
            throw new NotImplementedException();
        }

        private bool IsIntInRange(int input, int minimum, int maximum)
        {
            return input >= minimum && input <= maximum;
        }

        private bool IsDecimalInRange(decimal input, decimal minimum, decimal maximum)
        {
            return input >= minimum && input <= maximum;
        }
    }
}
