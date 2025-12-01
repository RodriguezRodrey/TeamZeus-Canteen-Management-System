namespace CanteenManagementSystem.logic.models
{
    public class Cashier : User
    {
        public Cashier(int userId, string firstName, string lastName, string email, string phone,
            string address, string username, string password)
            : base(userId, firstName, lastName, email, phone, address, username, password, "Cashier")
        {
        }
        
        public void ProcessSale() { }
        public void ViewInventoryLevels() { }
        public void GenerateReceipt() { }
        public void RequestRefundApproval() { }
    }
}