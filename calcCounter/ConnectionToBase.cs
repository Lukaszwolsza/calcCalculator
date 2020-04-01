using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCounter
{
    class ConnectionToBase
    {
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new System.Data.DataTable();


    }
}
