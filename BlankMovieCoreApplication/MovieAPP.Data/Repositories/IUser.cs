using MovieAPP.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAPP.Data.Repositories
{
    public interface IUser
    {
        string Register(UserModel userModel);
        UserModel Login(UserModel userModel);

        string Update(UserModel userModel);

        string Delete(int userId);

        object SelectUsers();

        object SelectUserById(int userId);

    }
}
