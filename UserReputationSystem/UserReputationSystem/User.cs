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
        //protected
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


        #region CONSTRUCTORS
        /*public Guest(string Username, string Password, string FirstName, string LastName, DateTime DateofBirth, int RatingsCount, float AverageRating)
        {
            this.username = Username;
            this.password = Password;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dateOfBirth = DateofBirth;
            this.ratingsCount = RatingsCount;
            this.averageRating = AverageRating;
        }

        

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int RatingsCount
        {
            get { return ratingsCount; }
            //set { ratingsCount = value; }
        }
        public double AverageRating
        {
            get { return averageRating; }
            //set { averageRating = value; }
        }
        */
        #endregion  //not sure if meant to be here

        
    }
}
