using CanteenManagementSystem.logic.models;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.logic.interfaces
{
    public interface IStockMovementRepository
    {
        StockMovement GetById(int id);
        List<StockMovement> GetAll();
        List<StockMovement> GetByProduct(int productId);
        List<StockMovement> GetByDateRange(DateTime startDate, DateTime endDate);
        void Save(StockMovement movement);
    }
}