using System.Collections.Generic;
using LAB7WebDesignTanelHelmik.Data.Entities;

namespace LAB7WebDesignTanelHelmik.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        IEnumerable<User> GetAllUsers();

        void SaveUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}