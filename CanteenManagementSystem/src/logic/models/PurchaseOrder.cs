using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderNumber { get; set; }
        
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        
        public DateTime PurchaseOrderDate { get; set; }
        public DateTime PurchaseOrderDeliveryDate { get; set; }
        public string PurchaseOrderStatus { get; set; }
        public decimal PurchaseOrderTotal { get; set; }
        
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        
        public int? ReceivedById { get; set; }
        public User ReceivedBy { get; set; }
        
        public DateTime? ReceivedDate { get; set; }
        
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}