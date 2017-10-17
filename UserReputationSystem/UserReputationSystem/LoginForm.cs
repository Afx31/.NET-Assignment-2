using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserReputationSystem
{
    public partial class LoginForm : Form
    {
        //doing so allows UserHandler object to be called throughout the project in the same instance as it is here
        private static UserHandler _userHandler = new UserHandler();
        public static UserHandler UserHandler
        {
            get { return _userHandler; }
            set { _userHandler = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _userHandler.LoadAllUsers();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginEnabled();
        }

        private void tbPassword_KeyDown1(object sender, KeyEventArgs e)
        {
            //Press enter after password entered to log in
            if (e.KeyCode == Keys.Enter)
            {
                LoginEnabled();
            }
        }

        private void LoginEnabled()
        {                        
            string inputUser = tbUsername.Text;
            string inputPassword = tbPassword.Text;            
            bool success = false;
            int tempCounter;

            try
            {
                for (tempCounter = 0; tempCounter < _userHandler.userList.Count() && success != true; tempCounter++)
                {
                    //call CheckUserNameAndPassword to check if username/password is valid, then assign to LoggedInUser
                    success = _userHandler.userList[tempCounter].CheckUserNameAndPassword(inputUser, inputPassword);                    
                }            
                if (success == true)
                {
                    
                    _userHandler.LoggedInUser = _userHandler.userList[tempCounter];
                    this.Hide();
                    new UserListScreen().Show();
                }
                else
                {
                    MessageBox.Show("Login Fail: username/password incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Fail: username/password incorrect.");
            }
        }

        private void btnNewuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NewUserForm().Show();
        }
    }
}
