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
        public int RatingsCount;
        protected double averageRating;
        public double AverageRating;

        public bool CheckUserNameAndPassword(string username, string password)
        {
            return;
        }        
        public string GetShortUserString()
        {
            return;
        }
        public void AddRating(int rating)
        {
            
        }
        public string GetFullUserString()
        {
            return;
        }
    }
}
