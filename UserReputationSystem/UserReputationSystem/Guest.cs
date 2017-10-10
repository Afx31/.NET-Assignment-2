using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserReputationSystem
{
    class Guest : User
    {
        private DateTime dateOfBirth;
        
        public Guest(string Username, string Password, string FirstName, string LastName, DateTime DateOfBirth, int RatingsCount, double AverageRating)
        {
            this.username = Username;
            this.password = Password;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.dateOfBirth = DateOfBirth;
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
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
}
