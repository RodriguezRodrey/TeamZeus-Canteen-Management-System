using System;

namespace CanteenManagementSystem.logic.models
{
    public class StockMovement
    {
        public int StockMovementId { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        
        public int QuantityChanged { get; set; }
        public string StockMovementType { get; set; }
        public DateTime StockMovementDate { get; set; }
        public int ReferenceNumber { get; set; }
        public string Reason { get; set; }
        
        public int PerformedById { get; set; }
        public User PerformedBy { get; set; }
    }
}