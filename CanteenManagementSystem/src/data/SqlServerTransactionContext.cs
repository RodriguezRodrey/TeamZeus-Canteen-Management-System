using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.enums;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerTransactionContext : ITransactionRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(Transaction transaction)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO Transactions " +
                                "(UserId, TransactionDate, TotalAmount, AmountPaid, ChangeAmount, " +
                                "PaymentMethod, TransactionStatus, VoidedByUserId, VoidedReason, VoidedDate) " +
                                "VALUES (@UserId, @TransactionDate, @TotalAmount, @AmountPaid, @ChangeAmount, " +
                                "@PaymentMethod, @TransactionStatus, @VoidedByUserId, @VoidedReason, @VoidedDate); " +
                                "SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", transaction.UserId);
                    cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                    cmd.Parameters.AddWithValue("@AmountPaid", transaction.AmountPaid);
                    cmd.Parameters.AddWithValue("@ChangeAmount", transaction.ChangeAmount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", transaction.PaymentMethod.ToString());
                    cmd.Parameters.AddWithValue("@TransactionStatus", transaction.TransactionStatus.ToString());
                    cmd.Parameters.AddWithValue("@VoidedByUserId", transaction.VoidedByUserId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VoidedReason", transaction.VoidedReason ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VoidedDate", transaction.VoidedDate ?? (object)DBNull.Value);

                    conn.Open();
                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    transaction.TransactionId = newId;
                }
            }
        }

        public Transaction GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Transactions WHERE TransactionId = @TransactionId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Transaction transaction = CreateTransactionFromReader(reader);
                        return transaction;
                    }
                }
            }
        }

        public List<Transaction> GetAll()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Transactions ORDER BY TransactionDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = CreateTransactionFromReader(reader);
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetByDate(DateTime date)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Transactions " +
                                "WHERE CAST(TransactionDate AS DATE) = @Date " +
                                "ORDER BY TransactionDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = CreateTransactionFromReader(reader);
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Transactions " +
                                "WHERE TransactionDate >= @StartDate AND TransactionDate <= @EndDate " +
                                "ORDER BY TransactionDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = CreateTransactionFromReader(reader);
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetByUser(int userId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Transactions " +
                                "WHERE UserId = @UserId " +
                                "ORDER BY TransactionDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = CreateTransactionFromReader(reader);
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public decimal GetDailySalesTotal(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT SUM(TotalAmount) FROM Transactions " +
                                "WHERE CAST(TransactionDate AS DATE) = @Date " +
                                "AND TransactionStatus = @Status";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", date.Date);
                    cmd.Parameters.AddWithValue("@Status", TransactionStatus.Completed.ToString());

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public void Update(Transaction transaction)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Transactions SET " +
                                "UserId = @UserId, " +
                                "TransactionDate = @TransactionDate, " +
                                "TotalAmount = @TotalAmount, " +
                                "AmountPaid = @AmountPaid, " +
                                "ChangeAmount = @ChangeAmount, " +
                                "PaymentMethod = @PaymentMethod, " +
                                "TransactionStatus = @TransactionStatus, " +
                                "VoidedByUserId = @VoidedByUserId, " +
                                "VoidedReason = @VoidedReason, " +
                                "VoidedDate = @VoidedDate " +
                                "WHERE TransactionId = @TransactionId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", transaction.UserId);
                    cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                    cmd.Parameters.AddWithValue("@AmountPaid", transaction.AmountPaid);
                    cmd.Parameters.AddWithValue("@ChangeAmount", transaction.ChangeAmount);
                    cmd.Parameters.AddWithValue("@PaymentMethod", transaction.PaymentMethod.ToString());
                    cmd.Parameters.AddWithValue("@TransactionStatus", transaction.TransactionStatus.ToString());
                    cmd.Parameters.AddWithValue("@VoidedByUserId", transaction.VoidedByUserId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VoidedReason", transaction.VoidedReason ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@VoidedDate", transaction.VoidedDate ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@TransactionId", transaction.TransactionId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Transaction CreateTransactionFromReader(SqlDataReader reader)
        {
            Transaction transaction = new Transaction
            {
                TransactionId = Convert.ToInt32(reader["TransactionId"]),
                UserId = Convert.ToInt32(reader["UserId"]),
                TransactionDate = Convert.ToDateTime(reader["TransactionDate"]),
                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                AmountPaid = Convert.ToDecimal(reader["AmountPaid"]),
                ChangeAmount = Convert.ToDecimal(reader["ChangeAmount"]),
                PaymentMethod = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), reader["PaymentMethod"].ToString()),
                TransactionStatus =
                    (TransactionStatus)Enum.Parse(typeof(TransactionStatus), reader["TransactionStatus"].ToString()),
                VoidedByUserId = reader["VoidedByUserId"] == DBNull.Value
                    ? (int?)null
                    : Convert.ToInt32(reader["VoidedByUserId"]),
                VoidedReason = reader["VoidedReason"] == DBNull.Value ? null : reader["VoidedReason"].ToString(),
                VoidedDate = reader["VoidedDate"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(reader["VoidedDate"])
            };

            return transaction;
        }

        // BONUS: Transaction with items (atomic operation)
        public void SaveTransactionWithItems(Transaction transaction, List<TransactionItem> items)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                conn.Open();
                using (SqlTransaction dbTransaction = conn.BeginTransaction())
                {
                    // Save transaction
                    string sqlQry = "INSERT INTO Transactions " +
                                    "(UserId, TransactionDate, TotalAmount, AmountPaid, ChangeAmount, " +
                                    "PaymentMethod, TransactionStatus, VoidedByUserId, VoidedReason, VoidedDate) " +
                                    "VALUES (@UserId, @TransactionDate, @TotalAmount, @AmountPaid, @ChangeAmount, " +
                                    "@PaymentMethod, @TransactionStatus, @VoidedByUserId, @VoidedReason, @VoidedDate); " +
                                    "SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sqlQry, conn, dbTransaction))
                    {
                        cmd.Parameters.AddWithValue("@UserId", transaction.UserId);
                        cmd.Parameters.AddWithValue("@TransactionDate", transaction.TransactionDate);
                        cmd.Parameters.AddWithValue("@TotalAmount", transaction.TotalAmount);
                        cmd.Parameters.AddWithValue("@AmountPaid", transaction.AmountPaid);
                        cmd.Parameters.AddWithValue("@ChangeAmount", transaction.ChangeAmount);
                        cmd.Parameters.AddWithValue("@PaymentMethod", transaction.PaymentMethod.ToString());
                        cmd.Parameters.AddWithValue("@TransactionStatus", transaction.TransactionStatus.ToString());
                        cmd.Parameters.AddWithValue("@VoidedByUserId", transaction.VoidedByUserId ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@VoidedReason", transaction.VoidedReason ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@VoidedDate", transaction.VoidedDate ?? (object)DBNull.Value);

                        int newId = Convert.ToInt32(cmd.ExecuteScalar());
                        transaction.TransactionId = newId;
                    }

                    // Save transaction items
                    foreach (var item in items)
                    {
                        item.TransactionId = transaction.TransactionId;

                        string itemQry = "INSERT INTO TransactionItems " +
                                         "(TransactionId, ProductId, Quantity, UnitPrice, Subtotal) " +
                                         "VALUES (@TransactionId, @ProductId, @Quantity, @UnitPrice, @Subtotal)";

                        using (SqlCommand cmd = new SqlCommand(itemQry, conn, dbTransaction))
                        {
                            cmd.Parameters.AddWithValue("@TransactionId", item.TransactionId);
                            cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                            cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);

                            cmd.ExecuteNonQuery();
                        }

                        // Update product stock
                        string updateStockQry = "UPDATE Products SET StockQuantity = StockQuantity - @Quantity " +
                                                "WHERE ProductId = @ProductId";

                        using (SqlCommand cmd = new SqlCommand(updateStockQry, conn, dbTransaction))
                        {
                            cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    dbTransaction.Commit();
                }
            }
        }
    }
}