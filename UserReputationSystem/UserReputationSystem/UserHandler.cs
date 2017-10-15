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

        public void LoadAllUsers()
        {
            StreamReader srGuest = new StreamReader(@"Guests.txt");
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
        }

        /*public void SaveAllUers()
        {
            Guest _guest = new Guest();
            if (_guest.WriteGuestToFile(@"Guests.txt") == true)
            {

            }
        }*/
    }
}
