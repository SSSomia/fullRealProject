using appBusiness;
using businessLayer0;
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
        public licenseInfo()
        {
            InitializeComponent();
        }

        private void licenseInfo_Load(object sender, EventArgs e)
        {

        }
        //public void showDate(int applicationID)
        //{
        //    this.applicationID= applicationID;
        //    _loadInfo();
        //}

        //private void _loadInfo()
        //{
        //    _license = clsLicense.printLicense(_licenseID);
        //    _showLicenseInfo();
        //}

        //private void _showLicenseInfo()
        //{
        //    if (_license != null)
        //    {
        //        name.Text = clsApp.getApplicantName(applicationID);
        //    }
        //}
    }
}
