using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserReputationSystem
{
    class Admin : User
    {
        public enum AdminType
        {
            SuperAdmin,
            Moderator
        }
        //wtfffffffffffffffffffffffffffffffffffffffffffffffffffffffffff   
        private AdminType adminType;
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private int v6;
        private double v7;
        //wtfffffffffffffffffffffffffffffffffffffffffffffffffffffffffff   

        protected double averageRatingAdmin;
        public Admin(string username, string password, string firstName, string lastName, string adminType, int ratingsCount, double averageRatingAdmin)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adminType = (AdminType)Enum.Parse(typeof(AdminType), adminType);
            this.ratingsCount = ratingsCount;
            this.averageRatingAdmin = averageRatingAdmin;
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
        public AdminType AdminTypes
        {
            get { return adminType; }
            set { adminType = value; }
        }
        public double AverageRatingAdmin
        {
            get { return averageRatingAdmin; }
        }

        /*public bool WriteAdminToFile(System.IO.StreamWriter file)
        {

        }*/

        public override string GetFullUserString()
        {
            string tempUsername = this.username;
            string tempFirstName = this.firstName;
            string tempLastName = this.lastName;
            string tempAdminType = this.adminType.ToString();

            string tempString = this.username + "," + tempFirstName + "," + tempLastName + "," + tempAdminType;
            return tempString;
        }
    }
}
