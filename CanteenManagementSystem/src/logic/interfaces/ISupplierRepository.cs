using CanteenManagementSystem.logic.models;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface ISupplierRepository
    {
        Supplier GetById(int id);
        List<Supplier> GetAll();
        void Save(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
    }
}