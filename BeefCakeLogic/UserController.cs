using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;

namespace BeefCakeLogic
{
    public class UserController
    {
        readonly IUserDao _userDao;

        /// <summary>
        /// Initializes <see cref="UserController"/>
        /// </summary>
        /// <param name="userDao">UserDao to use</param>
        public UserController(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public void EditUser(User user)
        {
            _userDao.Update(user);
        }

        public void AddUser(User user)
        {
            _userDao.Add(user);
        }
    }
}
