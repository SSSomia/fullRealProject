using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class addEditPerson : UserControl
    {
        public delegate void dataBackDlg(int nationalNum);
        public event dataBackDlg endWithForm;
        clsPerson _person;
        private int _personID;
        string filePath = "";
        public addEditPerson()
        {
            InitializeComponent();
        }
        public void editPerson(int personId)
        {
            _personID = personId;
            _dataInEditMode();
        }
        private void _cancel_Click(object sender, EventArgs e)
        {
            //dataBack();
        }
        // when finish we use fill data
        private clsPerson _fillData()
        {
            _person = new clsPerson(int.Parse(nationalNum.Text), first.Text, second.Text, third.Text, last.Text, phone.Text, email.Text, address.Text, filePath);
            return _person;
        }
        private clsPerson _loadData()
        {
            _person = clsPerson.printPerson(_personID);
            return _person;
        }

        public void addPerson()
        {
            _personID = -1;
            _intialFields();
        }
        private void _intialFields()
        {
            nationalNum.Text = string.Empty;
            first.Text = string.Empty;
            second.Text = string.Empty;
            third.Text = string.Empty;
            last.Text = string.Empty;
            phone.Text = string.Empty;
            email.Text = string.Empty;
            address.Text = string.Empty;
            filePath = string.Empty;
        }
        private void _dataInEditMode()
        {
            _loadData();
            nationalNum.Text = _person.nationalNum.ToString();
            first.Text = _person.firstName.ToString();
            second.Text = _person.secondName.ToString();
            third.Text = _person.thirdName.ToString();
            last.Text = _person.lastName.ToString();
            phone.Text = _person.phone.ToString();
            email.Text = _person.email.ToString();
            address.Text = _person.address.ToString();
            pictureBox1.ImageLocation = @_person.imageLink.ToString();
            filePath = _person.imageLink.ToString();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            while (filePath == "openFileDialog1")
            {
                MessageBox.Show("you have to enter your image.");
                openFileDialog1.ShowDialog();
                filePath = openFileDialog1.FileName;
            }
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_isFielsEmpty(_checkAllFields()))
            {
                MessageBox.Show(_checkAllFields());
                return;
            }
            if (!clsValidation.phoneNum(phone.Text))
            {
                return;
            }
            if (!clsValidation.email(email.Text))
            {
                return;
            }
            if (clsValidation.isNationalNumExist(int.Parse(nationalNum.Text)))
            {
                return;
            }
            if (_personID == -1)
            {
                clsPerson.addNewPerson(_fillData());
                endWithForm(_person.nationalNum);
            }
            else
            {
                clsPerson.updatePerson(_fillData(), _personID);
                endWithForm(_person.nationalNum);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // how to close the form without load the data in managePeople form
            //if (onDoneWithForm != null)
            //    // Raise the event with a parameter
            //    DoneWithForm(0);
            endWithForm(0);
        }

        private void addEditPerson_Load(object sender, EventArgs e)
        {
        }
  

        private void nationalNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.enterNumricVal( sender,  e);

        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.enterNumricVal(sender, e);
        }


        //private void phone_Leave(object sender, EventArgs e)
        //{
        //    if (!clsValidation.phoneNum(phone.Text))
        //    {
        //        phoneErr.SetError(phone, "phone number isn't correct!");
        //    }
        //    else
        //    {
        //        phoneErr.Clear();
        //    }
        //}

        private void email_Leave(object sender, EventArgs e)
        {
            if (!clsValidation.email(email.Text))
            {
                emailErr.SetError(email, "email isn't correct!");
            }
            else
            {
                emailErr.Clear();
               
            }
        }

        private string _checkAllFields()
        {
            string emptyFields = "";
            if (clsValidation.emptyField(first.Text))
                emptyFields += "-first name-";
            if (clsValidation.emptyField(second.Text))
                emptyFields += "-second name- ";
            if (clsValidation.emptyField(third.Text))
                emptyFields += "-thrid name-";
            if (clsValidation.emptyField(last.Text))
                emptyFields += "-last name-";
            if (clsValidation.emptyField(nationalNum.Text))
                emptyFields += "-national number-";
            if (clsValidation.emptyField(phone.Text))
                emptyFields += "-phone-";
            if (clsValidation.emptyField(address.Text))
                emptyFields += "-address-";
            if (clsValidation.emptyField(filePath))
                emptyFields += "-image-";
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

        private void nationalNum_TextChanged(object sender, EventArgs e)
        {
            if (_personID == -1)
            { 
                if (nationalNum.Text == "")
                {
                    return;
                }
                int num = int.Parse(nationalNum.Text);
                if (clsValidation.isNationalNumExist(num))
                {
                    nationalNumExistErr.SetError(nationalNum, "this national number is exist!");
                }
                else
                {
                    nationalNumExistErr.Clear();
                }
            }
            else
            {
                string national = _person.nationalNum.ToString();
                if (nationalNum.Text != national)
                {
                    int num = int.Parse(nationalNum.Text);
                    if (clsValidation.isNationalNumExist(num))
                    {
                        nationalNumExistErr.SetError(nationalNum, "this national number is exist!");
                    }
                    else
                    {
                        nationalNumExistErr.Clear();
                    }
                }
            }

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text.Length == 0)
                return;
            if (!clsValidation.phoneNum(phone.Text))
            {
                phoneErr.SetError(phone, "phone number isn't correct!");
            }
            else
            {
                phoneErr.Clear();
            }
        }


    }
}
