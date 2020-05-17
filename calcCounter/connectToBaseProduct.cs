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
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
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
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
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
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
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

        public void addingProdToMeal(string product, string username, string typeofmeal, string cur_date)
        {
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.userProdMeal (SELECTED_PROD, USERNAME, TYPEOFMEAL, CUR_DATE) VALUES ('{product}','{username}','{typeofmeal}','{cur_date}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }


        public List<string> prodView(string username)
        {
            //string errorResult = "Nothing find";
            List<string> errorResult = new List<string>();
            errorResult.Add("Nothing find !");

            List<string> products = new List<string>();

            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {

                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT SELECTED_PROD FROM dbo.userProdMeal WHERE USERNAME = '" + username + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //products = reader["SELECTED_PROD"] as List<string>;

                            products.Add(reader.GetString(0));
                            products.Count();

                            return products;
                            //foreach (string prod in products)
                            //{
                            //    prod.ToArray();
                            //    return prod;
                            //}
                        }
                    }
                }
            }
            return errorResult;
        }
        

    }

}
