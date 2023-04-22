using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamcheck
{
    internal class DatabaseConnection
    {
        public DatabaseConnection()
        {
            SqlConnection conn = new SqlConnection("server=.\\sqlexpress; Initial Catalog=jampractice; Integrated Security=True");
        }
    }
}
