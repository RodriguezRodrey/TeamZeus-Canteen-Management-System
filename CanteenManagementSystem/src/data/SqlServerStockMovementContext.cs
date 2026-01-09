using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.enums;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerStockMovementContext : IStockMovementRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(StockMovement movement)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO StockMovements " +
                               "(ProductId, SupplierId, QuantityChanged, MovementType, MovementDate, " +
                               "ReferenceNumber, Reason, PerformedById) " +
                               "VALUES (@ProductId, @SupplierId, @QuantityChanged, @MovementType, @MovementDate, " +
                               "@ReferenceNumber, @Reason, @PerformedById)";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", movement.ProductId);
                    cmd.Parameters.AddWithValue("@SupplierId", movement.SupplierId ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@QuantityChanged", movement.QuantityChanged);
                    cmd.Parameters.AddWithValue("@MovementType", movement.MovementType.ToString());
                    cmd.Parameters.AddWithValue("@MovementDate", movement.MovementDate);
                    cmd.Parameters.AddWithValue("@ReferenceNumber", movement.ReferenceNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Reason", movement.Reason ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@PerformedById", movement.PerformedById);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public StockMovement GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM StockMovements WHERE StockMovementId = @StockMovementId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@StockMovementId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        StockMovement movement = CreateStockMovementFromReader(reader);
                        return movement;
                    }
                }
            }
        }

        public List<StockMovement> GetAll()
        {
            List<StockMovement> movements = new List<StockMovement>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM StockMovements ORDER BY MovementDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockMovement movement = CreateStockMovementFromReader(reader);
                            movements.Add(movement);
                        }
                    }
                }
            }

            return movements;
        }

        public List<StockMovement> GetByProduct(int productId)
        {
            List<StockMovement> movements = new List<StockMovement>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM StockMovements " +
                               "WHERE ProductId = @ProductId " +
                               "ORDER BY MovementDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockMovement movement = CreateStockMovementFromReader(reader);
                            movements.Add(movement);
                        }
                    }
                }
            }

            return movements;
        }

        public List<StockMovement> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            List<StockMovement> movements = new List<StockMovement>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM StockMovements " +
                               "WHERE MovementDate >= @StartDate AND MovementDate <= @EndDate " +
                               "ORDER BY MovementDate DESC";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockMovement movement = CreateStockMovementFromReader(reader);
                            movements.Add(movement);
                        }
                    }
                }
            }

            return movements;
        }

        private StockMovement CreateStockMovementFromReader(SqlDataReader reader)
        {
            StockMovement movement = new StockMovement
            {
                StockMovementId = Convert.ToInt32(reader["StockMovementId"]),
                ProductId = Convert.ToInt32(reader["ProductId"]),
                SupplierId = reader["SupplierId"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["SupplierId"]),
                QuantityChanged = Convert.ToInt32(reader["QuantityChanged"]),
                MovementType = (StockMovementType)Enum.Parse(typeof(StockMovementType), reader["MovementType"].ToString()),
                MovementDate = Convert.ToDateTime(reader["MovementDate"]),
                ReferenceNumber = reader["ReferenceNumber"] == DBNull.Value ? null : reader["ReferenceNumber"].ToString(),
                Reason = reader["Reason"] == DBNull.Value ? null : reader["Reason"].ToString(),
                PerformedById = Convert.ToInt32(reader["PerformedById"])
            };

            return movement;
        }
    }
}