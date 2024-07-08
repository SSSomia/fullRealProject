using businessLayer0;
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
        private int _personID;
        clsPerson _person;
  
        public personInfoUC()
        {
            InitializeComponent();
        }

        public void showData(int index)
        {
            _personID = index;
            _loadInfo();
        }

        private void _loadInfo()
        {
            _person = clsPerson.printPerson(_personID);
                _showPersonInfo();
        }

        private void _showPersonInfo()
        {
            if (_person != null) 
            {
                personID.Text = _personID.ToString();
                name.Text = _person.fristName + ' ' + _person.secondName + ' ' + _person.thirdName + ' ' + _person.lastName;
                nationalNum.Text = _person.nationalNum.ToString();
                phone.Text = _person.phone.ToString();
                email.Text = _person.email.ToString();
                address.Text = _person.address.ToString();
                
            }
        }
    }
}
