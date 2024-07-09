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
        public delegate void dataBackDlg();
        public event dataBackDlg endWithForm;
        clsPerson _person;
        private int _personID;
        string filePath;
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
            _person = new clsPerson(int.Parse(nationalNum.Text),  first.Text,  second.Text,  third.Text,  last.Text,  email.Text,  phone.Text,  address.Text, filePath);
            return _person;
        }
        private clsPerson _loadData()
        {
            _person = clsPerson.printPerson(_personID);
            return _person;
        }

        public void addPerson(int personId)
        {
            _personID = personId;
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
                pictureBox1.Image = Image.FromFile(filePath);
            }

        private void save_Click(object sender, EventArgs e)
        {
            if (_personID == -1)
            {
                clsPerson.addNewPerson(_fillData());
                endWithForm();
            }
            else
            {
                clsPerson.updatePerson(_fillData(), _personID);
                endWithForm();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            // how to close the form without load the data in managePeople form
            //if (onDoneWithForm != null)
            //    // Raise the event with a parameter
            //    DoneWithForm(0);
            endWithForm();
        }

        private void addEditPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
