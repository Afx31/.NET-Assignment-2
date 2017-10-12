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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Load all Users
            UserHandler _userHandler = new UserHandler();
            _userHandler.LoadAllUsers();
        }
        
        private void bLogin_Click(object sender, EventArgs e)
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
            string inputUser = tbUsername.Text;
            string inputPassword = tbPassword.Text;

            UserHandler _userHandler = new UserHandler();
            User _user = new User();

            /*Boolean success = _user.CheckUserNameAndPassword(inputUser, inputPassword);           

            try
            {
                if (success == true)
                {
                    MessageBox.Show("YAY");
                    //_userHandler.Show();
                }
                else
                {
                    MessageBox.Show("Login Fail: username/password incorrect.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Fail: username/password incorrect.");
            }*/
        }
    }
}
