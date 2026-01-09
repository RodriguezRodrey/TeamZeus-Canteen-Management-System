using System;
using System.Collections.Generic;
using System.Linq;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;

namespace CanteenManagementSystem.logic.services
{
    public class ProductManager
    {
        private IProductRepository _productRepository;
        
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            ValidateProduct(product);
            _productRepository.Save(product);
        }

        public void UpdateProduct(Product product)
        {
            ValidateProduct(product);
            
            Product existingProduct = _productRepository.GetById(product.ProductId);
            if (existingProduct == null)
                throw new ArgumentException("Product not found");
            
            _productRepository.Update(product);
        }

        public void DeleteProduct(int productId)
        {
            Product product = _productRepository.GetById(productId);
            if (product == null)
                throw new ArgumentException("Product not found");
            
            _productRepository.Delete(productId);
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetById(productId);
        }

        public Product GetProductByCode(string productCode)
        {
            return _productRepository.GetByProductCode(productCode);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public List<Product> GetLowStockProducts()
        {
            return _productRepository.GetLowStockProducts();
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            return _productRepository.SearchProducts(searchTerm);
        }

        private void ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new ArgumentException("Product name is required");
            
            if (product.UnitPrice <= 0)
                throw new ArgumentException("Unit price must be greater than 0");
            
            if (product.CostPrice <= 0)
                throw new ArgumentException("Cost price must be greater than 0");
            
            if (product.StockQuantity < 0)
                throw new ArgumentException("Stock quantity cannot be negative");
        }
    }
}