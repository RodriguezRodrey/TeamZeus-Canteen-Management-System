using CanteenManagementSystem.logic.models;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface ITransactionItemRepository
    {
        TransactionItem GetById(int id);
        List<TransactionItem> GetByTransaction(int transactionId);
        void Save(TransactionItem item);
        void Delete(int id);
    }
}