﻿using businessLayer0;
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
    public partial class addEditUser : Form
    {
        clsUser _user;
        private int _userId;
        private int _personID;
        public addEditUser(int userID, int personID)
        {
            InitializeComponent();
            _userId = userID;
            _personID = personID;
            if (userID == -1)
            {
                formTitle.Text = "ADD NEW USER";
                addEditPerson1.Visible = false;
            }
            else
            {
                formTitle.Text = "MODIFIY USER";
                filter.Enabled = false;
                search.Enabled = false;
                nationalNumber.Enabled = false;
                addNewPerson.Enabled = false;
                personInfoUC1.Visible = false;
                _userDataInEdit();
               
            }
        }

        private void _userDataInEdit()
        {
            _loadUserData();
            userName.Text = _user.userName.ToString();
            password.Text = _user.password.ToString();
            cPassword.Text = _user.password.ToString();
            isActive.Checked = _user.isActive;
        }

        private void addNewPerson_Click(object sender, EventArgs e)
        {
            add_editPerson frm = new add_editPerson(-1);  // intialize object from form3   [1]
            frm.endWithAddPerson += showPersonData;
            frm.ShowDialog();

        }


        private void showPersonData(int nationalNum)
        {
            if (nationalNum != 0)
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
            else if (clsUser.getUserID(clsPerson.getPersonIdWithNationalNum(nationalN)) != 0)
            {
                MessageBox.Show("this national number is belong to a user!");
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

        private clsUser _loadUserData()
        { 
                _user = clsUser.printUser(_userId);
                return _user;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1);
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            if (_userId == -1)
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
            else
            {
                string userN = _user.userName.ToString();
                if (userName.Text != userN)
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
                else
                userNameErr.Clear();

            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (clsValidation.passwordLessThan4(password.Text))
            {
                passErr.SetError(password, "password less than 4");
            }
            else if (password.Text != cPassword.Text)
            {
                cPassErr.SetError(cPassword, "passwords not equal");
                passErr.SetError(password, "passwords not equal");

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

        private string _checkAllFields()
        {
            string emptyFields = "";
            if (clsValidation.emptyField(userName.Text))
                emptyFields += "-user name-";
            if (clsValidation.emptyField(password.Text))
                emptyFields += "-password- ";
            if (clsValidation.emptyField(cPassword.Text))
                emptyFields += "-confirm password-";
            emptyFields += "is required!!";
            return emptyFields;
        }
        private bool _isFielsEmpty(string emptyFields)
        {
            if (emptyFields == "is required!!")
            {
                return false;
            }
            return true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (personInfoUC1.getPersonId() != 0)
            {
                if (_isFielsEmpty(_checkAllFields()))
                {
                    MessageBox.Show(_checkAllFields());
                    return;
                }
                if (clsValidation.isUserNameExist(userName.Text))
                {
                    return;
                }
                if (clsValidation.passwordLessThan4(password.Text))
                {
                    return;
                }
                if (!clsValidation.passEquals(password.Text, cPassword.Text))
                {
                    return;
                }
                clsUser.addNewUser(_fillData());
                this.Close();
            }
            else {
                MessageBox.Show("you didn't choose a person to be a user");
                return;
            }
        }

        private void addEditPerson1_Load(object sender, EventArgs e)
        {
            addEditPerson1.editPerson(_personID);

        }

        private void user_Click(object sender, EventArgs e)
        {

        }
    }
}
