using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCounter
{ 
    class User
    {
        public string userLogin { get; private set; }
        public string userPassword { get; private set; }
        public string userName { get; private set; }
        public string userLastName { get; private set; }
        public int userAge { get; private set; }
        public string userEmail { get; private set; }
        public int userWeight { get; private set; }
        public int userHeight { get; private set; }
        public string userGender { get; private set; }

        public int ID { get; private set; } = 0;

        public User(string userlogin, string userpassword, string username, string userlastname, int userage, string useremail, int userweight, int userheight, string usergender)
        {
            ID++;
            setUserLogin(userlogin);
            setUserPassword(userpassword);
            setUserName(username);
            setUserLastName(userlastname);
            setUserAge(userage);
            setUserEmail(useremail);
            setUserWeight(userweight);
            setUserHeight(userheight);
            setUserGender(usergender);
        }
        public User() { }
        public void setUserLogin(string userlogin)
        {
            this.userLogin = userlogin;
            //if (string.IsNullOrWhiteSpace(userlogin) && userlogin.Length < 3)
            //{
            //    throw new Exception("Login is incorrect.");
            //}
            //if (userlogin == userLogin) { return; }
            //else { userlogin = userLogin; }
        }
        public void setUserPassword(string userpassword)
        {
            this.userPassword = userpassword;
            //if (string.IsNullOrWhiteSpace(userpassword) && userpassword.Length < 3)
            //{
            //    throw new Exception("Password is incorrect.");
            //}
            //if (userpassword == userPassword) { return; }
            //else { userpassword = userPassword; }
        }
        public void setUserName(string username)
        {
            this.userName = username;
            //if (string.IsNullOrWhiteSpace(username) && username.Length < 3)
            //{
            //    throw new Exception("Name is incorrect.");
            //}
            //if (username == userName) { return; }
            //else { username = userName; }
        }
        public void setUserLastName(string userlastname)
        {
            this.userLastName = userlastname;
            //if (string.IsNullOrWhiteSpace(userlastname) && userlastname.Length < 3)
            //{
            //    throw new Exception("Last name is incorrect.");
            //}
            //if (userlastname == userLastName) { return; }
            //else { userlastname = userLastName; }
        }
        public void setUserAge(int userage)
        {
            this.userAge = userage;
            //if (userage == null)
            //{
            //    throw new Exception("Age is incorrect.");
            //}
            //if (userage == userAge) { return; }
            //else { userage = userAge; }
        }
        public void setUserEmail(string useremail)
        {
            this.userEmail = useremail;
            //if (string.IsNullOrWhiteSpace(useremail) && useremail.Length < 3)
            //{
            //    throw new Exception("Email is incorrect.");
            //}
            //if (useremail == userEmail) { return; }
            //else { useremail = userEmail; }
        }
        public void setUserWeight(int userweight)
        {
            this.userWeight = userweight;
            //if (userweight == null)
            //{
            //    throw new Exception("Weight is incorrect.");
            //}
            //if (userweight == userWeight) { return; }
            //else { userweight = userWeight; }
        }
        public void setUserHeight(int userheight)
        {
            this.userHeight = userheight;
            //if (userheight == null)
            //{
            //    throw new Exception("Height is incorrect.");
            //}
            //if (userheight == userHeight) { return; }
            //else { userheight = userHeight; }
        }
        
        public void setUserGender(string usergender)
        {
            this.userGender = usergender;
        }
        ~User() { }
    }
}
