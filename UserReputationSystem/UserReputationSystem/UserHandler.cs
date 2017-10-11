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
        public List<Guest> guestList = new List<Guest>();
        public List<Admin> adminList = new List<Admin>();

        public void LoadAllUsers()
        {
            string guestFilePath = @"D:\Desktop\GitHub\.NET-Assignment-2\UserReputationSystem\UserReputationSystem\bin\Debug\Guests.txt";
            string adminFilePath = @"D:\Desktop\GitHub\.NET-Assignment-2\UserReputationSystem\UserReputationSystem\bin\Debug\Admin.txt";
            StreamReader srGuest = new StreamReader(guestFilePath);
            StreamReader srAdmin = new StreamReader(adminFilePath);
            string line1;
            string line2;

            //Load in all Guests
            while ((line1 = srGuest.ReadLine()) != null)
            {
                string[] temp = line1.Split(',');
                guestList.Add(new Guest(temp[0], temp[1], temp[2], temp[3], DateTime.ParseExact(temp[4], "dd-MM-yyyy", null), Convert.ToInt32(temp[5]),  
                    Convert.ToDouble(temp[6])));
            }
            srGuest.Close();



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
