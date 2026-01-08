using CanteenManagementSystem.logic.models;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface ITransactionRepository
    {
        Transaction GetById(int id);
        List<Transaction> GetAll();
        List<Transaction> GetByDate(DateTime date);
        List<Transaction> GetByDateRange(DateTime startDate, DateTime endDate);
        List<Transaction> GetByUser(int userId);
        decimal GetDailySalesTotal(DateTime date);
        void Save(Transaction transaction);
        void Update(Transaction transaction);
    }
}