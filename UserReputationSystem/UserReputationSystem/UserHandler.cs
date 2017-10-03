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
        //private List<User> users;
        public List<string> users = new List<string>();
        private User loggedInUser;
        public User LoggedInUser;

        /*public UserHandler()     //think its stored in here?
        {
            users = new List<User>();
        }*/
        public void LoadAllUsers()
        {
            string adminFilePath = @"D:\Desktop\GitHub\.NET-Assignment-2\UserReputationSystem\UserReputationSystem\bin\Debug\Admin.txt";
            
            using (var reader = new StreamReader(adminFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    users.Add(line);
                }
            }

            /*StreamReader srAdmin = new StreamReader(adminFilePath);
            User _user = new User();
            while (!srAdmin.EndOfStream)
            {
                //LOAD EMPLOYEES
                //_user = new User();                    
                users.Add(_user);

                //possible functions to call
                //_user.LoadEmployee(srAdmin);
            }*/


            //srAdmin.Close();     //passes 'true' value            
        }

        /*public bool SaveAllUsers()
        {
            //return;
        }*/


    }
}
