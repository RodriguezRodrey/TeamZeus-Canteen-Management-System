using System.Configuration;

namespace CanteenManagementSystem.helpers
{
    public class SqlServerHelpers
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString;
        }
    }
}