using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Commerce.Models
{
    class DatabaseConfig
    {
        private const string CONNECTIONSTRINGTAG = "ConexaoDeveloper";

        private static string _currentConnectionString = string.Empty;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_currentConnectionString))
                {
                    _currentConnectionString = ConfigurationManager.ConnectionStrings[CONNECTIONSTRINGTAG].ConnectionString;
                }

                return _currentConnectionString;
            }
        }
    }
}
