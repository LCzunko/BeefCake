using System.Collections.Generic;
using System.Linq;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;

namespace BeefCakeData.DAL.DAOImpl
{
    public class UserDao : IUserDao
    {
        public void Add(User user)
        {
            using (var context = new AppContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (var context = new AppContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public IList<User> ReadAll()
        {
            using (var context = new AppContext())
            {
                return context.Users.ToList();
            }
        }

        public void Update(User user)
        {
            using (var context = new AppContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}
