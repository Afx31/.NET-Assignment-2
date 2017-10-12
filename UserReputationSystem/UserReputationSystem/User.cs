using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserReputationSystem
{
    public abstract class User
    {
        protected string username, password, firstName, lastName;
        protected int ratingsCount;
        protected double averageRating;        
        public int RatingsCount
        {
            get { return ratingsCount; }
        }
        public double AverageRating
        {
            get { return averageRating; }
        }

        public bool CheckUserNameAndPassword(string username, string password)
        {
            bool match = false;
            if (this.username == username)
            {
                if (this.password == password)
                {
                    match = true;
                }
            }
            return match;
        }

        public string GetShortUserString()
        {
            string tempUsername = this.username;
            string tempFirstName = this.firstName;

            string tempString = tempUsername + "," + tempFirstName;
            return tempString;
        }

        public void AddRating(int rating)
        {
            averageRating = (averageRating * ratingsCount + rating);
            ratingsCount = ratingsCount + 1;
        }

        public abstract string GetFullUserString();
    }
}
