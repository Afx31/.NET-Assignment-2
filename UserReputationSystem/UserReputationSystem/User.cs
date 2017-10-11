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
        public string username, password, firstName, lastName;
        protected int ratingsCount;
        protected double averageRating;
        protected double averageRatingAdmin;

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

        public bool CheckUserNameAndPassword(string usr, string pass)
        {
            Boolean match = false;
            UserHandler _user = new UserHandler();
            List<Guest> tempList = new List<Guest>();
            tempList = _user.guestList;
            //username = "user1";
            //password = "password123";

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
        }

        public string GetShortUserString()
        {

        }
    }
}
