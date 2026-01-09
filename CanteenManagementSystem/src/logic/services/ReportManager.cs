using System;
using System.Collections.Generic;
using System.Linq;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.enums;

namespace CanteenManagementSystem.logic.services
{
    public class ReportManager
    {
        private ITransactionRepository _transactionRepository;
        private ITransactionItemRepository _transactionItemRepository;
        private IProductRepository _productRepository;
        
        public ReportManager(
            ITransactionRepository transactionRepository,
            ITransactionItemRepository transactionItemRepository,
            IProductRepository productRepository)
        {
            _transactionRepository = transactionRepository;
            _transactionItemRepository = transactionItemRepository;
            _productRepository = productRepository;
        }

        public SalesReport GetDailySalesReport(DateTime date)
        {
            List<Transaction> transactions = _transactionRepository.GetByDate(date);
            List<Transaction> completedTransactions = transactions
                .Where(t => t.TransactionStatus == TransactionStatus.Completed)
                .ToList();

            decimal totalSales = 0;
            foreach (Transaction t in completedTransactions)
            {
                totalSales += t.TotalAmount;
            }

            decimal averageTransaction = completedTransactions.Count > 0 
                ? totalSales / completedTransactions.Count 
                : 0;

            return new SalesReport
            {
                Date = date,
                TotalSales = totalSales,
                TransactionCount = completedTransactions.Count,
                AverageTransaction = averageTransaction
            };
        }

        public List<ProductSalesReport> GetTopSellingProducts(DateTime startDate, DateTime endDate, int top)
        {
            List<Transaction> transactions = _transactionRepository.GetByDateRange(startDate, endDate);
            List<int> transactionIds = transactions
                .Where(t => t.TransactionStatus == TransactionStatus.Completed)
                .Select(t => t.TransactionId)
                .ToList();

            Dictionary<int, ProductSalesData> productSales = new Dictionary<int, ProductSalesData>();

            foreach (int transactionId in transactionIds)
            {
                List<TransactionItem> items = _transactionItemRepository.GetByTransaction(transactionId);

                foreach (TransactionItem item in items)
                {
                    if (!productSales.ContainsKey(item.ProductId))
                    {
                        productSales[item.ProductId] = new ProductSalesData
                        {
                            ProductId = item.ProductId,
                            TotalQuantity = 0,
                            TotalRevenue = 0
                        };
                    }

                    productSales[item.ProductId].TotalQuantity += item.Quantity;
                    productSales[item.ProductId].TotalRevenue += item.Subtotal;
                }
            }

            List<ProductSalesReport> results = new List<ProductSalesReport>();

            foreach (KeyValuePair<int, ProductSalesData> kvp in productSales)
            {
                Product product = _productRepository.GetById(kvp.Key);
                if (product != null)
                {
                    results.Add(new ProductSalesReport
                    {
                        ProductId = kvp.Key,
                        ProductName = product.ProductName,
                        TotalQuantitySold = kvp.Value.TotalQuantity,
                        TotalRevenue = kvp.Value.TotalRevenue
                    });
                }
            }

            List<ProductSalesReport> topProducts = results
                .OrderByDescending(p => p.TotalQuantitySold)
                .Take(top)
                .ToList();

            return topProducts;
        }

        public InventoryReport GetCurrentInventoryReport()
        {
            List<Product> products = _productRepository.GetAll();

            decimal totalStockValue = 0;
            int lowStockCount = 0;
            int outOfStockCount = 0;

            foreach (Product product in products)
            {
                totalStockValue += product.StockQuantity * product.CostPrice;

                if (product.StockQuantity <= product.CriticalStockLevel)
                    lowStockCount++;

                if (product.StockQuantity == 0)
                    outOfStockCount++;
            }

            return new InventoryReport
            {
                TotalProducts = products.Count,
                TotalStockValue = totalStockValue,
                LowStockProducts = lowStockCount,
                OutOfStockProducts = outOfStockCount
            };
        }

        private class ProductSalesData
        {
            public int ProductId { get; set; }
            public int TotalQuantity { get; set; }
            public decimal TotalRevenue { get; set; }
        }
    }

    public class SalesReport
    {
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public int TransactionCount { get; set; }
        public decimal AverageTransaction { get; set; }
    }

    public class ProductSalesReport
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int TotalQuantitySold { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class InventoryReport
    {
        public int TotalProducts { get; set; }
        public decimal TotalStockValue { get; set; }
        public int LowStockProducts { get; set; }
        public int OutOfStockProducts { get; set; }
    }
}