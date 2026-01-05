using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public class Cashier : User
    {
        
        protected Cashier() : base() { }
        
        public Cashier(int userId, string firstName, string lastName, string email, string phone,
            string address, string username, string password)
            : base(userId, firstName, lastName, email, phone, address, username, password, UserRole.Cashier)
        {
        }
        
        public void ProcessSale() { }
        public void ViewInventory() { }
        public void GenerateReceipt() { }
        public void RequestRefundApproval() { }
    }
}