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
        private enum _enmode { showDetails, edit };
        private _enmode _mode;
        private int _personID;
        clsPerson _person;
  
        public personInfoUC()
        {
            InitializeComponent();

        }



        public void presonWithIndMod(int index, int mode)
        {
            _personID = index;
            if (mode == 1)
                _mode = _enmode.showDetails;
            else
                _mode = _enmode.edit;
            _loadInfo();
        }

        private void _loadInfo()
        {
            _person = clsPerson.printPerson(_personID);
            if (_mode == _enmode.showDetails)
            {
                _showPersonInfo();
            }
            else
            {
                MessageBox.Show("edit no ready yet");
            }
        }

        private void _showPersonInfo()
        {
            if (_person != null) 
            {
                personID.Text = _personID.ToString();
                name.Text = _person.fristName + ' ' + _person.secondName + ' ' + _person.thirdName + ' ' + _person.lastName;
                nationalNum.Text = _person.nationalID.ToString();
                phone.Text = _person.phone.ToString();
                email.Text = _person.email.ToString();
                date.Text = _person.dateOfBirth.ToString();
                address.Text = _person.address.ToString();
            }
        }
    }
}
