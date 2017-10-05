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
        //static ??
        //private List<string> users = new List<string>();
        //change to private
        public List<User> users;


        //private User loggedInUser;
        //public User LoggedInUser;

        public UserHandler()     //think its stored in here?
        {
            users = new List<User>();
        }
        public void LoadAllUsers()
        {
            string adminFilePath = @"D:\Desktop\GitHub\.NET-Assignment-2\UserReputationSystem\UserReputationSystem\bin\Debug\Admin.txt";
            User _user = new User();            

            StreamReader srAdmin = new StreamReader(adminFilePath);
            while (!srAdmin.EndOfStream)
            {
                //LOAD EMPLOYEES                   
                users.Add(_user);                
            }
            srAdmin.Close();     //passes 'true' value  

            /*using (var reader = new StreamReader(adminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //users.Add(line);
                }
            }*/
        }

        /*public bool SaveAllUsers()
        {
            //return;
        }*/


    }
}
