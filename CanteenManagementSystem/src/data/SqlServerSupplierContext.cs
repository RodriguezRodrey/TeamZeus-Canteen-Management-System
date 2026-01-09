using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerSupplierContext : ISupplierRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO Suppliers " +
                               "(SupplierName, ContactName, ContactPhone, Address, Email, IsActive) " +
                               "VALUES (@SupplierName, @ContactName, @ContactPhone, @Address, @Email, @IsActive)";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ContactPhone", supplier.ContactPhone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", supplier.IsActive);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Supplier GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Suppliers WHERE SupplierId = @SupplierId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Supplier supplier = new Supplier
                        {
                            SupplierId = Convert.ToInt32(reader["SupplierId"]),
                            SupplierName = reader["SupplierName"].ToString(),
                            ContactName = reader["ContactName"] == DBNull.Value ? null : reader["ContactName"].ToString(),
                            ContactPhone = reader["ContactPhone"] == DBNull.Value ? null : reader["ContactPhone"].ToString(),
                            Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString(),
                            Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        };

                        return supplier;
                    }
                }
            }
        }

        public List<Supplier> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Suppliers WHERE IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier
                            {
                                SupplierId = Convert.ToInt32(reader["SupplierId"]),
                                SupplierName = reader["SupplierName"].ToString(),
                                ContactName = reader["ContactName"] == DBNull.Value ? null : reader["ContactName"].ToString(),
                                ContactPhone = reader["ContactPhone"] == DBNull.Value ? null : reader["ContactPhone"].ToString(),
                                Address = reader["Address"] == DBNull.Value ? null : reader["Address"].ToString(),
                                Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };

                            suppliers.Add(supplier);
                        }
                    }
                }
            }

            return suppliers;
        }

        public void Update(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Suppliers SET " +
                               "SupplierName = @SupplierName, " +
                               "ContactName = @ContactName, " +
                               "ContactPhone = @ContactPhone, " +
                               "Address = @Address, " +
                               "Email = @Email, " +
                               "IsActive = @IsActive " +
                               "WHERE SupplierId = @SupplierId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@ContactName", supplier.ContactName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ContactPhone", supplier.ContactPhone ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", supplier.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", supplier.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", supplier.IsActive);
                    cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Suppliers SET IsActive = 0 WHERE SupplierId = @SupplierId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierId", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}