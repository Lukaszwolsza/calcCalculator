using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    class connectToBaseUser
    {
        public void addUserToBase(string login, string password, string username, string lastname, int age, string email, int weight, int height, string gender)
        {
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.users (LOGIN, PASSWORD, NAME, LASTNAME, AGE, EMAIL, WEIGHT, HEIGHT, GENDER) VALUES ('{login}','{password}','{username}','{lastname}','{age}', '{email}', '{weight}', '{height}', '{gender}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }
            }
        }

        public bool userAuthenticationInBase(string login, string password)
        {
            bool isLogged = false;
            string sqlStringConnector = "Server =.; Database = FatToFit; Trusted_Connection = True;";
            string query = "SELECT * FROM dbo.users WHERE LOGIN = '" + login + "' AND PASSWORD = '" + password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlStringConnector);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {   
                isLogged = true;
            }
            else
            {
                isLogged = false;
            }
            
            return isLogged;
        }


        public string userGreetingAndName(string login)
        {
            string errorResult = "Nothing find";
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT LOGIN FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userLogin = reader["LOGIN"] as string;
                            return userLogin;
                        }
                    }
                }
            }
            return errorResult;
        }


        public string userName(string login)
        {
            string errorResult = "Nothing find";
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT NAME FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader["NAME"] as string;
                            return userName;
                        }
                    }
                }
            }
            return errorResult;
        }

        public string userLastName(string login)
        {
            string errorResult = "Nothing find";
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT LASTNAME FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader["LASTNAME"] as string;
                            return userName;
                        }
                    }
                }
            }
            return errorResult;
        }


        public int userAge(string login)
        {
            int errorResult = 0;
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT AGE FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userAge = Convert.ToInt32(reader["AGE"]);
                            return userAge;
                        }
                    }
                }
            }
            return errorResult;
        }


        public string userEmail(string login)
        {
            string errorResult = "Nothing find";
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT EMAIL FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userEmail = reader["EMAIL"] as string;
                            return userEmail;
                        }
                    }
                }
            }
            return errorResult;
        }



        public int userWeight(string login)
        {
            int errorResult = 0;
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT WEIGHT FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userWeight= Convert.ToInt32(reader["WEIGHT"]);
                            return userWeight;
                        }
                    }
                }
            }
            return errorResult;
        }

        public int userHeight(string login)
        {
            int errorResult = 0;
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT HEIGHT FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userHeight = Convert.ToInt32(reader["HEIGHT"]);
                            return userHeight;
                        }
                    }
                }
            }
            return errorResult;
        }


        public string userGender(string login)
        {
            string errorResult = "Nothing find";
            using (var sqlStringConnector = new SqlConnection("Server =.; Database = FatToFit; Trusted_Connection = True;"))
            {
                sqlStringConnector.Open();
                using (var query = new SqlCommand("SELECT GENDER FROM dbo.users WHERE LOGIN = '" + login + "'", sqlStringConnector))
                {
                    using (var reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userGender = reader["GENDER"] as string;
                            return userGender;
                        }
                    }
                }
            }
            return errorResult;
        }
        //public string userLastName(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    string search = foundUser.userLastName;
        //    return search;
        //}
        //public string userEmail(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    string search = foundUser.userEmail;
        //    return search;
        //}
        //public int userAge(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    int search = foundUser.userAge;
        //    return search;
        //}
        //public int userWeight(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    int search = foundUser.userWeight;
        //    return search;
        //}
        //public int userHeight(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    int search = foundUser.userHeight;
        //    return search;
        //}
        //public string userGender(string login)
        //{
        //    var foundUser = usersInBase.Find(user => user.userLogin == login);
        //    string search = foundUser.userGender;
        //    return search;
        //}


    }
}
