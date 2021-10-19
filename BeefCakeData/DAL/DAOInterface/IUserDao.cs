using BeefCakeData.Model;
using System.Collections.Generic;

namespace BeefCakeData.DAL.DAOInterface
{
    public interface IUserDao
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        IList<User> ReadAll();
    }
}
