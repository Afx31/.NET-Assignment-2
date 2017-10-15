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

            //dataGridView implementation            
            dataGridView1.ColumnCount = 4;
            //define column names
            dataGridView1.Columns[0].Name = "Username";
            dataGridView1.Columns[1].Name = "First Name";
            dataGridView1.Columns[2].Name = "Average Rating";
            dataGridView1.Columns[3].Name = "Number of Ratings";
            //check box column implementation
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(checkBoxColumn);
            checkBoxColumn.HeaderText = "Provide Rating to User(s)";
            //

            //populate the rows
            for (int i = 0; i < LoginForm.getUserHandler.userList.Count(); i++)
            {
                //string[] tempArray = _userHandler.userList[i].GetShortUserString().Split(',');
                string[] tempShortString = LoginForm.getUserHandler.userList[i].GetShortUserString().Split(',');
                string tempAvgRating = LoginForm.getUserHandler.userList[i].AverageRating.ToString();
                string tempRatingsCount = LoginForm.getUserHandler.userList[i].RatingsCount.ToString();

                dataGridView1.Rows.Add(tempShortString);
                dataGridView1.Rows[i].Cells[2].Value = tempAvgRating;
                dataGridView1.Rows[i].Cells[3].Value = tempRatingsCount;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRateUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserRatingDialog().Show();
        }
    }
}
