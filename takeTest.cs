using appBusiness;
using businessLayer0;
using driverBusiness;
using licenseBusiness;
using personTestsBusiness;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace fullRealProject
{
    public partial class takeTest : Form
    {
        private int _id;
        private int _applicationID;
        clsDriver driver;
        clsLicense license;
        public takeTest(int id, int applicationID)
        {
            InitializeComponent();
            _id = id;
            _applicationID = applicationID;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private clsDriver _fillDriverData()
        {
            driver = new clsDriver(clsApp.getPersonID(_applicationID), DateTime.Now);
            return driver;
        }

        private clsLicense _fillLicenseData()
        {
            int licenseClassID = clsApp.getLIcenseID(_applicationID);
            license = new clsLicense(licenseClassID, DateTime.Now, DateTime.Now.AddYears(clsApp.yearsOfLicense(licenseClassID)), clsDriver.addNewDriver(_fillDriverData()), Current_user.userID);
                return license;
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool passed = false;
            if (pass.Checked) 
            {
                passed = true;  
            }
            if (clsPersonTest.takeTest(_id, passed, _applicationID) == 3)
                clsLicense.addNewLicense(_fillLicenseData());
            // after that you have to add the driver if not and add the license
            // you have to make clsData and clsBusiness for the license and driver
            this.Close();
        }
    }
}
