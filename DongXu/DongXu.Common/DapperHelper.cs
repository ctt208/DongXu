using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Common
{
    using System.Configuration;
    using Oracle.ManagedDataAccess.Client;
    public class DapperHelper
    {
        private static string oracleConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        public static OracleConnection GetConnectionString()
        {
            return new OracleConnection(oracleConnectionString);
        }
    }
}
