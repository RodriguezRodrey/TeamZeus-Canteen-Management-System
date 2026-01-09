namespace CanteenManagementSystem.logic.models
{
    public class TransactionItem
    {
        public int TransactionItemId { get; set; }
        
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal { get; set; }
        
        public void CalculateSubtotal()
        {
            Subtotal = Quantity * UnitPrice;
        }
    }
}