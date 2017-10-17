using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserReputationSystem
{
    public partial class UserRatingDialog : Form
    {
        private List<string> choosenUsersList = new List<string>();
        public UserRatingDialog(List<string> choosenUsersList)
        {
            InitializeComponent();
            this.choosenUsersList = choosenUsersList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < choosenUsersList.Count(); i++)
            {
                //refer to current user whom is being rated
                int currentUser = Int32.Parse(choosenUsersList[i]);

                //update their RatingsCount
                int currentUsersRatingCount = LoginForm.UserHandler.userList[Int32.Parse(choosenUsersList[i])].RatingsCount + 1;

                //perform the calulations for the new rating
                double calcAverage = (LoginForm.UserHandler.userList[currentUser].RatingsCount * 
                    LoginForm.UserHandler.userList[currentUser].AverageRating + RatingInput()) / currentUsersRatingCount;
                //call AddRatings method to update users RatingsCount & AverageRatings
                LoginForm.UserHandler.userList[currentUser].AddRating(Convert.ToInt32(calcAverage));
            }
            //write to file to save new updates
            Guest _guest = new Guest();
            StreamWriter file = new StreamWriter(@"Guests.txt", true);
            _guest.WriteGuestToFile(file);

            this.Hide();
            new UserListScreen().Show();
        }

        private int RatingInput()
        {
            //returns the User's input on which rating they wish to give
            if (rdbtn0.Checked)
            {
                return 0;
            }
            else if (rdbtn1.Checked)
            {
                return 1;
            }
            else if (rdbtn2.Checked)
            {
                return 2;
            }
            else if (rdbtn3.Checked)
            {
                return 3;
            }
            else if (rdbtn4.Checked)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserListScreen().Show();
        }        
    }
}
