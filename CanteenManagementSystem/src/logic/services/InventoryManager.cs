using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.services
{
    public class InventoryManager
    {
        private IProductRepository _productRepository;
        private IStockMovementRepository _stockMovementRepository;
        
        public InventoryManager(
            IProductRepository productRepository,
            IStockMovementRepository stockMovementRepository)
        {
            _productRepository = productRepository;
            _stockMovementRepository = stockMovementRepository;
        }

        public void StockIn(int productId, int quantity, int performedByUserId, string reason)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0");

            Product product = _productRepository.GetById(productId);
            if (product == null)
                throw new ArgumentException("Product not found");
            
            product.StockQuantity += quantity;
            _productRepository.Update(product);
            
            StockMovement stockMovement = new StockMovement
            {
                ProductId = productId,
                QuantityChanged = quantity,
                MovementType = StockMovementType.StockIn,
                MovementDate = DateTime.Now,
                Reason = reason,
                PerformedById = performedByUserId
            };
            _stockMovementRepository.Save(stockMovement);
        }

        public void StockOut(int productId, int quantity, int performedByUserId, string reason)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0");

            Product product = _productRepository.GetById(productId);
            if (product == null)
                throw new ArgumentException("Product not found");

            if (product.StockQuantity < quantity)
                throw new InvalidOperationException("Insufficient stock");
            
            product.StockQuantity -= quantity;
            _productRepository.Update(product);
            
            StockMovement stockMovement = new StockMovement
            {
                ProductId = productId,
                QuantityChanged = -quantity,
                MovementType = StockMovementType.StockOut,
                MovementDate = DateTime.Now,
                Reason = reason,
                PerformedById = performedByUserId
            };
            _stockMovementRepository.Save(stockMovement);
        }

        public void AdjustStock(int productId, int newQuantity, int performedByUserId, string reason)
        {
            Product product = _productRepository.GetById(productId);
            if (product == null)
                throw new ArgumentException("Product not found");

            int quantityChanged = newQuantity - product.StockQuantity;
            
            product.StockQuantity = newQuantity;
            _productRepository.Update(product);
            
            StockMovement stockMovement = new StockMovement
            {
                ProductId = productId,
                QuantityChanged = quantityChanged,
                MovementType = StockMovementType.Adjustment,
                MovementDate = DateTime.Now,
                Reason = reason,
                PerformedById = performedByUserId
            };
            _stockMovementRepository.Save(stockMovement);
        }

        public List<StockMovement> GetStockMovementHistory(int productId)
        {
            return _stockMovementRepository.GetByProduct(productId);
        }

        public List<Product> GetCurrentInventory()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetLowStockProducts()
        {
            return _productRepository.GetLowStockProducts();
        }
    }
}