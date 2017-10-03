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

        #region CONSTRUCTORS

        public string UserName
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }

        #endregion




        /*public bool CheckUserNameAndPassword(string username, string password)
        {
            
        }*/
        /*public string GetShortUserString()
        {
            
        }*/
        /*public void AddRating(int rating)
        {
            
        }*/
        /*public string GetFullUserString()
        {            

        }*/
    }
}
