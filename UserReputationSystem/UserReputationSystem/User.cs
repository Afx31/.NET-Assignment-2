using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserReputationSystem
{
    class User
    {
        protected string username, password, firstName, lastName;
        protected int ratingsCount;
        protected double averageRating;
        protected double averageRatingAdmin;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int RatingsCount
        {
            get { return ratingsCount; }
        }
        public double AverageRating
        {
            get { return averageRating; }
        }
        public double AverageRatingAdmin
        {
            get { return averageRatingAdmin; }
        }

        /*public bool CheckUserNameAndPassword(string usr, string pass)
        {
            Boolean match = false;
            UserHandler _user = new UserHandler();
            var tempList = _user.guestList;
            //username = "user1";
            //password = "password123";

            foreach (Guest g in tempList)
            {
                if (g.username == usr)
                {
                    match = true;
                }
            }

            /*for (int i = 0; i < tempList.Count; i++)
            {
                if(tempList[i].Equals(usr))
                {
                    match = true;
                }
            }

            if (usr == password)
            {
                if (pass == password)
                {
                    match = true;
                }
            }
            else
            {
                match = false;
            }
            return match;
        }*/


        public string GetShortUserString()
        {
            //UserHandler uh = new UserHandler();
            //var tempList = uh.userList.ToString();
            string tempUsername = Username;
            //string tempFirstName = "John";
            //return tempUsername + "," + tempFirstName;
            return tempUsername;
        }
    }
}
