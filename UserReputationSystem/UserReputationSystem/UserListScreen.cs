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
            Guest g = new Guest();
            _userHandler.LoadAllUsers();
            //DATAGRID            
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            //define column names
            dataGridView1.Columns[0].Name = "Username";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Average Rating";
            dataGridView1.Columns[3].Name = "Number of Ratings";
            //populate the rows
            
            //string[] tempArray = _user.GetShortUserString().Split(',');
            //dataGridView1.Rows.Add(_user.GetShortUserString());
            //tbUsername.Text = _user.us;


            //dataGridView1.DataSource = _userHandler.userList;

        }
    }
}
