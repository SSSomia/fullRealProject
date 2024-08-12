using appBusiness;
using licenseBusiness;
using manageApplicationTypesBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullRealProject
{
    public partial class renewReplaceLicense : Form
    {
        clsLicense _license;
        clsApp _app;
        private int _appID;
        private int _licenseID;
        public renewReplaceLicense()
        {
            InitializeComponent();
        }

        private void renewReplaceLicense_Load(object sender, EventArgs e)
        {
            createdBy.Text = Current_user.userName;
            renew.Checked = true;
            totalFee("renew license");
            filterLicenseWithID1.getLicenseID();
        }

        private void totalFee(string radioB)
        {
            if (radioB == "renew license") {
                totalFees.Text = clsApplicationType.getFees(3);
                    }
            else if (radioB == "replace for damage")
            {
                totalFees.Text = clsApplicationType.getFees(4);
            }
            else
            {
                totalFees.Text = clsApplicationType.getFees(5);
            }
        }

        private void renew_Click(object sender, EventArgs e)
        {
            totalFee("renew license");
        }

        private void damage_Click(object sender, EventArgs e)
        {
            totalFee("replace for damage");

        }

        private void lose_Click(object sender, EventArgs e)
        {
            totalFee("replace for lose");
        }

        private void filterLicenseWithID1_Load(object sender, EventArgs e)
        {

        }

        private void issue_Click(object sender, EventArgs e)
        {
            _licenseID = filterLicenseWithID1.getLicenseID();
            _appID = clsLicense.getAppID(_licenseID);
            if (_licenseID == 0)
            { return; }
            else
            {
                _license = clsLicense.printLicense(_licenseID);
                _app = clsApp.printApp(_appID);
                    _app.fees = int.Parse(totalFees.Text);
                    _app.createdDate = DateTime.Now;
                    _app.userID = Current_user.userID;
                _app.applicationState = "completed";
                if (renew.Checked)
                {
                    _app.applicationTypeID = 3;
                    _license.issueDate = DateTime.Now;
                    _license.expirationDate = DateTime.Now.AddYears(clsApp.yearsOfLicense(_license.licenseClassID));
                }
                else if (damage.Checked)
                {
                    _app.applicationTypeID = 4;
                }
                else
                {
                    _app.applicationInfoID = 5;
                }
                int newAppID = clsApp.addNewApp(_app);
                _license.isCreatedByUser = Current_user.userID;
                _license.applicationID = newAppID;
                // have to make the application first
                // have to change user, appplicationID,issueDate and expirationDate if renew
                clsLicense.updateLicense(_licenseID);
                clsLicense.addNewLicense(_license);
            }
            // issue license 
            // have new license and new application
            this.Close();
        }
    }
}
