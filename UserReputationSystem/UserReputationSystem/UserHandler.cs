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
        //private List<T>; of User objects
        //private User loggedInUser;
        //public User LoggedInUser;

        public bool LoadAllUsers()
        {
            StreamReader srAdmin = new StreamReader(@"D:\Desktop\.NET Assignment 2\UserReputationSystem\UserReputationSystem\bin\Debug\Admin.txt");
            {
                while (!srAdmin.EndOfStream)
                {
                    //LOAD EMPLOYEES
                }
            }

            /*StreamReader srGuest = new StreamReader(@"D:\Desktop\.NET Assignment 2\UserReputationSystem\UserReputationSystem\bin\Debug\Guests.txt");
            {

            }*/


        }

        /*public bool SaveAllUsers()
        {
            //return;
        }*/


    }
}
