using System;
using CanteenManagementSystem.logic.enums;

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
        public StockMovementType MovementType { get; set; }
        public DateTime MovementDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string Reason { get; set; }
        
        public int PerformedById { get; set; }
        public User PerformedBy { get; set; }
        
        public StockMovement()
        {
            MovementDate = DateTime.Now;
        }
    }
}