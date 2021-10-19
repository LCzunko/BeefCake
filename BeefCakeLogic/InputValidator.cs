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

        public InputValidator(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public bool IsUserNameAvailable(string input, out string message)
        {
            IList<User> allUsers = _userDao.ReadAll();
            bool isNameAvailable = !allUsers.Any(user => user.Name == input);
            message = isNameAvailable ? string.Empty : MessageResource.msgUserNameTaken;
            return isNameAvailable;
        }
        public bool IsDateOfBirthInThePast(DateTime input, out string message)
        {
            bool isDateInThePast = input.Date < DateTime.Today;
            message = isDateInThePast ? string.Empty : MessageResource.msgDateOfBirthNotInThePast;
            return isDateInThePast;
        }
        public bool IsHeightValid(string input, out string message)
        {
            throw new NotImplementedException();
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
