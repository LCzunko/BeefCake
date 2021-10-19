﻿using BeefCakeData.Model;

namespace BeefCakeData.DAL.DAOInterface
{
    public interface IUserDao
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        void ReadAll();
    }
}
