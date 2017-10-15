using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserReputationSystem
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string newUsername = tbUsername.Text;
            string newPassword = tbPassword.Text;
            string newFirstName = tbFirstName.Text;
            string newLastName = tbLastName.Text;
            string newDOB = dtpDOB.Value.ToString("dd-MM-yyyy");
            int i = 0;

            if (tbUsername.Text == null || tbPassword.Text == null || tbFirstName == null || tbLastName == null || dtpDOB == null)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                //create new user and write to file
                Guest _guest = new Guest(newUsername, newPassword, newFirstName, newLastName, DateTime.Parse(newDOB), i, i);                
                StreamWriter file = new StreamWriter(@"Guests.txt");
                _guest.WriteGuestToFile(file);
                LoginForm.getUserHandler.userList.Add(_guest);

                //display new user created message and close file
                MessageBox.Show("New user created.");
                file.Close();
                this.Close();
                new LoginForm().Show();
            }
        }
    }
}
