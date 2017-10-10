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
    public partial class UserListScreen : Form
    {       
        public UserListScreen()
        {
            InitializeComponent();
        }

        private void UserListScreen_Load(object sender, EventArgs e)
        {
            UserHandler uh = new UserHandler();
            /*List<string> tempList = new List<string>();
            var tempList = new List<string>();
            tempList = uh.userList;
            dataGridView1.DataSource = tempList;*/

            /*DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            for (int i = 0; i <= tempList.row.count - 1; i++)
            {
                dt.Rows.Add(tempList("ID"), tempList("name"));
            }
            this.dataGridView1.DataSource = dt;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
