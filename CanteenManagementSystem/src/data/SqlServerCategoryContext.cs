using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CanteenManagementSystem.data
{
    public class SQLServerCategoryContext : ICategoryRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "INSERT INTO Categories (CategoryName, CategoryDescription, IsActive) " +
                               "VALUES (@CategoryName, @CategoryDescription, @IsActive)";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    cmd.Parameters.AddWithValue("@CategoryDescription", category.CategoryDescription ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", category.IsActive);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Category GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Categories WHERE CategoryId = @CategoryId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        Category category = new Category
                        {
                            CategoryId = Convert.ToInt32(reader["CategoryId"]),
                            CategoryName = reader["CategoryName"].ToString(),
                            CategoryDescription = reader["CategoryDescription"] == DBNull.Value ? null : reader["CategoryDescription"].ToString(),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
                        };

                        return category;
                    }
                }
            }
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "SELECT * FROM Categories WHERE IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category
                            {
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                CategoryName = reader["CategoryName"].ToString(),
                                CategoryDescription = reader["CategoryDescription"] == DBNull.Value ? null : reader["CategoryDescription"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"])
                            };

                            categories.Add(category);
                        }
                    }
                }
            }

            return categories;
        }

        public void Update(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Categories SET " +
                               "CategoryName = @CategoryName, " +
                               "CategoryDescription = @CategoryDescription, " +
                               "IsActive = @IsActive " +
                               "WHERE CategoryId = @CategoryId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    cmd.Parameters.AddWithValue("@CategoryDescription", category.CategoryDescription ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", category.IsActive);
                    cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = "UPDATE Categories SET IsActive = 0 WHERE CategoryId = @CategoryId";

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}