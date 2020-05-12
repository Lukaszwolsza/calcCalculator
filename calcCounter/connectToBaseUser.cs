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
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            using (var sqlConnection = new SqlConnection(sqlStringConnector))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand($"INSERT INTO dbo.users (LOGIN, PASSWORD, NAME, LASTNAME, AGE, EMAIL, WEIGHT, HEIGHT, GENDER) VALUES ('{login}','{password}','{username}','{lastname}','{age}', '{email}', '{weight}', '{height}', '{gender}')", sqlConnection))
                {
                    var result = command.ExecuteNonQuery();
                }


                //SqlDataAdapter sqlData = new SqlDataAdapter("INSERT INTO dbo.products (NAME, CALORIES_ON_100G, PROTEIN, FAT, CARBS) VALUES ('Frytki','350','2','30','30')", sqlConnection);
                //DataTable dttable = new DataTable();

                //sqlData.Fill(dttable);


            }
        }

        public bool userAuthenticationInBase(string login, string password)
        {
            bool isLogged = false;
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            string query = "SELECT * FROM dbo.users WHERE LOGIN = '" + login + "' AND PASSWORD = '" + password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlStringConnector);
            DataTable dta = new DataTable();
            sda.Fill(dta);

            if (dta.Rows.Count == 1)
            {
                mainBox mainMenuBox = new mainBox();
                mainMenuBox.Show();
                isLogged = true;
            }
            else
            {
                MessageBox.Show("Incorrect password !");
                isLogged = false;
            }
            return isLogged;
        }


        public string userGreetingAndName(string login)
        {
            string sqlStringConnector = "Server =.\\SQLEXPRESS; Database = FatToFit; Trusted_Connection = True;";
            string query = "SELECT * FROM dbo.users WHERE LOGIN = '" + login + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlStringConnector);

            
            return query;
            //var foundUser = usersInBase.Find(user => user.userLogin == login);
            //string search = foundUser.userName;
            //return search;
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
