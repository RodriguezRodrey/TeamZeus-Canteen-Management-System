using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerProductContext : IProductRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO Products " +
                               "(ProductName, ProductCode, ProductDescription, CategoryId, UnitPrice, CostPrice, " +
                               "StockQuantity, CriticalStockLevel, ProductImage, IsActive, DateAdded) " +
                               "VALUES (@ProductName, @ProductCode, @ProductDescription, @CategoryId, @UnitPrice, @CostPrice, " +
                               "@StockQuantity, @CriticalStockLevel, @ProductImage, @IsActive, @DateAdded)";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@CostPrice", product.CostPrice);
                    cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    cmd.Parameters.AddWithValue("@CriticalStockLevel", product.CriticalStockLevel);
                    cmd.Parameters.AddWithValue("@ProductImage", product.ProductImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
                    cmd.Parameters.AddWithValue("@DateAdded", product.DateAdded);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Product GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Product product = CreateProductFromReader(reader);
                        return product;
                    }
                }
            }
        }

        public Product GetByProductCode(string productCode)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products WHERE ProductCode = @ProductCode";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductCode", productCode);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Product product = CreateProductFromReader(reader);
                        return product;
                    }
                }
            }
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products WHERE IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public List<Product> GetLowStockProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products " +
                               "WHERE StockQuantity <= CriticalStockLevel AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public List<Product> GetByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products WHERE CategoryId = @CategoryId AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Products " +
                               "WHERE (ProductName LIKE @SearchTerm " +
                               "OR ProductCode LIKE @SearchTerm " +
                               "OR ProductDescription LIKE @SearchTerm) " +
                               "AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = CreateProductFromReader(reader);
                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        public void Update(Product product)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Products SET " +
                               "ProductName = @ProductName, " +
                               "ProductCode = @ProductCode, " +
                               "ProductDescription = @ProductDescription, " +
                               "CategoryId = @CategoryId, " +
                               "UnitPrice = @UnitPrice, " +
                               "CostPrice = @CostPrice, " +
                               "StockQuantity = @StockQuantity, " +
                               "CriticalStockLevel = @CriticalStockLevel, " +
                               "ProductImage = @ProductImage, " +
                               "IsActive = @IsActive " +
                               "WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                    cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
                    cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                    cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    cmd.Parameters.AddWithValue("@CostPrice", product.CostPrice);
                    cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                    cmd.Parameters.AddWithValue("@CriticalStockLevel", product.CriticalStockLevel);
                    cmd.Parameters.AddWithValue("@ProductImage", product.ProductImage ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Products SET IsActive = 0 WHERE ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private Product CreateProductFromReader(SqlDataReader reader)
        {
            Product product = new Product
            {
                ProductId = Convert.ToInt32(reader["ProductId"]),
                ProductName = reader["ProductName"].ToString(),
                ProductCode = reader["ProductCode"].ToString(),
                ProductDescription = reader["ProductDescription"].ToString(),
                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                CostPrice = Convert.ToDecimal(reader["CostPrice"]),
                StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                CriticalStockLevel = Convert.ToInt32(reader["CriticalStockLevel"]),
                ProductImage = reader["ProductImage"] == DBNull.Value ? null : reader["ProductImage"].ToString(),
                IsActive = Convert.ToBoolean(reader["IsActive"]),
                DateAdded = Convert.ToDateTime(reader["DateAdded"])
            };

            return product;
        }
    }
}