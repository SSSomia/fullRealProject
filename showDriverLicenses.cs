using appBusiness;
using licenseBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace fullRealProject
{
    public partial class showDriverLicenses : Form
    {
        private int _appID;
        private int _licenseID;
        private int _driverID;
        public showDriverLicenses(int appID)
        {
            InitializeComponent();
            _appID = appID;
        }

        private void _loaddrivingLicenses()
        {
            personInfoUC1.showData(clsApp.getPersonID(_appID));
            _licenseID = clsLicense.getLicenseID(_appID);
            _driverID = clsLicense.getDriverID(_licenseID);
            driverLicense.DataSource = clsLicense.getAllDriverLicense(_driverID);
        }

        private void driverLicense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showDriverLicenses_Load(object sender, EventArgs e)
        {

            _loaddrivingLicenses();

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
