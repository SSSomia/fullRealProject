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
using appBusiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using userBusiness;
namespace fullRealProject
{
    public partial class newDrivingLicenses : Form
    {
        clsApp app;
        int _personID;
        public newDrivingLicenses()
        {
            InitializeComponent();
        }
        // application info not set
        private void filterWithPersonInfoUC1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1);
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newDrivingLicenses_Load(object sender, EventArgs e)
        {
            appDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            appFees.Text = "15";
            createBy.Text = Current_user.userName;
            licenseClass.SelectedIndex = 0;
        }

        private void person_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private clsApp _fillData()
        {
            app = new clsApp(_personID, 2, "new",int.Parse(appFees.Text), licenseClass.SelectedIndex + 1, DateTime.Now, clsUser.getUserID(_personID));
            return app;
        }
        private void save_Click(object sender, EventArgs e)
        {
            _personID = filterWithPersonInfoUC1.getPersonId();
            if (_personID == 0)
            {
                MessageBox.Show("you don't choose the person!!");
                return;
            }
            if (clsApp.isPersonHaveLicense(_personID))
            {
                if (clsApp.isPersonHaveSameLicense(_personID, licenseClass.SelectedIndex + 1))
                {
                    MessageBox.Show("this person has this license or an application to this license class!!");
                    return;
                }
            }
            clsApp.addNewApp(_fillData());
            this.Close();
        }

        private void appDate_Click(object sender, EventArgs e)
        {

        }
    }
}
