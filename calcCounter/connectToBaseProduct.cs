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

        public void addingProdToMeal(string product, string username, string typeofmeal, string cur_date, string full_calories)
        {

            int fullCalories = gettingFullCalories();
            fullCalories = +Convert.ToInt32(full_calories);

            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.userProdMeal (SELECTED_PROD, USERNAME, TYPEOFMEAL, CUR_DATE, ID_PROD, FULL_CALORIES) VALUES ('{product}','{username}','{typeofmeal}','{cur_date}', '1', '{fullCalories}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public int gettingFullCalories()
        {
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT FULL_CALORIES FROM dbo.userProdMeal", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        //public List<string> prodView(string username, string typeofmeal)
        //{

        //    //string errorResult = "Nothing find";
        //    List<string> errorResult = new List<string>();
        //    errorResult.Add("Nothing find !");

        //    List<string> products = new List<string>();

        //    using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
        //    {

        //        sqlStringConnector.Open();
        //        using (var query = new SqlCommand("SELECT SELECTED_PROD FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND TYPEOFMEAL = '" + typeofmeal + "'", sqlStringConnector))
        //        {
        //            using (var reader = query.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    string prod = reader["SELECTED_PROD"] as string;

        //                    products.Add(prod);
        //                    //products.Count();  
        //                }
        //                return products.;
        //            }
        //        }
        //    }
        //    return errorResult;
        //}



        public string prodView(string username, string typeofmeal)
        {

            string errorResult = "Nothing find";
            //List<string> errorResult = new List<string>();
            //errorResult.Add("Nothing find !");

            List<string> products = new List<string>();
            string resultOfProducts;

            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {

                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT SELECTED_PROD FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND TYPEOFMEAL = '" + typeofmeal + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //products = reader["SELECTED_PROD"] as List<string>;
                            products.Add(reader.GetString(0));
                        }
                        resultOfProducts = string.Join(", ", products);
                        return resultOfProducts;
                    }
                }
            }
            return errorResult;
        }

    }

}
