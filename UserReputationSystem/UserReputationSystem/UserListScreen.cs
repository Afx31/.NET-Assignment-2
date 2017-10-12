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
            //UserHandler _userHandler = new UserHandler();
            //_userHandler.LoadAllUsers();

            //DATAGRID            
            dataGridView1.ColumnCount = 4;
            //dataGridView1.ColumnHeadersVisible = true;
            //define column names
            dataGridView1.Columns[0].Name = "Username";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Average Rating";
            dataGridView1.Columns[3].Name = "Number of Ratings";
            //populate the rows

            for (int i = 0; i < LoginForm.getUserHandler.userList.Count(); i++)
            {
                //string[] tempArray = _userHandler.userList[i].GetShortUserString().Split(',');
                string[] tempArray = LoginForm.getUserHandler.userList[i].GetFullUserString().Split(',');
                dataGridView1.Rows.Add(tempArray);
            }
            

            //dataGridView1.DataSource = _userHandler.userList;

        }
    }
}
