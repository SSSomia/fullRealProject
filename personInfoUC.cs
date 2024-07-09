﻿using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class personInfoUC : UserControl
    {
        private int _personId;
        clsPerson _person;
  
        public personInfoUC()
        {
            InitializeComponent();
        }

        public void showData(int index)
        {
            _personId = index;
            _loadInfo();
        }

        private void _loadInfo()
        {
            _person = clsPerson.printPerson(_personId);
                _showPersonInfo();
        }

        private void _showPersonInfo()
        {
            if (_person != null) 
            {
                personID.Text = _personId.ToString();
                name.Text = _person.firstName + ' ' + _person.secondName + ' ' + _person.thirdName + ' ' + _person.lastName;
                nationalNum.Text = _person.nationalNum.ToString();
                phone.Text = _person.phone.ToString();
                email.Text = _person.email.ToString();
                address.Text = _person.address.ToString();
                personPicture.ImageLocation = @_person.imageLink.ToString();

            }
        }

        private void personPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
