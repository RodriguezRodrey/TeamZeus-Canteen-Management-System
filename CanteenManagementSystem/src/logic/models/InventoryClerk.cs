namespace CanteenManagementSystem.logic.models
{
    public class InventoryClerk : User
    {
        public InventoryClerk(int userId, string firstName, string lastName, string email, string phone,
            string address, string username, string password)
            : base(userId, firstName, lastName, email, phone, address, username, password, "InventoryClerk")
        {
        }
        
        public void ManageStock() { }
        public void RecordStockInOut() { }
        public void UpdateProductInfo() { }
        public void GenerateInventoryReport() { }
    }
}