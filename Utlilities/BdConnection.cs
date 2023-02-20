using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ApiShopp.Utlilities
{
    public class BdConnection
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(Startup.Configuration.GetSection("ConnectionString").Value);
        }
    }
}
