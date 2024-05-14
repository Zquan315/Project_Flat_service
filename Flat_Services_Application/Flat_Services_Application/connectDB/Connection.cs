using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Flat_Services_Application.connectDB
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-78R5URF\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                                                    
        public static SqlConnection GetConnection() 
        {
            return new SqlConnection(stringConnection);
        }
    }
}
