using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public int UnitPrice { get; set; }
        public int CostPrice { get; set; }
        public int StockQuantity { get; set; }
        public int CriticalStockLevel { get; set; }
        public string ProductImage { get; set; }
        public DateTime DateAdded { get; set; }
        
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public ICollection<TransactionItem> TransactionItems { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
    }
}