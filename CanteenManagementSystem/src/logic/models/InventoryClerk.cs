using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public class InventoryClerk : User
    {
        protected InventoryClerk() : base() { }
        
        public InventoryClerk(int userId, string firstName, string lastName, string email, string phone,
            string address, string username, string password)
            : base(userId, username, firstName, lastName, email, password, address, phone, UserRole.InventoryClerk)
        {
        }
    }
}