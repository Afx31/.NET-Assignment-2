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

            //populate the rows
            for (int i = 0; i < LoginForm.UserHandler.userList.Count(); i++)
            {
                string[] tempShortString = LoginForm.UserHandler.userList[i].GetShortUserString().Split(',');
                string tempAvgRating = LoginForm.UserHandler.userList[i].AverageRating.ToString();
                string tempRatingsCount = LoginForm.UserHandler.userList[i].RatingsCount.ToString();

                dataGridView1.Rows.Add(tempShortString);
                dataGridView1.Rows[i].Cells[2].Value = tempAvgRating;
                dataGridView1.Rows[i].Cells[3].Value = tempRatingsCount;
            }
        }

        private void btnRateUsers_Click(object sender, EventArgs e)
        {
            List<string> checkBoxUser = new List<string>();

            //for loop to go through each row, then check if the checkBox has been clicked
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((dataGridView1.CurrentCell as DataGridViewCheckBoxCell) != null)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        checkBoxUser.Add(i.ToString());
                        /*bool isChecked = (bool)row.Cells[0].EditedFormattedValue;
                        if (isChecked )
                        {
                            checkBoxUser.Add(i.ToString());
                        }*/
                    }
                }
            }
            if (checkBoxUser.Count() > 0)
            {
                this.Hide();
                new UserRatingDialog(checkBoxUser).Show();
            }
            else
            {
                MessageBox.Show("Error: select 1 user minimum to rate.");
            }
        }
    }
}
