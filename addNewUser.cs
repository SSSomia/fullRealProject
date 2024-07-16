using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class addNewUser : Form
    {
        clsUser _user;
        public addNewUser()
        {
            InitializeComponent();
        }


        private void addNewPerson_Click(object sender, EventArgs e)
        {
            add_editPerson frm = new add_editPerson(-1);  // intialize object from form3   [1]
            frm.endWithAddPerson += showPersonData;
            frm.ShowDialog();
            

        }

        private void showPersonData(int nationalNum)
        {
            if (nationalNum !=  0)
            {
                personInfoUC1.showDataWithNationalN(nationalNum);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (nationalNumber.Text.Length == 0)
            {
                return;
            }
            int nationalN = int.Parse(nationalNumber.Text);
            if (!clsPerson.isNationalNumExist(nationalN))
            {
                MessageBox.Show("this national number doesn't exist!");
            }
            else
            {
                personInfoUC1.showDataWithNationalN(nationalN);

            }
        }

        private void nationalNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.enterNumricVal(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1);//  tabControl1.SelectedTab()
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.isUserNameExist(userName.Text))
            {
                userNameErr.SetError(userName, "this national number is exist!");
            }
            else
            {
                userNameErr.Clear();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.passwordLessThan4(password.Text))
            {
                passErr.SetError(password, "password less than 4");
            }
            else
            { passErr.Clear(); }


            if (password.Text == cPassword.Text)
            {
                passErr.Clear();
                cPassErr.Clear();
            }
        }

        private void cPassword_TextChanged(object sender, EventArgs e)
        {
            if (password.Text != cPassword.Text)
            {
                cPassErr.SetError(cPassword, "passwords not equal");
                passErr.SetError(password, "passwords not equal");

            }
            else
            { cPassErr.Clear(); }
            if (password.Text == cPassword.Text)
            {
                passErr.Clear();
                cPassErr.Clear();
            }
        }

        private clsUser _fillData()
        {
            _user = new clsUser(personInfoUC1.getPersonId(), userName.Text, password.Text, isActive.Checked);
            return _user;
        }

        // i didn't save the user in the database
        private void save_Click(object sender, EventArgs e)
        {
           clsUser.addNewUser(_fillData());
            this.Close();           
        }

        private void personInfoUC1_Load(object sender, EventArgs e)
        {
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //private void user_Click(object sender, EventArgs e)
        //{

        //}

    }
}
