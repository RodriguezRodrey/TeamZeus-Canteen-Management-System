using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        public DateTime TransactionDate { get; set; }
        public int TotalAmount { get; set; }
        public int AmountPaid { get; set; }
        public int ChangeAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionStatus { get; set; }
        public string VoidedBy { get; set; }
        public string VoidedReason { get; set; }
        
        public ICollection<TransactionItem> TransactionItems { get; set; }
    }
}