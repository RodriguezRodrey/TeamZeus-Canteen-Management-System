using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public ICollection<StockMovement> StockMovements { get; set; }
    }
}