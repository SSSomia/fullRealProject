using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBusiness;

namespace fullRealProject
{
    public partial class manageUsers : Form
    {
        public manageUsers()
        {
            InitializeComponent();
        }

        private void listPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadListUsers()
        {
            listUsers.DataSource = clsPerson.getAllUsers();
        }

        public void rowNums()
        {
            rowsNum.Text = clsPerson.numOfUsers().ToString();
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            loadListUsers();
            rowNums();
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            addEditUser frm = new addEditUser(-1, -1);
            frm.ShowDialog();
            loadListUsers();
            rowNums();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new showUserDataFm((int)listUsers.CurrentRow.Cells[0].Value, (int)listUsers.CurrentRow.Cells[1].Value);
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEditUser frm = new addEditUser((int)listUsers.CurrentRow.Cells[0].Value, (int)listUsers.CurrentRow.Cells[1].Value);  // intialize object from form3   [1]
            frm.ShowDialog();

            loadListUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete user [" + listUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.deleteUser((int)listUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    loadListUsers();
                    rowNums();
                }

                else
                    MessageBox.Show("User is not deleted.");

            }
        }
    }
}
