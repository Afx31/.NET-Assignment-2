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
        //Jiajun's stuff, use for now but change later
        private static UserHandler _userHandler = new UserHandler();
        public static UserHandler getUserHandler
        {
            get { return _userHandler; }
            set { _userHandler = value; }
        }
        /// /////////////////////////////////////////////////////////////


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginEnabled();
        }

        private void tbPassword_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginEnabled();
            }
        }

        private void LoginEnabled()
        {            
            _userHandler.LoadAllUsers();

            string inputUser = tbUsername.Text;
            string inputPassword = tbPassword.Text;            
            bool success = false;
            
            for (int i = 0; i < _userHandler.userList.Count() && success != true; i++)
            {
                success = _userHandler.userList[i].CheckUserNameAndPassword(inputUser, inputPassword);
                /*if (success == true)
                {
                    _userHandler.LoggedInUser = inputUser;
                }*/
            }
            try
            {
                if (success == true)
                {
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
