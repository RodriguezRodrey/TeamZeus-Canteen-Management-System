using CanteenManagementSystem.logic.models;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);
        Product GetByProductCode(string productCode);
        List<Product> GetAll();
        List<Product> GetLowStockProducts();
        List<Product> GetByCategory(int categoryId);
        List<Product> SearchProducts(string searchTerm);
        void Save(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}