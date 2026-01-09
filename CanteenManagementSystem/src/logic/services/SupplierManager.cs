using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;

namespace CanteenManagementSystem.logic.services
{
    public class SupplierManager
    {
        private ISupplierRepository _supplierRepository;

        public SupplierManager(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepository.GetById(id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public void AddSupplier(Supplier supplier)
        {
            _supplierRepository.Save(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _supplierRepository.Update(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {
            _supplierRepository.Delete(supplierId);
        }
    }
}