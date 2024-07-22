using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBusiness;

namespace fullRealProject
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        // there is a problem that i can't close the before call dashboard
        private void login_Click(object sender, EventArgs e)
        {
            int userID = clsUser.loginUser(userName.Text, password.Text);
            if (userID != -1)
            {
                Current_user.userName = userName.Text;
                Current_user.password = password.Text;
                Current_user.userID = userID;
                Form frm = new dashBoard();
                frm.ShowDialog();
                this.Close();

            }
            else {
                MessageBox.Show("this user is not active. user name or password isn't correct");
            }
        }
    }
}
