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

        //textbox restrictions set up depending on which textbox it is
        //they will allow specific characters only to be entered
        //giving error message if not
        #region TEXTBOX RESTRICTIONS

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbUsername.Text, "^[a-zA-Z0-9]"))
            {
                MessageBox.Show("Error: Only alphabetical & numeric characters for Username.");
            }
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbUsername.Text, "^[a-zA-Z0-9]"))
            {
                MessageBox.Show("Error: Only alphabetical & numeric characters for Password.");
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbFirstName.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Error: Only alphabetical characters for First Name.");
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbLastName.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Error: Only alphabetical characters for Last Name.");
            }
        }

        #endregion

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string newUsername = tbUsername.Text;
            string newPassword = tbPassword.Text;
            string newFirstName = tbFirstName.Text;
            string newLastName = tbLastName.Text;
            //create instance for the FirstLetterToUpper method call, to try make the line of code not so long
            UserHandler _u = new UserHandler();

            if (tbUsername.Text == null || tbPassword.Text == null || tbFirstName == null || tbLastName == null || dtpDOB == null)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                //create new user and write to file   DateTime.Parse(dtpDOB.Value.ToString("dd-MM-yyyy"))
                Guest _guest = new Guest(newUsername, newPassword, _u.FirstLetterToUpper(newFirstName), _u.FirstLetterToUpper(newLastName), DateTime.Parse(dtpDOB.Value.ToString("dd-MM-yyyy")), 0, 0);                
                StreamWriter file = new StreamWriter(@"Guests.txt", true);
                _guest.WriteGuestToFile(file);
                LoginForm.UserHandler.userList.Add(_guest);

                //display new user created message and close file
                MessageBox.Show("New user created.");
                file.Close();
                this.Close();
                new LoginForm().Show();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
