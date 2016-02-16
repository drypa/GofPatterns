using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IUserRepository
    {
        User Find(int userId);
        List<User> GetAll();
        void Save(User user);
    }
}
