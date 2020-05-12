using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCounter
{
    class connectToBaseProduct
    {
        public void addProductToBase(string name, double calories, double protein, double fat, double carbs)
        {
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.products (NAME, CALORIES_ON_100G, PROTEIN, FAT, CARBS) VALUES ('{name}','{calories}','{protein}','{fat}','{carbs}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }           
            }
        }
        public DataTable displayingProducts()
        {
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM dbo.products", sqlConnection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
        }

        public DataTable searchingProduct(string prodName)
        {
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();
                if (prodName == "")
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM dbo.products", sqlConnection);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    return dtbl;
                }
                else
                {
                    SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM dbo.products WHERE NAME LIKE '{prodName}%'", sqlConnection);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    return dtbl;
                }
            }
        }

       


    }

}
