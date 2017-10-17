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
        private AdminType adminType;

        public Admin(string username, string password, string firstName, string lastName, string adminType, int ratingsCount, double averageRatingAdmin)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.adminType = (AdminType)Enum.Parse(typeof(AdminType), adminType);
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRatingAdmin;
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
            get { return averageRating; }
        }

        public bool WriteAdminToFile(System.IO.StreamWriter file)
        {
            //write all admins back to the admin.txt to include any changes
            if (file.BaseStream != null)
            {
                string newAdmin = System.Environment.NewLine + username + "," + password + "," + firstName + "," + lastName + "," + adminType + "," + ratingsCount + "," + averageRating;
                file.Write(newAdmin);
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

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
