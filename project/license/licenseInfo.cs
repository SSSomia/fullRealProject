using appBusiness;
using businessLayer0;
using driverBusiness;
using licenseBusiness;
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

namespace fullRealProject
{
    public partial class licenseInfo : UserControl
    {
        private int _licenseID = 0;
        private int applicationID = 0;
        clsLicense _license;
        clsDriver _drvier;
        public licenseInfo()
        {
            InitializeComponent();
        }

        private void licenseInfo_Load(object sender, EventArgs e)
        {

        }

        public void printLicense(int licenseID)
        {
            this._licenseID = licenseID;
            _loadInfo();
        }

        public void showDate(int applicationID)
        {
            this.applicationID = applicationID;
            _loadInfo();
        }

        private void _loadInfo()
        {
            if (_licenseID == 0)
            {
                _licenseID = clsLicense.getLicenseID(applicationID);
            }
            _license = clsLicense.printLicense(_licenseID);
            _drvier = clsDriver.printDriver(_license.driverID);
            _showLicenseInfo();
        }

        private void _showLicenseInfo()
        {
            if (_license != null)
            {
                name.Text = clsApp.getApplicantName(_drvier.personID);
                licenseClass.Text = clsApp.getLicenseClass(_license.licenseClassID);
                licenseID.Text = _licenseID.ToString();
                nationalNum.Text = clsPerson.nationalNumber(_drvier.personID).ToString();
                issueDate.Text = _license.issueDate.ToString("dd/MM/yyyy");
                expirationDate.Text = _license.expirationDate.ToString("dd/MM/yyyy");
                driverID.Text = _drvier.driverID.ToString();
                isActive.Text = _license.isActive.ToString();
                personPicture.ImageLocation = @clsPerson.getImageLink(_drvier.personID).ToString();

            }
        }
    }
}
