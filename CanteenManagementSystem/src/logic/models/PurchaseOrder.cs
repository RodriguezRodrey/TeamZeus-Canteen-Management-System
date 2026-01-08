using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public class PurchaseOrder
    {
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrderNumber { get; set; }
        
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        
        public DateTime OrderDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; } 
        public PurchaseOrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        
        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        
        public int? ReceivedById { get; set; }
        public User ReceivedBy { get; set; }
        
        public string Notes { get; set; } 
        
        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        
        public PurchaseOrder()
        {
            OrderDate = DateTime.Now;
            Status = PurchaseOrderStatus.Pending;
        }
        
        public void GeneratePONumber()
        {
            PurchaseOrderNumber = $"PO-{OrderDate:yyyyMMdd}-{PurchaseOrderId:D6}";
        }
    }
}