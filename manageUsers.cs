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
            addNewUser frm = new addNewUser();
            frm.ShowDialog();
            loadListUsers();
            rowNums();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new showUserData((int)listUsers.CurrentRow.Cells[0].Value, (int)listUsers.CurrentRow.Cells[1].Value);
            frm.Show();
        }
    }
}
