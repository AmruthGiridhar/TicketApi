using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Service
{
    public class connectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _config;
        public string connectionString { get; set; }
        public  connectionFactory(IConfiguration config)
         {
            _config = config;
            connectionString = _config.GetConnectionString("DefaultConnectionString");
        }

       

        public IDbConnection GetConnection
        {
            get
            {
                DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }
        }
        public string getConnectionString()
        {
            return connectionString;
        }
    }
}
