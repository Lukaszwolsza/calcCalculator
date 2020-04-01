using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcCounter
{
    public class userService
    {
        static List<User> usersInBase = new List<User>();
        
        public void addNewUserToList(string login, string password, string username, string lastname, int age, string email, int weight, int height)
        {
            User user = new User(login, password, username, lastname, age, email, weight, height);
            User nowy = new User("admin", "admin", "test", "test", 30 , "test", 100, 190);
            usersInBase.Add(nowy);
            usersInBase.Add(user);
        }
        
        public bool userAuthentication(string login, string password)
        {
            bool isLogged = false;

            if (usersInBase.Exists(x => x.userLogin == login))
            {
                var foundObject = usersInBase.Find(x => x.userLogin == login);
                if (foundObject.userLogin == login && foundObject.userPassword == password)
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
            }
            else
            {
                MessageBox.Show("Valid user login!");
                isLogged = false;
            }
            return isLogged;
        }
        
        public void completingTheInfoAboutUser(string login)
        {
            var foundUser = usersInBase.Find(user => user.userLogin == login);

            string name = foundUser.userLogin;
            string lastname = foundUser.userLastName;
            string email = foundUser.userEmail;
            int age = foundUser.userAge;
            int weight = foundUser.userWeight;
            int height = foundUser.userHeight;

            //accountInfo acntinf = new accountInfo();
            //acntinf.completeAllData(name,lastname,email,age,weight,height);

        }

    }
}
