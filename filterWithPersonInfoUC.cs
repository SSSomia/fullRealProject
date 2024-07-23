using businessLayer0;
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
    public partial class filterWithPersonInfoUC : UserControl
    {
        public filterWithPersonInfoUC()
        {
            InitializeComponent();
        }

        private void showPersonData(int nationalNum)
        {
            if (nationalNum != 0)
            {
                personInfoUC1.showDataWithNationalN(nationalNum);
            }
        }


        public int getPersonId()
        {
            return personInfoUC1.getPersonId();
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

        private void nationalNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            clsValidation.enterNumricVal(sender, e);

        }

        private void filterWithPersonInfoUC_Load(object sender, EventArgs e)
        {

        }

        private void addNewPerson_Click_1(object sender, EventArgs e)
        {
            add_editPerson frm = new add_editPerson(-1);  // intialize object from form3   [1]
            frm.endWithAddPerson += showPersonData;
            frm.ShowDialog();
        }
    }
}
