using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int StockQuantity { get; set; }
        public int CriticalStockLevel { get; set; }
        public string ProductImage { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
        
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
        
        public Product()
        {
            IsActive = true;
            DateAdded = DateTime.Now;
        }
        
        public bool IsLowStock()
        {
            return StockQuantity <= CriticalStockLevel;
        }
        
        public bool IsOutOfStock()
        {
            return StockQuantity == 0;
        }
        
        public decimal GetProfitMargin()
        {
            if (UnitPrice == 0) return 0;
            return ((UnitPrice - CostPrice) / UnitPrice) * 100;
        }
    }
}