

namespace CanteenManagementSystem.logic.models
{
    public class PurchaseOrderItem
    {
        public int PurchaseOrderItemId { get; set; }
        
        public int PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int Quantity { get; set; }
        public decimal UnitCostPrice { get; set; }
        public decimal Subtotal { get; set; } 
        
        public void CalculateSubtotal()
        {
            Subtotal = Quantity * UnitCostPrice;
        }
    }
}