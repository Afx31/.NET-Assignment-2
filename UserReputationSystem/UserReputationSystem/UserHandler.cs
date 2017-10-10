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
        //change to private
        public List<Guest> userList = new List<Guest>();

        public void LoadAllUsers()
        {
            string guestFilePath = @"D:\Desktop\GitHub\.NET-Assignment-2\UserReputationSystem\UserReputationSystem\bin\Debug\Guests.txt";
            
            string line;
            StreamReader srGuest = new StreamReader(guestFilePath);

            while ((line = srGuest.ReadLine()) != null)
            {
                string[] temp = line.Split(',');
                userList.Add(new Guest(temp[0], temp[1], temp[2], temp[3], DateTime.ParseExact(temp[4], "dd-MM-yyyy", null), Convert.ToInt32(temp[5]),  
                    Convert.ToDouble(temp[6])));

                //User user = new User() { UserName = temp[0], Password = temp[1], FirstName = temp[2], LastName = temp[3],
                //    Date = temp[4], RatingsCount = Convert.ToInt32(temp[5]), AverageRating = Convert.ToDouble(temp[6]) };                
            }
            srGuest.Close();
            foreach (Guest guest in userList)
            {
                Console.WriteLine(guest.FirstName);
            }
        }
    }
}
