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
            UserHandler uh = new UserHandler();
            User u = new User();
            //Guest g = new Guest();
            List<Guest> tempList = new List<Guest>();
            tempList = uh.userList;

            DataTable dt = new DataTable();
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));

            for (int i = 0; i <= tempList.Count - 1; i++)
            {
                //dt.Rows.Add(tempList("ID"), tempList("name"));
                dt.Rows.Add(u.username("Username"));
                dt.Rows.Add(u.password("Password"));
                dt.Rows.Add(u.firstName("First Name"));
                dt.Rows.Add(u.lastName("Lsst Name"));
            }
            this.dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
