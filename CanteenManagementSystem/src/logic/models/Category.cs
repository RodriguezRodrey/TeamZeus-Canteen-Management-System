using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}