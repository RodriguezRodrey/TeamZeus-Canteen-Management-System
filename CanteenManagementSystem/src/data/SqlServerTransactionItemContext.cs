using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerTransactionItemContext : ITransactionItemRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(TransactionItem item)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO TransactionItems " +
                               "(TransactionId, ProductId, Quantity, UnitPrice, Subtotal) " +
                               "VALUES (@TransactionId, @ProductId, @Quantity, @UnitPrice, @Subtotal)";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionId", item.TransactionId);
                    cmd.Parameters.AddWithValue("@ProductId", item.ProductId);
                    cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                    cmd.Parameters.AddWithValue("@Subtotal", item.Subtotal);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public TransactionItem GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM TransactionItems WHERE TransactionItemId = @TransactionItemId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionItemId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        TransactionItem item = CreateTransactionItemFromReader(reader);
                        return item;
                    }
                }
            }
        }

        public List<TransactionItem> GetByTransaction(int transactionId)
        {
            List<TransactionItem> items = new List<TransactionItem>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM TransactionItems WHERE TransactionId = @TransactionId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionId", transactionId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TransactionItem item = CreateTransactionItemFromReader(reader);
                            items.Add(item);
                        }
                    }
                }
            }

            return items;
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "DELETE FROM TransactionItems WHERE TransactionItemId = @TransactionItemId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionItemId", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private TransactionItem CreateTransactionItemFromReader(SqlDataReader reader)
        {
            TransactionItem item = new TransactionItem
            {
                TransactionItemId = Convert.ToInt32(reader["TransactionItemId"]),
                TransactionId = Convert.ToInt32(reader["TransactionId"]),
                ProductId = Convert.ToInt32(reader["ProductId"]),
                Quantity = Convert.ToInt32(reader["Quantity"]),
                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                Subtotal = Convert.ToDecimal(reader["Subtotal"])
            };

            return item;
        }
    }
}