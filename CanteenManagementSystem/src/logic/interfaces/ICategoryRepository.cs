using CanteenManagementSystem.logic.models;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Save(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}