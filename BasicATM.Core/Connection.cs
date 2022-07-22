using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM.Core
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source = FATIH\\LOCAL1; Initial Catalog = BasicATM; Integrated Security = True");
        }
    }
}
