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
        private int _personId;
        clsPerson _person;
        private int _nationalN;
  
        public personInfoUC()
        {
            InitializeComponent();
        }

        public void showData(int index)
        {
            _personId = index;
            _loadInfo();
        }
        public int getPersonId()
        {
            return _person.PersonID;
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
                personID.Text = _person.PersonID.ToString();
                name.Text = _person.firstName + ' ' + _person.secondName + ' ' + _person.thirdName + ' ' + _person.lastName;
                nationalNum.Text = _person.nationalNum.ToString();
                phone.Text = _person.phone.ToString();
                email.Text = _person.email.ToString();
                address.Text = _person.address.ToString();
                personPicture.ImageLocation = @_person.imageLink.ToString();

            }
        }

        public void showDataWithNationalN(int index)
        {
            _nationalN = index;
            _loadInfoWithNationalNum();
        }

        private void _loadInfoWithNationalNum()
        {
            _person = clsPerson.printPersonWithNationalNum(_nationalN);
            _showPersonInfo();
        }



        private void personPicture_Click(object sender, EventArgs e)
        {

        }

        private void personInfoUC_Load(object sender, EventArgs e)
        {

        }
    }
}
