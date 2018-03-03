using System.Collections.Generic;
using LAB7WebDesignTanelHelmik.Models;

namespace LAB7WebDesignTanelHelmik.Services
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);

        IEnumerable<UserViewModel> GetAllUsers();

        void SaveUser(UserViewModel user);

        void UpdateUser(UserViewModel user);

        void DeleteUser(int id);
  }
}