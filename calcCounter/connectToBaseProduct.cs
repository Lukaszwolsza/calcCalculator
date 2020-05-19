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

        public void addingProdToMeal(string product, string username, string typeofmeal, string cur_date, string full_calories, string full_protein, string full_fat, string full_carbs)
        {

            int fullCalories = gettingFullCalories(username);
            fullCalories = +Convert.ToInt32(full_calories);

            int fullProteins = gettingFullFat(username);
            fullProteins = +Convert.ToInt32(full_protein);

            int fullFats = gettingFullFat(username);
            fullFats = +Convert.ToInt32(full_fat);

            int fullCarbs = gettingFullFat(username);
            fullCarbs = +Convert.ToInt32(full_carbs);


            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.userProdMeal (SELECTED_PROD, USERNAME, TYPEOFMEAL, CUR_DATE, ID_PROD, FULL_CALORIES, FULL_PROTEIN, FULL_FAT, FULL_CARBS) VALUES ('{product}','{username}','{typeofmeal}','{cur_date}', '1', '{fullCalories}', '{fullProteins}', '{fullFats}', '{fullCarbs}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public int gettingFullCalories(string username)
        {
            DateTime thisDay = DateTime.Today;
            string cur_date = thisDay.ToString("d");

            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT SUM(FULL_CALORIES) AS FULL_CALORIES FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND CUR_DATE = '" + cur_date + "' GROUP BY USERNAME", sqlConnection))
                {
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public int gettingFullProtein(string username)
        {
            DateTime thisDay = DateTime.Today;
            string cur_date = thisDay.ToString("d");

            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT SUM(FULL_PROTEIN) AS FULL_PROTEIN FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND CUR_DATE = '" + cur_date + "' GROUP BY USERNAME", sqlConnection))
                {
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }
        public int gettingFullFat(string username)
        {
            DateTime thisDay = DateTime.Today;
            string cur_date = thisDay.ToString("d");

            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT SUM(FULL_FAT) AS FULL_FAT FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND CUR_DATE = '" + cur_date + "' GROUP BY USERNAME", sqlConnection))
                {
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
        }

        public int gettingFullCarbs(string username)
        {
            DateTime thisDay = DateTime.Today;
            string cur_date = thisDay.ToString("d");

            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT SUM(FULL_CARBS) AS FULL_CARBS FROM dbo.userProdMeal WHERE USERNAME = '" + username + "' AND CUR_DATE = '" + cur_date + "' GROUP BY USERNAME", sqlConnection))
                {
                    var result = command.ExecuteScalar();
                    return Convert.ToInt32(result);
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
