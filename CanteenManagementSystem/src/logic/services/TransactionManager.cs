using System;
using System.Collections.Generic;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.services
{
    public class TransactionManager
    {
        private ITransactionRepository _transactionRepository;
        private ITransactionItemRepository _transactionItemRepository;
        private IProductRepository _productRepository;
        private IStockMovementRepository _stockMovementRepository;
        
        public TransactionManager(
            ITransactionRepository transactionRepository,
            ITransactionItemRepository transactionItemRepository,
            IProductRepository productRepository,
            IStockMovementRepository stockMovementRepository)
        {
            _transactionRepository = transactionRepository;
            _transactionItemRepository = transactionItemRepository;
            _productRepository = productRepository;
            _stockMovementRepository = stockMovementRepository;
        }

        public Transaction ProcessSale(
            int userId, 
            List<TransactionItem> items, 
            decimal amountPaid, 
            PaymentMethod paymentMethod)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("Transaction must have at least one item");
            
            foreach (TransactionItem item in items)
            {
                Product product = _productRepository.GetById(item.ProductId);
                if (product.StockQuantity < item.Quantity)
                    throw new InvalidOperationException(
                        string.Format("Insufficient stock for {0}", product.ProductName));
            }

            decimal total = 0;
            foreach (TransactionItem item in items)
            {
                total += item.Subtotal;
            }

            if (amountPaid < total)
                throw new InvalidOperationException("Insufficient payment amount");
            
            Transaction transaction = new Transaction
            {
                UserId = userId,
                TransactionDate = DateTime.Now,
                TotalAmount = total,
                AmountPaid = amountPaid,
                ChangeAmount = amountPaid - total,
                PaymentMethod = paymentMethod,
                TransactionStatus = TransactionStatus.Completed
            };
            
            _transactionRepository.Save(transaction);
            
            foreach (TransactionItem item in items)
            {
                item.TransactionId = transaction.TransactionId;
                _transactionItemRepository.Save(item);
                
                Product product = _productRepository.GetById(item.ProductId);
                product.StockQuantity -= item.Quantity;
                _productRepository.Update(product);

                StockMovement movement = new StockMovement
                {
                    ProductId = item.ProductId,
                    QuantityChanged = -item.Quantity,
                    MovementType = StockMovementType.Sale,
                    MovementDate = DateTime.Now,
                    ReferenceNumber = string.Format("TRX-{0}", transaction.TransactionId),
                    Reason = "Point of Sale",
                    PerformedById = userId
                };
                _stockMovementRepository.Save(movement);
            }

            return transaction;
        }

        public void VoidTransaction(int transactionId, int voidedByUserId, string reason)
        {
            Transaction transaction = _transactionRepository.GetById(transactionId);
            if (transaction == null)
                throw new ArgumentException("Transaction not found");

            if (transaction.TransactionStatus == TransactionStatus.Voided)
                throw new InvalidOperationException("Transaction already voided");
            
            transaction.TransactionStatus = TransactionStatus.Voided;
            transaction.VoidedByUserId = voidedByUserId;
            transaction.VoidedReason = reason;
            transaction.VoidedDate = DateTime.Now;
            
            _transactionRepository.Update(transaction);
            
            List<TransactionItem> items = _transactionItemRepository.GetByTransaction(transactionId);

            foreach (TransactionItem item in items)
            {
                Product product = _productRepository.GetById(item.ProductId);
                product.StockQuantity += item.Quantity;
                _productRepository.Update(product);

                StockMovement movement = new StockMovement
                {
                    ProductId = item.ProductId,
                    QuantityChanged = item.Quantity,
                    MovementType = StockMovementType.Return,
                    MovementDate = DateTime.Now,
                    ReferenceNumber = string.Format("VOID-{0}", transactionId),
                    Reason = string.Format("Voided transaction: {0}", reason),
                    PerformedById = voidedByUserId
                };
                _stockMovementRepository.Save(movement);
            }
        }

        public List<Transaction> GetDailyTransactions(DateTime date)
        {
            return _transactionRepository.GetByDate(date);
        }

        public decimal GetDailySalesTotal(DateTime date)
        {
            return _transactionRepository.GetDailySalesTotal(date);
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _transactionRepository.GetById(transactionId);
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactionRepository.GetAll();
        }

        public List<Transaction> GetTransactionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _transactionRepository.GetByDateRange(startDate, endDate);
        }

        public List<TransactionItem> GetTransactionItems(int transactionId)
        {
            return _transactionItemRepository.GetByTransaction(transactionId);
        }
    }
}