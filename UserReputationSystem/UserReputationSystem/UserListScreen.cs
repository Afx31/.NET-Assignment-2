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
    public partial class UserListScreen : Form
    {       
        public UserListScreen()
        {
            InitializeComponent();
        }

        private void UserListScreen_Load(object sender, EventArgs e)
        {
            UserHandler _userHandler = new UserHandler();
            User _user = new User();
            _userHandler.LoadAllUsers();
            //DATAGRID            
            //dataGridView1.DataSource = _userHandler.guestList;
            dataGridView1.DataSource = _user.GetShortUserString();

            
        }
    }
}
