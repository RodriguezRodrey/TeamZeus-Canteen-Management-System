using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ChangeAmount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        
        public int? VoidedByUserId { get; set; }
        public User VoidedBy { get; set; }
        
        public string VoidedReason { get; set; }
        public DateTime? VoidedDate { get; set; }
        
        public ICollection<TransactionItem> TransactionItems { get; set; }
        
        public Transaction()
        {
            TransactionDate = DateTime.Now;
            TransactionStatus = TransactionStatus.Pending;
        }
        
        public void CalculateChange()
        {
            ChangeAmount = AmountPaid - TotalAmount;
        }
        
        public void Void(int voidedByUserId, string reason)
        {
            TransactionStatus = TransactionStatus.Voided;
            VoidedByUserId = voidedByUserId;
            VoidedReason = reason;
            VoidedDate = DateTime.Now;
        }
    }
}