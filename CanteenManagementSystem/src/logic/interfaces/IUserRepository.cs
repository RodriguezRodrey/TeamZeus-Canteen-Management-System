using CanteenManagementSystem.logic.models;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);
        User GetByUsername(string username);
        User AuthenticateUser(string username, string password);
        List<User> GetAllUsers();
        void Save(User user);
        void Update(User user);
        void Delete(int id);
    }
}