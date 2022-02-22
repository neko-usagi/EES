using Microsoft.Data.SqlClient;
using System.Configuration;

namespace EES.Database
{
    internal class DbConnection
    {
        public string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

		    builder.DataSource = ConfigurationManager.AppSettings["DB_HOST"];
		    builder.InitialCatalog = ConfigurationManager.AppSettings["DB_NAME"];
            builder.UserID = ConfigurationManager.AppSettings["DB_USER_ID"];
		    builder.Password = ConfigurationManager.AppSettings["DB_PASS"];

            return builder.ConnectionString;
        }
    }
}
