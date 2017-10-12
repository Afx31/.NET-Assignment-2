using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserReputationSystem
{
    class UserHandler
    {
        //make private
        //public List<Guest> guestList = new List<Guest>();
        //public List<Admin> adminList = new List<Admin>();
        public List<User> userList = new List<User>();


        public void LoadAllUsers()
        {
            StreamReader srGuest = new StreamReader(@"Guest.txt");
            string line1;

            //Load in all Guests
            while (!srGuest.EndOfStream)
            {
                line1 = srGuest.ReadLine();
                string[] temp = line1.Split(',');
                Guest g = new Guest(temp[0], temp[1], temp[2], temp[3], DateTime.ParseExact(temp[4], "dd-MM-yyyy", null), Convert.ToInt32(temp[5]),
                    Convert.ToDouble(temp[6]));
                userList.Add(g);
                  //userList.Add(new Guest(temp[0], temp[1], temp[2], temp[3], DateTime.ParseExact(temp[4], "dd-MM-yyyy", null), Convert.ToInt32(temp[5]),  
                  //  Convert.ToDouble(temp[6])));
            }
            srGuest.Close();

            /*StreamReader srGuest = new StreamReader(@"Guest.txt");
            string line;
            while (!srGuest.EndOfStream)
            {
                line = srGuest.ReadLine();
                string[] splitString = line.Split(',');
                Guest temp = new Guest(splitString[0], splitString[1], splitString[2], splitString[3], Convert.ToDateTime(splitString[4]), Int32.Parse(splitString[5]), float.Parse(splitString[6]));
                userList.Add(temp);
            }
            srGuest.Close();*/

            /*foreach (User user in userList)
            {
                Console.WriteLine(user); //Name is a property of the User class
            }*/




            //Load in all Admins
            /*while ((line2 = srAdmin.ReadLine()) != null)
            {
                string[] temp = line2.Split(',');
                adminList.Add(new Admin(temp[0], temp[1], temp[2], temp[3], temp[4], Convert.ToInt32(temp[5]),
                    Convert.ToDouble(temp[6])));             
            }
            //(Admin.AdminType)Enum.Parse(typeof(Admin.AdminType), temp[4])
            srAdmin.Close();*/
        }
    }
}
