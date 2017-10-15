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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            dtPickerDOB.Format = DateTimePickerFormat.Custom;
            dtPickerDOB.CustomFormat = "dd-MM-yyy";
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string newUsername = tbUsername.Text;
            string newPassword = tbPassword.Text;
            string newFirstName = tbFirstName.Text;
            string newLastName = tbLastName.Text;
            string newDOB = dtPickerDOB.Value.ToString("dd-MM-yyyy");

            if (tbUsername.Text == null || tbPassword.Text == null || tbFirstName == null || tbLastName == null || dtPickerDOB == null)
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                //    newUsername + "," + newPassword + "," + newFirstName + "," + newLastName + "," + newDOB; DateTime.ParseExact(newDOB, "dd-MM-yyy", null)
                Guest _guest = new Guest(newUsername, newPassword, newFirstName, newLastName, Convert.ToDateTime(newDOB), 0, 0);
                MessageBox.Show("New user created.");
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
