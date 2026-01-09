using CanteenManagementSystem.logic.interfaces;
using CanteenManagementSystem.logic.models;
using CanteenManagementSystem.logic.enums;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static BCrypt.Net.BCrypt;

namespace CanteenManagementSystem.data
{
    public class SQLServerUserContext : IUserRepository
    {
        private string _conStr = helpers.SqlServerHelpers.GetConnectionString();

        public void Save(User user)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string tableName = GetTableNameByRole(user.Role);
                
                string hashedPassword = HashPassword(user.Password);
                
                string sqlQry = string.Format("INSERT INTO {0} " +
                               "(Username, Password, FirstName, LastName, Email, PhoneNumber, Address, CreatedByUserId, IsActive, CreatedAt) " +
                               "VALUES (@Username, @Password, @FirstName, @LastName, @Email, @PhoneNumber, @Address, @CreatedByUserId, @IsActive, @CreatedAt)", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@CreatedByUserId", user.CreatedByUserId);
                    cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                    cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetById(int id)
        {
            User user = GetUserFromTable("Admins", id);
            if (user != null) return user;

            user = GetUserFromTable("Cashiers", id);
            if (user != null) return user;

            user = GetUserFromTable("InventoryClerks", id);
            return user;
        }

        public User GetByUsername(string username)
        {
            User user = GetUserFromTableByUsername("Admins", username);
            if (user != null) return user;

            user = GetUserFromTableByUsername("Cashiers", username);
            if (user != null) return user;

            user = GetUserFromTableByUsername("InventoryClerks", username);
            return user;
        }

        public User AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                User user = AuthenticateFromTable("Admins", username, password, conn);
                if (user != null) return user;

                user = AuthenticateFromTable("Cashiers", username, password, conn);
                if (user != null) return user;

                user = AuthenticateFromTable("InventoryClerks", username, password, conn);
                return user;
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> allUsers = new List<User>();

            allUsers.AddRange(GetUsersFromTable("Admins", UserRole.Admin));
            allUsers.AddRange(GetUsersFromTable("Cashiers", UserRole.Cashier));
            allUsers.AddRange(GetUsersFromTable("InventoryClerks", UserRole.InventoryClerk));

            return allUsers;
        }

        public void Update(User user)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string tableName = GetTableNameByRole(user.Role);
                
                string passwordToSave = user.Password;
                if (!user.Password.StartsWith("$2"))
                {
                    passwordToSave = HashPassword(user.Password);
                }

                string sqlQry = string.Format("UPDATE {0} SET " +
                               "Username = @Username, " +
                               "Password = @Password, " +
                               "FirstName = @FirstName, " +
                               "LastName = @LastName, " +
                               "Email = @Email, " +
                               "PhoneNumber = @PhoneNumber, " +
                               "Address = @Address, " +
                               "IsActive = @IsActive " +
                               "WHERE UserId = @UserId", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", passwordToSave);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                    cmd.Parameters.AddWithValue("@UserId", user.UserId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            User user = GetById(id);
            if (user == null) return;

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string tableName = GetTableNameByRole(user.Role);
                string sqlQry = string.Format("DELETE FROM {0} WHERE UserId = @UserId", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private User GetUserFromTable(string tableName, int id)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = string.Format("SELECT * FROM {0} WHERE UserId = @UserId", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        User user = CreateUserFromReader(reader, GetRoleFromTableName(tableName));
                        return user;
                    }
                }
            }
        }

        private User GetUserFromTableByUsername(string tableName, string username)
        {
            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = string.Format("SELECT * FROM {0} WHERE Username = @Username", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        User user = CreateUserFromReader(reader, GetRoleFromTableName(tableName));
                        return user;
                    }
                }
            }
        }

        private User AuthenticateFromTable(string tableName, string username, string password, SqlConnection conn)
        {
            string sqlQry = string.Format("SELECT * FROM {0} WHERE Username = @Username AND IsActive = 1", tableName);

            using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        conn.Close();
                        return null;
                    }

                    string storedHash = reader["Password"].ToString();
                    
                    if (!Verify(password, storedHash))
                    {
                        conn.Close();
                        return null;
                    }

                    User user = CreateUserFromReader(reader, GetRoleFromTableName(tableName));
                    conn.Close();
                    return user;
                }
            }
        }

        private List<User> GetUsersFromTable(string tableName, UserRole role)
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(_conStr))
            {
                string sqlQry = string.Format("SELECT * FROM {0}", tableName);

                using (SqlCommand cmd = new SqlCommand(sqlQry, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = CreateUserFromReader(reader, role);
                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        private User CreateUserFromReader(SqlDataReader reader, UserRole role)
        {
            int userId = Convert.ToInt32(reader["UserId"]);
            string username = reader["Username"].ToString();
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string email = reader["Email"].ToString();
            string phone = reader["PhoneNumber"].ToString();
            string address = reader["Address"].ToString();
            string password = reader["Password"].ToString();

            User user = null;

            if (role == UserRole.Admin)
            {
                user = new Admin(userId, firstName, lastName, email, phone, address, username, password);
            }
            else if (role == UserRole.Cashier)
            {
                user = new Cashier(userId, firstName, lastName, email, phone, address, username, password);
            }
            else if (role == UserRole.InventoryClerk)
            {
                user = new InventoryClerk(userId, firstName, lastName, email, phone, address, username, password);
            }

            return user;
        }

        private string GetTableNameByRole(UserRole role)
        {
            if (role == UserRole.Admin)
            {
                return "Admins";
            }
            else if (role == UserRole.Cashier)
            {
                return "Cashiers";
            }
            else if (role == UserRole.InventoryClerk)
            {
                return "InventoryClerks";
            }
            else
            {
                return "Admins";
            }
        }

        private UserRole GetRoleFromTableName(string tableName)
        {
            if (tableName == "Admins")
            {
                return UserRole.Admin;
            }
            else if (tableName == "Cashiers")
            {
                return UserRole.Cashier;
            }
            else if (tableName == "InventoryClerks")
            {
                return UserRole.InventoryClerk;
            }
            else
            {
                return UserRole.Admin;
            }
        }
    }
}