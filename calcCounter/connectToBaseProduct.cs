﻿using System;
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

            
            //SqlDataAdapter sqlData = new SqlDataAdapter("INSERT INTO dbo.products (NAME, CALORIES_ON_100G, PROTEIN, FAT, CARBS) VALUES ('Frytki','350','2','30','30')", sqlConnection);
                //DataTable dttable = new DataTable();

               //sqlData.Fill(dttable);

                
            }
        }


        public void searchingProduct(string prodName)
        {
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"SELECT * FROM dbo.products WHERE NAME = '{prodName}'", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }


                //SqlDataAdapter sqlData = new SqlDataAdapter("INSERT INTO dbo.products (NAME, CALORIES_ON_100G, PROTEIN, FAT, CARBS) VALUES ('Frytki','350','2','30','30')", sqlConnection);
                //DataTable dttable = new DataTable();

                //sqlData.Fill(dttable);


            }
        }
        
    }

}