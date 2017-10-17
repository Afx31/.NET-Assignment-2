using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserReputationSystem
{
    public class UserHandler
    {
        //make private
        public List<User> userList = new List<User>();
        private User loggedInUser;
        public User LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        public bool LoadAllUsers()
        {
            //pre-set StreamReader to the files required
            StreamReader srGuest = new StreamReader(@"Guests.txt");
            StreamReader srAdmin = new StreamReader(@"Admin.txt");
            string line;

            //Load in all Guests
            while (!srGuest.EndOfStream)
            {
                line = srGuest.ReadLine();
                string[] temp = line.Split(',');
                Guest _guest = new Guest(temp[0], temp[1], temp[2], temp[3], DateTime.ParseExact(temp[4], "dd-MM-yyyy", null), Convert.ToInt32(temp[5]),
                    Convert.ToDouble(temp[6]));
                userList.Add(_guest);
            }
            srGuest.Close();
            return true;
        
            while (!srAdmin.EndOfStream)
            {
                line = srAdmin.ReadLine();
                string[] temp = line.Split(',');
                Admin _admin = new Admin(temp[0], temp[1], temp[2], temp[3], temp[4], Convert.ToInt32(temp[5]), Convert.ToDouble(temp[6]));
                userList.Add(_admin);
            }
            srAdmin.Close();
            return true;
        }

        /*public bool SaveAllUers()
        {
            //Guest _guest = new Guest();
            //Admin _admin = new Admit();
            //_guest.WriteGuestToFile(@"Guests.txt", true);
            //_admin.WriteAdminToFile(@"Admin.txt", true);
        }*/

        public string FirstLetterToUpper(string input)
        {
            //parses in the string which will return it after making the first letter capital
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
