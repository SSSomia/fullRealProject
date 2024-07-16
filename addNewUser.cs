using businessLayer0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class addNewUser : Form
    {
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


    }
}
