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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fullRealProject
{
    public partial class changeUserPassword : Form
    {
        public changeUserPassword()
        {
            InitializeComponent();
            showUserDataUC01.showData(Current_user.userID, clsUser.getPersonID(Current_user.userID));
        }

        private void newPass_Click(object sender, EventArgs e)
        {
            if (currPass.Text == "")
            {
                currPassErr.SetError(currPass, "you don't enter the current password!");
            }
            else { currPassErr.Clear(); }
        }

        

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.passwordLessThan4(newPass.Text))
            {
                newPassErr.SetError(newPass, "newPass less than 4");
            }
            else if (newPass.Text != cPass.Text)
            {
                cPassErr.SetError(cPass, "newPasss not equal");
                newPassErr.SetError(newPass, "newPasss not equal");

            }
            else
            { newPassErr.Clear(); }


            if (newPass.Text == cPass.Text)
            {
                newPassErr.Clear();
                cPassErr.Clear();
            }
        }

        private void cPass_TextChanged(object sender, EventArgs e)
        {
            if (newPass.Text != cPass.Text)
            {
                cPassErr.SetError(cPass, "passwords not equal");
                newPassErr.SetError(newPass, "passwords not equal");

            }
            else
            { cPassErr.Clear(); }
            if (newPass.Text == cPass.Text)
            {
                newPassErr.Clear();
                cPassErr.Clear();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (currPass.Text != Current_user.password)
            {
                MessageBox.Show("current password isn't correct!");
                return;
            }
            if (currPass.Text == "" || cPass.Text == "")
            { return;
            }
            if (clsValidation.passwordLessThan4(newPass.Text))
            {
                return;
            }
            if (!clsValidation.passEquals(newPass.Text, cPass.Text))
            {
                return;
            }
            else
            {
                string hashPass = hashing.ComputeHash(newPass.Text);
                clsUser.updateUserPass(hashPass, Current_user.userID);
                this.Close();
            }
        }

        private void currPass_TextChanged(object sender, EventArgs e)
        {
            if (currPass.Text != Current_user.password)
            {
                currPassErr.SetError(currPass, "password isn't correct!");
            }
            else
                currPassErr.Clear();
        }
    }
}
